using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace ViKTUK_SFE
{
    public partial class Form1 : Form
    {
        String readypath;
         // Set your salt here, change it to meet your flavor:
                // The salt bytes must be at least 8 bytes.
        byte[] saltBytes = new byte[] { 0x56, 0x69, 0x4B, 0x54, 0x55, 0x4B, 0x53, 0x46, 0x45 };

        public Form1(string path)
        {
            InitializeComponent();
            if (path != "")
            {
                readypath = path;
                AllowUse();
            }
            checkUpdates(false);
        }

        [Serializable]
        public struct vsfeFile {
            public string filename;
            public string description;
            public byte[] bytes;
        }

        public void SavevsfeFile(string filepath, vsfeFile vsfeFile) {
            FileStream fstream = File.Open(filepath, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fstream, vsfeFile);
            fstream.Close();
        }

        public vsfeFile ReadvsfeFile(string filepath) {
            vsfeFile vsfeFile = new vsfeFile();
            FileStream fstream = File.Open(filepath, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            try
            {
                vsfeFile = (vsfeFile)binaryFormatter.Deserialize(fstream);
            } catch {
                vsfeFile.bytes = null;
            }
            fstream.Close();
            return vsfeFile;
        }

        void AllowUse() {
            if (Path.GetExtension(readypath) == ".vsfe")
            {
                radioDecrypt.Checked = true;
                CalculateInformation(true);
                GC.Collect();
            }
            else {
                CalculateInformation(false);
            }
            radioEncrypt.Enabled = true;
            radioDecrypt.Enabled = true;
            PasswordTextBox.Enabled = true;
            FileDescriptionCheckBox.Enabled = true;
        }
        private void CalculateInformation(bool isvsfe)
        {
            SetWindowStatus("Getting File Information");
            string information = null;
            long size = new FileInfo(readypath).Length;
            string sizetext;
            if (size < 1024)
            {
                sizetext = size.ToString() + " bytes";
            }
            else if (size < 1048576)
            {
                sizetext = (size / 1024).ToString() + " KB";
            }
            else {
                sizetext = (size / 1048576).ToString() + " MB";
            }
            if (isvsfe) {
                vsfeFile vsfeFile = new vsfeFile();
                vsfeFile = ReadvsfeFile(readypath);
                information = "VSFE Description:\n"+vsfeFile.description+"\n";
            }
            information = information+ "File Name:\n" + Path.GetFileName(readypath) +
                    "\nMD5:\n" + CalculateMD5(readypath) +
                    "\nSize:\n" + sizetext +
                    "\nModified:\n" + File.GetLastWriteTime(readypath) +
                    "\nPath:\n" + readypath;
            FileInformation.Text = information;
            SetWindowStatus();
        }

        private string GetTimeString(System.Diagnostics.Stopwatch sw) {
            if (sw.ElapsedMilliseconds < 1000) {
                return sw.ElapsedMilliseconds.ToString() + "ms.";
            } else {
                return (sw.ElapsedMilliseconds / 1000).ToString() + "s.";
            }
        }
        private void SetWindowStatus(string status){
            Text = "ViKTUK SFE - "+status;
        }

        private void SetWindowStatus()
        {
            Text = "ViKTUK SFE";
        }

        static string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void PasswordCheck(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                SaveFileButton.Enabled = false;
            }
            else
            {
                SaveFileButton.Enabled = true;
            }
        }

        private void checkUpdates(bool manual)
        {
            using (WebClient client = new WebClient())
            {
                string network_version = null;
                string current_version = Application.ProductVersion;
                try
                {
                    network_version = client.DownloadString("https://viktuk.tk/programs/sfe_version");
                    if (network_version != current_version && network_version != null)
                    {
                        if (MessageBox.Show("New version " + network_version + " is available. Install?", "Check updates", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start("http://viktuk.tk/programs/sfe");
                        }
                    }
                    else
                    {
                        if (manual)
                        {
                            MessageBox.Show("No updates found. You are using the latest version.", "Check updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch
                {
                    if (manual)
                    {
                        MessageBox.Show("No internet connection.", "Check updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutBox1 About = new AboutBox1();
            About.Show();
        }

        private void OpenFileClick(object sender, EventArgs e)
        {
            GC.Collect();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                readypath = openFileDialog1.FileName;
                AllowUse();
            }
            else {
                FileInformation.Text = "No file selected";
                radioEncrypt.Enabled = false;
                radioDecrypt.Enabled = false;
                PasswordTextBox.Enabled = false;
                SaveFileButton.Enabled = false;
                FileDescriptionCheckBox.Enabled = false;
                FileDescriptionTextBox.Enabled = false;
                FileDescriptionCheckBox.Checked = false;
            }
        }
        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            GC.Collect();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(PasswordTextBox.Text);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            if (radioEncrypt.Checked)
            {
                byte[] FileBytes = File.ReadAllBytes(readypath);
                SetWindowStatus("Encrypting...");
                vsfeFile vsfeFile = new vsfeFile();
                vsfeFile.filename = Path.GetFileName(readypath);
                if (FileDescriptionTextBox.Enabled == true) { 
                    vsfeFile.description = FileDescriptionTextBox.Text;
                }
                vsfeFile.bytes = AES_Encrypt(FileBytes, passwordBytes);
                FileBytes = null; GC.Collect(); //clear memory
                sw.Stop();
                SetWindowStatus();
                saveFileDialog1.Filter = "ViKTUK VSFE files (*.vsfe)|*.vsfe|All files (*.*)|*.*";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    SetWindowStatus("Saving file...");
                    sw.Start();
                    SavevsfeFile(saveFileDialog1.FileName, vsfeFile);
                    sw.Stop();
                    SetWindowStatus();
                    MessageBox.Show("Operation completed successfully.\nIt took " + GetTimeString(sw), "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                vsfeFile.bytes=null;
            }
            else
            {
                vsfeFile vsfeFile = new vsfeFile();
                vsfeFile = ReadvsfeFile(readypath);
                if (vsfeFile.bytes != null)
                {
                    SetWindowStatus("Decrypting...");
                    byte[] decrypted = AES_Decrypt(vsfeFile.bytes, passwordBytes);
                    sw.Stop();
                    SetWindowStatus();
                    if (decrypted != null)
                    {
                        string filename = vsfeFile.filename;
                        string fileext = Path.GetExtension(filename);
                        saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(filename);
                        saveFileDialog1.Filter = fileext.Remove(0, 1).ToUpper() + " files (*" + fileext + ")|*" + fileext + "|All files (*.*)|*.*";
                        saveFileDialog1.ShowDialog();
                        if (saveFileDialog1.FileName != "")
                        {
                            SetWindowStatus("Saving file...");
                            sw.Start();
                            File.WriteAllBytes(saveFileDialog1.FileName, decrypted);
                            sw.Stop();
                            SetWindowStatus();
                            MessageBox.Show("Operation completed successfully.\nIt took " + GetTimeString(sw), "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Decryption failed. Check your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("It isn't VSFE file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            GC.Collect();
        }

        public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;
            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }
            return encryptedBytes;
        }

        public byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;
            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        try
                        {
                            cs.Close();
                        }
                        catch
                        {
                            return null;
                        }
                    }
                    decryptedBytes = ms.ToArray();
                }
            }
            return decryptedBytes;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkUpdates(true);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://viktuk.tk/programs/sfe#how");
        }

        private void FileDescriptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FileDescriptionTextBox.Enabled = FileDescriptionCheckBox.Checked;
        }
    }
}

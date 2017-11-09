namespace ViKTUK_SFE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.Step1Label = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Step2Label = new System.Windows.Forms.Label();
            this.Step4Label = new System.Windows.Forms.Label();
            this.Step3Label = new System.Windows.Forms.Label();
            this.radioEncrypt = new System.Windows.Forms.RadioButton();
            this.radioDecrypt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileInformation = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FileDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.FileDescriptionCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileButton.Image")));
            this.OpenFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenFileButton.Location = new System.Drawing.Point(12, 32);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(109, 25);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileClick);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Enabled = false;
            this.SaveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveFileButton.Image")));
            this.SaveFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveFileButton.Location = new System.Drawing.Point(12, 148);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(109, 25);
            this.SaveFileButton.TabIndex = 1;
            this.SaveFileButton.Text = "Save File";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // Step1Label
            // 
            this.Step1Label.AutoSize = true;
            this.Step1Label.Location = new System.Drawing.Point(9, 16);
            this.Step1Label.Name = "Step1Label";
            this.Step1Label.Size = new System.Drawing.Size(86, 13);
            this.Step1Label.TabIndex = 2;
            this.Step1Label.Text = "Step 1. Open file";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Enabled = false;
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 75);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(180, 20);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordCheck);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Step2Label
            // 
            this.Step2Label.AutoSize = true;
            this.Step2Label.Location = new System.Drawing.Point(9, 59);
            this.Step2Label.Name = "Step2Label";
            this.Step2Label.Size = new System.Drawing.Size(117, 13);
            this.Step2Label.TabIndex = 4;
            this.Step2Label.Text = "Step 2. Enter password";
            // 
            // Step4Label
            // 
            this.Step4Label.AutoSize = true;
            this.Step4Label.Location = new System.Drawing.Point(9, 134);
            this.Step4Label.Name = "Step4Label";
            this.Step4Label.Size = new System.Drawing.Size(85, 13);
            this.Step4Label.TabIndex = 5;
            this.Step4Label.Text = "Step 4. Save file";
            // 
            // Step3Label
            // 
            this.Step3Label.AutoSize = true;
            this.Step3Label.Location = new System.Drawing.Point(9, 98);
            this.Step3Label.Name = "Step3Label";
            this.Step3Label.Size = new System.Drawing.Size(112, 13);
            this.Step3Label.TabIndex = 8;
            this.Step3Label.Text = "Step 3. Choose action";
            // 
            // radioEncrypt
            // 
            this.radioEncrypt.AutoSize = true;
            this.radioEncrypt.Checked = true;
            this.radioEncrypt.Enabled = false;
            this.radioEncrypt.Location = new System.Drawing.Point(12, 114);
            this.radioEncrypt.Name = "radioEncrypt";
            this.radioEncrypt.Size = new System.Drawing.Size(61, 17);
            this.radioEncrypt.TabIndex = 9;
            this.radioEncrypt.TabStop = true;
            this.radioEncrypt.Text = "Encrypt";
            this.radioEncrypt.UseVisualStyleBackColor = true;
            // 
            // radioDecrypt
            // 
            this.radioDecrypt.AutoSize = true;
            this.radioDecrypt.Enabled = false;
            this.radioDecrypt.Location = new System.Drawing.Point(80, 114);
            this.radioDecrypt.Name = "radioDecrypt";
            this.radioDecrypt.Size = new System.Drawing.Size(62, 17);
            this.radioDecrypt.TabIndex = 10;
            this.radioDecrypt.Text = "Decrypt";
            this.radioDecrypt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FileInformation);
            this.groupBox1.Location = new System.Drawing.Point(214, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 180);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Information";
            // 
            // FileInformation
            // 
            this.FileInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileInformation.Location = new System.Drawing.Point(6, 16);
            this.FileInformation.Name = "FileInformation";
            this.FileInformation.ReadOnly = true;
            this.FileInformation.Size = new System.Drawing.Size(222, 157);
            this.FileInformation.TabIndex = 14;
            this.FileInformation.Text = "No file selected";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Step1Label);
            this.groupBox2.Controls.Add(this.OpenFileButton);
            this.groupBox2.Controls.Add(this.radioDecrypt);
            this.groupBox2.Controls.Add(this.SaveFileButton);
            this.groupBox2.Controls.Add(this.radioEncrypt);
            this.groupBox2.Controls.Add(this.PasswordTextBox);
            this.groupBox2.Controls.Add(this.Step3Label);
            this.groupBox2.Controls.Add(this.Step2Label);
            this.groupBox2.Controls.Add(this.Step4Label);
            this.groupBox2.Location = new System.Drawing.Point(2, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 180);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AES";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFileClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem1,
            this.checkUpdatesToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "How it works";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.About_Click);
            // 
            // checkUpdatesToolStripMenuItem
            // 
            this.checkUpdatesToolStripMenuItem.Name = "checkUpdatesToolStripMenuItem";
            this.checkUpdatesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.checkUpdatesToolStripMenuItem.Text = "Check updates";
            this.checkUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkUpdatesToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.FileDescriptionTextBox);
            this.groupBox3.Controls.Add(this.FileDescriptionCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(2, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 64);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(116, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please do not enter your password here. This field will not be encrypted.";
            // 
            // FileDescriptionTextBox
            // 
            this.FileDescriptionTextBox.Enabled = false;
            this.FileDescriptionTextBox.Location = new System.Drawing.Point(116, 17);
            this.FileDescriptionTextBox.Name = "FileDescriptionTextBox";
            this.FileDescriptionTextBox.Size = new System.Drawing.Size(324, 20);
            this.FileDescriptionTextBox.TabIndex = 1;
            // 
            // FileDescriptionCheckBox
            // 
            this.FileDescriptionCheckBox.AutoSize = true;
            this.FileDescriptionCheckBox.Enabled = false;
            this.FileDescriptionCheckBox.Location = new System.Drawing.Point(12, 20);
            this.FileDescriptionCheckBox.Name = "FileDescriptionCheckBox";
            this.FileDescriptionCheckBox.Size = new System.Drawing.Size(98, 17);
            this.FileDescriptionCheckBox.TabIndex = 0;
            this.FileDescriptionCheckBox.Text = "File Description";
            this.FileDescriptionCheckBox.UseVisualStyleBackColor = true;
            this.FileDescriptionCheckBox.CheckedChanged += new System.EventHandler(this.FileDescriptionCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(450, 275);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ViKTUK SFE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Label Step1Label;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Step2Label;
        private System.Windows.Forms.Label Step4Label;
        private System.Windows.Forms.Label Step3Label;
        private System.Windows.Forms.RadioButton radioEncrypt;
        private System.Windows.Forms.RadioButton radioDecrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RichTextBox FileInformation;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox FileDescriptionTextBox;
        private System.Windows.Forms.CheckBox FileDescriptionCheckBox;
        private System.Windows.Forms.Label label1;
    }
}


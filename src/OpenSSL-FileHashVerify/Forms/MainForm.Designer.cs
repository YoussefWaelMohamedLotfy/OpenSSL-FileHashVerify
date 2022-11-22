namespace OpenSSL_FileHashVerify
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSHA1Hash = new System.Windows.Forms.TextBox();
            this.btnCopyToClipboard_SHA1 = new System.Windows.Forms.Button();
            this.btnCopyToClipboard_SHA256 = new System.Windows.Forms.Button();
            this.txtSHA256Hash = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCopyToClipboard_SHA512 = new System.Windows.Forms.Button();
            this.txtSHA512Hash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculateHashes = new System.Windows.Forms.Button();
            this.btnCompareSHA1 = new System.Windows.Forms.Button();
            this.btnCompareSHA256 = new System.Windows.Forms.Button();
            this.btnCompareSHA512 = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 424);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 20);
            this.toolStripStatusLabel1.Text = "OpenSSL v3.0.7";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 72);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(438, 55);
            this.txtFilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Browse for the file you want to verify";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(481, 72);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(124, 55);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "SHA-1 Hash";
            // 
            // txtSHA1Hash
            // 
            this.txtSHA1Hash.Location = new System.Drawing.Point(28, 197);
            this.txtSHA1Hash.Multiline = true;
            this.txtSHA1Hash.Name = "txtSHA1Hash";
            this.txtSHA1Hash.ReadOnly = true;
            this.txtSHA1Hash.Size = new System.Drawing.Size(560, 27);
            this.txtSHA1Hash.TabIndex = 6;
            // 
            // btnCopyToClipboard_SHA1
            // 
            this.btnCopyToClipboard_SHA1.Location = new System.Drawing.Point(594, 197);
            this.btnCopyToClipboard_SHA1.Name = "btnCopyToClipboard_SHA1";
            this.btnCopyToClipboard_SHA1.Size = new System.Drawing.Size(94, 27);
            this.btnCopyToClipboard_SHA1.TabIndex = 7;
            this.btnCopyToClipboard_SHA1.Text = "Copy";
            this.btnCopyToClipboard_SHA1.UseVisualStyleBackColor = true;
            // 
            // btnCopyToClipboard_SHA256
            // 
            this.btnCopyToClipboard_SHA256.Location = new System.Drawing.Point(594, 271);
            this.btnCopyToClipboard_SHA256.Name = "btnCopyToClipboard_SHA256";
            this.btnCopyToClipboard_SHA256.Size = new System.Drawing.Size(94, 27);
            this.btnCopyToClipboard_SHA256.TabIndex = 10;
            this.btnCopyToClipboard_SHA256.Text = "Copy";
            this.btnCopyToClipboard_SHA256.UseVisualStyleBackColor = true;
            // 
            // txtSHA256Hash
            // 
            this.txtSHA256Hash.Location = new System.Drawing.Point(28, 271);
            this.txtSHA256Hash.Multiline = true;
            this.txtSHA256Hash.Name = "txtSHA256Hash";
            this.txtSHA256Hash.ReadOnly = true;
            this.txtSHA256Hash.Size = new System.Drawing.Size(560, 27);
            this.txtSHA256Hash.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "SHA-256 Hash";
            // 
            // btnCopyToClipboard_SHA512
            // 
            this.btnCopyToClipboard_SHA512.Location = new System.Drawing.Point(594, 353);
            this.btnCopyToClipboard_SHA512.Name = "btnCopyToClipboard_SHA512";
            this.btnCopyToClipboard_SHA512.Size = new System.Drawing.Size(94, 51);
            this.btnCopyToClipboard_SHA512.TabIndex = 13;
            this.btnCopyToClipboard_SHA512.Text = "Copy";
            this.btnCopyToClipboard_SHA512.UseVisualStyleBackColor = true;
            // 
            // txtSHA512Hash
            // 
            this.txtSHA512Hash.Location = new System.Drawing.Point(28, 353);
            this.txtSHA512Hash.Multiline = true;
            this.txtSHA512Hash.Name = "txtSHA512Hash";
            this.txtSHA512Hash.ReadOnly = true;
            this.txtSHA512Hash.Size = new System.Drawing.Size(560, 51);
            this.txtSHA512Hash.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "SHA-512 Hash";
            // 
            // btnCalculateHashes
            // 
            this.btnCalculateHashes.Location = new System.Drawing.Point(622, 72);
            this.btnCalculateHashes.Name = "btnCalculateHashes";
            this.btnCalculateHashes.Size = new System.Drawing.Size(124, 55);
            this.btnCalculateHashes.TabIndex = 1;
            this.btnCalculateHashes.Text = "Calculate Hashes";
            this.btnCalculateHashes.UseVisualStyleBackColor = true;
            this.btnCalculateHashes.Click += new System.EventHandler(this.btnCalculateHashes_Click);
            // 
            // btnCompareSHA1
            // 
            this.btnCompareSHA1.Location = new System.Drawing.Point(694, 197);
            this.btnCompareSHA1.Name = "btnCompareSHA1";
            this.btnCompareSHA1.Size = new System.Drawing.Size(94, 27);
            this.btnCompareSHA1.TabIndex = 14;
            this.btnCompareSHA1.Text = "Compare";
            this.btnCompareSHA1.UseVisualStyleBackColor = true;
            this.btnCompareSHA1.Click += new System.EventHandler(this.btnCompareSHA1_Click);
            // 
            // btnCompareSHA256
            // 
            this.btnCompareSHA256.Location = new System.Drawing.Point(694, 271);
            this.btnCompareSHA256.Name = "btnCompareSHA256";
            this.btnCompareSHA256.Size = new System.Drawing.Size(94, 27);
            this.btnCompareSHA256.TabIndex = 15;
            this.btnCompareSHA256.Text = "Compare";
            this.btnCompareSHA256.UseVisualStyleBackColor = true;
            // 
            // btnCompareSHA512
            // 
            this.btnCompareSHA512.Location = new System.Drawing.Point(694, 353);
            this.btnCompareSHA512.Name = "btnCompareSHA512";
            this.btnCompareSHA512.Size = new System.Drawing.Size(94, 51);
            this.btnCompareSHA512.TabIndex = 16;
            this.btnCompareSHA512.Text = "Compare";
            this.btnCompareSHA512.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCompareSHA512);
            this.Controls.Add(this.btnCompareSHA256);
            this.Controls.Add(this.btnCompareSHA1);
            this.Controls.Add(this.btnCalculateHashes);
            this.Controls.Add(this.btnCopyToClipboard_SHA512);
            this.Controls.Add(this.txtSHA512Hash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCopyToClipboard_SHA256);
            this.Controls.Add(this.txtSHA256Hash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCopyToClipboard_SHA1);
            this.Controls.Add(this.txtSHA1Hash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "OpenSSL File Verify";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox txtFilePath;
        private Label label1;
        private Button btnBrowse;
        private Label label2;
        private TextBox txtSHA1Hash;
        private Button btnCopyToClipboard_SHA1;
        private Button btnCopyToClipboard_SHA256;
        private TextBox txtSHA256Hash;
        private Label label3;
        private Button btnCopyToClipboard_SHA512;
        private TextBox txtSHA512Hash;
        private Label label4;
        private Button btnCalculateHashes;
        private Button btnCompareSHA1;
        private Button btnCompareSHA256;
        private Button btnCompareSHA512;
    }
}
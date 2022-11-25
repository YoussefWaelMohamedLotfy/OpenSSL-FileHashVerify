namespace OpenSSL_FileHashVerify.Forms
{
    partial class HashCompareForm
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
            this.txtHash = new System.Windows.Forms.TextBox();
            this.txtInputHash = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(35, 33);
            this.txtHash.Multiline = true;
            this.txtHash.Name = "txtHash";
            this.txtHash.ReadOnly = true;
            this.txtHash.Size = new System.Drawing.Size(325, 323);
            this.txtHash.TabIndex = 1;
            // 
            // txtInputHash
            // 
            this.txtInputHash.Location = new System.Drawing.Point(428, 33);
            this.txtInputHash.Multiline = true;
            this.txtInputHash.Name = "txtInputHash";
            this.txtInputHash.Size = new System.Drawing.Size(325, 323);
            this.txtInputHash.TabIndex = 0;
            this.txtInputHash.TextChanged += new System.EventHandler(this.txtInputHash_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(35, 387);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(257, 41);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "The hashes are {0}";
            // 
            // HashCompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtInputHash);
            this.Controls.Add(this.txtHash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HashCompareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hash Compare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtHash;
        private TextBox txtInputHash;
        private Label lblResult;
    }
}
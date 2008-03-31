namespace CompressionUtility
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.rdbDeflate = new System.Windows.Forms.RadioButton();
            this.rdbGzip = new System.Windows.Forms.RadioButton();
            this.btnCompress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.txtTargetPath = new System.Windows.Forms.TextBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.txtSourcePath2 = new System.Windows.Forms.TextBox();
            this.txtTargetPath2 = new System.Windows.Forms.TextBox();
            this.btnUnCompress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(369, 83);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(11, 83);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.ReadOnly = true;
            this.txtSourcePath.Size = new System.Drawing.Size(352, 20);
            this.txtSourcePath.TabIndex = 1;
            // 
            // rdbDeflate
            // 
            this.rdbDeflate.AutoSize = true;
            this.rdbDeflate.Checked = true;
            this.rdbDeflate.Location = new System.Drawing.Point(71, 7);
            this.rdbDeflate.Name = "rdbDeflate";
            this.rdbDeflate.Size = new System.Drawing.Size(59, 17);
            this.rdbDeflate.TabIndex = 2;
            this.rdbDeflate.TabStop = true;
            this.rdbDeflate.Text = "Deflate";
            this.rdbDeflate.UseVisualStyleBackColor = true;
            // 
            // rdbGzip
            // 
            this.rdbGzip.AutoSize = true;
            this.rdbGzip.Location = new System.Drawing.Point(147, 7);
            this.rdbGzip.Name = "rdbGzip";
            this.rdbGzip.Size = new System.Drawing.Size(48, 17);
            this.rdbGzip.TabIndex = 2;
            this.rdbGzip.Text = "GZip";
            this.rdbGzip.UseVisualStyleBackColor = true;
            // 
            // btnCompress
            // 
            this.btnCompress.Enabled = false;
            this.btnCompress.Location = new System.Drawing.Point(369, 108);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(75, 23);
            this.btnCompress.TabIndex = 3;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Method";
            // 
            // ofd
            // 
            this.ofd.RestoreDirectory = true;
            // 
            // txtTargetPath
            // 
            this.txtTargetPath.Enabled = false;
            this.txtTargetPath.Location = new System.Drawing.Point(11, 109);
            this.txtTargetPath.Name = "txtTargetPath";
            this.txtTargetPath.ReadOnly = true;
            this.txtTargetPath.Size = new System.Drawing.Size(352, 20);
            this.txtTargetPath.TabIndex = 1;
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(370, 188);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse2.TabIndex = 0;
            this.btnBrowse2.Text = "Browse";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // txtSourcePath2
            // 
            this.txtSourcePath2.Location = new System.Drawing.Point(12, 188);
            this.txtSourcePath2.Name = "txtSourcePath2";
            this.txtSourcePath2.ReadOnly = true;
            this.txtSourcePath2.Size = new System.Drawing.Size(352, 20);
            this.txtSourcePath2.TabIndex = 1;
            // 
            // txtTargetPath2
            // 
            this.txtTargetPath2.Enabled = false;
            this.txtTargetPath2.Location = new System.Drawing.Point(12, 214);
            this.txtTargetPath2.Name = "txtTargetPath2";
            this.txtTargetPath2.ReadOnly = true;
            this.txtTargetPath2.Size = new System.Drawing.Size(352, 20);
            this.txtTargetPath2.TabIndex = 1;
            // 
            // btnUnCompress
            // 
            this.btnUnCompress.Enabled = false;
            this.btnUnCompress.Location = new System.Drawing.Point(370, 213);
            this.btnUnCompress.Name = "btnUnCompress";
            this.btnUnCompress.Size = new System.Drawing.Size(75, 23);
            this.btnUnCompress.TabIndex = 3;
            this.btnUnCompress.Text = "UnCompress";
            this.btnUnCompress.UseVisualStyleBackColor = true;
            this.btnUnCompress.Click += new System.EventHandler(this.btnUnCompress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnCompress);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.rdbGzip);
            this.Controls.Add(this.rdbDeflate);
            this.Controls.Add(this.txtTargetPath2);
            this.Controls.Add(this.txtTargetPath);
            this.Controls.Add(this.txtSourcePath2);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.RadioButton rdbDeflate;
        private System.Windows.Forms.RadioButton rdbGzip;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox txtTargetPath;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.TextBox txtSourcePath2;
        private System.Windows.Forms.TextBox txtTargetPath2;
        private System.Windows.Forms.Button btnUnCompress;
    }
}


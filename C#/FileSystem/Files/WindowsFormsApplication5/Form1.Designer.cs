namespace WindowsFormsApplication5
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
            this.btnRead = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnBinRead = new System.Windows.Forms.Button();
            this.btnBinWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 12);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Text Reader";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 41);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(404, 223);
            this.txtContent.TabIndex = 1;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(93, 12);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Text Writer";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnBinRead
            // 
            this.btnBinRead.Location = new System.Drawing.Point(191, 12);
            this.btnBinRead.Name = "btnBinRead";
            this.btnBinRead.Size = new System.Drawing.Size(88, 23);
            this.btnBinRead.TabIndex = 0;
            this.btnBinRead.Text = "Binary Reader";
            this.btnBinRead.UseVisualStyleBackColor = true;
            this.btnBinRead.Click += new System.EventHandler(this.btnBinRead_Click);
            // 
            // btnBinWrite
            // 
            this.btnBinWrite.Location = new System.Drawing.Point(285, 12);
            this.btnBinWrite.Name = "btnBinWrite";
            this.btnBinWrite.Size = new System.Drawing.Size(75, 23);
            this.btnBinWrite.TabIndex = 2;
            this.btnBinWrite.Text = "binary Writer";
            this.btnBinWrite.UseVisualStyleBackColor = true;
            this.btnBinWrite.Click += new System.EventHandler(this.btnBinWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 276);
            this.Controls.Add(this.btnBinWrite);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnBinRead);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnBinRead;
        private System.Windows.Forms.Button btnBinWrite;
    }
}


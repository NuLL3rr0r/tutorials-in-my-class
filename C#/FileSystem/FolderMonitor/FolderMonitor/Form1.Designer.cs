namespace FolderMonitor
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.chkAutoSave = new System.Windows.Forms.CheckBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.fsw = new System.IO.FileSystemWatcher();
            this.chkIncSubs = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.ntfyTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxMinimize = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mItemReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mItemExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).BeginInit();
            this.ctxMinimize.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(510, 20);
            this.txtPath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(528, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lstLog
            // 
            this.lstLog.Enabled = false;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(12, 66);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(591, 212);
            this.lstLog.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(12, 37);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(93, 37);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // chkAutoSave
            // 
            this.chkAutoSave.AutoSize = true;
            this.chkAutoSave.Checked = true;
            this.chkAutoSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoSave.Enabled = false;
            this.chkAutoSave.Location = new System.Drawing.Point(358, 41);
            this.chkAutoSave.Name = "chkAutoSave";
            this.chkAutoSave.Size = new System.Drawing.Size(103, 17);
            this.chkAutoSave.TabIndex = 5;
            this.chkAutoSave.Text = "Save to Log File";
            this.chkAutoSave.UseVisualStyleBackColor = true;
            // 
            // fsw
            // 
            this.fsw.EnableRaisingEvents = true;
            this.fsw.SynchronizingObject = this;
            this.fsw.Renamed += new System.IO.RenamedEventHandler(this.fsw_Renamed);
            this.fsw.Deleted += new System.IO.FileSystemEventHandler(this.fsw_Deleted);
            this.fsw.Created += new System.IO.FileSystemEventHandler(this.fsw_Created);
            this.fsw.Changed += new System.IO.FileSystemEventHandler(this.fsw_Changed);
            // 
            // chkIncSubs
            // 
            this.chkIncSubs.AutoSize = true;
            this.chkIncSubs.Enabled = false;
            this.chkIncSubs.Location = new System.Drawing.Point(467, 43);
            this.chkIncSubs.Name = "chkIncSubs";
            this.chkIncSubs.Size = new System.Drawing.Size(136, 17);
            this.chkIncSubs.TabIndex = 5;
            this.chkIncSubs.Text = "Include Sub Directories";
            this.chkIncSubs.UseVisualStyleBackColor = true;
            this.chkIncSubs.CheckedChanged += new System.EventHandler(this.chkIncSubs_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(230, 37);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ntfyTray
            // 
            this.ntfyTray.ContextMenuStrip = this.ctxMinimize;
            this.ntfyTray.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfyTray.Icon")));
            this.ntfyTray.DoubleClick += new System.EventHandler(this.ntfyTray_DoubleClick);
            // 
            // ctxMinimize
            // 
            this.ctxMinimize.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemReturn,
            this.toolStripMenuItem1,
            this.mItemStart,
            this.mItemStop,
            this.toolStripMenuItem2,
            this.mItemExit});
            this.ctxMinimize.Name = "ctxMinimize";
            this.ctxMinimize.Size = new System.Drawing.Size(108, 104);
            // 
            // mItemReturn
            // 
            this.mItemReturn.Name = "mItemReturn";
            this.mItemReturn.Size = new System.Drawing.Size(152, 22);
            this.mItemReturn.Text = "Return";
            this.mItemReturn.Click += new System.EventHandler(this.ntfyTray_DoubleClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mItemStart
            // 
            this.mItemStart.Enabled = false;
            this.mItemStart.Name = "mItemStart";
            this.mItemStart.Size = new System.Drawing.Size(152, 22);
            this.mItemStart.Text = "Start";
            this.mItemStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // mItemStop
            // 
            this.mItemStop.Enabled = false;
            this.mItemStop.Name = "mItemStop";
            this.mItemStop.Size = new System.Drawing.Size(152, 22);
            this.mItemStop.Text = "Stop";
            this.mItemStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // mItemExit
            // 
            this.mItemExit.Name = "mItemExit";
            this.mItemExit.Size = new System.Drawing.Size(152, 22);
            this.mItemExit.Text = "Exit";
            this.mItemExit.Click += new System.EventHandler(this.mItemExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 291);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkIncSubs);
            this.Controls.Add(this.chkAutoSave);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Folder Monitor";
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).EndInit();
            this.ctxMinimize.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox chkAutoSave;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.IO.FileSystemWatcher fsw;
        private System.Windows.Forms.CheckBox chkIncSubs;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NotifyIcon ntfyTray;
        private System.Windows.Forms.ContextMenuStrip ctxMinimize;
        private System.Windows.Forms.ToolStripMenuItem mItemReturn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mItemStart;
        private System.Windows.Forms.ToolStripMenuItem mItemStop;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mItemExit;
    }
}


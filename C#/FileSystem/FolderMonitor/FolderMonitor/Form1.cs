using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FolderMonitor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void SetFormStatus(bool state)
        {
            btnBrowse.Enabled = state;
            btnStart.Enabled = state;
            mItemStart.Enabled = state;
            chkAutoSave.Enabled = state;
            chkIncSubs.Enabled = state;
            btnStop.Enabled = !state;
            mItemStop.Enabled = !state;
        }

        private void ReportEvent(string state)
        {
            try
            {
                DateTime dt = DateTime.Now;

                state = dt.ToString() + "   " + state;
                lstLog.Items.Add(state);

                using (StreamWriter sw = new StreamWriter(@"C:\reports.log", true, Encoding.UTF8 ))
                {
                    sw.WriteLine(state);
                    sw.Close();
                }

                this.ntfyTray.Text = "The Last Event: " + state;
                //bug
            }
            catch
            {
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {
                btnStart.Enabled = true;
                chkAutoSave.Enabled = true;
                chkIncSubs.Enabled = true;
                lstLog.Enabled = true;

                txtPath.Text = fbd.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SetFormStatus(false);

            fsw.Path = txtPath.Text;
            fsw.EnableRaisingEvents = true;

            ReportEvent("Monitor Started");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SetFormStatus(true);

            fsw.EnableRaisingEvents = false;

            ReportEvent("Monitor Stoped");
        }

        private void chkIncSubs_CheckedChanged(object sender, EventArgs e)
        {
            fsw.IncludeSubdirectories = chkIncSubs.Checked;
        }

        private void fsw_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            ReportEvent(String.Format("The {0} was {1}", e.Name, e.ChangeType));
        }

        private void fsw_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            ReportEvent(String.Format("The {0} was {1}", e.Name, e.ChangeType));
        }

        private void fsw_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            ReportEvent(String.Format("The {0} was {1}", e.Name, e.ChangeType));
        }

        private void fsw_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            ReportEvent(String.Format("The {0} was {1} to {2}", e.OldName, e.ChangeType, e.Name));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            ntfyTray.Visible = true;
            this.ShowInTaskbar = false;

            if (!btnStop.Enabled)
            {
                ntfyTray.Text = "Monitor is stoping";
            }
        }

        private void ntfyTray_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            ntfyTray.Visible = false;
        }

        private void mItemExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            //Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ntfyTray.Visible = false;
        }
    }
}

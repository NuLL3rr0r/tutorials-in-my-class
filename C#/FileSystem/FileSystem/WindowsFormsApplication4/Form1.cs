using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            ofd.Filter = "All Files (*.*) | *.*; | All Picture Types | *.jpg;*.bmp;*.tif;";
            DialogResult result = ofd.ShowDialog();
            txtFilePath.Text = ofd.FileName;

            try
            {
                if (result != DialogResult.Cancel)
                {
                    FileInfo fi = new FileInfo(txtFilePath.Text);
                    string name = fi.Name;
                    string len = (fi.Length / 1024).ToString();
                    string cTime = fi.CreationTime.ToString();

                    string res = String.Format("File Name is\t{0}\nSize is\t{1} KB\nCreation Time is\t{2}", name, len, cTime);
                    MessageBox.Show(res);
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show("C1: We got an error!\n\n" + ex.Message, "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("C2: We got an error!\n\n" + ex.Message, "Common Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = fbd.ShowDialog();

            txtFolderPath.Text = fbd.SelectedPath;

            try
            {
                if (result != DialogResult.Cancel)
                {
                    lstFiles.Items.Clear();
                    lstFiles.Items.AddRange(Directory.GetFiles(txtFolderPath.Text));

                    /*foreach (string file in Directory.GetFiles(txtFolderPath.Text))
                    {
                        lstFiles.Items.Add(file);
                    }*/
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show("C1: We got an error!\n\n" + ex.Message, "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("C2: We got an error!\n\n" + ex.Message, "Common Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

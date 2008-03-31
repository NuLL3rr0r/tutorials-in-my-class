using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;

namespace CompressionUtility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region Compress / Decompress Section

        /*        private byte[] Compress(string data)
        {
            return Compress(Encoding.Unicode.GetBytes(data));
        }

        private string DecompressToStr(byte[] data)
        {
            return Encoding.Unicode.GetString(Decompress(data));
        }*/

        private byte[] Compress(byte[] data)
        {
            try
            {
                Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime;

                MemoryStream ms = new MemoryStream();
                Stream s;

                if (rdbDeflate.Checked)
                   s  = new DeflateStream(ms, CompressionMode.Compress);
                else
                    s = new GZipStream(ms, CompressionMode.Compress);

                s.Write(data, 0, data.Length);
                s.Close();

                byte[] cData = { };
                cData = (byte[])ms.ToArray();

                Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.Normal;

                return cData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\t" + ex.Message);
                Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.Normal;
                return null;
            }
        }

        private byte[] Decompress(byte[] data)
        {
            try
            {
                Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime;

                string result = string.Empty;
                byte[] uData = { };

                MemoryStream ms = new MemoryStream(data);
                Stream s = new DeflateStream(ms, CompressionMode.Decompress);

                int len = 4096;

                while (true)
                {
                    int oldLen = uData.Length;
                    Array.Resize(ref uData, oldLen + len);
                    int size = s.Read(uData, oldLen, len);
                    if (size != len)
                    {
                        Array.Resize(ref uData, uData.Length - (len - size));
                        break;
                    }
                    if (size <= 0)
                        break;
                }
                s.Close();

                Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.Normal;

                return uData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\t" + ex.Message);
                Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.Normal;
                return null;
            }
        }

        #endregion


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofd.Filter = "All Files(*.*) | *.*";
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtSourcePath.Text = ofd.FileName;
                btnCompress.Enabled = true;
                txtTargetPath.Enabled = true;
                txtTargetPath.Text = string.Empty;
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = fbd.ShowDialog();

                int sSize = -1;
                float tSize = -1;


                if (result == DialogResult.OK)
                {
                    this.Enabled = false;

                    FileInfo fi = new FileInfo(txtSourcePath.Text);
                    sSize = (int)fi.Length;
                    string ext = rdbDeflate.Checked ? ".dfl" : ".gzp";
                    string target = fi.Name + ext;

                    txtTargetPath.Text = fbd.SelectedPath;
                    txtTargetPath.Text += (txtTargetPath.Text.EndsWith("\\") ? string.Empty : "\\");
                    txtTargetPath.Text += target;

                    byte[] data = { };
                    using (FileStream fs = new FileStream(txtSourcePath.Text, FileMode.Open))
                    {
                        int len = (int)fi.Length;

                        data = new byte[len];

                        fs.Read(data, 0, len);
                        fs.Close();
                    }

                    data = Compress(data);


                    using (FileStream fs = new FileStream(txtTargetPath.Text, FileMode.Create))
                    {
                        fs.Write(data, 0, data.Length);
                        fs.Close();
                    }

                    FileInfo fi2 = new FileInfo(txtTargetPath.Text);
                    tSize = (float)fi2.Length;

                    float ratio = ((sSize - tSize) / sSize) * 100;

                    this.Enabled = true;
                    MessageBox.Show("Compressed Successfully\n\nRatio: " + ratio.ToString().Substring(0, ratio.ToString().LastIndexOf(".") + 3) + "%");
                }
            }
            catch (Exception ex)
            {
                this.Enabled = true;
                MessageBox.Show("Error:\n\t" + ex.Message);
            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            ofd.Filter = rdbDeflate.Checked ? "Deflate Files (*.dfl) | *.dfl" : "GZip Files (*.gzp) | *.gzp";

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                btnUnCompress.Enabled = true;
                txtTargetPath2.Enabled = true;
                txtTargetPath2.Text = string.Empty;
                txtSourcePath2.Text = ofd.FileName;
            }
        }

        private void btnUnCompress_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.Enabled = false;

                    FileInfo fi = new FileInfo(txtSourcePath2.Text);
                    string target = fi.Name.Substring(0, fi.Name.LastIndexOf("."));

                    txtTargetPath2.Text = fbd.SelectedPath;
                    txtTargetPath2.Text += (txtTargetPath.Text.EndsWith("\\") ? string.Empty : "\\");
                    txtTargetPath2.Text += target; 
                    

                    byte[] data = { };
                    using (FileStream fs = new FileStream(txtSourcePath2.Text, FileMode.Open))
                    {
                        int len = (int)fi.Length;

                        data = new byte[len];

                        fs.Read(data, 0, len);
                        fs.Close();
                    }

                    data = Decompress(data);

                    using (FileStream fs = new FileStream(txtTargetPath2.Text, FileMode.Create))
                    {
                        fs.Write(data, 0, data.Length);
                        fs.Close();
                    }

                    this.Enabled = true;
                    MessageBox.Show("UnCompressed Successfully");
                }
            }
            catch (Exception ex)
            {
                this.Enabled = true;
                MessageBox.Show("Error:\n\t" + ex.Message);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofd.Filter = "All Files(*.*) | *.*;";

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                btnUpload.Enabled = true;
                txtPath.Text = ofd.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fi = new FileInfo(txtPath.Text);
                int len = (int)fi.Length;

                byte[] contents = new byte[len];

                using (FileStream fs = new FileStream(txtPath.Text, FileMode.Open, FileAccess.Read))
                {
                    fs.Read(contents, 0, len);
                    fs.Close();
                }

                MyIOOperations.ServiceSoapClient MyIO = new MyIOOperations.ServiceSoapClient();

                string res = MyIO.SnedFile(contents, fi.Name);

                MessageBox.Show("Server Said:\n\t" + res);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Client Error:\n\t" + ex.Message);
            }
        }
    }
}

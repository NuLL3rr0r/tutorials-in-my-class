using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication5
{

    /// <summary>
    /// Hello, C#
    /// </summary>
    public partial class Form1 : Form
    {
        public string path = Environment.CurrentDirectory;
        public string file = "test.txt";
        public string pic = "pic.jpg";

        public Form1()
        {
            path += path.EndsWith("\\") ? string.Empty : "\\";
            //path += path.EndsWith(@"\") ? string.Empty : @"\";
            file = path + file;
            pic = path + pic;

            InitializeComponent();
        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            txtContent.Text = string.Empty;
            using (StreamReader sr = new StreamReader(file, Encoding.UTF8))
            {
/*                while (sr.Peek() > 0)
                {
                    txtContent.Text += sr.ReadLine() + "\n";
                }*/
                txtContent.Text += sr.ReadToEnd();
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(file, false, Encoding.UTF8)) // false overwrite / true append
            {
                sw.Write(txtContent.Text);
                sw.Flush();
            }
        }

        private void btnBinRead_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(pic);
            int len = (int)fi.Length;
            //int len = Convert.ToInt32(fi.Length);
            byte[] buffer = new byte[len];
            using (FileStream fs = new FileStream(pic, FileMode.Open, FileAccess.Read))
            {
                fs.Read(buffer, 0, len);
            }

            txtContent.Text =Convert.ToBase64String(buffer);
        }

        private void btnBinWrite_Click(object sender, EventArgs e)
        {
            byte[] buffer = Convert.FromBase64String(txtContent.Text);

            using (FileStream fs = new FileStream(pic, FileMode.Create, FileAccess.Write))
            {
                fs.Write(buffer, 0, buffer.Length);
            }
        }
    }
}

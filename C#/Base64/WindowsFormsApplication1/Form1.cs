using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*) | *.*";
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             System.IO.FileInfo fi = new System.IO.FileInfo(textBox1.Text);
            using (System.IO.FileStream fs =  new System.IO.FileStream(textBox1.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read))
            {
                byte[] file = {};
                int len = (int)fi.Length;
                Array.Resize(ref file, len);
                fs.Read(file, 0, len);
                textBox2.Text = Convert.ToBase64String(file);
            }
        }
    }
}

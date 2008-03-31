using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Math;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Primative pr = new Primative();
            pr.dn1 = 100;
            pr.dn2 = 300;
            long result = pr.Add();

            Primative

            MessageBox.Show(result.ToString());
        }
    }
}

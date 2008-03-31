using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestForm
{
    public partial class TestForm : Form
    {
        public string SetMyText
        {
            get
            {
                return txtMainText.Text;
            }
            set
            {
                txtMainText.Text = value;
            }
        }

        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}

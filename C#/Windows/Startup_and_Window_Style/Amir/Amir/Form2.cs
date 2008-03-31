using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Amir
{
    public partial class Form2 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000080;
                this.ShowInTaskbar = false;
                return cp;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }
    }
}

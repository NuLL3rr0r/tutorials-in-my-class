using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Amir
{
    public partial class Form3 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        public Form3()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;

            InitializeComponent();
        }
    }
}

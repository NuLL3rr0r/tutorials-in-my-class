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

        private bool shift = false;

        private void Transform(TextBox textBox, KeyPressEventArgs e)
        {
            int pos = textBox.SelectionStart;
            e.Handled = true;

            if (!shift)
            {
                switch (e.KeyChar.ToString().ToUpper())
                {
                    case "H":
                        textBox.Text += "\u0627";
                        break;
                    default:
                        e.Handled = false;
                        break;
                }
            }
            else
            {
                switch (e.KeyChar.ToString().ToUpper())
                {
                    case "H":
                        textBox.Text += "\u0622";
                        break;
                    default:
                        e.Handled = false;
                        break;
                }
                shift = false;
            }
            textBox.Select(pos + 1, 0);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Transform(textBox1, e);
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            shift = e.Shift;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Transform(textBox3, e);
        }


    }
}

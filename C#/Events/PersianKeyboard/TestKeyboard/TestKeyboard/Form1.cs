using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using CrossPlatformKeyboard;


namespace TestKeyboard
{
    public partial class Form1 : Form
    {
        PersianKeyboard kb = new PersianKeyboard();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            kb.usePersianNums = true;
            kb.TransformInputChar((TextBox)sender, e);
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            kb.shiftPressed = e.Shift;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        TestForm frm = new TestForm();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            //Environment.Exit(0);
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //TestForm frm = new TestForm();
            frm.Show();
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            //TestForm frm = new TestForm();
            frm.ShowDialog(this);
        }

        private void txtMasterText_TextChanged(object sender, EventArgs e)
        {
            //TestForm frm = new TestForm();
            frm.SetMyText = ((TextBox)sender).Text;
        }

        private void btnShowText_Click(object sender, EventArgs e)
        {
            MessageBox.Show(frm.SetMyText);
        }

        private void cmbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            switch (cmb.Text)
            {
                case "Red":
                    frm.BackColor = Color.Red;
                    break;
                case "Green":
                    frm.BackColor = Color.Green;
                    break;
                case "Blue":
                    frm.BackColor = Color.Blue;
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cmbColors.Items.Add("Red");
            //cmbColors.Items.Add("Green");
            //cmbColors.Items.Add("Blue");

            //cmbColors.Items.AddRange(new string[] {"Red", "Green", "Blue"});

            MessageBox.Show("Form Load");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Form Shown");
        }
    }
}

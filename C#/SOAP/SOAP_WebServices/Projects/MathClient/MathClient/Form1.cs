using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using System.Web.Services.Protocols;



namespace MathClient
{
    public partial class Form1 : Form
    {
        private MathServer.MyMath srv = new MathClient.MathServer.MyMath();

        public Form1()
        {
            InitializeComponent();

            srv.AddCompleted += new MathServer.AddCompletedEventHandler(AddCompleted);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = 0 ,n2 = 0;
            if (int.TryParse(textBox1.Text, out n1))
            {
                if (int.TryParse(textBox2.Text, out n2))
                {
                    long result = srv.Add(n1, n2);

                    MessageBox.Show(result.ToString());
                }
                else
                    MessageBox.Show("Invalid value");
            }
            else
                MessageBox.Show("Invalid value");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0;
            if (int.TryParse(textBox1.Text, out n1))
            {
                if (int.TryParse(textBox2.Text, out n2))
                {
                    long result = srv.Dec(n1, n2);

                    MessageBox.Show(result.ToString());
                }
                else
                    MessageBox.Show("Invalid value");
            }
            else
                MessageBox.Show("Invalid value");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0;
            if (int.TryParse(textBox1.Text, out n1))
            {
                if (int.TryParse(textBox2.Text, out n2))
                {
                    srv.AddAsync(n1, n2);
                }
                else
                    MessageBox.Show("Invalid value");
            }
            else
                MessageBox.Show("Invalid value");
        }


        private void AddCompleted(Object sender, MathServer.AddCompletedEventArgs Completed)
        {
            try
            {
                long result = Completed.Result;
                MessageBox.Show(result.ToString());
            }
            catch (SoapException ex)
            {
                MessageBox.Show("Error:\n\n", ex.Message + "\n\n" + ex.InnerException.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n", ex.Message + "\n\n" + ex.InnerException.Message);
            }
            finally
            {
            }

        }
    }
}

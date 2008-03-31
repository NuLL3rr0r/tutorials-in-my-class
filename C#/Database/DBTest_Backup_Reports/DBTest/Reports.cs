using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBTest
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stdDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.stdDataSet.students);

            this.reportViewer1.RefreshReport();
        }
    }
}

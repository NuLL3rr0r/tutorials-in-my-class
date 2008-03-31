using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersianDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetDate_Click(object sender, EventArgs e)
        {

            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();

            DateTime dt = DateTime.Now;

            //{0} = Year
            //{1} = Month
            //{2} = Day
            string strDate = String.Format("{0}/{1}/{2}", pc.GetYear(dt), pc.GetMonth(dt), pc.GetDayOfMonth(dt));

            MessageBox.Show(strDate);
            Shamsi.Shamsi sh = new Shamsi.Shamsi();
            MessageBox.Show(sh.ShamsiDate());
            MessageBox.Show(MSBabaei.DateProvider.ToPersian());
        }
    }
}

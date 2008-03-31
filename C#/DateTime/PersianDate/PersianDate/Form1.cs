using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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



        private static string GetGregorianDate()
        {
            DateTime dt = DateTime.Now;

            //{0} = Year
            //{1} = Month
            //{2} = Day
            string y = dt.Year.ToString();
            string m = dt.Month.ToString();
            string d = dt.Day.ToString();

            if (m.Length != 2)
                m = "0" + m;
            if (d.Length != 2)
                d = "0" + d;

            return String.Format("{0}/{1}/{2}", y, m, d);
        }

        private static string GetHijriDate()
        {
            System.Globalization.HijriCalendar hc = new System.Globalization.HijriCalendar();

            DateTime dt = DateTime.Now;

            string y = hc.GetYear(dt).ToString();
            string m = hc.GetMonth(dt).ToString();
            string d = hc.GetDayOfMonth(dt).ToString();

            if (m.Length != 2)
                m = "0" + m;
            if (d.Length != 2)
                d = "0" + d;

            //{0} = Year
            //{1} = Month
            //{2} = Day
            return String.Format("{0}/{1}/{2}", y, m, d);
        }

        private string GetPersianDate()
        {
            return GetPersianDate(DateTime.Now);
        }

        private string GetPersianDate(DateTime dt)
        {
            //using System.Globalization;
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();

            string y = pc.GetYear(dt).ToString();
            string m = pc.GetMonth(dt).ToString();
            string d = pc.GetDayOfMonth(dt).ToString();

            if (m.Length != 2)
                m = "0" + m;
            if (d.Length != 2)
                d = "0" + d;

            //{0} = Year
            //{1} = Month
            //{2} = Day

            return string.Format("{0}/{1}/{2}", y, m, d);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            MessageBox.Show(dt.ToString());
            MessageBox.Show(string.Format("{0}/{1}/{2}, {3}:{4}:{5}", dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(GetPersianDate(DateTime.Now));
            MessageBox.Show(GetPersianDate());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetPersianDate(new DateTime(2000, 5, 6)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateTime dt = pc.ToDateTime(1384, 2, 31, 0, 0, 0, 0);
            MessageBox.Show(string.Format("{0}/{1}/{2}", dt.Year, dt.Month, dt.Day));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private string GetTime()
        {
            DateTime dt = DateTime.Now;

            string hh = dt.Hour.ToString();
            string mm = dt.Minute.ToString();
            string ss = dt.Second.ToString();

            if (hh.Length == 1)
                hh = "0" + hh;
            if (mm.Length == 1)
                mm = "0" + mm;
            if (ss.Length == 1)
                ss = "0" + ss;

            return string.Format("{0}:{1}:{2}", hh, mm, ss);
        }

        private string GetTimeWMS()
        {
            DateTime dt = DateTime.Now;

            string hh = dt.Hour.ToString();
            string mm = dt.Minute.ToString();
            string ss = dt.Second.ToString();
            string ms = dt.Millisecond.ToString();

            if (hh.Length == 1)
                hh = "0" + hh;
            if (mm.Length == 1)
                mm = "0" + mm;
            if (ss.Length == 1)
                ss = "0" + ss;
            if (ms.Length == 1)
                ms = "00" + ms;
            if (ms.Length == 2)
                ms = "0" + ms;

            return string.Format("{0}:{1}:{2}.{3}", hh, mm, ss, ms);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string t = GetTime();

            label1.Text = GetGregorianDate() + ", " + t;
            label2.Text = GetPersianDate() + ", " + t;
            label3.Text = GetHijriDate() + ", " + t;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = GetTimeWMS();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.IsLeapYear(2008).ToString());
        }

    }
}

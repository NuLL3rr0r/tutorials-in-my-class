using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using IWshRuntimeLibrary;

namespace Amir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string startupPath = Environment.GetEnvironmentVariable("ALLUSERSPROFILE");
            if (!startupPath.EndsWith(Path.DirectorySeparatorChar.ToString()))
                startupPath += Path.DirectorySeparatorChar.ToString();
            startupPath += @"Start Menu\Programs\Startup\";

            /*string appPath = Environment.CurrentDirectory;
            if (!appPath.EndsWith(Path.DirectorySeparatorChar.ToString()))
                appPath += Path.DirectorySeparatorChar.ToString();*/

            //string appPath = Environment.GetCommandLineArgs()[0];
            string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            /*using (StreamWriter sw = new StreamWriter(startupPath + "Amir.url"))
            {
                sw.WriteLine("[InternetShortcut]");
                sw.WriteLine("URL=file:///" + appPath);
                sw.WriteLine("IconIndex=0");
                string icon = appPath.Replace('\\', '/');
                sw.WriteLine("IconFile=" + icon);
                sw.Flush();
            }*/

            WshShellClass WshShell = new WshShellClass();
            IWshRuntimeLibrary.IWshShortcut shortcut;
            shortcut = (IWshRuntimeLibrary.IWshShortcut)WshShell.CreateShortcut(startupPath + "Amir.lnk");
            shortcut.TargetPath = appPath;
            shortcut.Description = "Launch Amir's App";
            shortcut.IconLocation = appPath;
            shortcut.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {        
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}

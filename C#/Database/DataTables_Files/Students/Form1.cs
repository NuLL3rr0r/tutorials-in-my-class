using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Analyzer(string phrase)
        {
            int pos = phrase.LastIndexOf(":") + 2;
            int len = phrase.Length - pos;
            phrase = phrase.Substring(pos, len);
            return phrase;
        }

        private string GetColName(string phrase)
        {
            int pos1 = phrase.IndexOf(" ") + 1;
            int pos2 = phrase.LastIndexOf(":");
            int len = pos2 - pos1;
            phrase = phrase.Substring(pos1, len);
            return phrase;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Text File (*.txt) | *.txt";
            DialogResult result = ofd.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                txtPath.Text = ofd.FileName;
                try
                {
                    using (StreamReader sr = new StreamReader(txtPath.Text, Encoding.UTF8))
                    {
                        string res = sr.ReadLine();

                        if (res == "Students DB v1.0")
                        {
                            DataTable dt = new DataTable("Students");
                            dt.Columns.Add("ID", Type.GetType("System.String"));
                            dt.Columns.Add("Name", Type.GetType("System.String"));
                            dt.Columns.Add("No", Type.GetType("System.String"));
                            dt.Columns.Add("Rank", Type.GetType("System.String"));

                            DataRow dr = dt.NewRow();

                            int posCol = -1;

                            while (sr.Peek() > -1)
                            {
                                res = sr.ReadLine();
                                if (res.Contains("Student ID: ") || res.Contains("Student Name: ") || res.Contains("Student No: ") || res.Contains("Student Rank: "))
                                {
                                    switch (GetColName(res))
                                    {
                                        case "ID":
                                            dr["ID"] = Analyzer(res);
                                            //dr[0] = Analyzer(res);
                                            break;
                                        case "Name":
                                            dr["Name"] = Analyzer(res);
                                            //dr[1] = Analyzer(res);
                                            break;
                                        case "No":
                                            dr["No"] = Analyzer(res);
                                            //dr[2] = Analyzer(res);
                                            break;
                                        case "Rank":
                                            dr["Rank"] = Analyzer(res);
                                            //dr[3] = Analyzer(res);
                                            break;
                                        default:
                                            break;
                                    }
                                    if (++posCol == 4)
                                    {
                                        posCol = -1;
                                        dt.Rows.Add(dr);
                                        dr = dt.NewRow();
                                    }
                                }
                            }

                            dgvStudents.ReadOnly = true;
                            dgvStudents.DataSource = dt;

                            dgvStudents.Sort(dgvStudents.Columns["Name"], System.ComponentModel.ListSortDirection.Ascending);
                            //dgvStudents.Sort(dgvStudents.Columns["Name"], System.ComponentModel.ListSortDirection.Descending);
                        }
                        else
                        {
                            MessageBox.Show("Invalid File Format / Version", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        sr.Close();
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "IO/Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace MultipleDB
{
    public partial class Form1 : Form
    {
        string path = string.Empty;
        private string dBpw = string.Empty;
        private string fileDb = "Database1.mdb";
        private string cnnStr;

        public Form1()
        {
            path = Environment.CurrentDirectory;
            path += path.EndsWith(Path.DirectorySeparatorChar.ToString()) ? string.Empty : Path.DirectorySeparatorChar.ToString();
            fileDb = string.Concat(path, fileDb);
            cnnStr = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Database Password={1};", fileDb, dBpw);

            InitializeComponent();
        }

        private string Add(string tbl, string[,] data)
        {
            string msg = string.Empty;

            string sqlStr = string.Concat("SELECT * FROM ", tbl);

            try
            {
                OleDbConnection cnn = new OleDbConnection(cnnStr);
                OleDbDataAdapter oda = new OleDbDataAdapter(sqlStr, cnn);
                OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda);

                cnn.Open();

                OleDbCommand cmd = new OleDbCommand(sqlStr, cnn);
                OleDbDataReader drr = cmd.ExecuteReader();

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                DataRow dr;

                ocb.QuotePrefix = "[";
                ocb.QuoteSuffix = "]";
                oda.Fill(ds, tbl);

                bool found = false;

                while (drr.Read())
                {
                    if (drr["id"].ToString().Trim() == data[0,0])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    dt = ds.Tables[tbl];
                    dr = dt.NewRow();
                    
                    for (int i = 0; i < data.Length / 2; i++)
                        dr[data[i, 0]] = data[i, 1].Trim();

                    dt.Rows.Add(dr);

                    oda.InsertCommand = ocb.GetInsertCommand();

                    if (oda.Update(ds, tbl) == 1)
                    {
                        ds.AcceptChanges();
                        msg = "Added";
                    }
                    else
                    {
                        ds.RejectChanges();
                        msg = "Rejected";
                    }
                }
                else
                    msg = "Already Exist";

                cnn.Close();
                drr.Close();

                ds.Dispose();
                cmd.Dispose();
                drr.Dispose();
                ocb.Dispose();
                oda.Dispose();
                cnn.Dispose();
                dt.Dispose();

                ds = null;
                ocb = null;
                oda = null;
                dr = null;
                dt = null;
                cmd = null;
                drr = null;
                cnn = null;
            }
            catch (Exception ex)
            {
                msg = "Error:\n\t" + ex.Message;
            }
            finally
            {
                //tbl = null;
                sqlStr = null;
            }

            return tbl + " ==>   " + msg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Add("students",
                                new string[,] {
                                                { "id", textBox1.Text },
                                                { "stdname", textBox2.Text },
                                                { "stdno", textBox3.Text }
                                }));

            MessageBox.Show(Add("teachers",
                                new string[,] {
                                                { "id", textBox4.Text },
                                                { "tchname", textBox5.Text } 
                                }));

            MessageBox.Show(Add("schools",
                                new string[,] {
                                                { "id", textBox6.Text },
                                                { "schname", textBox7.Text },
                                                { "classes", textBox8.Text }
                                }));
        }
    }
}

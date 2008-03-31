using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using System.IO;
using System.Data;
using System.Data.OleDb;


namespace DBTest
{
    public partial class Form1 : Form
    {
        string path;
        string dbPw = "123";
        string dbFile = "std.mdb";
        private string cnnStr;

        private string id4Edit = string.Empty;


        private DataTable dtMaster = new DataTable();


        public Form1()
        {
            path = Environment.CurrentDirectory;

            // Get the path separator char in OS, example: win-> C:\App\   Other OS -> C:/App/
            string sepChar = Path.DirectorySeparatorChar.ToString();

            // C:\App is an Example
            // in some OSes looked like C:\App and Some C:\App\
            // C:\App\std.mdb   path += "std.mdb"   path += "\std.mdb" 
            if (!path.EndsWith(sepChar))
                path += sepChar;
                //output C:\App\

            dbFile = string.Concat(path, dbFile);  // dbFile = path + dbFile;
            // output C:\App\std.mdb

            cnnStr = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Database Password={1};", dbFile, dbPw);

            InitializeComponent();

            // Must appear afffter InitializeComponent
            dgvStudents.RightToLeft = RightToLeft.Yes;
            dgvStudents.ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tbl = "students";
            string sqlStr = string.Concat("SELECT * FROM ", tbl);

            try
            {
                OleDbConnection cnn = new OleDbConnection(cnnStr);
                OleDbDataAdapter oda = new OleDbDataAdapter(sqlStr, cnn);
                OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda);
                
                cnn.Open();

                // must appear after cnn.open
                OleDbCommand cmd = new OleDbCommand(sqlStr, cnn);
                OleDbDataReader drr = cmd.ExecuteReader();
                ///////

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                DataRow dr;

                bool duplicate = false;

                while (drr.Read())
                {
                    if (drr["id"].ToString().Trim() == txtIDAdd.Text.Trim())
                    {
                        duplicate = true;
                        break;
                    }
                }


                if (!duplicate)
                {
                    ocb.QuotePrefix = "[";
                    ocb.QuoteSuffix = "]";
                    oda.Fill(ds, tbl);

                    dt = ds.Tables[tbl];
                    dr = dt.NewRow();

                    /*dr[0] = txtIDAdd.Text.Trim();
                    dr[1] = txtNameAdd.Text.Trim();
                    dr[2] = txtMarkAdd.Text.Trim();*/
                    dr["id"] = txtIDAdd.Text.Trim();
                    dr["studentname"] = txtNameAdd.Text.Trim();
                    dr["mark"] = Convert.ToByte(txtMarkAdd.Text.Trim());
                    dt.Rows.Add(dr);

                    oda.InsertCommand = ocb.GetInsertCommand();

                    if (oda.Update(ds, tbl) == 1)
                    {
                        ds.AcceptChanges();
                        MessageBox.Show("Added");
                    }
                    else
                    {
                        ds.RejectChanges();
                        MessageBox.Show("Rejected");
                    }
                }
                else
                    MessageBox.Show("Already Exist");


                drr.Close();
                cnn.Close();

                dt.Dispose();
                ds.Dispose();
                drr.Dispose();
                cmd.Dispose();
                ocb.Dispose();
                oda.Dispose();
                cnn.Dispose();

                dt = null;
                ds = null;
                drr = null;
                cmd = null;
                ocb = null;
                oda = null;
                cnn = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\t" + ex.Message);
            }
            finally
            {
            }
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            string tbl = "students";
            string sqlStr = string.Concat("SELECT * FROM ", tbl);

            try
            {
                OleDbConnection cnn = new OleDbConnection(cnnStr);
                OleDbDataAdapter oda = new OleDbDataAdapter(sqlStr, cnn);
                OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda);

                cnn.Open();

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                DataRow dr;

                ocb.QuotePrefix = "[";
                ocb.QuoteSuffix = "]";
                oda.Fill(ds, tbl);

                bool found = false;

                dt = ds.Tables[tbl];
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    dr = dt.Rows[i];
                    if (dr["id"].ToString().Trim() == txtIDSearch.Text.Trim())
                    {
                        found = true;

                        dr.Delete();

                        oda.DeleteCommand = ocb.GetDeleteCommand();

                        if (oda.Update(ds, tbl) == 1)
                        {
                            ds.AcceptChanges();
                            MessageBox.Show("Erased");
                        }
                        else
                        {
                            ds.RejectChanges();
                            MessageBox.Show("Rejected");
                        }

                        break;
                    }
                }

                if (!found)
                    MessageBox.Show("Not Found!!");


                cnn.Close();

                dt.Dispose();
                ds.Dispose();
                ocb.Dispose();
                oda.Dispose();
                cnn.Dispose();

                dt = null;
                ds = null;
                ocb = null;
                oda = null;
                cnn = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\t" + ex.Message);
            }
            finally
            {
            }
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            string tbl = "students";
            string sqlStr = string.Concat("SELECT * FROM ", tbl);

            try
            {
                OleDbConnection cnn = new OleDbConnection(cnnStr);

                cnn.Open();

                OleDbCommand cmd = new OleDbCommand(sqlStr, cnn);
                OleDbDataReader drr = cmd.ExecuteReader();

                bool found = false;

                while (drr.Read())
                {
                    if (drr["id"].ToString().Trim() == txtIDSearch.Text.Trim())
                    {
                        id4Edit = drr["id"].ToString().Trim();
                        found = true;

                        txtIDEdit.Text = drr["id"].ToString().Trim();
                        txtNameEdit.Text = drr["studentname"].ToString().Trim();
                        txtMarkEdit.Text = drr["mark"].ToString().Trim();

                        txtIDEdit.SelectAll();
                        txtIDEdit.Focus();
                        break;
                    }
                }

                if (!found)
                    MessageBox.Show("Not Found!!");

                drr.Close();
                cnn.Close();

                drr.Dispose();
                cmd.Dispose();
                cnn.Dispose();

                drr = null;
                cmd = null;
                cnn = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\t" + ex.Message);
            }
            finally
            {
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string tbl = "students";
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

                if (txtIDEdit.Text.Trim() != id4Edit.Trim())
                    while (drr.Read())
                    {
                        if (drr["id"].ToString().Trim() == txtIDEdit.Text.Trim())
                        {
                            found = true;
                            break;
                        }
                    }

                if (!found)
                {
                    dt = ds.Tables[tbl];
                    for (int i = 0; i < dt.Rows.Count; ++i)
                    {
                        dr = dt.Rows[i];
                        if (dr["id"].ToString().Trim() == id4Edit.Trim())
                        {
                            dr.BeginEdit();

                            dr["id"] = txtIDEdit.Text.Trim();
                            dr["studentname"] = txtNameEdit.Text.Trim();
                            dr["mark"] = txtMarkEdit.Text.Trim();

                            dr.EndEdit();

                            oda.UpdateCommand = ocb.GetUpdateCommand();

                            if (oda.Update(ds, tbl) == 1)
                            {
                                ds.AcceptChanges();
                                MessageBox.Show("Updated!!");
                            }
                            else
                            {
                                ds.RejectChanges();
                                MessageBox.Show("Rejected");
                            }

                            break;
                        }
                    }
                }
                else
                    MessageBox.Show("Duplicate Error");


                drr.Close();
                cnn.Close();

                dt.Dispose();
                ds.Dispose();
                drr.Dispose();
                cmd.Dispose();
                ocb.Dispose();
                oda.Dispose();
                cnn.Dispose();

                dt = null;
                ds = null;
                drr = null;
                cmd = null;
                ocb = null;
                oda = null;
                cnn = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\t" + ex.Message);
            }
            finally
            {
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            string tbl = "students";
            string sqlStr = string.Concat("SELECT * FROM ", tbl);

            try
            {
                OleDbConnection cnn = new OleDbConnection(cnnStr);
                OleDbDataAdapter oda = new OleDbDataAdapter(sqlStr, cnn);

                cnn.Open();

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                oda.Fill(ds, tbl);

                dt = ds.Tables[tbl];
                dt.Columns[0].ColumnName = "شماره دانشجوئي";
                dt.Columns[1].ColumnName = "نام";
                dt.Columns[2].ColumnName = "نمره";
                
                dtMaster = dt;

                dgvStudents.DataSource = dt;

                dgvStudents.Columns[0].Width = 150;
                dgvStudents.Columns[1].Width = 150;
                dgvStudents.Columns[2].Width = 150;


                cnn.Close();

                dt.Dispose();
                ds.Dispose();
                oda.Dispose();
                cnn.Dispose();

                dt = null;
                ds = null;
                oda = null;
                cnn = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\t" + ex.Message);
            }
            finally
            {
            }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string tbl = "students";
            string sqlStr = string.Concat("SELECT * FROM ", tbl);

            try
            {
                OleDbConnection cnn = new OleDbConnection(cnnStr);

                cnn.Open();

                OleDbCommand cmd = new OleDbCommand(sqlStr, cnn);
                OleDbDataReader drr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                DataRow dr;

                dt.Columns.Add("شماره دانشجوئي", Type.GetType("System.String"));
                dt.Columns.Add("نام", Type.GetType("System.String"));
                dt.Columns.Add("نمره", Type.GetType("System.Byte"));

                bool found = false;

                while (drr.Read())
                {
                    if (drr["studentname"].ToString().Trim().ToLower().Contains(txtNameSearch.Text.Trim().ToLower()))
                    {
                        found = true;

                        dr = dt.NewRow();
                        dr[0] = drr["id"].ToString().Trim();
                        dr[1] = drr["studentname"].ToString().Trim();
                        dr[2] = drr["mark"].ToString().Trim();
                        dt.Rows.Add(dr);
                    }
                }

                if (found)
                {
                    dtMaster = dt;
                    dgvStudents.DataSource = dt;

                    dgvStudents.Columns[0].Width = 150;
                    dgvStudents.Columns[1].Width = 150;
                    dgvStudents.Columns[2].Width = 150;
                }
                else
                    MessageBox.Show("Not Found!!");

                cnn.Close();
                drr.Close();

                cmd.Dispose();
                drr.Dispose();
                cnn.Dispose();

                cmd = null;
                drr = null;
                cnn = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\t" + ex.Message);
            }
            finally
            {
                tbl = null;
                sqlStr = null;
            }
        }

        private void txtSearchRealTime_TextChanged(object sender, EventArgs e)
        {
            string phrase = txtSearchRealTime.Text.Trim().ToLower();
            if (phrase != string.Empty)
            {
                DataTable dt = dtMaster.Clone();
                for (int i = 0; i < dtMaster.Rows.Count; ++i)
                {
                    // dr = dt.Rows[i];
                    //if (dr[1].ToString().Trim().ToLower())
                    if (dtMaster.Rows[i][1].ToString().Trim().ToLower().Contains(phrase))
                    {
                        object[] row = dtMaster.Rows[i].ItemArray;
                        dt.Rows.Add(row);
                    }
                }
                dgvStudents.DataSource = dt;
            }
            else
                dgvStudents.DataSource = dtMaster;
        }

        private void dgvStudents_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                id4Edit = dgvStudents.CurrentRow.Cells[0].Value.ToString().Trim();
                txtIDSearch.Text = id4Edit.Trim();
                txtIDEdit.Text = id4Edit.Trim();
                txtNameEdit.Text = dgvStudents.CurrentRow.Cells[1].Value.ToString().Trim();
                txtMarkEdit.Text = dgvStudents.CurrentRow.Cells[2].Value.ToString().Trim();
            }
            catch
            {
            }
            finally
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports frm = new Reports();
            frm.ShowDialog(this);
        }

        private void chkNewRow_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;

            dgvStudents.AllowUserToAddRows = chk.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*frmBackup frm = new frmBackup();
            frm.ShowDialog(this);*/
        }

    }
}

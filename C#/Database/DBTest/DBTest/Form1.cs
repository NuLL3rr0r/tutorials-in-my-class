using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//
using System.IO;
using System.Data.OleDb;

namespace DBTest
{
    public partial class Form1 : Form
    {
        string path = string.Empty;
        private string dBpw = "123";
        private string fileDb = "std.mdb";
        private string cnnStr;

        private string id4Edit = string.Empty;

        private DataTable dtMaster = new DataTable();

        public Form1()
        {
            path = Environment.CurrentDirectory;
            path += path.EndsWith(Path.DirectorySeparatorChar.ToString()) ? string.Empty : Path.DirectorySeparatorChar.ToString();
            fileDb = string.Concat(path, fileDb);
            cnnStr = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Database Password={1};", fileDb, dBpw);

            InitializeComponent();

            dgvStudents.RightToLeft = RightToLeft.Yes;
            dgvStudents.ReadOnly = true;
            dgvStudents.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
                    if (drr["id"].ToString().Trim() == txtAddID.Text.Trim())
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    dt = ds.Tables[tbl];
                    dr = dt.NewRow();
                    //dr[0] = txtAddID.Text.Trim();
                    dr["id"] = txtAddID.Text.Trim();
                    dr["fullname"] = txtAddName.Text.Trim();
                    dr["no"] = txtAddNo.Text.Trim();
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
                MessageBox.Show("Error:\n\t" + ex.Message);
            }
            finally
            {
                tbl = null;
                sqlStr = null;
            }
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            string tbl = "students";
            string sqlStr = "SELECT * FROM " + tbl;

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
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dr = dt.Rows[i];
                    if (dr["id"].ToString().Trim() == txtSearchID.Text.Trim())
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
                    MessageBox.Show("Not Found");

                cnn.Close();

                ds.Dispose();
                ocb.Dispose();
                oda.Dispose();
                cnn.Dispose();
                dt.Dispose();

                ds = null;
                ocb = null;
                oda = null;
                dr = null;
                dt = null;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tbl = "students";
            string sqlStr = "SELECT * FROM " + tbl;

            try
            {
                OleDbConnection cnn = new OleDbConnection(cnnStr);

                cnn.Open();

                OleDbCommand cmd = new OleDbCommand(sqlStr, cnn);
                OleDbDataReader drr = cmd.ExecuteReader();

                bool found = false;

                while (drr.Read())
                {
                    if (drr["id"].ToString().Trim() == txtSearchID.Text.Trim())
                    {
                        id4Edit = drr["id"].ToString().Trim();
                        found = true;

                        txtEditID.Text = drr["id"].ToString().Trim();
                        txtEditName.Text = drr["fullname"].ToString().Trim();
                        txtEditNo.Text = drr["no"].ToString().Trim();

                        txtEditID.SelectAll();
                        txtEditID.Focus();
                        break;
                    }
                }

                if (!found)
                    MessageBox.Show("Not Found");

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string tbl = "students";
            string sqlStr = "SELECT * FROM " + tbl;

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

                if (txtEditID.Text.Trim() != id4Edit.Trim())
                    while (drr.Read())
                    {
                        if (drr["id"].ToString().Trim() == txtEditID.Text.Trim())
                        {
                            found = true;
                            break;
                        }
                    }

                if (!found)
                {
                    dt = ds.Tables[tbl];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dr = dt.Rows[i];
                        if (dr["id"].ToString().Trim() == id4Edit.Trim())
                        {
                            dr.BeginEdit();

                            dr["id"] = txtEditID.Text.Trim();
                            dr["fullname"] = txtEditName.Text.Trim();
                            dr["no"] = txtEditNo.Text.Trim();

                            dr.EndEdit();

                            oda.UpdateCommand = ocb.GetUpdateCommand();

                            if (oda.Update(ds, tbl) == 1)
                            {
                                ds.AcceptChanges();
                                MessageBox.Show("Updated");
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
                MessageBox.Show("Error:\n\t" + ex.Message);
            }
            finally
            {
                tbl = null;
                sqlStr = null;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string tbl = "students";
            string sqlStr = "SELECT * FROM " + tbl;

            try
            {
                OleDbConnection cnn = new OleDbConnection(cnnStr);
                OleDbDataAdapter oda = new OleDbDataAdapter(sqlStr, cnn);

                cnn.Open();

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                oda.Fill(ds, tbl);

                dt = ds.Tables[tbl];
                //dt.Columns["id"].ColumnName = "شماره دانشجوئي";
                dt.Columns[0].ColumnName = "شماره دانشجوئي";
                dt.Columns[1].ColumnName = "نام";
                dt.Columns[2].ColumnName = "نمره";

                dtMaster = dt;
                dgvStudents.DataSource = dt;

                dgvStudents.Columns[0].Width = 150;
                dgvStudents.Columns[1].Width = 150;
                dgvStudents.Columns[2].Width = 150;

                cnn.Close();

                ds.Dispose();
                oda.Dispose();
                cnn.Dispose();
                dt.Dispose();

                ds = null;
                oda = null;
                dt = null;
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

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string tbl = "students";
            string sqlStr = "SELECT * FROM " + tbl;

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
                dt.Columns.Add("نمره", Type.GetType("System.String"));
                //dt.Columns.Add("نمره", Type.GetType("System.Int32"));

                bool found = false;

                while (drr.Read())
                {
                    if (drr["fullname"].ToString().Trim().ToLower().Contains(txtSearchName.Text.ToLower().Trim()))
                    {
                        found = true;

                        dr = dt.NewRow();
                        dr[0] = drr["id"].ToString().Trim();
                        dr[1] = drr["fullname"].ToString().Trim();
                        dr[2] = drr["no"].ToString().Trim();
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
                    MessageBox.Show("Not Found");

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

        private void dgvStudents_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                id4Edit = dgvStudents.CurrentRow.Cells[0].Value.ToString().Trim();
                txtSearchID.Text = id4Edit.Trim();
                txtEditID.Text = id4Edit.Trim();
                txtEditName.Text = dgvStudents.CurrentRow.Cells[1].Value.ToString().Trim();
                txtEditNo.Text = dgvStudents.CurrentRow.Cells[2].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }
        }

        private void txtSearchRealTime_TextChanged(object sender, EventArgs e)
        {
            string phrase = txtSearchRealTime.Text.Trim().ToLower();
            if (phrase != string.Empty)
            {
                DataTable dt = dtMaster.Clone();
                for (int i = 0; i < dtMaster.Rows.Count; i++)
                {
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
    }
}

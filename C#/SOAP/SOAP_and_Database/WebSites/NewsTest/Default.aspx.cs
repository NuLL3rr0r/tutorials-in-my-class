using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write(GetLatestNews("news"));
    }

    private string GetLatestNews(string tbl)
    {
        tbl = tbl.Trim();

        string sqlStr = "SELECT * FROM " + tbl;

        string news = string.Empty;

        try
        {
            OleDbConnection cnn = new OleDbConnection(Base.cnnStr);
            OleDbDataAdapter oda = new OleDbDataAdapter(sqlStr, cnn);
            cnn.Open();

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dr;

            oda.Fill(ds, tbl);
            dt = ds.Tables[tbl];

            string temp = "<a href=\"news.aspx?id={0}\">{1}</a><br />";

            string id = string.Empty;
            string header = string.Empty;

            for (int i = dt.Rows.Count - 1; i > dt.Rows.Count - 4; --i)
            {
                dr = dt.Rows[i];

                id = dr["id"].ToString();
                header = dr["header"].ToString();

                news += string.Format(temp, id, header);
            }

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
            news = ex.Message;
        }
        finally
        {
            tbl = null;
            sqlStr = null;
        }

        return news;
    }
}
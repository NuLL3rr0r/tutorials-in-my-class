using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.OleDb;

public partial class newsbody : System.Web.UI.Page
{
    private string newsId = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        newsId = Request.QueryString["id"];

        Response.Write(GetNewsBody("news"));
    }

    private string GetNewsBody(string tbl)
    {
        int nId;
        if (!int.TryParse(newsId, out nId))
        {
            return string.Empty;
        }

        --nId;

        tbl = tbl.Trim();

        string sqlStr = "SELECT * FROM " + tbl;

        string body = string.Empty;

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

            dr = dt.Rows[nId];
            body = dr["body"].ToString();

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
            body = ex.Message;
        }
        finally
        {
            tbl = null;
            sqlStr = null;
        }

        return body;
    }

}
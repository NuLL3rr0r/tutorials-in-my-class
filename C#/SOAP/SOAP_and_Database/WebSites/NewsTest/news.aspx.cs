using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.OleDb;

public partial class news : System.Web.UI.Page
{
    private string newsId = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        newsId = Request.QueryString["id"];

        Response.Write(
                        "<html xmlns=\"http://www.w3.org/1999/xhtml\">" +
                        "<head>" +
                        "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=iso-8859-1\" />" +
                        "<title>Untitled Document</title>" +
                        "<script type=\"text/javascript\" src=\"ajax.js\"></script>" +
                        "</head>" +
                        "<body>"
                      );
        Response.Write(GetNews("news"));
        Response.Write(
                        "</body>" +
                        "</html>"
                      );
    }

    private string GetNews(string tbl)
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

            //string temp = "<a href=\"news.aspx?id={0}\">{1}</a><div style=\"border: 1px solid #000;\">{2}</div><br />";
            string temp = "<a href=\"javascript:;\" onclick=\"TalkingServer('newsbody.aspx?id={0}', 'dvNews{0}');\">{1}</a><div style=\"border: 1px solid #000;\" id=\"dvNews{0}\">{2}</div><br />";

            string id = string.Empty;
            string header = string.Empty;
            string body = string.Empty;

            for (int i = dt.Rows.Count - 1; i > -1; --i)
            {
                dr = dt.Rows[i];

                id = dr["id"].ToString();
                header = dr["header"].ToString();

                if (newsId != (i + 1).ToString())
                {
                    body = string.Empty;
                }
                else
                {
                    body = dr["body"].ToString();
                }

                news += string.Format(temp, id, header, body);
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
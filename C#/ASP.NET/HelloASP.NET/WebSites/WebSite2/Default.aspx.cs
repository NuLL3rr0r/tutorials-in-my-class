using System;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.IO;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string path = Server.MapPath("~");

            if (!path.EndsWith("\\"))
                path += "\\";

            path += "UserFiles\\";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            if (FileUpload1.HasFile)
            {
                String fileName = FileUpload1.FileName;

                path += fileName;
                FileUpload1.SaveAs(path);

                Response.Write("Your file was saved as " + fileName);
            }
            else
            {
                Response.Write("You did not specify a file to upload.");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}

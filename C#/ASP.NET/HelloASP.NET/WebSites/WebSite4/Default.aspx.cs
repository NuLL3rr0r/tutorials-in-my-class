using System;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;
using System.Net.Mail;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string to = "testclasscskr@gmail.com";
        string from = "\"" + txtName.Text + "\" <" + txtMail.Text +">";
        string subject = "user of hmbadi.net / " + txtSubject.Text;

        StringBuilder body = new StringBuilder();

        body.Append("<br /><br /><br /><h3>Detail</h3>");
        body.Append("Name: {0}<br/>");
        body.Append("Mail: {1}<br/>");
        body.Append("URL: {2}<br/>");
        body.Append("<br /><br/>");

        body.Append("<h3>Subject</h3>{3}");
        body.Append("<h3>Body</h3>{4}");

        string msgBody = String.Format(body.ToString(), txtName.Text, txtMail.Text, txtURL.Text, txtSubject.Text, txtBody.Text);
        msgBody = msgBody.Replace("\n", "<br/>");

        try
        {
            using (MailMessage msg = new MailMessage(from, to, subject, msgBody))
            {
                msg.BodyEncoding = Encoding.UTF8;
                msg.SubjectEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.High;

                //fort gmail
/*                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential("yourid@gmail.com", "pw");
                smtp.EnableSsl = true;*/


                SmtpClient smtp = new SmtpClient("webmail.hmabadi.net", 25);
                smtp.Credentials = new System.Net.NetworkCredential("info@hmabadi.net", "123456");
                smtp.Send(msg);
            }

            Response.Write("Thank you!");
        }
        catch (FormatException ex)
        {
            Response.Write("Format Error: " + ex.Message);
            // TODO: some statements
        }
        catch (SmtpException ex)
        {
            Response.Write("SMTP Error: " + ex.Message);
            // TODO: some statements
        }
        catch (Exception ex)
        {
            Response.Write("Error: " + ex.Message);
            // TODO: some statements
        }
        finally
        {
            // TODO: some statements
        }

    }
}

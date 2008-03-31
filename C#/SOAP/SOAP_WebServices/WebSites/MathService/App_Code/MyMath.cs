using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class MyMath : System.Web.Services.WebService
{
    public MyMath()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public long Add(int n1, int n2)
    {
        return n1 + n2;
    }

    [WebMethod]
    public long Dec(int n1, int n2)
    {
        return n1 - n2;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace app.WebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client s = new ServiceReference1.Service1Client();
            Response.Write(s.GetData(2));
           // Response.Write(s.GetDataUsingDataContract());
            Response.End();

            ServiceReference2.CodeServiceClient c = new ServiceReference2.CodeServiceClient();
            Response.Write(c.InserCodeService("sss"));
            Response.End();
        }
    }
}
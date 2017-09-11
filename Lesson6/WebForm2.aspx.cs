using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("第二个页面的内容");

            Response.Write(" <img src='img/a.png' />");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Execute("WebForm3.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm3.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
          
              Response.Redirect("WebForm3.aspx");
        }
    }
}
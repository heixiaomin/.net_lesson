using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Server核心对象

            Response.Write("服务器名称："+Server.MachineName);
            Response.Write("<br/>");


            Response.Write("图片的url地址：" + Image1.ImageUrl);

            Response.Write("<br/>");

            string urlencode = Server.UrlEncode(Image1.ImageUrl);
            Response.Write("图片的url地址编码显示：" + urlencode);
            Response.Write("<br/>");
            Response.Write("图片的url地址编码显示：" + Server.UrlDecode(urlencode));
            Response.Write("<br/>");

            Response.Write("<h1>sdfsdfds</h1>");

            //使用server对象的html编码
            Response.Write("使用server对象的html编码：" + Server.HtmlEncode("<h1>html编码</h1>"));
            Response.Write("使用server对象的html解码：" + Server.HtmlDecode("<h1>html解码<h1>"));

            Response.Write("<br/>");
            //把相对路径转化成绝对路径

           string cpath  =  Server.MapPath("~");
           Response.Write("绝对位置："+cpath);




        }
    }
}
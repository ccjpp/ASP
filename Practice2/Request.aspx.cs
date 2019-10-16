using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Request : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        throw new Exception("该页面发生异常");
        //Response.Write(Request.Url);
        //Response.Write("<br>");
        //Response.Write(Request.UserHostAddress);
        //Response.Write("<br>");
        //Response.Write(Request.PhysicalApplicationPath);
        //Response.Write("<br>");
        //Response.Write(Request.CurrentExecutionFilePath);
        //Response.Write("<br>");
        //Response.Write(Request.PhysicalPath);
    }
}
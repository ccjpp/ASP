using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.ErrorPage = "HTMLErrorPage.htm";
        int x = 5;
        int y = 0;
        int z = 0;

        z = x / y;

        //try
        //{
        //    z = x / y;
        //    Response.Write(x.ToString() + "除以" + y.ToString + "=" + z.ToString() + "<br/>");

        //}
        //catch (Exception ex)
        //{
        //    Response.Write(ex.Message);
        //}
        //finally
        //{
        //    Response.Write("再见");
        //}


    }

    //protected void Page_Error(object sender, EventArgs e)
    //{
    //    //获取最近的异常
    //    Exception ex = Server.GetLastError();
    //    Response.Write("页面发生错误,错误原因:" + ex.Message + "<br/>");
    //    Server.ClearError();
    //}
}
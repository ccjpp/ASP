using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ErrorProcess : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.ErrorPage = "Error.htm";
        throw new Exception("该页面发生异常");
    }
    //protected void Page_Error(object sender, EventArgs e)
    //{
    //    Exception objErr = Server.GetLastError();
    //    Response.Write("错误" + objErr.Message);
    //    Server.ClearError();
    //}

}
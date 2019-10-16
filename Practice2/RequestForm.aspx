<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RequestForm.aspx.cs" Inherits="RequestForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    账号:<input name="TxtName" type="text" />
    <br>
    密码:<input name="TxtPwd" type="password" />
    <br>
     <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>

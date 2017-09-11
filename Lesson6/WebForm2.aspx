<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Lesson6.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
         我是第二个html页面

        <asp:Button ID="Button1" runat="server" Text="Execute跳转" OnClick="Button1_Click" />

        <asp:Button ID="Button2" runat="server" Text="Transfer跳转" OnClick="Button2_Click" />

        <asp:Button ID="Button3" runat="server" Text="Redirect跳转" OnClick="Button3_Click" />

    </div>
    </form>
</body>
</html>

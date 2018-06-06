<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebFormMVC.WebForm1" %>
<%@ Register Src="~/UserControl1.ascx" TagName="uc1" TagPrefix="me" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form runat="server">
        Hello World !
        <div>
            <me:uc1 runat="server"/>
        </div>
        <div>
            下面是一个 GridView  <br />
            <asp:GridView ID="gridView" runat="server" AlternatingRowStyle-BackColor="LightBlue" BorderStyle="Dotted">

            </asp:GridView>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="navigation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>webform 1</h1>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="webform2.aspx">go to webform 2</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="https://www.pmu.edu.sa">outside url</asp:HyperLink>
        </div>
    </form>
</body>
</html>

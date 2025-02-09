<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="viewState.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
            <asp:Button runat="server" Text="Click Me" OnClick="Button1_Click" ID="Button1"></asp:Button>
        </div>
    </form>
</body>
</html>

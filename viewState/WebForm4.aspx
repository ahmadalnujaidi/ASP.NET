<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="viewState.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div>
            <p>ASP.NET Server Control:</p>
            <asp:TextBox runat="server" ID="TextBox4"></asp:TextBox>
        </div>
        <div>
            <p>HTML Control:</p>
            <input id="Text1" type="text" runat="server"/> 
            add runat="server" to make it like the .net Textbox where it stores it in ViewState
        </div>
            <br />
            <asp:Button runat="server" Text="Button"></asp:Button>
            </div>
    </form>
</body>
</html>

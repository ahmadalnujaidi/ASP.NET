<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="btnLinkbtnImagebtn.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Button runat="server" Text="Submit" OnClick="Unnamed1_Click"></asp:Button><asp:LinkButton runat="server" OnClick="Unnamed2_Click">LinkButton</asp:LinkButton><asp:ImageButton runat="server" ImageUrl="./images/gig 3.png" Height="200px"></asp:ImageButton>
        </div>
    </form>
</body>
</html>

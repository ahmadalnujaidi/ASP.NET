<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="customValidator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>enter a positive even number</b>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="not even number" ControlToValidate="TextBox1" OnServerValidate="serverVal" ValidateEmptyText="True"></asp:CustomValidator>
        </div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
</body>
</html>

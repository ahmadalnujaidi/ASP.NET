<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="compareValidator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>password</b>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <b>confirm password</b>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="passwords must match" ControlToValidate="TextBox2" ControlToCompare="TextBox1" Operator="Equal" Type="String" ></asp:CompareValidator>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
    </form>

</body>
</html>

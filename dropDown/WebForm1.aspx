<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="dropDown.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:DropDownList runat="server" OnSelectedIndexChanged="Unnamed1_SelectedIndexChanged" ID="dropDownList1"></asp:DropDownList><asp:Button runat="server" Text="Button"></asp:Button>
        </div>
    </form>
</body>
</html>

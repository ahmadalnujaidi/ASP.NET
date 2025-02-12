<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ControlsExc2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <tr>
                    <th colspan="2">Registration Form</th>
                </tr>
                <tr>
                    <td><asp:Label ID="Label1" runat="server" Text="Title"></asp:Label></td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Mr.</asp:ListItem>
                            <asp:ListItem>Mrs.</asp:ListItem>
                            <asp:ListItem>Ms.</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Name"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="Gender"/>
                        <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="Gender"/>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Student" TextAlign="Left"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /></td>
                    <td><asp:LinkButton ID="LinkButton1" runat="server">Clear</asp:LinkButton></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

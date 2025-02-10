<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RadioButton.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset width="250px">
                <legend><b>Gender:</b></legend>
                <asp:RadioButton runat="server" Text="Male" GroupName="GenderGroup"></asp:RadioButton>
                <asp:RadioButton runat="server" Text="Female" GroupName="GenderGroup"></asp:RadioButton>
                <asp:RadioButton runat="server" Text="Unknown" GroupName="GenderGroup"></asp:RadioButton>
            </fieldset>
         
        </div>
    </form>
</body>
</html>

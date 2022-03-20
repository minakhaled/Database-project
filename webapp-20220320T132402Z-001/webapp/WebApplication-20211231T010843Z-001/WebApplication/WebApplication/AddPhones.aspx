<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddPhones.aspx.cs" Inherits="WebApplication.AddPhones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Phone Number<br />
            <asp:TextBox ID="ph" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button3" runat="server" Text="Add" OnClick="Button3_Click" />
            <br />
            <br />
            Do you want to add another Phone Number ?<br />
            <asp:Button ID="Button1" runat="server" Text="Yes" OnClick="Button1_Click" />
            &nbsp;
            <asp:Button ID="Button2" runat="server" Text="No" OnClick="Button2_Click" />
            <br />
        </div>
    </form>
</body>
</html>

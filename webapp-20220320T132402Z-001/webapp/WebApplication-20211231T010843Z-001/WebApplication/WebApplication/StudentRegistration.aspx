﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="WebApplication.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Register Here<br />
            First Name<br />
            <asp:TextBox ID="firstname" runat="server"></asp:TextBox>
            <br />
            Last Name<br />
            <asp:TextBox ID="lastname" runat="server"></asp:TextBox>
            <br />
            Password<br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            Faculty<br />
            <asp:TextBox ID="faculty" runat="server"></asp:TextBox>
            <br />
            Are you a GUCian?<br />
            <asp:CheckBox ID="Yes" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
            Yes<asp:CheckBox ID="No" runat="server" OnCheckedChanged="No_CheckedChanged" />
            No<br />
            Email<br />
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <br />
            Address<br />
            <asp:TextBox ID="address" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
            <br />
        </div>
    </form>
</body>
</html>

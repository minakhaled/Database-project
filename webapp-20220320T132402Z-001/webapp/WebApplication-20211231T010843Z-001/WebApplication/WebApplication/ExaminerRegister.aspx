<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExaminerRegister.aspx.cs" Inherits="WebApplication.ExaminerRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Register Here<br />
            <br />
            Name<br />
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />
            Naitonality?<br />
            <asp:CheckBox ID="National" runat="server" OnCheckedChanged="Yes_CheckedChanged" />
            &nbsp;National<asp:CheckBox ID="International" runat="server" OnCheckedChanged="No_CheckedChanged" />
            International<br />
            Password<br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            Field Of Work<br />
            <asp:TextBox ID="field" runat="server"></asp:TextBox>
            <br />
            Email<br />
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <br />
            <br />
           
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
            <br />
        </div>
    </form>
</body>
</html>

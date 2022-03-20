<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Login<br />
            Email<br />
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <br />
            Password<br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="login" Text="login" />
            <br />
            <br />
            If you dont have an account<br />
&nbsp;<asp:Button ID="Button2" runat="server" Text="Resgiter Here as a Student!" OnClick="Register" />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Register Here as a Supervisor!" OnClick="Register2" />
            
            <br />
            <asp:Button ID="Button4" runat="server" Text="Register Here as an Examiner!" OnClick="Button4_Click" />
            
        </div>
    </form>
</body>
</html>

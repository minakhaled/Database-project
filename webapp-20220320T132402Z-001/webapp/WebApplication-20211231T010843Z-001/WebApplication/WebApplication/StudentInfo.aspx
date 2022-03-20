<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentInfo.aspx.cs" Inherits="WebApplication.StudentInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="My Thesis" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Courses" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>

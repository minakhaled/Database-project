<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhoneEnquiry.aspx.cs" Inherits="WebApplication.PhoneEnquiry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Do you want to add telephone numbers ?<br />
            <asp:Button ID="Button1" runat="server" Text="Yes" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="No" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>

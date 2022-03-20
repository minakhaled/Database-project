<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Courses.aspx.cs" Inherits="WebApplication.Courses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="CoursesTB" runat="server" AutoGenerateColumns="false" AllowPaging="true">
        <Columns>
            <asp:BoundField ItemStyle-Width="50px" DataField="cid" HeaderText="CourseID" />
            <asp:BoundField ItemStyle-Width="50px" DataField="code" HeaderText="CourseCode" />
            <asp:BoundField ItemStyle-Width="50px" DataField="grade" HeaderText="Grade" />
           
        </Columns>
    </asp:GridView>
        </div>
    </form>
</body>
</html>

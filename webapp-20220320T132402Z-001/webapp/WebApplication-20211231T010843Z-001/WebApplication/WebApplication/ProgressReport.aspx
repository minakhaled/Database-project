<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProgressReport.aspx.cs" Inherits="WebApplication.ProgressReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            If you want to add a progress report please fill in the following:<br />
    
            
            <br />
            (1)Progress Report Date (Year/Month/Day)<br />
            <asp:TextBox ID="progressrepdate" runat="server"></asp:TextBox>
            <br />
            <br />
            (2)Progress Report Number<br />
            <asp:TextBox ID="progressrepno" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            <br />
            <br />
            If you want to fill your progess report please fill in the following:<br />
            <asp:Label ID="noLabel" runat="server" Text="(1)Progress Report Number"></asp:Label>
        </div>
        <p>
            <asp:TextBox ID="notext" runat="server" style="margin-bottom: 0px" Width="40px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="stateLabel" runat="server" Text="(2)State"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="statetext" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="descriptLabel" runat="server" Text="(3)Description(200 character limit)"></asp:Label>
        </p>
        <asp:TextBox ID="descripttext" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="submitbutton" runat="server" Text="Submit" OnClick="submitbutton_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            If you want to add a publication please fill in the following:</p>
        <p>
            (1)Title</p>
        <p>
            <asp:TextBox ID="title" runat="server"></asp:TextBox>
        </p>
        <p>
            (2)Publication Date (Year/Month/Day)</p>
        <p>
            <asp:TextBox ID="pubdate" runat="server"></asp:TextBox>
        </p>
        <p>
            (3)Host</p>
        <p>
            <asp:TextBox ID="host" runat="server"></asp:TextBox>
        </p>
        <p>
            (4)Place</p>
        <p>
            <asp:TextBox ID="place" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Add" OnClick="Button2_Click" />
        </p>
    </form>
</body>
</html>

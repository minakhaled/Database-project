<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Supervisor.aspx.cs" Inherits="WebApplication.Supervisor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <asp:GridView ID="StudentSupervised" runat="server" AutoGenerateColumns="false" AllowPaging="true">
        <Columns>
            <asp:BoundField ItemStyle-Width="50px" DataField="serial_no" HeaderText="ThesisSerialNumber" />
            <asp:BoundField ItemStyle-Width="50px" DataField="id" HeaderText="StudentID" />
            <asp:BoundField ItemStyle-Width="50px" DataField="firstName" HeaderText="FirstName" />
            <asp:BoundField ItemStyle-Width="50px" DataField="lastName" HeaderText="LastName" />
            <asp:BoundField ItemStyle-Width="50px" DataField="years" HeaderText="YearsSpent"  />
        </Columns>
    </asp:GridView>
            <br />
            Type the student id to view his publication!<br />
            <asp:TextBox ID="studentid" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="View Publication" OnClick="Button1_Click" />
            <br />
    <br />
    <asp:GridView ID="StudentPublication" runat="server" AutoGenerateColumns="false" AllowPaging="true">
    <Columns>
 <asp:BoundField ItemStyle-Width="50px" DataField="id" HeaderText="StudentID" />
            <asp:BoundField ItemStyle-Width="50px" DataField="title" HeaderText="Title" />
            <asp:BoundField ItemStyle-Width="50px" DataField="dateOfPublication" HeaderText="DateOfPublication" />
            <asp:BoundField ItemStyle-Width="50px" DataField="place" HeaderText="Place" />
            <asp:BoundField ItemStyle-Width="50px" DataField="accepted" HeaderText="Acceptance"  />
            <asp:BoundField ItemStyle-Width="50px" DataField="host" HeaderText="Host"  />
        </Columns>
        </asp:GridView>  
            <br />
            To Add a defense for a thesis please insert the following:
            <br />
            (1)Thesis Serial Number
            <asp:TextBox ID="thesisserial" runat="server"></asp:TextBox>
           <br />
            (2)Defense Date
            (Year/Month/Day)
            <asp:TextBox ID="defensedate" runat="server"></asp:TextBox>
            <br />
            (3)Defense Location
            <asp:TextBox ID="defenselocation" runat="server"></asp:TextBox>
            <br />
            <br />
            Please Specify if the student is Gucian or Non-Gucian by clicking the corresponding button
            <br />
            <asp:Button ID="Button2" runat="server" Text="Gucian" OnClick="Button2_Click" />

        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Non-Gucian" OnClick="Button3_Click" />


            <br />
            <br />
            To Add an Examiner to a defense please insert the following:<br />
            (1)Thesis Serial Number <asp:TextBox ID="thesis2" runat="server"></asp:TextBox>
            <br />
            (2)Defense Date (Year/Month/Day) <asp:TextBox ID="defensedate2" runat="server"></asp:TextBox>
            <br />
            (3)Examiner Name <asp:TextBox ID="examinername" runat="server"></asp:TextBox>
            <br />
            (4)Password <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            (5)Field OF Work <asp:TextBox ID="fieldofwork" runat="server"></asp:TextBox>
            <br />
            (6)National/International <asp:TextBox ID="nationality" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Add Examiner" OnClick="Button4_Click" />
            <br />
            <br />
            To Evaluate a progress report please insert the following:<br />
            (1)Thesis Serial Number
            <asp:TextBox ID="thesis3" runat="server"></asp:TextBox>
            <br />
            (2)Progress Report Number
            <asp:TextBox ID="progress" runat="server"></asp:TextBox>
            <br />
            (3)Evaluation (From 0 to 3)
            <asp:TextBox ID="Eval" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" Text="Evaluate" OnClick="Button5_Click" />
            <br />
            <br />
            To cancel a thesis please insert the following:<br />
            (1)Thesis Serial Number
            <asp:TextBox ID="thesiscancel" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button6" runat="server" Text="Cancel Thesis" OnClick="Button6_Click" />
            <br />
        </div>
</form>
</body>
</html>

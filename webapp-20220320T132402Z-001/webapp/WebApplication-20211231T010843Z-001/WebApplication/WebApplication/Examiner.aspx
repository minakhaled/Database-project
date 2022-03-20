<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Examiner.aspx.cs" Inherits="WebApplication.Examiner" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Edit Personal Information:<br />
            (1)Name
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />
            (2)Field of work
            <asp:TextBox ID="field" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Edit" OnClick="Button1_Click" />
            <br />       
            <asp:Button ID="Button2" runat="server" Text="List all Theses i have a defense for" OnClick="Button2_Click" />

            <div>
                <asp:GridView ID="theses" runat="server" AutoGenerateColumns="false" AllowPaging="true">
        <Columns>
            <asp:BoundField ItemStyle-Width="50px" DataField="serialNumber" HeaderText="ThesisSerialNumber" />
            <asp:BoundField ItemStyle-Width="50px" DataField="title" HeaderText="ThesisTitle" />
            <asp:BoundField ItemStyle-Width="50px" DataField="name" HeaderText="SupervisorName" />
            <asp:BoundField ItemStyle-Width="50px" DataField="firstName" HeaderText="StudentFirstName" />
            <asp:BoundField ItemStyle-Width="50px" DataField="lastname" HeaderText="StudentLastName" />
            <asp:BoundField ItemStyle-Width="50px" DataField="date" HeaderText="DefenseDate" />

        </Columns>
    </asp:GridView>
            </div>
            <br />
            To add a comment for a
            defense please fill in the following:<br />
            (1)Thesis Serial Number
            <asp:TextBox ID="th" runat="server"></asp:TextBox>
            <br />
            (2)Defense Date
            (Year/Month/Day)
            <asp:TextBox ID="dd" runat="server"></asp:TextBox>
            <br />
            (3)Comment(s)
            <asp:TextBox ID="c" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Add" OnClick="Button3_Click" />
            <br />
            <br />
            To add a grade for a defense please fill in the following:<br />
            (1)Thesis Serial Number
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            (2)Defense Date
            (Year/Month/Day)
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            (3)Grade
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Add" OnClick="Button4_Click" />
            <br />
            <br />

             Enter keyword for thesis search:
            <asp:TextBox ID="keyword" runat="server"></asp:TextBox>
            <asp:Button ID="searchbutton" runat="server" OnClick="Button5_Click" Text="Search" />
            <br />
            <br />
                        <br />

            <asp:GridView ID="searchresult" runat="server" AutoGenerateColumns="false" AllowPaging="true">
        <Columns>
            <asp:BoundField ItemStyle-Width="50px" DataField="serialNumber" HeaderText="ThesisSerialNumber" />
            <asp:BoundField ItemStyle-Width="50px" DataField="field" HeaderText="Field" />
            <asp:BoundField ItemStyle-Width="50px" DataField="type" HeaderText="NumberOfExtensionYears"  />
            <asp:BoundField ItemStyle-Width="50px" DataField="title" HeaderText="Title" />
            <asp:BoundField ItemStyle-Width="50px" DataField="startDate" HeaderText="StartDate" />
            <asp:BoundField ItemStyle-Width="50px" DataField="endDate" HeaderText="EndDate"  />
            <asp:BoundField ItemStyle-Width="50px" DataField="defenseDate" HeaderText="DefenseDate"  />
            <asp:BoundField ItemStyle-Width="50px" DataField="years" HeaderText="YearsSpent"  />
            <asp:BoundField ItemStyle-Width="50px" DataField="grade" HeaderText="Grade"  />
            <asp:BoundField ItemStyle-Width="50px" DataField="payment_id" HeaderText="NumberOfExtensionYears"  />
            <asp:BoundField ItemStyle-Width="50px" DataField="noOfExtensions" HeaderText="NumberOfExtensionYears"  />


        </Columns>
    </asp:GridView>
        </div>
    </form>
</body>
</html>

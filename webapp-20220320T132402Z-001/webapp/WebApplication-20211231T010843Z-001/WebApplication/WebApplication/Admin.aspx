<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebApplication.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:GridView ID="supdisplay" runat="server" AutoGenerateColumns="false" AllowPaging="true">
        <Columns>
            <asp:BoundField ItemStyle-Width="50px" DataField="id" HeaderText="SupervisorID" />
            <asp:BoundField ItemStyle-Width="50px" DataField="email" HeaderText="Email" />
            <asp:BoundField ItemStyle-Width="50px" DataField="password" HeaderText="Password" />
            <asp:BoundField ItemStyle-Width="50px" DataField="name" HeaderText="Name" />
            <asp:BoundField ItemStyle-Width="50px" DataField="faculty" HeaderText="Faculty"  />


        </Columns>
    </asp:GridView>
        </div>
        <div>
               <asp:GridView ID="thesisdisplay" runat="server" AutoGenerateColumns="false" AllowPaging="true">
        <Columns>
            <asp:BoundField ItemStyle-Width="50px" DataField="serialNumber" HeaderText="ThesisSerialNumber" />
            <asp:BoundField ItemStyle-Width="50px" DataField="field" HeaderText="Field" />
            <asp:BoundField ItemStyle-Width="50px" DataField="type" HeaderText="Type"  />
            <asp:BoundField ItemStyle-Width="50px" DataField="title" HeaderText="Title" />
            <asp:BoundField ItemStyle-Width="50px" DataField="startDate" HeaderText="StartDate" />
            <asp:BoundField ItemStyle-Width="50px" DataField="endDate" HeaderText="EndDate"  />
            <asp:BoundField ItemStyle-Width="50px" DataField="defenseDate" HeaderText="DefenseDate"  />
            <asp:BoundField ItemStyle-Width="50px" DataField="years" HeaderText="YearsSpent"  />
            <asp:BoundField ItemStyle-Width="50px" DataField="grade" HeaderText="Grade"  />
            <asp:BoundField ItemStyle-Width="50px" DataField="payment_id" HeaderText="PaymentID"  />
            <asp:BoundField ItemStyle-Width="50px" DataField="noOfExtensions" HeaderText="NumberOfExtensionYears"  />


        </Columns>
    </asp:GridView>
        </div>
        <div>
            <br />
            <br />
            To issue a thesis payment please fill in the following:

            <br />
            (1)Thesis Serial Number <asp:TextBox ID="serial" runat="server"></asp:TextBox>
            <br />
            (2)Amount
            <asp:TextBox ID="amount" runat="server"></asp:TextBox>
            <br />
            (3)Number of Installments
            <asp:TextBox ID="number" runat="server"></asp:TextBox>
            <br />
            (4)Fund Percentage
            <asp:TextBox ID="fund" runat="server"></asp:TextBox>

            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Issue a Payment" OnClick="Button1_Click" />

            <br />
            <br />
            To issue installments for a certain payment please fill in the following:<br />
            (1)Payment ID
            <asp:TextBox ID="payid" runat="server"></asp:TextBox>
            <br />
            (2)Installments Start Date
            (Year/Month/Day)
            <asp:TextBox ID="install" runat="server"></asp:TextBox>

            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Issue Installments" OnClick="Button2_Click" />

            <br />
            <br />
            If you want to add an extension to a thesis please fill in the following:<br />
            (1)Thesis Serial Number
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Add Extension" OnClick="Button3_Click" />

        </div>
    </form>
</body>
</html>

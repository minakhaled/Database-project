<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Thesis.aspx.cs" Inherits="WebApplication.Thesis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            If you want to work on the thesis click on its serial number
            <br />
                        <br />

            <asp:GridView ID="ThesisDisplay" runat="server" AutoGenerateColumns="false" AllowPaging="true">
        <Columns>
            <asp:BoundField ItemStyle-Width="50px" DataField="serialNumber" HeaderText="ThesisSerialNumber" />
            <asp:BoundField ItemStyle-Width="50px" DataField="field" HeaderText="Field" />
            <asp:BoundField ItemStyle-Width="50px" DataField="title" HeaderText="Title" />
            <asp:BoundField ItemStyle-Width="50px" DataField="startDate" HeaderText="StartDate" />
            <asp:BoundField ItemStyle-Width="50px" DataField="endDate" HeaderText="EndDate"  />
            <asp:BoundField ItemStyle-Width="50px" DataField="defenseDate" HeaderText="DefenseDate"  />
             <asp:BoundField ItemStyle-Width="50px" DataField="years" HeaderText="YearsSpent"  />

            <asp:BoundField ItemStyle-Width="50px" DataField="grade" HeaderText="Grade"  />

            <asp:BoundField ItemStyle-Width="50px" DataField="noOfExtensions" HeaderText="NumberOfExtensionYears"  />


        </Columns>
    </asp:GridView>
        </div>
    </form>
</body>
</html>

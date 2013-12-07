<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="Practice.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="CSSStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <asp:GridView ID="GetgridView" runat="server" AutoGenerateColumns="false" CssClass="newTable" OnRowCommand="gridView_RowCommand" DataKeyNames="Id"
                RowStyle-CssClass="newRow1" HeaderStyle-CssClass="newTH" AlternatingRowStyle-CssClass="newRow2">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="ID" HeaderText="ID" />
                    <asp:BoundField DataField="Manager.name" HeaderText="Manager" />
                    <asp:BoundField DataField="Salary" HeaderText="Salary" />
                    <asp:TemplateField HeaderText="Edit/Delete">
                        <ItemTemplate>
                            <asp:Button ID="EditBtn" runat="server" Text="Edit" CommandName="Editeaza"
                                CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" />
                            <asp:Button ID="DeleteBtn" runat="server" Text="Delete" CommandName="Sterge"
                                CommandArgument='<%#((GridViewRow)Container).RowIndex %>' />
                        </ItemTemplate>
                        <asp:ItemTemplate />
                    </asp:TemplateField>

                </Columns>

            </asp:GridView>

            <asp:HyperLink runat="server" NavigateUrl="~/AddEmployee.aspx">Add new Employee</asp:HyperLink>


        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewEmployee.aspx.cs" Inherits="Practice.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="cssstyle.css" />
</head>
<body>
    <form  runat="server">
        <div>
             
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="false" CssClass="newTable" 
                RowStyle-CssClass="newRow1" HeaderStyle-CssClass="newTH" AlternatingRowStyle-CssClass="newRow2">
                <Columns>
                  <asp:BoundField DataField="Name" HeaderText="Name"  />
                    <asp:BoundField DataField="ID" HeaderText="ID" />
                    <asp:BoundField DataField="Manager.name" HeaderText="Manager"  />
                    <asp:BoundField DataField="Salary" HeaderText="Salary" />
                    <asp:TemplateField HeaderText="Edit/Delete">
                        <ItemTemplate>
                            <asp:Button ID="EditBtn" runat="server" CommandName="EditBtn" Text="Edit" />
                            <asp:Button ID="DeleteBtn" runat="server" CommandName="DeleteBtn" Text="Delete" />
                        </ItemTemplate> 
                        <asp:ItemTemplate   />
                    </asp:TemplateField>
                    
                </Columns>
                
            </asp:GridView>

            <asp:HyperLink  runat="server" NavigateUrl="~/NewEmployee.aspx">Add new Employee</asp:HyperLink>
        </div>
    </form>
</body>
</html>

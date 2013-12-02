<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewEmployee.aspx.cs" Inherits="Practice.NewEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="name"  runat="server">Name </asp:TextBox>
            <br />
            <asp:TextBox ID="id"  runat="server"> Id </asp:TextBox>
            <br />
            <asp:TextBox ID="manager"  runat="server"> Manager</asp:TextBox>
            <br />
            <asp:DropDownList ID="DDList"  runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:TextBox ID="salary"  runat="server"> Salary:</asp:TextBox>
            <br />
            <asp:Button ID="SaveBtn" Text="Save" runat="server" OnClick="SaveBtn_Click" />
            <asp:Button ID="CancelBtn" Text="Cancel" runat="server" />

        </div>
    </form>
</body>
</html>

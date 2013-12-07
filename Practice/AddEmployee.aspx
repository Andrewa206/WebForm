<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="Practice.AddEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <p> Nume: <asp:TextBox ID="Getname"  runat="server"></asp:TextBox></p>
        

            <p> Id: <asp:TextBox ID="GetId"  runat="server"></asp:TextBox></p>
           <p> Salariu:<asp:TextBox ID="GetSalary"  runat="server"></asp:TextBox> </p>
           
            <p> Manager:
            <asp:DropDownList ID="DDList"  runat="server" AppendDataBoundItems="true">
            <asp:ListItem Text="" Value="0"></asp:ListItem>
            </asp:DropDownList></p>
        
            <asp:Button ID="SaveBtn" Text="Save" runat="server" OnClick="SaveBtn_Click" />
            <asp:Button ID="CancelBtn" Text="Cancel" runat="server" OnClick="CancelBtn_Click" />
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Practice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title id="myTitle">Practice Asp.NET Web Forms</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:Panel ID="MyPanel" runat="server" Width="300" Height="150" BorderColor="#CC9999" BorderStyle="Dashed">
           <br />
           <asp:Label ID="label" runat="server"> Nume: </asp:Label> 
           <asp:TextBox ID="MyTextBox" runat="server" Width="100" Height="30"> Scrie aici !</asp:TextBox>
           <br />
            <asp:Button id="b1" Text="submit" runat="server" OnClick="b1_Click" />
           <br />
            <asp:Button id="b2" Text="Schimba Titlu" runat="server" OnClick="b2_Click" />
       </asp:Panel> 
        <asp:CheckBox ID="MyCheckBox"  Text="Show/Hide" runat="server" AutoPostBack="true"  OnCheckedChanged="CheckBox_CheckedChanged" />
       
        <br />
         <asp:Label ID="label2" EnableViewState="false" runat="server"> NewLabel: </asp:Label> 
         <asp:Button id="Button3" Text="New Button 2" runat="server" OnClick="Button1_Click" />
        <br />
         <asp:Button id="Button4" Text="Incarca Pagina Noua" runat="server" OnClick="Button4_Click" />
         
    </div>
    </form>
</body>
</html>

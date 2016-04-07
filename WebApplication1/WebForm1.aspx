<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>Welcome to Your Calculator!</div>
    Number 1: <asp:TextBox ID="tbOne" runat="server"></asp:TextBox>
        <br />
    Number 2: <asp:TextBox ID="tbTwo" runat="server"></asp:TextBox>
        <asp:RadioButtonList ID="rblOperations" runat="server">
            <asp:ListItem>Add</asp:ListItem>
            <asp:ListItem>Subtract</asp:ListItem>
            <asp:ListItem>Multiply</asp:ListItem>
            <asp:ListItem>Divide</asp:ListItem>
        </asp:RadioButtonList>
        <p>
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate!" onClick="finish"/>
        </p>
        <asp:Label ID="lblAnswer" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>

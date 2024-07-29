<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ip1a.aspx.cs" Inherits="Practical1.ip1a" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 775px">
    <form id="form1" runat="server">
    Enter A: 
    <asp:TextBox ID="txt_1" runat="server"></asp:TextBox>
    <br />
    Enter B: 
    <asp:TextBox ID="txt_3" runat="server"></asp:TextBox>
    <br />
    Enter C: 
    <asp:TextBox ID="txt_2" runat="server"></asp:TextBox>
    <br />
    Enter D: 
    <asp:TextBox ID="txt_4" runat="server"></asp:TextBox>
    <br />
    <div>
    
        <asp:Button ID="cmdProduct" runat="server" onclick="cmdProduct_Click" Text="Calculate" 
            BackColor="#0066FF" Font-Bold="True" Font-Italic="False" />
    
    </div>
    <p style="height: 29px; width: 1281px">
        <asp:TextBox ID="txt_5" runat="server"></asp:TextBox>
    </p>
    </form>
</body>
</html>

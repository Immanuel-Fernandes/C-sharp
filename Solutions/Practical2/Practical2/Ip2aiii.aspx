<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ip2aiii.aspx.cs" Inherits="Practical2.Ip2aiii" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <asp:Label ID="Lbl_a" runat="server" Text="Enter coefficient a:"></asp:Label>
&nbsp;
        <asp:TextBox ID="Txt_a" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Lbl_b" runat="server" Text="Enter coefficient b:"></asp:Label>
&nbsp;
        <asp:TextBox ID="Txt_b" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Lbl_c" runat="server" Text="Enter coefficient c:"></asp:Label>
&nbsp;
        <asp:TextBox ID="Txt_c" runat="server"></asp:TextBox>    
        <br />
        <br />
        <asp:Button ID="CmdCheck" runat="server" Text="Check" onclick="CmdCheck_Click" />
        <br />
        <br />
        <asp:Label ID="Lbl_roots" runat="server" Text=" "></asp:Label>
    
    </div>
    </form>
</body>
</html>

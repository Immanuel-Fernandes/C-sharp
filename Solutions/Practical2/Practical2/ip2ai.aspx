<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ip2ai.aspx.cs" Inherits="Practical2.ip2ai" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lbl_1" runat="server" Text="Enter a Numbers:">
            </asp:Label>
            &nbsp;
            <asp:TextBox ID="Txt_1" runat="server">
            </asp:TextBox>
            <br />
            <br />
            <asp:Button ID="CmdFact" runat="server" Text="Calculate Factorial" OnClick="CmdFact_Click" />
            <br />
            <br />
            <asp:Label ID="Lbl_3" runat="server" Text="__"></asp:Label>
            &nbsp;</div>
    </form>
</body>
</html>

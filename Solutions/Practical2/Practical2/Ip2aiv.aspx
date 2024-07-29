<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ip2aiv.aspx.cs" Inherits="Practical2.Ip2aiv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lbl_1" runat="server" Text="Enter Temperature in Fahrenheit: ">
            </asp:Label>
            &nbsp;
            <asp:TextBox ID="Txt_1" runat="server">
            </asp:TextBox>
            <br />
            <br />
            <asp:Button ID="CmdCal" runat="server" Text="Convert" OnClick="CmdCal_Click" />
            <br />
            <br />
            <asp:Label ID="Lbl_3" runat="server" Text=" "></asp:Label>
            &nbsp;</div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ip2biii.aspx.cs" Inherits="Practical2.ip2biii" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lbl_1" runat="server" Text="Enter a Numbers to Add by 10 :">
            </asp:Label>
            <br />
            <br />
            <asp:TextBox ID="Txt_1" runat="server">
            </asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Lbl_3" runat="server" Text="__"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Lbl_2" runat="server" Text="Enter two Numbers:">
            </asp:Label>
            <br /><br />
            <asp:TextBox ID="Txt_2" runat="server"></asp:TextBox>
            &nbsp;
            <asp:TextBox ID="Txt_3" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Lbl_4" runat="server" Text="__"></asp:Label>
            </p>
        <p>
            <asp:Button ID="CmdCalculate" runat="server" Text="Calculate Sum" OnClick="CmdCalculate_Click" />
        </p>
    </form>
</body>
</html>

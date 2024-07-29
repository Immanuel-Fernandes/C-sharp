<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ip2bi.aspx.cs" Inherits="Practical2.Ip2bi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lbl1" runat="server" Text="Enter a Numbers to Add by 10 :">
            </asp:Label>
            <br />
            <br />
            <asp:TextBox ID="Txt1" runat="server">
            </asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Lbl3" runat="server" Text="__"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Lbl2" runat="server" Text="Enter two Numbers:">
            </asp:Label>
            <br /><br />
            <asp:TextBox ID="Txt2" runat="server"></asp:TextBox>
            &nbsp;
            <asp:TextBox ID="Txt3" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Lbl4" runat="server" Text="__"></asp:Label>
            </p>
        <p>
            <asp:Button ID="CmdCalculate" runat="server" Text="Calculate Sum" OnClick="CmdCalculate_Click" />
        </p>
    </form>
</body>
</html>

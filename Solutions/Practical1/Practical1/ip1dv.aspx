<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ip1dv.aspx.cs" Inherits="Practical1.ip1dv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            Enter a Number:
            <asp:TextBox ID="Txt_1" runat="server" ></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="CmdCal" runat="server" Text="Calculate Sum" OnClick="CmdCal_Click" />
            </p>
        <p>
            Reverse Number is: 
            <asp:Label ID="Lbl_Reverse" runat="server" Text="_"></asp:Label>
        </p>
        <p>
            Sum of digits of a number is: 
            <asp:Label ID="Lbl_Sum" runat="server" Text="_"></asp:Label>
        </p>
    </form>
</body>
</html>

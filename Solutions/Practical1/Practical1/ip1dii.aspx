﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ip1dii.aspx.cs" Inherits="Practical1.ip1dii" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
      <form id="form1" runat="server">
        <div>
            Enter a number:
            <asp:TextBox ID="Txt_1" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="CmdPrime" runat="server" Text="Check Prime" OnClick="CmdPrime_Click" />
            </p>
        <p>
            Result is: 
            <asp:Label ID="Lbl_1" runat="server" Text="_"></asp:Label>
        </p>
    </form>
</body>
</html>

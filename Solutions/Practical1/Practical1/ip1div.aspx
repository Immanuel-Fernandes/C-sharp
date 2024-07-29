<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ip1div.aspx.cs" Inherits="Practical1.ip1div" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="CmdDisplay" runat="server" Text="Display" 
            onclick="CmdDisplay_Click" />
        <br />
        <asp:Label ID="lbl_1" runat="server" Text=""></asp:Label>    
    </div>
    <p>
        &nbsp;</p>
    </form>
</body>
</html>

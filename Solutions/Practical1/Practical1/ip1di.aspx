<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ip1di.aspx.cs" Inherits="Practical1.ip1di" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter The Numbers to be Printed in the Fibonacci Series:
        <asp:TextBox ID="Txt_1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="cmdFibonacci" runat="server" onclick="cmdFibonacci_Click" 
            Text="Generate" />
        <br />
        <br />
        Fibonacci Series:
        <br />
        <br />
        <asp:TextBox ID="Txt_2" runat="server" Height="35px" Width="1168px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>

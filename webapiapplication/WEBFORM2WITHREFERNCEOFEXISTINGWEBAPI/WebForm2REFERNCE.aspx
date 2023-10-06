<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2REFERNCE.aspx.cs" Inherits="WEBFORM2WITHREFERNCEOFEXISTINGWEBAPI.WebForm2REFERNCE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Var A :
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Var B ;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </div>
    </form>
</body>
</html>

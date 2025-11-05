<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio_15._3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Introduzca un Texto<p>
            <asp:TextBox ID="txtSaludo" runat="server"></asp:TextBox>
            <asp:Button ID="btnSaludar" runat="server" OnClick="btnSaludar_Click" Text="Enviar Saludo!" />
        </p>
    </form>
</body>
</html>

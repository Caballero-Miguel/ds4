<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio_15._4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblNumeroA" runat="server" Text="Número A"></asp:Label>
        <asp:TextBox ID="txtNumeroA" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblNumeroB" runat="server" Text="Número B"></asp:Label>
            <asp:TextBox ID="txtNumeroB" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnSumar" runat="server" OnClick="btnSumar_Click" Text="Sumar" />
        <p>
            <asp:Label ID="lblResultado" runat="server" Text="Resultado"></asp:Label>
        </p>
    </form>
</body>
</html>

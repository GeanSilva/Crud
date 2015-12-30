<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    <script src="Scripts/jquery.1.9.1.js"></script>
    <script src="Scripts/bootstrap.js"></script>

    <title>Home</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="jumbotron">
        <h1>Projeto CRUD- Controle de Clientes</h1>

        Selecione a operação desejado
        <asp:DropDownList ID="ddlMenu" runat="server">
            <asp:ListItem Value="0" Text="Escolha uma Opção"></asp:ListItem>
            <asp:ListItem Value="1" Text="Cadastrar Cliente"></asp:ListItem>
            <asp:ListItem Value="2" Text="Consultar Cliente"></asp:ListItem>
            <asp:ListItem Value="3" Text="Detalhes Cliente"></asp:ListItem>
        </asp:DropDownList>
    
        <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn btn-primary btn-lg" OnClick="btnMenu_Click" />
        <p><asp:Label ID="lblMensagem" runat="server" ForeColor="Red"></asp:Label></p>
    </div>
    </form>
</body>
</html>

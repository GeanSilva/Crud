<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    <script src="Scripts/jquery.1.9.1.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="col-lg-10 col-lg-offset-1">
            <div class="row">
                <h3 class="well">Cadastrar Cliente</h3>
                <br />
                Nome do Cliente:<br />
                <asp:TextBox id="txtNome" runat="server" placeholder="Nome Completo" width="50%" CssClass="form-control"></asp:TextBox> 
                <asp:RequiredFieldValidator ErrorMessage="Por favor, digite seu nome" ControlToValidate="txtNome" runat="server" ForeColor="Red" />
                <br />

                Endereço:<br />
                <asp:TextBox id="txtEndereco" runat="server" placeholder="Endereço Resindêncial" width="50%" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ErrorMessage="Por favor, digite seu endereço" ControlToValidate="txtEndereco" runat="server" ForeColor="Red" />

                <br />
                E-mail:<br />
                <asp:TextBox id="txtEmail" runat="server" placeholder="E-mail válido" width="50%" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ErrorMessage="Informe um E-mail válido" ControlToValidate="txtEmail" runat="server"  ForeColor="Red"/>
                
                <p><asp:Label id="lblmensagem" runat="server"></asp:Label></p>

                <div= class="row">
                    <div class="col-lg-4">
                        <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-success" OnClick="btnCadastrar_Click" />
                        <a href="/Default.aspx" class="btn btn-default">Voltar</a>
                    </div>
                   
                </div>
                
            </div>
        </div>
    </div>
    </form>
</body>
</html>

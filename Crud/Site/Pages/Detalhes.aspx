<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Deatalhes" %>

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
                <h3 class="well">Detalhes do Cliente</h3>
                <br />
                        <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Width="10%" placeholder="Código"></asp:TextBox><br />
                        <asp:Button ID="btnPesquisa" runat="server" Text="Pesquisar"  CssClass="btn btn-info" OnClick="btnPesquisa_Click" />
                        <a href="/Default.aspx" class="btn btn-default">Voltar</a>   <br /><br />
                        
                        <asp:Panel id="pnlDados" runat="server">  
                            <asp:TextBox  ID="txtNome" runat="server" CssClass="form-control" Width="50%" placeholder="Nome do Cliente"></asp:TextBox> <br />
                            <asp:TextBox ID="txtEndereco" runat="server" CssClass="form-control" Width="50%" placeholder="Endereço do Cliente"></asp:TextBox> <br />
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Width="50%" placeholder="E-mail do Cliente"></asp:TextBox> <br />    
                                      
                            <asp:Button ID="btnAtualizar" runat="server" Text="Atulizar"  CssClass="btn btn-warning" OnClick="btnAtualizar_Click" />
                            <asp:Button ID="btnExcluir" runat="server" Text="Deletar"  CssClass="btn btn-danger" OnClick="btnExcluir_Click" />  
                        </asp:Panel>  

                <p><asp:Label id="lblmensagem" runat="server"></asp:Label></p>

            </div>
        </div>
    </div>
    </form>
</body>
</html>

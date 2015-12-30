<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Site.Pages.Consulta" %>

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
        <div class="col-lg-10 col-lg-offset-1" > 
            <div class="row">
                <h3 class="well">Consulta de Clientes</h3>
                
                <asp:GridView ID="gridClientes" runat="server" CssClass="table table-striped table-hover table-bordered" GridLines="None" BackColor="Silver" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="Codigo" HeaderText="Código" />
                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
                        <asp:BoundField DataField="Email" HeaderText="E-mail" />
                    </Columns>
                    <RowStyle CssClass="curos-pointer" />
                </asp:GridView>

               <p><asp:Label id="lblmensagem" runat="server"></asp:Label></p>

                <div= class="row">
                    <div class="col-lg-4">
                        <a href="/Default.aspx" class="btn btn-default">Voltar</a>
                    </div>
                   
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>

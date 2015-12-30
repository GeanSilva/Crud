using DAL.Model;
using DAL.Percistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var pessoa = new Pessoa();

                pessoa.Nome = txtNome.Text;
                pessoa.Endereco = txtEndereco.Text;
                pessoa.Email = txtEmail.Text;

                var gravar = new PessaoDal();
                gravar.Grvar(pessoa);

                lblmensagem.ForeColor = System.Drawing.Color.Green;
                lblmensagem.Text = "Cliente " + pessoa.Nome + " cadastrado com Sucesso!";
            }
            catch (Exception ex)
            {

                lblmensagem.ForeColor = System.Drawing.Color.Red;
                lblmensagem.Text = ex.Message;
            }
    }
}
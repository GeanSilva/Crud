using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Percistencia;
namespace Site.Pages
{
    public partial class Deatalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
        }

        protected void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                var pessoaDal = new PessaoDal();
                Pessoa pessoa = pessoaDal.PesquisarPorCodigo(codigo);

                if (pessoa != null)
                {
                    pnlDados.Visible = true;
                    txtCodigo.ReadOnly = true;
                    txtNome.Text = pessoa.Nome;
                    txtEndereco.Text = pessoa.Endereco;
                    txtEmail.Text = pessoa.Email;
                }
                else
                {
                    lblmensagem.Text = "Cliente não localizado";
                }
            }
            catch (Exception ex )
            {

                lblmensagem.Text = ex.Message;
            }

        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var pessoa = new Pessoa();
                var pessoaDal = new PessaoDal();

                pessoa.Codigo = Convert.ToInt32(txtCodigo.Text);
                pessoa.Nome = Convert.ToString(txtNome.Text);
                pessoa.Endereco = Convert.ToString(txtEndereco.Text);
                pessoa.Email = Convert.ToString(txtEmail.Text);

                pessoaDal.Atualizar(pessoa);

               // Response.Redirect("/Pages/Consulta.aspx");
                lblmensagem.ForeColor = System.Drawing.Color.Green;
                lblmensagem.Text = "Cliente Atualizado com sucesso";

            }
            catch (Exception ex)
            {

                lblmensagem.ForeColor = System.Drawing.Color.Red;
                lblmensagem.Text = ex.Message;

            }
        }
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                var pessoa = new Pessoa();
                var pessoaDal = new PessaoDal();

                pessoaDal.Excluir(codigo);

                lblmensagem.Text = "Cliente excluído com sucesso";

                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;

                Response.Redirect("/Pages/Consulta.aspx");
            }
            catch (Exception ex)
            {
                lblmensagem.ForeColor = System.Drawing.Color.Red;
                lblmensagem.Text = ex.Message;
            }
        }
    }
}
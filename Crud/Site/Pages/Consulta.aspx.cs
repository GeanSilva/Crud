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
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var pessaoDal = new PessaoDal();
                gridClientes.DataSource = pessaoDal.PesquisarTodos();
                gridClientes.DataBind();

            }
            catch (Exception ex)
            {

                lblmensagem.ForeColor = System.Drawing.Color.Red;
                lblmensagem.Text = ex.Message;
            }
        }
    }
}
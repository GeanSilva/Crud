using System;
using System.Data.SqlClient;
using DAL.Properties;

namespace DAL.Conexao
{
  public  class ConectaBanco
    {
        protected SqlConnection conecta;
        protected SqlCommand comando;
        protected SqlDataReader dataReader;
        
        protected void AbrirConexao()
        {
            try
            {
                conecta = new SqlConnection(Settings.Default.ConectaDB);
                conecta.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        protected void FecharConexao()
        {
            try
            {
                conecta.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}

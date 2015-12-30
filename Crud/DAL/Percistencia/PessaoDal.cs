using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;
using DAL.Conexao;

namespace DAL.Percistencia
{
    public class PessaoDal : ConectaBanco
    {
        public void Grvar(Pessoa pessoa)
        {
            try
            {
                AbrirConexao();

                comando = new SqlCommand("insert into Pessoa (Nome,Endereco,Email) values(@v1,@v2,@v3)",conecta);
                comando.Parameters.AddWithValue("@v1",pessoa.Nome);
                comando.Parameters.AddWithValue("@v2",pessoa.Endereco);
                comando.Parameters.AddWithValue("@v3",pessoa.Email);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar cliente"+ ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        public void Atualizar(Pessoa pessoa)
        {
            try
            {
                AbrirConexao();
                comando = new SqlCommand("update Pessoa set Nome=@v1,Endereco=@v2, Email=@v3 where Codigo = @v4",conecta);
                comando.Parameters.AddWithValue("@v1", pessoa.Nome);
                comando.Parameters.AddWithValue("@v2", pessoa.Endereco);
                comando.Parameters.AddWithValue("@v3", pessoa.Email);
                comando.Parameters.AddWithValue("@v4",pessoa.Codigo);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Atualizar cliente"+ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        public void Excluir(int codigo)
        {
            try
            {
                AbrirConexao();
                comando = new SqlCommand("delete from Pessoa where codigo =@v1",conecta);
                comando.Parameters.AddWithValue("@v1",codigo);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        public Pessoa PesquisarPorCodigo(int codigo)
        {
            try
            {
                AbrirConexao();
                comando = new SqlCommand("select * from Pessoa where codigo = @v1",conecta);
                comando.Parameters.AddWithValue("@v1", codigo);
                dataReader = comando.ExecuteReader();
                Pessoa pessoa = null; // criando um espaço de memória: ponteiro

                if (dataReader.Read())
                {
                    pessoa = new Pessoa();
                    pessoa.Codigo = Convert.ToInt32(dataReader["Codigo"]);
                    pessoa.Nome = Convert.ToString(dataReader["Nome"]);
                    pessoa.Endereco = Convert.ToString(dataReader["Endereco"]);
                    pessoa.Email = Convert.ToString(dataReader["Email"]);

                }

                return pessoa;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar o cliente "+ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        public List<Pessoa> PesquisarTodos()
        {
            try
            {
                AbrirConexao();
                comando = new SqlCommand("select * from Pessoa",conecta);
                dataReader = comando.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();

                while (dataReader.Read())
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.Codigo = Convert.ToInt32(dataReader["Codigo"]);
                    pessoa.Nome = Convert.ToString(dataReader["Nome"]);
                    pessoa.Endereco = Convert.ToString(dataReader["Endereco"]);
                    pessoa.Email = Convert.ToString(dataReader["Email"]);

                    lista.Add(pessoa);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}

using CRUDProduto.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRUDProduto.DAL
{
    public class DALProduto
    {

        public void Incluir(model modelo)
        {

            SqlConnection conexao = new SqlConnection();
            try
            {
                //Inserir dados e conectando ao banco usando a classe dados
                conexao.ConnectionString = dados.ConexaoDB;

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "insert into produto (id, nome, marca, preco, quantidade) " +
                                      " values ( @id, @nome, @marca, @preco, @quantidade) ";

                comando.Parameters.AddWithValue("@id", modelo.ID);
                comando.Parameters.AddWithValue("@nome", modelo.Nome);
                comando.Parameters.AddWithValue("@marca", modelo.Marca);
                comando.Parameters.AddWithValue("@preco", modelo.Preco);
                comando.Parameters.AddWithValue("@quantidade", modelo.Quantidade);


                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }


            public DataTable Localizar(string Codigo)
        {
            SqlConnection conexao = new SqlConnection();
            try
            {
                conexao.ConnectionString = dados.ConexaoDB;
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;

                comando.CommandText = " SELECT id, nome, marca, preco, quantidade  " +
                                      " FROM produto WHERE CODIGO LIKE @id ";
                comando.Parameters.AddWithValue("@id", Codigo + "%");
                conexao.Open();
                SqlDataAdapter db = new SqlDataAdapter(comando);
                DataTable pessoa = new DataTable();

                db.Fill(pessoa);
                return pessoa;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Alterar(model modelo)
        {
            SqlConnection conexao = new SqlConnection();
            try
            {
                conexao.ConnectionString = dados.ConexaoDB;

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE pessoa SET id = @id  " +
                                      "  WHERE nome = @nome, marca = @marca, preco = @preco, quantidade = @quantidade";

                comando.Parameters.AddWithValue("@id", modelo.ID);
                comando.Parameters.AddWithValue("@nome", modelo.Nome);
                comando.Parameters.AddWithValue("@marca", modelo.Nome);
                comando.Parameters.AddWithValue("@preco", modelo.Nome);
                comando.Parameters.AddWithValue("@quantidade", modelo.Nome);


                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

        }
        public void Excluir(model modelo)
        {
            SqlConnection conexao = new SqlConnection();
            try
            {
                conexao.ConnectionString = dados.ConexaoDB;

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "delete from pessoa where id = @id ";

                comando.Parameters.AddWithValue("@id", modelo.ID);


                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

    }
}

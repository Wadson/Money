using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Money
{
    internal class ProdutoDAL
    {
        public DataTable lista_Produto()
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("SELECT id_produto, nome_produto, descricao_produto, marca_produto, precocusto_produto, lucro_produto, precovenda_produto FROM produto", conn);
                
                SqlDataAdapter daCliente = new SqlDataAdapter();
                daCliente.SelectCommand = sql;
                DataTable dtcliente = new DataTable();
                daCliente.Fill(dtcliente);
                return dtcliente;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }
       
        public void salvaProduto(ProdutosMODEL produto)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("INSERT INTO produto (id_produto, nome_produto, descricao_produto, marca_produto, precocusto_produto, lucro_produto, precovenda_produto) VALUES (@id_Produto, @nome_Produto, @descricao_Produto, @marca_Produto, @precocusto_Produto, @lucro_Produto, @precovenda_Produto)", conn);

                sql.Parameters.AddWithValue("@id_Produto", produto.Id_produto);
                sql.Parameters.AddWithValue("@nome_Produto", produto.Nome_produto);
                sql.Parameters.AddWithValue("@descricao_Produto", produto.Descricao_produto);
                sql.Parameters.AddWithValue("@marca_Produto", produto.Marca_produto);
                sql.Parameters.AddWithValue("@precocusto_Produto", produto.Precocusto_produto);
                sql.Parameters.AddWithValue("@lucro_Produto", produto.Lucro_produto);
                sql.Parameters.AddWithValue("@precovenda_Produto", produto.Precovenda_produto);                

                conn.Open();
                sql.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        public void excluiProduto(ProdutosMODEL produto)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("DELETE FROM produto WHERE id_produto = @id_Produto ", conn);  
                sql.Parameters.AddWithValue("@id_Produto", produto);              

                conn.Open();
                sql.ExecuteNonQuery();               
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }

        public void atualizaProduto(ProdutosMODEL produto)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("UPDATE produto SET id_produto  = @id_Produto, nome_produto = @nome_Produto, descricao_produto = @descricao_Produto, marca_produto = @marca_Produto, precocusto_produto = @precocusto_Produto, lucro_produto = @lucro_Produto, precovenda_produto = @precovenda_Produto WHERE id_produto = @id_Produto", conn);

                sql.Parameters.AddWithValue("@nome_Produto", produto.Nome_produto);
                sql.Parameters.AddWithValue("@descricao_Produto", produto.Descricao_produto);
                sql.Parameters.AddWithValue("@marca_Produto", produto.Marca_produto);
                sql.Parameters.AddWithValue("@precocusto_Produto", produto.Precocusto_produto);
                sql.Parameters.AddWithValue("@lucro_Produto", produto.Lucro_produto);
                sql.Parameters.AddWithValue("@precovenda_Produto", produto.Precovenda_produto);
                sql.Parameters.AddWithValue("@id_Produto", produto.Id_produto);

                conn.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }            
        }
    }
}

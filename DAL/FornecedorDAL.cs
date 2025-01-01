using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace Money
{
    class FornecedorDAL
    {
        
        public DataTable lista_Fornecedor()
        {
            var conn = Conexao.Conex();
            try
            {
                conn.Open();
                SqlCommand sqlcomando = new SqlCommand("SELECT * FROM fornecedor", conn);
                SqlDataAdapter daFornecedor = new SqlDataAdapter();
                daFornecedor.SelectCommand = sqlcomando;
                DataTable dtFornecedor = new DataTable();
                daFornecedor.Fill(dtFornecedor);
                return dtFornecedor;
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
       
        public void gravaFornecedor(FornecedorMODEL fornecedor)
        {
            var conn = Conexao.Conex();
            //*********
            SqlCommand sqlcomando = new SqlCommand("INSERT INTO fornecedor (id_fornecedor, nome_fornecedor, endere_fornecedor) VALUES  (@id_Fornecedor, @nome_Fornecedor, @endere_Fornecedor)", conn);

            sqlcomando.Parameters.AddWithValue("@id_Fornecedor", fornecedor.ID_Fornecedor);
            sqlcomando.Parameters.AddWithValue("@nome_Fornecedor", fornecedor.Fornecedor);
            sqlcomando.Parameters.AddWithValue("@endere_Fornecedor", fornecedor.Endere_fornecedor);

            conn.Open();
            sqlcomando.ExecuteNonQuery();
            //********
            try
            {
                //SqlCommand sqlcomando = new SqlCommand("INSERT INTO fornecedor (id_fornecedor, nome_fornecedor, endere_fornecedor) VALUES  (@id_Fornecedor, @nome_Fornecedor, @endere_Fornecedor)", conn);

                //sqlcomando.Parameters.AddWithValue("@id_Fornecedor", fornecedor.ID_Fornecedor);
                //sqlcomando.Parameters.AddWithValue("@nome_Fornecedor", fornecedor.Fornecedor);
                //sqlcomando.Parameters.AddWithValue("@endere_Fornecedor", fornecedor.Endere_fornecedor);              
                
                //conn.Open();
                //sqlcomando.ExecuteNonQuery();
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
      
        public void excluiFornecedor(FornecedorMODEL fornecedor)
        {
            var conn = Conexao.Conex();
            try
            {   
                SqlCommand sqlcomando = new SqlCommand("DELETE FROM fornecedor WHERE id_fornecedor = @id_Fornecedor", conn);
                sqlcomando.Parameters.AddWithValue("@id_Fornecedor", fornecedor.ID_Fornecedor);
                conn.Open();
                sqlcomando.ExecuteNonQuery();
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
       
        public void atualizaFornecedor(FornecedorMODEL fornecedor)
        {
            var conn = Conexao.Conex();
            try
            {   
                SqlCommand sqlcomando = new SqlCommand("UPDATE fornecedor SET nome_fornecedor = @nome_Fornecedor, endere_fornecedor = @endere_Fornecedor WHERE id_fornecedor = @id_Fornecedor", conn);

                sqlcomando.Parameters.AddWithValue("@nome_Fornecedor", fornecedor.Fornecedor);
                sqlcomando.Parameters.AddWithValue("@endere_Fornecedor", fornecedor.Endere_fornecedor);             
                sqlcomando.Parameters.AddWithValue("@id_Fornecedor", fornecedor.ID_Fornecedor);

                conn.Open();
                sqlcomando.ExecuteNonQuery();
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

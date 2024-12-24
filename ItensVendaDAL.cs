using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class ItensVendaDAL
    {

        public DataTable listaItensVenda()
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand comando = new SqlCommand("SELECT id_itensvenda, id_produto, qtd_produto, valor_produto, id_venda, num_parcela FROM itensvenda", conn);
                

                SqlDataAdapter daItensVenda = new SqlDataAdapter();
                daItensVenda.SelectCommand = comando;

                DataTable dtItensVenda = new DataTable();
                daItensVenda.Fill(dtItensVenda);
                return dtItensVenda;
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

        public void SalvarRegistro(ItensVendaMODEL itensvenda)
        {
            var conn = Conexao.Conex();

            SqlCommand sqlcomm = new SqlCommand("INSERT INTO itensvenda (id_itensvenda, id_produto, qtd_produto, valor_produto, id_venda, num_parcela) VALUES " +
                    "(@id_Itensvenda, @id_Produto, @qtd_Produto, @valor_Produto, @id_Venda, @num_Parcela)", conn);

            sqlcomm.Parameters.AddWithValue("@id_Itensvenda", itensvenda.Id_itensvenda);
            sqlcomm.Parameters.AddWithValue("@id_Produto", itensvenda.Id_produto);
            sqlcomm.Parameters.AddWithValue("@qtd_Produto", itensvenda.Qtd_produto);
            sqlcomm.Parameters.AddWithValue("@valor_Produto", itensvenda.Valor_produto);
            sqlcomm.Parameters.AddWithValue("@num_Parcela", itensvenda.Num_parcela);
            sqlcomm.Parameters.AddWithValue("@id_Venda", itensvenda.Id_venda);


            conn.Open();
            sqlcomm.ExecuteNonQuery();
            try
            {
                
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
        // ***********E  X  C  L  U  I         U  S  U  A  R  I  O***********************************
        public void excluirItensVenda(ItensVendaMODEL itensvenda)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sqlcomando = new SqlCommand("DELETE FROM itensvenda WHERE id_itensvenda = @id_Itensvenda", conn);
                sqlcomando.Parameters.AddWithValue("@id_Itensvenda", itensvenda.Id_itensvenda);
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
        //********A  T  U  A  L  I  Z  A     U  S  U  A  R  I  O  *****************************************************
        public void atualizaItensVenda(ItensVendaMODEL itensvenda)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sqlcomm = new SqlCommand("UPDATE itensvenda SET  id_produto = @id_Produto, qtd_produto = @qtd_Produto, valor_produto = @valor_Produto, id_venda = @id_Venda, num_parcela = @num_Parcela WHERE id_itensvenda = @id_Itensvenda", conn);

                sqlcomm.Parameters.AddWithValue("@id_Produto", itensvenda.Id_produto);
                sqlcomm.Parameters.AddWithValue("@qtd_Produto", itensvenda.Qtd_produto);
                sqlcomm.Parameters.AddWithValue("@valor_Produto", itensvenda.Valor_produto);
                sqlcomm.Parameters.AddWithValue("@id_Venda", itensvenda.Id_venda);
                sqlcomm.Parameters.AddWithValue("@num_Parcela", itensvenda.Num_parcela);
                sqlcomm.Parameters.AddWithValue("@id_Itensvenda", itensvenda.Id_itensvenda);

                conn.Open();
                sqlcomm.ExecuteNonQuery();

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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class VendaDAL
    {
        public void SalvarVenda(VendaMODEL venda)
        {
            var conn = Conexao.Conex();            
            try
            {
                SqlCommand sql = new SqlCommand("INSERT INTO venda (id_venda, dt_venda, id_cliente) " +
                "VALUES (@id_Venda, @dt_Venda, @id_Cliente)", conn);
                               
                sql.Parameters.AddWithValue("@id_Venda", venda.Id_venda);
                sql.Parameters.AddWithValue("@dt_Venda", venda.Dt_venda);
                sql.Parameters.AddWithValue("@id_Cliente", venda.Id_cliente);

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
            conn.Close();
        }
        public void excluirVenda(VendaMODEL venda)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("DELETE FROM venda WHERE id_venda = @id_Venda", conn);
                sql.Parameters.AddWithValue("@id_Venda", venda.Id_venda);
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
       
        public void atualizaVenda(VendaMODEL venda)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("UPDATE venda SET id_venda = @id_Venda, dt_venda = @dt_Venda, id_cliente = @id_Cliente", conn);

                sql.Parameters.AddWithValue("@id_Venda", venda.Id_venda);
                sql.Parameters.AddWithValue("@dt_Venda", venda.Dt_venda);
                sql.Parameters.AddWithValue("@id_Cliente", venda.Id_cliente);                              

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

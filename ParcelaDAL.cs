using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Money
{
    class ParcelaDAL
    {
        public void SalvarParcelas(ParcelaModel parcela)
        {
            var conn = Conexao.Conex();

            try
            {
                SqlCommand sql = new SqlCommand("INSERT INTO parcelas (id_parcela, valor_parcela, num_parcela, dt_vcto_parcela, id_venda) " +
                "VALUES (@id_Parcela, @valor_Parcela, @num_Parcela, @dt_Vcto_Parcela, @id_Venda)", conn);

                sql.Parameters.AddWithValue("@id_Parcela", parcela.Idparcela);
                sql.Parameters.AddWithValue("@valor_Parcela", parcela.Valor_parc);
                sql.Parameters.AddWithValue("@num_Parcela", parcela.Numparcela);
                sql.Parameters.AddWithValue("@dt_Vcto_Parcela", parcela.Datavenc);
                sql.Parameters.AddWithValue("@id_Venda", parcela.IdVenda);

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

        public void excluirTodasParcela(ParcelaModel parcela)
        {
            var conn = Conexao.Conex();
            try
            {               
                SqlCommand sql = new SqlCommand("DELETE FROM parcelas WHERE id_venda = @IdVenda", conn);
                sql.Parameters.AddWithValue("@IdVenda", parcela.IdVenda);
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
        //public void excluiParcelaUnica(ParcelaModel parcelas)
        //{
        //    var conn = Conexao.Conex();
        //    try
        //    {
        //        SqlCommand sql = new SqlCommand("DELETE FROM parcelas WHERE id_parcela = @iDparcela", conn);
        //        sql.Parameters.AddWithValue("@iDparcela", parcelas.Idparcela);
        //        conn.Open();
        //        sql.ExecuteNonQuery();
        //    }
        //    catch (Exception erro)
        //    {
        //        throw erro;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}      
        public void atualizaParcela(ParcelaModel parc)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("UPDATE parcelas SET valor_parc = @ValorParc, dt_vcto_parcela = @dt_Vcto_parcela WHERE id_parcela = @IdParc", conn);

                sql.Parameters.AddWithValue("@valor_Parcela", parc.Valor_parc);
                sql.Parameters.AddWithValue("@dt_Vcto_Parcela", parc.Datavenc);               
                sql.Parameters.AddWithValue("@id_Parc", parc.Idparcela);

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

        public void baixarParcela(ParcelaModel parcela)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("UPDATE parcelas SET valor_pago = @valor_Pago, datapgto = @Datapgto, pago = @Pago WHERE idparcela = @IDparcela", conn);

                sql.Parameters.AddWithValue("@valor_Pago", parcela.Valorpago);
                sql.Parameters.AddWithValue("@Datapgto", parcela.Datapgto);
                sql.Parameters.AddWithValue("@pago", parcela.Pago);
                sql.Parameters.AddWithValue("@IDparcela", parcela.Idparcela);

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

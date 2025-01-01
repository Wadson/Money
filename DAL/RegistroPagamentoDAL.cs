using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class RegistroPagamentoDAL
    {
        public void SalvarRegistroPagamento(RegistroPagamentoModel parcela)
        {
            var conn = Conexao.Conex();            try
            {
                SqlCommand sql = new SqlCommand("INSERT INTO parcelas (id_pagamento, id_contasreceber, id_formapgto, valor_pgto, dt_pgto) " +
                "VALUES (@id_Pagamento, @id_Contasreceber, @id_Formapgto, @valor_Pgto, @dt_pgto)", conn);

                sql.Parameters.AddWithValue("@id_Pagamento", parcela.Id_pagamento);
                sql.Parameters.AddWithValue("@id_Contasreceber", parcela.Id_contasreceber);
                sql.Parameters.AddWithValue("@id_Formapgto", parcela.Id_formapgto);
                sql.Parameters.AddWithValue("@valor_Pgto", parcela.Valor_pgto);
                sql.Parameters.AddWithValue("@dt_pgto", parcela.Dt_pgto);
                
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

        public void excluirTodosPagamentos(RegistroPagamentoModel parcela)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("DELETE FROM registropagamento WHERE id_pagamento = @id_Pagamento", conn);
                sql.Parameters.AddWithValue("@id_Pagamento", parcela.Id_pagamento);
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
        public void excluiParcelaUnica(RegistroPagamentoModel parcelas)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("DELETE FROM registropagamento WHERE id_pagamento = @id_Pagamento", conn);
                sql.Parameters.AddWithValue("@id_Pagamento", parcelas.Id_pagamento);
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
        public void atualizaRegistroPagamento(RegistroPagamentoModel parc)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("UPDATE registropagamento SET id_pagamento = @id_Pagamento, id_contasreceber = @id_Contasreceber, id_formapgto = @id_Formapgto, valor_pgto = @valor_Pgto, dt_pgto = @dt_pgto", conn);
                                               
                sql.Parameters.AddWithValue("@id_Contasreceber", parc.Id_contasreceber);
                sql.Parameters.AddWithValue("@id_Formapgto", parc.Id_formapgto);
                sql.Parameters.AddWithValue("@valor_Pgto", parc.Valor_pgto);
                sql.Parameters.AddWithValue("@dt_pgto", parc.Dt_pgto);
                sql.Parameters.AddWithValue("@id_Pagamento", parc.Id_pagamento);

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

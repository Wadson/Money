using Money.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.DAL
{
    internal class PagamentosDAL
    {
        public void Salvar(PagamentosModel pagamento)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "INSERT INTO Pagamentos (DespesaID, GastoID, DataPagamento, ValorPago, MetodoPgtoID) " +
                             "VALUES (@DespesaID, @GastoID, @DataPagamento, @ValorPago, @MetodoPgtoID)";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DespesaID", pagamento.DespesaID);                    
                    cmd.Parameters.AddWithValue("@DataPagamento", pagamento.DataPagamento);
                    cmd.Parameters.AddWithValue("@ValorPago", pagamento.ValorPago);
                    cmd.Parameters.AddWithValue("@MetodoPgtoID", (object)pagamento.MetodoPgtoID ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(PagamentosModel pagamento)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE Pagamentos SET DespesaID = @DespesaID, GastoID = @GastoID, " +
                             "DataPagamento = @DataPagamento, ValorPago = @ValorPago, MetodoPgtoID = @MetodoPgtoID " +
                             "WHERE PagamentoID = @PagamentoID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@PagamentoID", pagamento.PagamentoID);
                    cmd.Parameters.AddWithValue("@DespesaID", pagamento.DespesaID);
                    cmd.Parameters.AddWithValue("@GastoID", (object)pagamento.GastoID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DataPagamento", pagamento.DataPagamento);
                    cmd.Parameters.AddWithValue("@ValorPago", pagamento.ValorPago);
                    cmd.Parameters.AddWithValue("@MetodoPgtoID", (object)pagamento.MetodoPgtoID ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int pagamentoID)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "DELETE FROM Pagamentos WHERE PagamentoID = @PagamentoID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@PagamentoID", pagamentoID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<PagamentosModel> Pesquisar(int? despesaID = null)
        {
            var lista = new List<PagamentosModel>();
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "SELECT * FROM Pagamentos";
                if (despesaID.HasValue)
                    sql += " WHERE DespesaID = @DespesaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    if (despesaID.HasValue)
                        cmd.Parameters.AddWithValue("@DespesaID", despesaID.Value);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new PagamentosModel
                            {
                                PagamentoID = reader.GetInt32(0),
                                DespesaID = reader.GetInt32(1),
                                GastoID = reader.IsDBNull(2) ? null : (int?)reader.GetInt32(2),
                                DataPagamento = reader.GetDateTime(3),
                                ValorPago = reader.GetDecimal(4),
                                MetodoPgtoID = reader.IsDBNull(5) ? null : (int?)reader.GetInt32(5)
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}

using Money.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.DAL
{
    internal class ParcelasDAL
    {
        public void Salvar(ParcelasModel parcela)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "INSERT INTO Parcelas (DespesaID, NumeroParcela, ValorParcela, DataVencimento, Status) " +
                             "VALUES (@DespesaID, @NumeroParcela, @ValorParcela, @DataVencimento, @Status)";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DespesaID", parcela.DespesaID);
                    cmd.Parameters.AddWithValue("@NumeroParcela", parcela.NumeroParcela);
                    cmd.Parameters.AddWithValue("@ValorParcela", parcela.ValorParcela);
                    cmd.Parameters.AddWithValue("@DataVencimento", parcela.DataVencimento);
                    cmd.Parameters.AddWithValue("@Status", parcela.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(ParcelasModel parcela)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE Parcelas SET DespesaID = @DespesaID, NumeroParcela = @NumeroParcela, " +
                             "ValorParcela = @ValorParcela, DataVencimento = @DataVencimento, Status = @Status " +
                             "WHERE ParcelaID = @ParcelaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ParcelaID", parcela.ParcelaID);
                    cmd.Parameters.AddWithValue("@DespesaID", parcela.DespesaID);
                    cmd.Parameters.AddWithValue("@NumeroParcela", parcela.NumeroParcela);
                    cmd.Parameters.AddWithValue("@ValorParcela", parcela.ValorParcela);
                    cmd.Parameters.AddWithValue("@DataVencimento", parcela.DataVencimento);
                    cmd.Parameters.AddWithValue("@Status", parcela.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int parcelaID)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "DELETE FROM Parcelas WHERE ParcelaID = @ParcelaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ParcelaID", parcelaID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ParcelasModel> Pesquisar(int? despesaID = null)
        {
            var lista = new List<ParcelasModel>();
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "SELECT * FROM Parcelas";
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
                            lista.Add(new ParcelasModel
                            {
                                ParcelaID = reader.GetInt32(0),
                                DespesaID = reader.GetInt32(1),
                                NumeroParcela = reader.GetInt32(2),
                                ValorParcela = reader.GetDecimal(3),
                                DataVencimento = reader.GetDateTime(4),
                                Status = reader.GetString(5)
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}

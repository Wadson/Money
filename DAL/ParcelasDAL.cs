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
                string sql = "INSERT INTO Parcelas (DespesaID, NumeroParcela, ValorParcela, DataVencimento, DataPgto, Pago) " +
                             "VALUES (@DespesaID, @NumeroParcela, @ValorParcela, @DataVencimento, @DataPgto, @Pago)";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DespesaID", parcela.DespesaID);
                    cmd.Parameters.AddWithValue("@NumeroParcela", parcela.NumeroParcela);
                    cmd.Parameters.AddWithValue("@ValorParcela", parcela.ValorParcela);
                    cmd.Parameters.AddWithValue("@DataVencimento", parcela.DataVencimento);
                    cmd.Parameters.AddWithValue("@DataPgto", (object)parcela.DataPgto ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Pago", parcela.Pago ?? false);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void QuitarParcela(int parcelaID, DateTime? dataPgto = null)
        {
            if (parcelaID <= 0)
                throw new ArgumentException("ID da parcela inválido.");

            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE Parcelas SET Pago = @Pago, DataPgto = @DataPgto WHERE ParcelaID = @ParcelaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ParcelaID", parcelaID);
                    cmd.Parameters.AddWithValue("@Pago", true); // Marca como pago
                    cmd.Parameters.AddWithValue("@DataPgto", (object)(dataPgto ?? DateTime.Now) ?? DBNull.Value); // Usa data fornecida ou atual

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new InvalidOperationException($"Nenhuma parcela encontrada com o ParcelaID {parcelaID}.");
                }
            }
        }
        public void Alterar(ParcelasModel parcela)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE Parcelas SET DespesaID = @DespesaID, NumeroParcela = @NumeroParcela, " +
                             "ValorParcela = @ValorParcela, DataVencimento = @DataVencimento, DataPgto = @DataPgto, " +
                             "Pago = @Pago WHERE ParcelaID = @ParcelaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ParcelaID", parcela.ParcelaID);
                    cmd.Parameters.AddWithValue("@DespesaID", parcela.DespesaID);
                    cmd.Parameters.AddWithValue("@NumeroParcela", parcela.NumeroParcela);
                    cmd.Parameters.AddWithValue("@ValorParcela", parcela.ValorParcela);
                    cmd.Parameters.AddWithValue("@DataVencimento", parcela.DataVencimento);
                    cmd.Parameters.AddWithValue("@DataPgto", (object)parcela.DataPgto ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Pago", parcela.Pago ?? false);
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
                string sql = "SELECT ParcelaID, DespesaID, NumeroParcela, ValorParcela, DataVencimento, Pago, DataPgto FROM Parcelas";
                if (despesaID.HasValue)
                {
                    sql += " WHERE DespesaID = @DespesaID";
                }
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    if (despesaID.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@DespesaID", despesaID.Value);
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var parcela = new ParcelasModel
                            {
                                ParcelaID = reader.GetInt32(0),
                                DespesaID = reader.GetInt32(1),
                                NumeroParcela = reader.GetInt32(2),
                                ValorParcela = reader.GetDecimal(3),
                                DataVencimento = reader.GetDateTime(4),
                                Pago = reader.GetBoolean(5),
                                DataPgto = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6)
                            };
                            lista.Add(parcela);
                        }
                    }
                }
            }
            Console.WriteLine($"ParcelasDAL.Pesquisar retornou {lista.Count} registros.");
            return lista;
        }
    }
}

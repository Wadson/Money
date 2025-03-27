using Money.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.DAL
{
    internal class DespesasDAL
    {
        public void Salvar(DespesasModel despesa)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "INSERT INTO Despesas (Descricao, ValorDaCompra, DataVencimento, Status, NumeroParcelas, " +
                             "ValorParcela, CategoriaID, MetodoPgtoID, Pago, DataCriacao, DataPgto) " +
                             "VALUES (@Descricao, @ValorDaCompra, @DataVencimento, @Status, @NumeroParcelas, " +
                             "@ValorParcela, @CategoriaID, @MetodoPgtoID, @Pago, @DataCriacao, @DataPgto)";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Descricao", despesa.Descricao);
                    cmd.Parameters.AddWithValue("@ValorDaCompra", despesa.ValorDaCompra);
                    cmd.Parameters.AddWithValue("@DataVencimento", despesa.DataVencimento);
                    cmd.Parameters.AddWithValue("@Status", despesa.Status);
                    cmd.Parameters.AddWithValue("@NumeroParcelas", string.IsNullOrEmpty(despesa.NumeroParcelas) ? (object)DBNull.Value : despesa.NumeroParcelas);
                    cmd.Parameters.AddWithValue("@ValorParcela", (object)despesa.ValorParcela ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CategoriaID", (object)despesa.CategoriaID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MetodoPgtoID", (object)despesa.MetodoPgtoID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Pago", despesa.Pago);
                    cmd.Parameters.AddWithValue("@DataCriacao", despesa.DataCriacao);
                    if (despesa.DataPgto.HasValue)
                        cmd.Parameters.AddWithValue("@DataPgto", despesa.DataPgto.Value);
                    else
                        cmd.Parameters.AddWithValue("@DataPgto", DBNull.Value);

                    Console.WriteLine($"DAL - Pago: {despesa.Pago}, DataPgto: {despesa.DataPgto}");
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Atualizar(DespesasModel despesa)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE Despesas SET Descricao = @Descricao, ValorDaCompra = @ValorDaCompra, " +
                             "DataVencimento = @DataVencimento, Status = @Status, NumeroParcelas = @NumeroParcelas, " +
                             "ValorParcela = @ValorParcela, CategoriaID = @CategoriaID, MetodoPgtoID = @MetodoPgtoID, " +
                             "Pago = @Pago, DataCriacao = @DataCriacao " + // Adicionado espaço aqui
                             "WHERE DespesaID = @DespesaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Descricao", despesa.Descricao);
                    cmd.Parameters.AddWithValue("@ValorDaCompra", despesa.ValorDaCompra);
                    cmd.Parameters.AddWithValue("@DataVencimento", despesa.DataVencimento);
                    cmd.Parameters.AddWithValue("@Status", despesa.Status);                    
                    cmd.Parameters.AddWithValue("@NumeroParcelas", string.IsNullOrEmpty(despesa.NumeroParcelas) ? (object)DBNull.Value : despesa.NumeroParcelas);
                    cmd.Parameters.AddWithValue("@ValorParcela", (object)despesa.ValorParcela ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CategoriaID", (object)despesa.CategoriaID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MetodoPgtoID", (object)despesa.MetodoPgtoID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Pago", despesa.Pago);
                    cmd.Parameters.AddWithValue("@DataCriacao", despesa.DataCriacao);
                    cmd.Parameters.AddWithValue("@DespesaID", despesa.DespesaID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("Nenhum registro foi atualizado. Verifique se o DespesaID existe.");
                }
            }
        }
        public void AtualizarStatus(DespesasModel despesa)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE Despesas SET Status = @Status, Pago = @Pago, DataPgto = @DataPgto WHERE DespesaID = @DespesaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {                   
                    cmd.Parameters.AddWithValue("@Status", despesa.Status);                   
                    cmd.Parameters.AddWithValue("@Pago", despesa.Pago);
                    cmd.Parameters.AddWithValue("@DataPgto", despesa.DataPgto);
                    cmd.Parameters.AddWithValue("@DespesaID", despesa.DespesaID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("Nenhum registro foi atualizado. Verifique se o DespesaID existe.");
                }
            }
        }
        public void Excluir(int despesaId)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "DELETE FROM Despesas WHERE DespesaID = @DespesaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DespesaID", despesaId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("Nenhum registro foi excluído. Verifique se o DespesaID existe.");
                }
            }
        }

        public List<DespesasModel> Pesquisar(string descricao = null, bool? pago = null)
        {
            var lista = new List<DespesasModel>();
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = @"SELECT 
                        d.DespesaID, 
                        d.Descricao,  
                        d.ValorDaCompra,
                        d.DataVencimento, 
                        d.Status, 
                        d.NumeroParcelas, 
                        d.ValorParcela, 
                        d.CategoriaID, 
                        c.NomeCategoria AS NomeCategoria,  -- Ajustado para o nome correto
                        d.MetodoPgtoID, 
                        d.Pago, 
                        d.DataCriacao, 
                        d.DataPgto 
                      FROM Despesas d
                      LEFT JOIN Categorias c ON d.CategoriaID = c.CategoriaID";
                var conditions = new List<string>();

                // Filtro de pagamento
                if (pago.HasValue)
                {
                    conditions.Add("d.Pago = @Pago");
                }

                // Filtro de descrição
                if (!string.IsNullOrEmpty(descricao))
                {
                    conditions.Add("d.Descricao LIKE @Descricao");
                }

                // Combinar condições, se existirem
                if (conditions.Count > 0)
                {
                    sql += " WHERE " + string.Join(" AND ", conditions);
                }

                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    if (pago.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@Pago", pago.Value);
                    }
                    if (!string.IsNullOrEmpty(descricao))
                    {
                        cmd.Parameters.AddWithValue("@Descricao", "%" + descricao + "%");
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DespesasModel
                            {
                                DespesaID = reader.GetInt32(0),
                                Descricao = reader.GetString(1),
                                ValorDaCompra = reader.GetDecimal(2),
                                DataVencimento = reader.GetDateTime(3),
                                Status = reader.GetString(4),                                
                                NumeroParcelas = reader.IsDBNull(5) ? null : reader.GetValue(5).ToString(),
                                ValorParcela = reader.IsDBNull(6) ? null : (decimal?)reader.GetDecimal(6),
                                CategoriaID = reader.IsDBNull(7) ? null : (int?)reader.GetInt32(7),
                                NomeCategoria = reader.IsDBNull(8) ? null : reader.GetString(8),
                                MetodoPgtoID = reader.IsDBNull(9) ? null : (int?)reader.GetInt32(9),
                                Pago = reader.GetBoolean(10),
                                DataCriacao = reader.GetDateTime(11),
                                DataPgto = reader.IsDBNull(12) ? null : (DateTime?)reader.GetDateTime(12)
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public List<DespesasModel> PesquisarRelatorios(string descricao = null)
        {
            var lista = new List<DespesasModel>();
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "SELECT d.DespesaID, d.Descricao, d.DataVencimento, d.Status, " +
                             "d.NumeroParcelas, d.ValorParcela, d.CategoriaID, d.MetodoPgtoID, " +
                             "d.Pago, d.DataCriacao, d.DataPgto, d.ValorDaCompra, c.NomeCategoria " +
                             "FROM Despesas d LEFT JOIN Categorias c ON d.CategoriaID = c.CategoriaID";
                if (!string.IsNullOrEmpty(descricao))
                    sql += " WHERE d.Descricao LIKE @Descricao";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(descricao))
                        cmd.Parameters.AddWithValue("@Descricao", "%" + descricao + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DespesasModel
                            {
                                DespesaID = reader.GetInt32(0),       // Índice 0
                                Descricao = reader.GetString(1),      // Índice 1
                                DataVencimento = (DateTime)(reader.IsDBNull(2) ? (DateTime?)null : reader.GetDateTime(2)), // Índice 2
                                Status = reader.GetString(3),         // Índice 3
                                NumeroParcelas = reader.IsDBNull(4) ? null : reader.GetValue(4).ToString(), // Índice 4
                                ValorParcela = reader.IsDBNull(5) ? null : (decimal?)reader.GetDecimal(5), // Índice 5
                                CategoriaID = reader.IsDBNull(6) ? null : (int?)reader.GetInt32(6), // Índice 6
                                MetodoPgtoID = reader.IsDBNull(7) ? null : (int?)reader.GetInt32(7), // Índice 7
                                Pago = reader.GetBoolean(8),          // Índice 8
                                DataCriacao = reader.GetDateTime(9),  // Índice 9
                                DataPgto = reader.IsDBNull(10) ? (DateTime?)null : reader.GetDateTime(10), // Índice 10
                                ValorDaCompra = reader.IsDBNull(11) ? 0m : reader.GetDecimal(11), // Índice 11
                                NomeCategoria = reader.IsDBNull(12) ? null : reader.GetString(12) // Índice 12
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}

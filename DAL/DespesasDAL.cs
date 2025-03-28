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
                string sql = "INSERT INTO Despesas (Descricao, ValorDaCompra, CategoriaID, MetodoPgtoID, DataDaCompra) " +
                             "VALUES (@Descricao, @ValorDaCompra, @CategoriaID, @MetodoPgtoID, @DataDaCompra)";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Descricao", despesa.Descricao);
                    cmd.Parameters.AddWithValue("@ValorDaCompra", despesa.ValorDaCompra);
                    cmd.Parameters.AddWithValue("@CategoriaID", (object)despesa.CategoriaID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MetodoPgtoID", (object)despesa.MetodoPgtoID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DataDaCompra", despesa.DataDaCompra); // Usando DataCriacao como DataDaCompra
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void AtualizarDespesasEParcelas(DespesasModel despesa)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Atualizar a tabela Despesas
                        string sqlDespesa = "UPDATE Despesas SET Descricao = @Descricao, ValorDaCompra = @ValorDaCompra, " +
                                           "CategoriaID = @CategoriaID, MetodoPgtoID = @MetodoPgtoID, DataDaCompra = @DataDaCompra " +
                                           "WHERE DespesaID = @DespesaID";
                        using (var cmdDespesa = new SqlCeCommand(sqlDespesa, conn, transaction))
                        {
                            cmdDespesa.Parameters.AddWithValue("@Descricao", despesa.Descricao);
                            cmdDespesa.Parameters.AddWithValue("@ValorDaCompra", despesa.ValorDaCompra);
                            cmdDespesa.Parameters.AddWithValue("@CategoriaID", (object)despesa.CategoriaID ?? DBNull.Value);
                            cmdDespesa.Parameters.AddWithValue("@MetodoPgtoID", (object)despesa.MetodoPgtoID ?? DBNull.Value);
                            cmdDespesa.Parameters.AddWithValue("@DataDaCompra", despesa.DataDaCompra);
                            cmdDespesa.Parameters.AddWithValue("@DespesaID", despesa.DespesaID);
                            int rowsAffected = cmdDespesa.ExecuteNonQuery();
                            if (rowsAffected == 0)
                                throw new Exception("Nenhum registro foi atualizado. Verifique se o DespesaID existe.");
                        }

                        // Buscar o número de parcelas associadas
                        string sqlCountParcelas = "SELECT COUNT(*) FROM Parcelas WHERE DespesaID = @DespesaID";
                        int numeroParcelas;
                        using (var cmdCount = new SqlCeCommand(sqlCountParcelas, conn, transaction))
                        {
                            cmdCount.Parameters.AddWithValue("@DespesaID", despesa.DespesaID);
                            numeroParcelas = (int)cmdCount.ExecuteScalar();
                        }

                        if (numeroParcelas > 0)
                        {
                            // Recalcular o valor das parcelas com base no novo ValorDaCompra
                            decimal novoValorParcela = despesa.ValorDaCompra / numeroParcelas;

                            // Atualizar as parcelas na tabela Parcelas
                            string sqlParcelas = "UPDATE Parcelas SET ValorParcela = @ValorParcela " +
                                                "WHERE DespesaID = @DespesaID";
                            using (var cmdParcelas = new SqlCeCommand(sqlParcelas, conn, transaction))
                            {
                                cmdParcelas.Parameters.AddWithValue("@ValorParcela", novoValorParcela);
                                cmdParcelas.Parameters.AddWithValue("@DespesaID", despesa.DespesaID);
                                cmdParcelas.ExecuteNonQuery();
                            }
                        }

                        // Confirmar a transação
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Reverter a transação em caso de erro
                        transaction.Rollback();
                        throw new Exception($"Erro ao atualizar despesa e parcelas: {ex.Message}", ex);
                    }
                }
            }
        }
        public void Atualizar(DespesasModel despesa)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE Despesas SET Descricao = @Descricao, ValorDaCompra = @ValorDaCompra, " +
                             "CategoriaID = @CategoriaID, MetodoPgtoID = @MetodoPgtoID, DataDaCompra = @DataDaCompra " +
                             "WHERE DespesaID = @DespesaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Descricao", despesa.Descricao);
                    cmd.Parameters.AddWithValue("@ValorDaCompra", despesa.ValorDaCompra);
                    cmd.Parameters.AddWithValue("@CategoriaID", (object)despesa.CategoriaID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MetodoPgtoID", (object)despesa.MetodoPgtoID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DataDaCompra", despesa.DataDaCompra);
                    cmd.Parameters.AddWithValue("@DespesaID", despesa.DespesaID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("Nenhum registro foi atualizado. Verifique se o DespesaID existe.");
                }
            }
        }

        // O método AtualizarStatus não é mais necessário aqui, pois Pago e DataPgto estão em Parcelas
        public void AtualizarStatus(DespesasModel despesa)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE Despesas SET /* Adicione aqui o campo de status, ex: Pago = @Pago */ WHERE DespesaID = @DespesaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DespesaID", despesa.DespesaID);
                    // Se houver um campo "Pago" na tabela Despesas, adicione-o aqui
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int despesaID)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "DELETE FROM Despesas WHERE DespesaID = @DespesaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DespesaID", despesaID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ExcluirEmCascata(int despesaID)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Primeiro, excluir as parcelas associadas
                        string sqlParcelas = "DELETE FROM Parcelas WHERE DespesaID = @DespesaID";
                        using (var cmdParcelas = new SqlCeCommand(sqlParcelas, conn, transaction))
                        {
                            cmdParcelas.Parameters.AddWithValue("@DespesaID", despesaID);
                            cmdParcelas.ExecuteNonQuery();
                        }

                        // Depois, excluir a despesa
                        string sqlDespesa = "DELETE FROM Despesas WHERE DespesaID = @DespesaID";
                        using (var cmdDespesa = new SqlCeCommand(sqlDespesa, conn, transaction))
                        {
                            cmdDespesa.Parameters.AddWithValue("@DespesaID", despesaID);
                            cmdDespesa.ExecuteNonQuery();
                        }

                        // Confirmar a transação
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Reverter a transação em caso de erro
                        transaction.Rollback();
                        throw new Exception($"Erro ao excluir despesa: {ex.Message}", ex);
                    }
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
                    d.CategoriaID, 
                    c.NomeCategoria,
                    d.MetodoPgtoID, 
                    d.DataDaCompra 
                FROM Despesas d
                LEFT JOIN Categorias c ON d.CategoriaID = c.CategoriaID";

                if (!string.IsNullOrEmpty(descricao) || pago.HasValue)
                {
                    sql += " WHERE ";
                    if (!string.IsNullOrEmpty(descricao))
                        sql += "d.Descricao LIKE @Descricao";
                    if (pago.HasValue)
                    {
                        if (!string.IsNullOrEmpty(descricao)) sql += " AND ";
                        sql += "/* Adicione aqui o campo de status, ex: d.Pago = @Pago */";
                    }
                }

                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(descricao))
                        cmd.Parameters.AddWithValue("@Descricao", "%" + descricao + "%");
                    if (pago.HasValue)
                        cmd.Parameters.AddWithValue("@Pago", pago.Value);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DespesasModel
                            {
                                DespesaID = reader.GetInt32(0),
                                Descricao = reader.GetString(1),
                                ValorDaCompra = reader.IsDBNull(2) ? 0m : reader.GetDecimal(2),
                                CategoriaID = reader.IsDBNull(3) ? null : (int?)reader.GetInt32(3),
                                NomeCategoria = reader.IsDBNull(4) ? null : reader.GetString(4),
                                MetodoPgtoID = reader.IsDBNull(5) ? null : (int?)reader.GetInt32(5),
                                DataDaCompra = reader.GetDateTime(6)
                            });
                        }
                    }
                }
            }
            return lista;
        }
        public List<DespesasModel> PesquisarRelatorio()
        {
            var lista = new List<DespesasModel>();
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "SELECT d.DespesaID, d.Descricao, d.ValorDaCompra, d.DataDaCompra, " +
                             "d.CategoriaID, c.NomeCategoria, d.MetodoPgtoID " +
                             "FROM Despesas d " +
                             "LEFT JOIN Categorias c ON d.CategoriaID = c.CategoriaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var despesa = new DespesasModel
                            {
                                DespesaID = reader.GetInt32(0),
                                Descricao = reader.GetString(1),
                                ValorDaCompra = reader.GetDecimal(2),
                                DataDaCompra = reader.GetDateTime(3),
                                CategoriaID = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4),
                                NomeCategoria = reader.IsDBNull(5) ? null : reader.GetString(5),
                                MetodoPgtoID = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6)
                            };
                            lista.Add(despesa);
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
                string sql = @"
            SELECT 
                d.DespesaID, 
                d.Descricao, 
                d.ValorDaCompra, 
                d.DataDaCompra, 
                c.NomeCategoria, 
                c.CategoriaID, 
                m.MetodoPgtoID,
                m.NomeMetodoPagamento
            FROM Despesas d
            LEFT JOIN Categorias c ON d.CategoriaID = c.CategoriaID
            LEFT JOIN MetodosPagamento m ON d.MetodoPgtoID = m.MetodoPgtoID";

                if (!string.IsNullOrEmpty(descricao))
                {
                    sql += " WHERE d.Descricao LIKE @Descricao";
                }

                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(descricao))
                    {
                        cmd.Parameters.AddWithValue("@Descricao", "%" + descricao + "%");
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var despesa = new DespesasModel
                            {
                                DespesaID = reader.GetInt32(0),
                                Descricao = reader.GetString(1),
                                ValorDaCompra = reader.GetDecimal(2),
                                DataDaCompra = reader.GetDateTime(3),
                                NomeCategoria = reader.IsDBNull(4) ? "Sem categoria" : reader.GetString(4),
                                CategoriaID = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5),
                                MetodoPgtoID = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6)
                            };
                            lista.Add(despesa);
                        }
                    }
                }
            }
            Console.WriteLine($"DespesaDAL.PesquisarRelatorios retornou {lista.Count} registros.");
            return lista;
        }

        public List<DespesasModel> PesquisarRelatoriosComVencimento(string descricao = null)
        {
            var lista = new List<DespesasModel>();
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = @"
            SELECT 
                d.DespesaID, 
                d.Descricao, 
                d.ValorDaCompra, 
                d.DataDaCompra, 
                c.NomeCategoria, 
                c.CategoriaID, 
                m.MetodoPgtoID, 
                m.NomeMetodoPagamento,
                p.ParcelaID,
                p.NumeroParcela,
                p.ValorParcela,
                p.DataVencimento,
                p.DataPgto,
                p.Pago
            FROM Despesas d
            LEFT JOIN Categorias c ON d.CategoriaID = c.CategoriaID
            LEFT JOIN MetodosPagamento m ON d.MetodoPgtoID = m.MetodoPgtoID
            LEFT JOIN Parcelas p ON d.DespesaID = p.DespesaID";

                if (!string.IsNullOrEmpty(descricao))
                {
                    sql += " WHERE d.Descricao LIKE @Descricao";
                }

                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(descricao))
                    {
                        cmd.Parameters.AddWithValue("@Descricao", "%" + descricao + "%");
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        var despesasDict = new Dictionary<int, DespesasModel>();
                        while (reader.Read())
                        {
                            int despesaId = reader.GetInt32(0);
                            if (!despesasDict.ContainsKey(despesaId))
                            {
                                var despesa = new DespesasModel
                                {
                                    DespesaID = despesaId,
                                    Descricao = reader.GetString(1),
                                    ValorDaCompra = reader.GetDecimal(2),
                                    DataDaCompra = reader.GetDateTime(3),
                                    NomeCategoria = reader.IsDBNull(4) ? "Sem categoria" : reader.GetString(4),
                                    CategoriaID = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5),
                                    MetodoPgtoID = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6),
                                    Parcelas = new List<ParcelasModel>() // Garantir inicialização aqui também
                                };
                                despesasDict[despesaId] = despesa;
                            }

                            // Adicionar parcela, se existir
                            if (!reader.IsDBNull(8)) // Verifica se ParcelaID não é nulo
                            {
                                var parcela = new ParcelasModel
                                {
                                    ParcelaID = reader.GetInt32(8),
                                    DespesaID = despesaId,
                                    NumeroParcela = reader.GetInt32(9),
                                    ValorParcela = reader.GetDecimal(10),
                                    DataVencimento = reader.GetDateTime(11),
                                    DataPgto = reader.IsDBNull(12) ? (DateTime?)null : reader.GetDateTime(12),
                                    Pago = reader.GetBoolean(13)
                                };
                                despesasDict[despesaId].Parcelas.Add(parcela); // Agora Parcelas nunca será null
                            }
                        }
                        lista.AddRange(despesasDict.Values);
                    }
                }
            }
            Console.WriteLine($"DespesaDAL.PesquisarRelatoriosComVencimento retornou {lista.Count} despesas.");
            return lista;
        }
    }
}

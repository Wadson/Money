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
                string sql = "INSERT INTO Despesas (Descricao, Valor, DataVencimento, Status, NumeroParcelas, " +
                             "ValorParcela, CategoriaID, MetodoPgtoID, Pago, DataCriacao, DataPgto) " +
                             "VALUES (@Descricao, @Valor, @DataVencimento, @Status, @NumeroParcelas, " +
                             "@ValorParcela, @CategoriaID, @MetodoPgtoID, @Pago, @DataCriacao, @DataPgto)";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Descricao", despesa.Descricao);
                    cmd.Parameters.AddWithValue("@Valor", despesa.Valor);
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
                string sql = "UPDATE Despesas SET Descricao = @Descricao, Valor = @Valor, " +
                             "DataVencimento = @DataVencimento, Status = @Status, NumeroParcelas = @NumeroParcelas, " +
                             "ValorParcela = @ValorParcela, CategoriaID = @CategoriaID, MetodoPgtoID = @MetodoPgtoID, " +
                             "Pago = @Pago, DataCriacao = @DataCriacao " + // Adicionado espaço aqui
                             "WHERE DespesaID = @DespesaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Descricao", despesa.Descricao);
                    cmd.Parameters.AddWithValue("@Valor", despesa.Valor);
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
                        d.Valor, 
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
                                Valor = reader.GetDecimal(2),
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
                string sql = "SELECT d.*, c.NomeCategoria FROM Despesas d LEFT JOIN Categorias c ON d.CategoriaID = c.CategoriaID";
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
                                DespesaID = reader.GetInt32(0),
                                Descricao = reader.GetString(1),
                                Valor = reader.GetDecimal(2),
                                DataVencimento = (DateTime)(reader.IsDBNull(3) ? null : (DateTime?)reader.GetDateTime(3)), // Nullable                                
                                Status = reader.GetString(4),                                
                                
                                NumeroParcelas = reader.IsDBNull(5) ? null : reader.GetValue(5).ToString(),
                                ValorParcela = reader.IsDBNull(6) ? null : (decimal?)reader.GetDecimal(6),
                                CategoriaID = reader.IsDBNull(7) ? null : (int?)reader.GetInt32(7),
                                MetodoPgtoID = reader.IsDBNull(8) ? null : (int?)reader.GetInt32(8),
                                Pago = reader.GetBoolean(9),
                                DataCriacao = reader.GetDateTime(10),
                                DataPgto = reader.IsDBNull(11) ? null : (DateTime?)reader.GetDateTime(11),
                                NomeCategoria = reader.IsDBNull(12) ? null : reader.GetString(12)
                            });
                        }
                    }
                }
            }
            return lista;
        }

        //public List<DespesasModel> PesquisarRelatorios(string descricao = null)
        //{
        //    var lista = new List<DespesasModel>();
        //    using (var conn = Conexao.Conex())
        //    {
        //        conn.Open();
        //        string sql = "SELECT d.*, c.NomeCategoria FROM Despesas d LEFT JOIN Categorias c ON d.CategoriaID = c.CategoriaID";
        //        if (!string.IsNullOrEmpty(descricao))
        //            sql += " WHERE d.Descricao LIKE @Descricao";
        //        using (var cmd = new SqlCeCommand(sql, conn))
        //        {
        //            if (!string.IsNullOrEmpty(descricao))
        //                cmd.Parameters.AddWithValue("@Descricao", "%" + descricao + "%");
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    lista.Add(new DespesasModel
        //                    {
        //                        DespesaID = reader.GetInt32(reader.GetOrdinal("DespesaID")),
        //                        Descricao = reader.GetString(reader.GetOrdinal("Descricao")),
        //                        Valor = reader.GetDecimal(reader.GetOrdinal("Valor")),
        //                        DataVencimento = reader.GetDateTime(reader.GetOrdinal("DataVencimento")),
        //                        Status = reader.GetString(reader.GetOrdinal("Status")),
        //                        NumeroParcelas = reader.IsDBNull(reader.GetOrdinal("NumeroParcelas")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("NumeroParcelas")),
        //                        ValorParcela = reader.IsDBNull(reader.GetOrdinal("ValorParcela")) ? null : (decimal?)reader.GetDecimal(reader.GetOrdinal("ValorParcela")),
        //                        CategoriaID = reader.IsDBNull(reader.GetOrdinal("CategoriaID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("CategoriaID")),
        //                        MetodoPgtoID = reader.IsDBNull(reader.GetOrdinal("MetodoPgtoID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("MetodoPgtoID")),
        //                        Pago = reader.GetBoolean(reader.GetOrdinal("Pago")),
        //                        DataCriacao = reader.GetDateTime(reader.GetOrdinal("DataCriacao")),
        //                        DataPgto = reader.IsDBNull(reader.GetOrdinal("DataPgto")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("DataPgto")),
        //                        NomeCategoria = reader.IsDBNull(reader.GetOrdinal("NomeCategoria")) ? null : reader.GetString(reader.GetOrdinal("NomeCategoria"))
        //                    });
        //                }
        //            }
        //        }
        //    }
        //    return lista;
        //}
    }
}

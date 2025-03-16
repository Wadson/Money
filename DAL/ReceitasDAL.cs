using Money.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.DAL
{
    internal class ReceitasDAL
    {
        public void Salvar(ReceitasModel receita)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "INSERT INTO Receitas (Descricao, Valor, Data, TipoID, DataCriacao) " +
                             "VALUES (@Descricao, @Valor, @Data, @TipoID, @DataCriacao)";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Descricao", receita.Descricao);
                    cmd.Parameters.AddWithValue("@Valor", receita.Valor);
                    cmd.Parameters.AddWithValue("@Data", receita.Data);
                    cmd.Parameters.AddWithValue("@TipoID", receita.TipoID);                    
                    cmd.Parameters.AddWithValue("@DataCriacao", receita.DataCriacao);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(ReceitasModel receita)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE Receitas SET Descricao = @Descricao, Valor = @Valor, Data = @Data, " +
                             "TipoID = @TipoID, DataCriacao = @DataCriacao " +
                             "WHERE ReceitaID = @ReceitaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ReceitaID", receita.ReceitaID);
                    cmd.Parameters.AddWithValue("@Descricao", receita.Descricao);
                    cmd.Parameters.AddWithValue("@Valor", receita.Valor);
                    cmd.Parameters.AddWithValue("@Data", receita.Data);
                    cmd.Parameters.AddWithValue("@TipoID", receita.TipoID);                    
                    cmd.Parameters.AddWithValue("@DataCriacao", receita.DataCriacao);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int receitaID)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "DELETE FROM Receitas WHERE ReceitaID = @ReceitaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ReceitaID", receitaID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<TiposReceitaModel> PesquisarTipos(string nomeTipo = null)
        {
            var lista = new List<TiposReceitaModel>();
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "SELECT TipoReceitaID, NomeTipoReceita FROM TiposReceita";
                if (!string.IsNullOrEmpty(nomeTipo))
                    sql += " WHERE NomeTipoReceita LIKE @NomeTipo";

                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(nomeTipo))
                        cmd.Parameters.AddWithValue("@NomeTipo", "%" + nomeTipo + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new TiposReceitaModel
                            {
                                TipoReceitaID = reader.GetInt32(0),
                                NomeTipoReceita = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            return lista;
        }

        // Método existente para ReceitasModel
        public List<ReceitasModel> Pesquisar(string descricao = null)
        {
            var lista = new List<ReceitasModel>();
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = @"
                SELECT r.ReceitaID, r.Descricao, r.Valor, r.Data, r.TipoID, r.DataCriacao, t.NomeTipo
                FROM Receitas r
                LEFT JOIN TiposReceita t ON r.TipoID = t.TipoID";
                if (!string.IsNullOrEmpty(descricao))
                    sql += " WHERE r.Descricao LIKE @Descricao";

                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(descricao))
                        cmd.Parameters.AddWithValue("@Descricao", "%" + descricao + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ReceitasModel
                            {
                                ReceitaID = reader.GetInt32(0),
                                Descricao = reader.GetString(1),
                                Valor = reader.GetDecimal(2),
                                Data = reader.GetDateTime(3),
                                TipoID = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4),
                                DataCriacao = reader.GetDateTime(5),
                                NomeTipoReceita = reader.IsDBNull(6) ? null : reader.GetString(6)
                            });
                        }
                    }
                }
            }
            return lista;
        }

    }
}

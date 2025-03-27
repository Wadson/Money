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
                string sql = "INSERT INTO Receitas (Descricao, Valor, DataRecebimento, TipoID, DataCadastro) " +
                             "VALUES (@Descricao, @Valor, @DataRecebimento, @TipoID, @DataCadastro)";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Descricao", receita.Descricao);
                    cmd.Parameters.AddWithValue("@Valor", receita.ValorDaReceita);
                    cmd.Parameters.AddWithValue("@DataRecebimento", receita.DataRecebimento);
                    cmd.Parameters.AddWithValue("@TipoID", receita.TipoID);                    
                    cmd.Parameters.AddWithValue("@DataCadastro", receita.DataCadastro);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(ReceitasModel receita)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE Receitas SET Descricao = @Descricao, Valor = @Valor, DataRecebimento = @DataRecebimento, " +
                             "TipoID = @TipoID, DataCadastro = @DataCadastro " +
                             "WHERE ReceitaID = @ReceitaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ReceitaID", receita.ReceitaID);
                    cmd.Parameters.AddWithValue("@Descricao", receita.Descricao);
                    cmd.Parameters.AddWithValue("@Valor", receita.ValorDaReceita);
                    cmd.Parameters.AddWithValue("@DataRecebimento", receita.DataRecebimento);
                    cmd.Parameters.AddWithValue("@TipoID", receita.TipoID);                    
                    cmd.Parameters.AddWithValue("@DataCadastro", receita.DataCadastro);
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
                SELECT r.ReceitaID, r.Descricao, r.Valor, r.TipoID, t.NomeTipo, r.DataRecebimento, r.DataCadastro
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
                                ValorDaReceita = reader.GetDecimal(2),                                
                                TipoID = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3),                                
                                NomeTipoReceita = reader.IsDBNull(4) ? null : reader.GetString(4),
                                DataRecebimento = reader.GetDateTime(5),
                                DataCadastro = reader.GetDateTime(6)
                            });
                        }
                    }
                }
            }
            return lista;
        }

    }
}

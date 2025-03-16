using Money.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.DAL
{
    internal class TiposReceitaDAL
    {
        public void Salvar(TiposReceitaModel tipo)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "INSERT INTO TiposReceita (NomeTipo) VALUES (@NomeTipo)";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NomeTipo", tipo.NomeTipoReceita);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(TiposReceitaModel tipo)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE TiposReceita SET NomeTipo = @NomeTipo WHERE TipoID = @TipoID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@TipoID", tipo.TipoReceitaID);
                    cmd.Parameters.AddWithValue("@NomeTipo", tipo.NomeTipoReceita);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int tipoID)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "DELETE FROM TiposReceita WHERE TipoID = @TipoID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@TipoID", tipoID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<TiposReceitaModel> Pesquisar(string descricao = null)
        {
            var lista = new List<TiposReceitaModel>();
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = @"SELECT * FROM TiposReceita";

                if (!string.IsNullOrEmpty(descricao))
                    sql += " WHERE NomeTipo LIKE @NomeTipo";

                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(descricao))
                        cmd.Parameters.AddWithValue("@NomeTipo", "%" + descricao + "%");

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
        public TiposReceitaModel Listar(string NomeTipoReceita)
        {
            TiposReceitaModel tipo = null;
            using (var conn = Conexao.Conex())
            {
                conn.Open();                
                string sql = "SELECT TipoID, NomeTipo FROM TiposReceita WHERE NomeTipo LIKE @NomeTipo";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NomeTipo", NomeTipoReceita);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tipo = new TiposReceitaModel
                            {
                                TipoReceitaID = reader.GetInt32(0),
                                NomeTipoReceita = reader.GetString(1)
                            };
                        }
                    }
                }
            }
            return tipo; // Retorna null se não encontrar o TipoID
        }

    }
}

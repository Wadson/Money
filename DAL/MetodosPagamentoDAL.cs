using Money.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.DAL
{
    internal class MetodosPagamentoDAL
    {
        public void Salvar(MetodosPagamentoModel metodo)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "INSERT INTO MetodosPagamento (NomeMetodoPagamento) VALUES (@NomeMetodoPagamento)";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NomeMetodoPagamento", metodo.NomeMetodoPagamento);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(MetodosPagamentoModel metodo)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE MetodosPagamento SET NomeMetodoPagamento = @NomeMetodoPagamento " +
                             "WHERE MetodoPgtoID = @MetodoPgtoID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MetodoPgtoID", metodo.MetodoPgtoID);
                    cmd.Parameters.AddWithValue("@NomeMetodoPagamento", metodo.NomeMetodoPagamento);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int metodoPgtoID)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "DELETE FROM MetodosPagamento WHERE MetodoPgtoID = @MetodoPgtoID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MetodoPgtoID", metodoPgtoID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ...



        public List<MetodosPagamentoModel> PesquisarMetodoPagamento(string nomeMetodo = null)
        {
            var lista = new List<MetodosPagamentoModel>();
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "SELECT * FROM MetodosPagamento";
                if (!string.IsNullOrEmpty(nomeMetodo))
                    sql += " WHERE NomeMetodoPagamento LIKE @NomeMetodoPagamento";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(nomeMetodo))
                        cmd.Parameters.AddWithValue("@NomeMetodoPagamento", "%" + nomeMetodo + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new MetodosPagamentoModel
                            {
                                MetodoPgtoID = reader.GetInt32(0),
                                NomeMetodoPagamento = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}


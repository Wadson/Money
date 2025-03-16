using Money.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.DAL
{
    internal class CartoesCreditoDAL
    {
        public void Salvar(CartoesCreditoModel cartao)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "INSERT INTO CartoesCredito (NomeCartao, Limite, Fechamento, Vencimento, Bandeira) " +
                             "VALUES (@NomeCartao, @Limite, @Fechamento, @Vencimento, @Bandeira)";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NomeCartao", cartao.NomeCartao);
                    cmd.Parameters.AddWithValue("@Limite", cartao.Limite);
                    cmd.Parameters.AddWithValue("@Fechamento", cartao.Fechamento);
                    cmd.Parameters.AddWithValue("@Vencimento", cartao.Vencimento);
                    cmd.Parameters.AddWithValue("@Bandeira", (object)cartao.Bandeira ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(CartoesCreditoModel cartao)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE CartoesCredito SET NomeCartao = @NomeCartao, Limite = @Limite, " +
                             "Fechamento = @Fechamento, Vencimento = @Vencimento, Bandeira = @Bandeira " +
                             "WHERE CartaoID = @CartaoID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CartaoID", cartao.CartaoID);
                    cmd.Parameters.AddWithValue("@NomeCartao", cartao.NomeCartao);
                    cmd.Parameters.AddWithValue("@Limite", cartao.Limite);
                    cmd.Parameters.AddWithValue("@Fechamento", cartao.Fechamento);
                    cmd.Parameters.AddWithValue("@Vencimento", cartao.Vencimento);
                    cmd.Parameters.AddWithValue("@Bandeira", (object)cartao.Bandeira ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int cartaoID)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "DELETE FROM CartoesCredito WHERE CartaoID = @CartaoID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CartaoID", cartaoID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<CartoesCreditoModel> Pesquisar(string nomeCartao = null)
        {
            var lista = new List<CartoesCreditoModel>();
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "SELECT * FROM CartoesCredito";
                if (!string.IsNullOrEmpty(nomeCartao))
                    sql += " WHERE NomeCartao LIKE @NomeCartao";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(nomeCartao))
                        cmd.Parameters.AddWithValue("@NomeCartao", "%" + nomeCartao + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CartoesCreditoModel
                            {
                                CartaoID = reader.GetInt32(0),
                                NomeCartao = reader.GetString(1),
                                Limite = reader.GetDecimal(2),
                                Fechamento = reader.GetInt32(3),
                                Vencimento = reader.GetInt32(4),
                                Bandeira = reader.IsDBNull(5) ? null : reader.GetString(5)
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}

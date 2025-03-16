using Money.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.DAL
{
    internal class GastosCombustivelDAL
    {
        public void Salvar(GastosCombustivelModel gasto)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "INSERT INTO GastosCombustivel (Data, Valor, Litros, PrecoPorLitro, Veiculo, DataCriacao) " +
                             "VALUES (@Data, @Valor, @Litros, @PrecoPorLitro, @Veiculo, @DataCriacao)";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Data", gasto.Data);
                    cmd.Parameters.AddWithValue("@Valor", gasto.Valor);
                    cmd.Parameters.AddWithValue("@Litros", gasto.Litros);
                    cmd.Parameters.AddWithValue("@PrecoPorLitro", gasto.PrecoPorLitro);
                    cmd.Parameters.AddWithValue("@Veiculo", gasto.Veiculo);
                    cmd.Parameters.AddWithValue("@DataCriacao", gasto.DataCriacao);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(GastosCombustivelModel gasto)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE GastosCombustivel SET Data = @Data, Valor = @Valor, Litros = @Litros, " +
                             "PrecoPorLitro = @PrecoPorLitro, Veiculo = @Veiculo, DataCriacao = @DataCriacao " +
                             "WHERE GastoID = @GastoID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@GastoID", gasto.GastoID);
                    cmd.Parameters.AddWithValue("@Data", gasto.Data);
                    cmd.Parameters.AddWithValue("@Valor", gasto.Valor);
                    cmd.Parameters.AddWithValue("@Litros", gasto.Litros);
                    cmd.Parameters.AddWithValue("@PrecoPorLitro", gasto.PrecoPorLitro);
                    cmd.Parameters.AddWithValue("@Veiculo", gasto.Veiculo);
                    cmd.Parameters.AddWithValue("@DataCriacao", gasto.DataCriacao);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int gastoID)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "DELETE FROM GastosCombustivel WHERE GastoID = @GastoID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@GastoID", gastoID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<GastosCombustivelModel> Pesquisar(string veiculo = null)
        {
            var lista = new List<GastosCombustivelModel>();
            using (var conn =   Conexao.Conex())
            {
                conn.Open();
                string sql = "SELECT * FROM GastosCombustivel";
                if (!string.IsNullOrEmpty(veiculo))
                    sql += " WHERE Veiculo LIKE @Veiculo";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(veiculo))
                        cmd.Parameters.AddWithValue("@Veiculo", "%" + veiculo + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new GastosCombustivelModel
                            {
                                GastoID = reader.GetInt32(0),
                                Data = reader.GetDateTime(1),
                                Valor = reader.GetDecimal(2),
                                Litros = reader.GetDecimal(3),
                                PrecoPorLitro = reader.GetDecimal(4),
                                Veiculo = reader.GetString(5),
                                DataCriacao = reader.GetDateTime(6)
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}

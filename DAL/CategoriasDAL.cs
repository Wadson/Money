using Money.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.DAL
{
    internal class CategoriasDAL
    {
      
        public void Salvar(CategoriasModel categoria)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "INSERT INTO Categorias (NomeCategoria) VALUES (@NomeCategoria)";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NomeCategoria", categoria.NomeCategoria);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(CategoriasModel categoria)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE Categorias SET NomeCategoria = @NomeCategoria WHERE CategoriaID = @CategoriaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoriaID", categoria.CategoriaID);
                    cmd.Parameters.AddWithValue("@NomeCategoria", categoria.NomeCategoria);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int categoriaID)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "DELETE FROM Categorias WHERE CategoriaID = @CategoriaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoriaID", categoriaID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<CategoriasModel> PesquisarCategoria(string nomeCategoria = null)
        {
            var lista = new List<CategoriasModel>();
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "SELECT * FROM Categorias";
                if (!string.IsNullOrEmpty(nomeCategoria))
                    sql += " WHERE NomeCategoria LIKE @NomeCategoria";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(nomeCategoria))
                        cmd.Parameters.AddWithValue("@NomeCategoria", "%" + nomeCategoria + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CategoriasModel
                            {
                                CategoriaID = reader.GetInt32(0),
                                NomeCategoria = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}

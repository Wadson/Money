using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class CidadeDAL
    {
        public DataTable Listar_Cidades()
        {
            var conn = Conexao.Conex();
            try
            {
                conn.Open();
                SqlCommand sqlcomando = new SqlCommand("SELECT cidade.id, cidade.nome, estado.nome AS Expr1, cidade.uf AS Expr2 FROM cidade INNER JOIN estado ON cidade.uf = estado.id", conn);
                SqlDataAdapter daReceitas = new SqlDataAdapter();
                daReceitas.SelectCommand = sqlcomando;
                DataTable dtReceitas = new DataTable();
                daReceitas.Fill(dtReceitas);
                return dtReceitas;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }

        public void gravaCidades(CidadeMODEL Cidades)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sqlcomando = new SqlCommand("INSERT INTO cidade (id, nome, uf, ibge) VALUES  (@Id, @Nome, @Uf, @Ibge)", conn);

                //sqlcomando.Parameters.AddWithValue("@Idreceitas", Receitas.IdReceita);
                sqlcomando.Parameters.AddWithValue("@Id", Cidades.Id_cidade);
                sqlcomando.Parameters.AddWithValue("@Nome", Cidades.Nome_cidade);
                sqlcomando.Parameters.AddWithValue("@Uf", Cidades.Uf_cidade);
                sqlcomando.Parameters.AddWithValue("@Ibge", Cidades.Ibge);
                

                conn.Open();
                sqlcomando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void excluiCidade(CidadeMODEL Cidades)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sqlcomando = new SqlCommand("DELETE FROM cidade WHERE id = @Id", conn);
                sqlcomando.Parameters.AddWithValue("@Id", Cidades.Id_cidade);
                conn.Open();
                sqlcomando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }

        public void atualizaCidades(CidadeMODEL Cidades)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sqlcomando = new SqlCommand("UPDATE cidade SET id = @Id, nome = @Nome, ibge = @Ibge WHERE Id = @Id", conn);
                                
                sqlcomando.Parameters.AddWithValue("@Nome", Cidades.Nome_cidade);
                sqlcomando.Parameters.AddWithValue("@Uf", Cidades.Uf_cidade);
                sqlcomando.Parameters.AddWithValue("@Ibge", Cidades.Ibge);
                sqlcomando.Parameters.AddWithValue("@Id", Cidades.Id_cidade);

                conn.Open();
                sqlcomando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}

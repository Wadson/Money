using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Money
{
    class ReceitasDAL
    {
        public DataTable lista_Receitas()
        {
            var conn = Conexao.Conex();
            try
            {
                conn.Open();
                SqlCommand sqlcomando = new SqlCommand("SELECT receitas.idreceitas, receitas.datacadastro, receitas.idfornecedor, fornecedor.fornecedor, receitas.valor, receitas.descricao, receitas.competencia FROM fornecedor INNER JOIN receitas ON fornecedor.idfornecedor = receitas.idfornecedor", conn);
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

        public void gravaReceitas(ReceitasMODEL Receitas)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sqlcomando = new SqlCommand("INSERT INTO receitas ( datacadastro, idfornecedor, valor, descricao, competencia) VALUES  (@Dtcadastro, @Idfornecedor, @Valor, @Descricao, @Competencia)", conn);

                //sqlcomando.Parameters.AddWithValue("@Idreceitas", Receitas.IdReceita);
                sqlcomando.Parameters.AddWithValue("@Dtcadastro", Receitas.DataCadastro);
                sqlcomando.Parameters.AddWithValue("@Idfornecedor", Receitas.Idfornecedor);
                sqlcomando.Parameters.AddWithValue("@Valor", Receitas.Valor);
                sqlcomando.Parameters.AddWithValue("@Descricao", Receitas.Descricao);
                sqlcomando.Parameters.AddWithValue("@Competencia", Receitas.Competencia);

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

        public void excluiReceitas(ReceitasMODEL Receitas)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sqlcomando = new SqlCommand("DELETE FROM receitas WHERE idreceitas = @Idreceitas", conn);
                sqlcomando.Parameters.AddWithValue("@Idreceitas", Receitas.IdReceita);
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

        public void atualizaReceitas(ReceitasMODEL Receitas)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sqlcomando = new SqlCommand("UPDATE receitas SET idfornecedor = @Idfornecedor, valor = @Valor, descricao = @Descricao, competencia = @Competencia WHERE idreceitas = @Ideceitas", conn);

                sqlcomando.Parameters.AddWithValue("@Idfornecedor", Receitas.Idfornecedor);
                sqlcomando.Parameters.AddWithValue("@Valor", Receitas.Valor);
                sqlcomando.Parameters.AddWithValue("@Descricao", Receitas.Descricao);
                sqlcomando.Parameters.AddWithValue("@Competencia", Receitas.Competencia);
                sqlcomando.Parameters.AddWithValue("@Ideceitas", Receitas.IdReceita);

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
namespace Money
{
    class cidadeDAL
    {
        string conexao_acces = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Money\bin\Debug\bdfinance.accdb";
        OleDbConnection conexao = null;

        public DataTable lista_Cidade()
        {
            try
            {
                conexao = new OleDbConnection(conexao_acces);
                OleDbCommand sqlcomando = new OleDbCommand("SELECT * FROM cidade", conexao);
                OleDbDataAdapter daCidade = new OleDbDataAdapter();
                daCidade.SelectCommand = sqlcomando;
                DataTable dtCidade = new DataTable();
                daCidade.Fill(dtCidade);
                return dtCidade;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        // ************** G  R  A  V  A     F O  N  E  C  E  D  O  R********
        public void gravaCidade(cidadeModel Cidade)
        {

            try
            {
                conexao = new OleDbConnection(conexao_acces);
                OleDbCommand sqlcomando = new OleDbCommand("INSERT INTO cidade (idCidade, cidade, uf) VALUES (@idCidade, @cidade, @uf)", conexao);

                sqlcomando.Parameters.AddWithValue("@idCidade", Cidade.Idcidade); 
                sqlcomando.Parameters.AddWithValue("@cidade", Cidade.Cidade);
                sqlcomando.Parameters.AddWithValue("@uf", Cidade.Uf);
                              

                conexao.Open();
                sqlcomando.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                conexao.Close();
            }

        }
        // ***********E  X  C  L  U  I       F  O  R  N  E  C  E  D  O  R***
        public void excluiCidade(cidadeModel Cidade)
        {
            try
            {
                conexao = new OleDbConnection(conexao_acces);
                OleDbCommand sqlcomando = new OleDbCommand("DELETE FROM cidade WHERE idCidade = @idCidade", conexao);
                sqlcomando.Parameters.AddWithValue("@idCidade", Cidade.Idcidade);
                conexao.Open();
                sqlcomando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }
        
        public void atualizacidade(cidadeModel Cidade)
        {
            try
            {
                conexao = new OleDbConnection(conexao_acces);
                OleDbCommand sqlcomando = new OleDbCommand("UPDATE cidade SET cidade = @cidade, uf = @uf WHERE idCidade = @idCidade", conexao);

                sqlcomando.Parameters.AddWithValue("@cidade", Cidade.Cidade);
                sqlcomando.Parameters.AddWithValue("@uf", Cidade.Uf);
                sqlcomando.Parameters.AddWithValue("@idCidade", Cidade.Idcidade);
                conexao.Open();
                sqlcomando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

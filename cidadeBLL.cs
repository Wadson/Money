using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Money
{
    class cidadeBLL
    {
        cidadeDAL cidadedal = null;

        public DataTable listaCidade()
        {
            DataTable dtable = new DataTable();

            try
            {
                cidadedal = new cidadeDAL();
                dtable = cidadedal.lista_Cidade();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }
        public void gravaCidade(cidadeModel Cidade)
        {
            try
            {
                cidadedal = new cidadeDAL();
                cidadedal.gravaCidade(Cidade);
            }
            catch (OleDbException erro)
            {
                throw erro;
            }
        }

        public void excluiCidade(cidadeModel cidade)
        {
            try
            {
                cidadedal = new cidadeDAL();
                cidadedal.excluiCidade(cidade);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public void atualizaCidade(cidadeModel cidade)
        {
            try
            {
                cidadedal = new cidadeDAL();
                cidadedal.atualizacidade(cidade);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }



        public cidadeModel pesquisaCidade(string pesquisa)
        {
            string conexao_acces = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Money\bin\Debug\bdfinance.accdb";

            OleDbConnection conexao = null;
            try
            {
                conexao = new OleDbConnection(conexao_acces);
                OleDbCommand sql = new OleDbCommand("SELECT  * FROM cidade WHERE cidade LIKE '" + pesquisa + "%' ", conexao);
                conexao.Open();
                OleDbDataReader datareader;
                cidadeModel obj_cidade = new cidadeModel();

                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);
                while (datareader.Read())
                {
                    obj_cidade.Cidade = datareader["cidade"].ToString();
                    obj_cidade.Uf = datareader["uf"].ToString();                                     
                    obj_cidade.Idcidade = Convert.ToInt16(datareader["idCidade"]);
                }
                return obj_cidade;
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

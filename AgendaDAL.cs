using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
namespace Money
{
    class AgendaDAL
    {
        string conexao_acces = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Money\bin\Debug\bdfinance.accdb";
        OleDbConnection conexao = null;

        public DataTable lista_Agenda()
        {
            try
            {
                conexao = new OleDbConnection(conexao_acces);
                OleDbCommand sqlcomando = new OleDbCommand("SELECT agenda.idagenda, agenda.nome, agenda.fone, agenda.celular, agenda.endereco, agenda.email, cidade.cidade, cidade.uf FROM agenda INNER JOIN cidade ON agenda.idcidade = cidade.idCidade)", conexao);
                OleDbDataAdapter daAgenda = new OleDbDataAdapter();
                daAgenda.SelectCommand = sqlcomando;
                DataTable dtAgenda = new DataTable();
                daAgenda.Fill(dtAgenda);
                return dtAgenda;
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
        public DataTable lista_Agenda2()
        {
            try
            {
                conexao = new OleDbConnection(conexao_acces);
                OleDbCommand sqlcomando = new OleDbCommand("SELECT idagenda, nome FROM agenda", conexao);
                OleDbDataAdapter daAgenda = new OleDbDataAdapter();
                daAgenda.SelectCommand = sqlcomando;
                DataTable dtAgenda = new DataTable();
                daAgenda.Fill(dtAgenda);
                return dtAgenda;
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
        public void gravaAgenda(AgendaModel Agenda)
        {

            try
            {
                conexao = new OleDbConnection(conexao_acces);
                OleDbCommand sqlcomando = new OleDbCommand("INSERT INTO agenda (nome, fone, celular,endereco,email, idcidade) VALUES (@nome, @fone, @celular,@endereco,@email,@idcidade)", conexao);

               
                sqlcomando.Parameters.AddWithValue("@nome", Agenda.Nome);                
                sqlcomando.Parameters.AddWithValue("@fone", Agenda.Fone);
                sqlcomando.Parameters.AddWithValue("@celular", Agenda.Celular);
                sqlcomando.Parameters.AddWithValue("@endereco", Agenda.Endereco);
                sqlcomando.Parameters.AddWithValue("@email",Agenda.Email);
                sqlcomando.Parameters.AddWithValue("@idcidade", Agenda.Idcidade);                

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
      
        public void excluiAgenda(AgendaModel Agenda)
        {
            try
            {
                conexao = new OleDbConnection(conexao_acces);
                OleDbCommand sqlcomando = new OleDbCommand("DELETE FROM agenda WHERE idagenda = @idagenda", conexao);
                sqlcomando.Parameters.AddWithValue("@idagenda", Agenda.Idagenda);
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
       
        public void atualizaAgenda(AgendaModel Agenda)
        {
            try
            {
                conexao = new OleDbConnection(conexao_acces);
                OleDbCommand sqlcomando = new OleDbCommand("UPDATE agenda SET nome = @nome, fone = @fone, celular = @celular, endereco = @endereco,email = @email, idcidade = @idcidade WHERE idagenda = @idagenda", conexao);
                             
                sqlcomando.Parameters.AddWithValue("@nome", Agenda.Nome);               
                sqlcomando.Parameters.AddWithValue("@fone", Agenda.Fone);
                sqlcomando.Parameters.AddWithValue("@celular", Agenda.Celular);
                sqlcomando.Parameters.AddWithValue("@endereco", Agenda.Endereco); 
                sqlcomando.Parameters.AddWithValue("@email",Agenda.Email);
                sqlcomando.Parameters.AddWithValue("@idcidade", Agenda.Idcidade);                
                sqlcomando.Parameters.AddWithValue("@idagenda",Agenda.Idagenda);
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

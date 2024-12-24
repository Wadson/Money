using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;

namespace Money
{
    class CentroCustoDAL
    {
        public DataTable listaCentroCusto()
        {
         var conn = Conexao.Conex();

            try
            {
                SqlCeCommand comando = new SqlCeCommand("SELECT * FROM centrocusto", conn);
               
                SqlCeDataAdapter dacentrocusto = new SqlCeDataAdapter();
                dacentrocusto.SelectCommand = comando;
                DataTable dtcentrocusto = new DataTable();
                dacentrocusto.Fill(dtcentrocusto);
                return dtcentrocusto;
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
      
        public void gravaCentroCusto(CentroCustoModel Centrocusto)
        {
            var conn = Conexao.Conex();
           
            try
            {
                SqlCeCommand sqlcomm = new SqlCeCommand("INSERT INTO centrocusto (idcentrocusto, centrocusto) VALUES (@idcentrocusto, @centrocusto)", conn);  
                sqlcomm.Parameters.AddWithValue("@idcentrocusto", Centrocusto.Id_centro);
                sqlcomm.Parameters.AddWithValue("@centrocusto", Centrocusto.Centrocusto);

                conn.Open();
                sqlcomm.ExecuteNonQuery();
            }
            catch (SqlCeException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                conn.Close();
            }            
        }
        // ***********E  X  C  L  U  I         U  S  U  A  R  I  O***********************************
        public void excluiCentroCust(CentroCustoModel Centrocusto)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCeCommand sqlcomando = new SqlCeCommand("delete from centrocusto where idcentrocusto = @idcentrocusto", conn);
                sqlcomando.Parameters.AddWithValue("@idcentrocusto", Centrocusto.Id_centro);
                
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
        //********A  T  U  A  L  I  Z  A     U  S  U  A  R  I  O  *****************************************************
        public void atualizaCentrocust(CentroCustoModel Centrocusto)
        {
            var conn = Conexao.Conex();

            try
            {
                SqlCeCommand sqlcomm = new SqlCeCommand("UPDATE centrocusto SET centrocusto = @centrocusto WHERE idcentrocusto = @idcentrocusto", conn);

                sqlcomm.Parameters.AddWithValue("@centrocusto", Centrocusto.Centrocusto);
                sqlcomm.Parameters.AddWithValue("@idcentrocusto", Centrocusto.Id_centro);
                conn.Open();
                sqlcomm.ExecuteNonQuery();

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

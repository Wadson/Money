using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Money
{
    class SubsubcategoriaDAL
    {
        public DataTable ListaSubsubcategoria()
        {
         var conn = Conexao.Conex();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM subcategoria", conn);
               
                SqlDataAdapter dasubcategoria = new SqlDataAdapter();
                dasubcategoria.SelectCommand = comando;
                DataTable dtsubcategoria = new DataTable();
                dasubcategoria.Fill(dtsubcategoria);
                return dtsubcategoria;
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
      
        public void gravasubcategoria(SubCategoriaMODEL subcategoria)
        {
            var conn = Conexao.Conex();
           
            try
            {
                SqlCommand sqlcomm = new SqlCommand("INSERT INTO subcategoria (id_subcategoria, id_categoria, nome_subcategoria) VALUES (@Idsubcategoria, @Idcategoria, @subcategoria)", conn);
                sqlcomm.Parameters.AddWithValue("@Idsubcategoria", subcategoria.Idsubcategoria);
                sqlcomm.Parameters.AddWithValue("@Idcategoria", subcategoria.Idcategoria);
                sqlcomm.Parameters.AddWithValue("@subcategoria", subcategoria.Subcategoria);

                conn.Open();
                sqlcomm.ExecuteNonQuery();
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
        // ***********E  X  C  L  U  I         U  S  U  A  R  I  O***********************************
        public void excluiSubCategoria(SubCategoriaMODEL subcategoria)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sqlcomando = new SqlCommand("DELETE FROM nome_subcategoria WHERE id_subcategoria = @idsubcategoria", conn);
                sqlcomando.Parameters.AddWithValue("@idsubcategoria", subcategoria.Idsubcategoria);
                
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
        public void atualizaSubCategoria(SubCategoriaMODEL subcategoria)
        {
            var conn = Conexao.Conex();

            try
            {
                SqlCommand sqlcomm = new SqlCommand("UPDATE subcategoria SET nome_subcategoria = @subcategoria WHERE id_subcategoria = @idsubcategoria", conn);

                sqlcomm.Parameters.AddWithValue("@subcategoria", subcategoria.Subcategoria);
                sqlcomm.Parameters.AddWithValue("@idsubcategoria", subcategoria.Idsubcategoria);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Money
{
    class categoriaDAL
    {
        public DataTable listacategoria()
        {
         var conn = Conexao.Conex();

            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM categoria", conn);
               
                SqlDataAdapter dacategoria = new SqlDataAdapter();
                dacategoria.SelectCommand = comando;
                DataTable dtcategoria = new DataTable();
                dacategoria.Fill(dtcategoria);
                return dtcategoria;
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
      
        public void gravacategoria(categoriaModel categoria)
        {
            var conn = Conexao.Conex();
           
            try
            {
                SqlCommand sqlcomm = new SqlCommand("INSERT INTO categoria (id_categoria, nome_categoria) VALUES (@idcategoria, @categoria)", conn);  
                sqlcomm.Parameters.AddWithValue("@idcategoria", categoria.Idcategoria);
                sqlcomm.Parameters.AddWithValue("@categoria", categoria.Categoria);

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
        public void excluiCentroCust(categoriaModel categoria)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sqlcomando = new SqlCommand("DELETE FROM categoria WHERE id_categoria = @idcategoria", conn);
                sqlcomando.Parameters.AddWithValue("@idcategoria", categoria.Idcategoria);
                
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
        public void atualizaCentrocust(categoriaModel categoria)
        {
            var conn = Conexao.Conex();

            try
            {
                SqlCommand sqlcomm = new SqlCommand("UPDATE categoria SET nome_categoria = @categoria WHERE id_categoria = @idcategoria", conn);

                sqlcomm.Parameters.AddWithValue("@categoria", categoria.Categoria);
                sqlcomm.Parameters.AddWithValue("@idcategoria", categoria.Idcategoria);
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

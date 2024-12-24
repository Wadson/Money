using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;



namespace Money
{
    class FormaPgtoDAL
    {
        public DataTable listaFormapgto()
        {
            var conn = Conexao.Conex();
            try
            {
                conn.Open();
                SqlCommand sqlcomando = new SqlCommand("SELECT * FROM formapgto", conn);
                SqlDataAdapter daFormapgto = new SqlDataAdapter();
                daFormapgto.SelectCommand = sqlcomando;
                DataTable dtFormaPgto = new DataTable();
                daFormapgto.Fill(dtFormaPgto);
                return dtFormaPgto;
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

        public void salvaFormaPgto(FormaPgtoMODEL formapgoto)
        {
            var conn = Conexao.Conex();

            try
            {
                SqlCommand sqlcomando = new SqlCommand("INSERT INTO formapgto (id_formapgto, formapgto) VALUES  (@id_FormaPgto, @Formapgto)", conn);

                sqlcomando.Parameters.AddWithValue("@id_FormaPgto", formapgoto.Id_formapgto);
                sqlcomando.Parameters.AddWithValue("@Formapgto", formapgoto.Formapgto);              

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

        public void ExcluiFormaPgto(FormaPgtoMODEL formapgto)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sqlcomando = new SqlCommand("DELETE FROM formapgto WHERE id_formapgto = @id_Formapgto", conn);
                sqlcomando.Parameters.AddWithValue("@id_Formapgto", formapgto.Id_formapgto);
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

        public void AtualizaFormaPgto(FormaPgtoMODEL formapgto)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sqlcomando = new SqlCommand("UPDATE formapgto SET formapgto = @Formapgto WHERE id_formapgto = @id_Formapgto", conn);

                sqlcomando.Parameters.AddWithValue("@Formapgto", formapgto.Formapgto);
                sqlcomando.Parameters.AddWithValue("@id_Formapgto", formapgto.Id_formapgto);              

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

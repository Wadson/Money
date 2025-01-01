using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Money
{
    class categoriaBLL
    {
        categoriaDAL categoriaDAL = null;
       
        public DataTable lista_Centro_Custo()
        {
            DataTable dtable = new DataTable();
            try
            {

                categoriaDAL = new categoriaDAL();
                dtable = categoriaDAL.listacategoria();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }


        public void Salvar(categoriaModel categoria)
        {           
            try
            {
                categoriaDAL = new categoriaDAL();
                categoriaDAL.gravacategoria(categoria);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Excluir(categoriaModel categoria)
        {
            try
            {
                categoriaDAL = new categoriaDAL();
                categoriaDAL.excluiCentroCust(categoria);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public void Alterar(categoriaModel categoria)
        {
            try
            {
                categoriaDAL = new categoriaDAL();
                categoriaDAL.atualizaCentrocust(categoria);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
      
        public categoriaModel pesquisacategoria(string pesquisa)
        {
            var conn = Conexao.Conex();
            try
            {   
                SqlCommand sql = new SqlCommand("select * from usuario where usuario like '" + pesquisa + "%'", conn);
                conn.Open();
                SqlDataReader datareader;
                categoriaModel objetocategoria = new categoriaModel();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                while (datareader.Read())
                {

                    objetocategoria.Idcategoria = Convert.ToInt32(datareader["idcategoria"]);
                    objetocategoria.Categoria = datareader["categoria"].ToString();


                }
                return objetocategoria;
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

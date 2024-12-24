using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Money
{
    class SubsubCategoriaBLL
    {
        SubsubcategoriaDAL SubCategoriaDAL = null;

        public DataTable listaSubsubCategoria()
        {
            DataTable dtable = new DataTable();
            try
            {

                SubCategoriaDAL = new SubsubcategoriaDAL();
                dtable = SubCategoriaDAL.ListaSubsubcategoria();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }


        public void Salvar(SubCategoriaMODEL subCategoria)
        {
            try
            {
                SubCategoriaDAL = new SubsubcategoriaDAL();
                SubCategoriaDAL.gravasubcategoria(subCategoria);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Excluir(SubCategoriaMODEL subCategoria)
        {
            try
            {
                SubCategoriaDAL = new SubsubcategoriaDAL();
                SubCategoriaDAL.excluiSubCategoria(subCategoria);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public void Alterar(SubCategoriaMODEL subCategoria)
        {
            try
            {
                SubCategoriaDAL = new SubsubcategoriaDAL();
                SubCategoriaDAL.atualizaSubCategoria(subCategoria);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public SubCategoriaMODEL pesquisasubCategoria(string pesquisa)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("select * from subcategoria where subcategoria like '" + pesquisa + "%'", conn);
                conn.Open();
                SqlDataReader datareader;
                SubCategoriaMODEL objetosubCategoria = new SubCategoriaMODEL();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                while (datareader.Read())
                {

                    objetosubCategoria.Idcategoria = Convert.ToInt32(datareader["idsubcategoria"]);
                    objetosubCategoria.Subcategoria = datareader["subcategoria"].ToString();


                }
                return objetosubCategoria;
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

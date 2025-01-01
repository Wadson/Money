using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class CidadeBLL
    {
        CidadeDAL CidadeDal = null;
        // ************************LISTA USUARIO*********************************************
        public DataTable ListarCidades()
        {
            DataTable dtable = new DataTable();
            try
            {
                CidadeDal = new CidadeDAL();
                dtable = CidadeDal.Listar_Cidades();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }

        public void GravarCidade(CidadeMODEL cidades)
        {
            try
            {
                CidadeDal = new CidadeDAL();
                CidadeDal.gravaCidades(cidades);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluiUsuarioDal(CidadeMODEL cidades)
        {
            try
            {
                CidadeDal = new CidadeDAL();
                CidadeDal.excluiCidade(cidades);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void atualizaUsuarioDal(CidadeMODEL cidades)
        {
            try
            {
                CidadeDal = new CidadeDAL();
                CidadeDal.atualizaCidades(cidades);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        

        public CidadeMODEL PesquisaCidade(string pesquisa)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM cidade WHERE nome like '" + pesquisa + "%'", conn);
                conn.Open();
                SqlDataReader datareader;
                CidadeMODEL obj_cidade = new CidadeMODEL();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                while (datareader.Read())
                {
                    obj_cidade.Id_cidade = Convert.ToInt32(datareader["id"]);
                    obj_cidade.Nome_cidade = datareader["nome"].ToString();                   
                }
                return obj_cidade;
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

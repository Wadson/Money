using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;

namespace Money
{
    class CentroCustoBLL
    {
        CentroCustoDAL CentroCustoDAL = null;
       
        public DataTable lista_Centro_Custo()
        {
            DataTable dtable = new DataTable();
            try
            {

                CentroCustoDAL = new CentroCustoDAL();
                dtable = CentroCustoDAL.listaCentroCusto();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }


        public void Salvar(CentroCustoModel centrocusto)
        {           
            try
            {
                CentroCustoDAL = new CentroCustoDAL();
                CentroCustoDAL.gravaCentroCusto(centrocusto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Excluir(CentroCustoModel centrocusto)
        {
            try
            {
                CentroCustoDAL = new CentroCustoDAL();
                CentroCustoDAL.excluiCentroCust(centrocusto);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public void Alterar(CentroCustoModel centrocusto)
        {
            try
            {
                CentroCustoDAL = new CentroCustoDAL();
                CentroCustoDAL.atualizaCentrocust(centrocusto);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
      
        public CentroCustoModel pesquisaCentroCusto(string pesquisa)
        {
            var conn = Conexao.Conex();
            try
            {   
                SqlCeCommand sql = new SqlCeCommand("select * from usuario where usuario like '" + pesquisa + "%'", conn);
                conn.Open();
                SqlCeDataReader datareader;
                CentroCustoModel objetocentrocusto = new CentroCustoModel();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                while (datareader.Read())
                {

                    objetocentrocusto.Id_centro = Convert.ToInt32(datareader["idcentro"]);
                    objetocentrocusto.Centrocusto = datareader["centro_custo"].ToString();


                }
                return objetocentrocusto;
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

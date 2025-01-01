using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class ItensVendaBLL
    {
        ItensVendaDAL itensvendasdall = null;
        // ************************LISTA USUARIO*********************************************
        public DataTable listaItensVendas()
        {
            DataTable dtable = new DataTable();
            try
            {
                itensvendasdall = new ItensVendaDAL();
                dtable = itensvendasdall.listaItensVenda();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }

        public void SalvarItensVenda(ItensVendaMODEL itensvenda)
        {            
            try
            {
                itensvendasdall = new ItensVendaDAL();
                itensvendasdall.SalvarItensVenda(itensvenda);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void ExcluirItensVenda(ItensVendaMODEL itensvenda)
        {
            try
            {
                itensvendasdall = new ItensVendaDAL();
                itensvendasdall.excluirItensVenda(itensvenda);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void AtualizaItensVenda(ItensVendaMODEL itensvenda)
        {
            try
            {
                itensvendasdall = new ItensVendaDAL();
                itensvendasdall.atualizaItensVenda(itensvenda);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }       

        public ItensVendaMODEL pesquisaItensVenda(string pesquisa)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM itensvenda WHERE id_itensvenda like '" + pesquisa + "%'", conn);
                conn.Open();
                SqlDataReader datareader;
                ItensVendaMODEL obj_Itensvenda = new ItensVendaMODEL();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                while (datareader.Read())
                {

                    obj_Itensvenda.Id_itensvenda = Convert.ToInt32(datareader["id_usuario"]);
                }
                return obj_Itensvenda;
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

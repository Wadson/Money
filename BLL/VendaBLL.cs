using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class VendaBLL
    {
        VendaDAL vendaDALL = null;
        public void SalvarVenda(VendaMODEL vendas)
        {
            vendaDALL = new VendaDAL();
            vendaDALL.SalvarVenda(vendas);
            try
            {
               
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public void ExcluirVenda(VendaMODEL vendas)
        {
            try
            {
                vendaDALL = new VendaDAL();
                vendaDALL.excluirVenda(vendas);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public void Alterar(VendaMODEL vendas)
        {
            try
            {
                vendaDALL = new VendaDAL();
                vendaDALL.atualizaVenda(vendas);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        
    }
}

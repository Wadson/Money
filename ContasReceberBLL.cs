using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Money
{
    internal class ContasReceberBLL
    {
        ContasReceberDAL contasreceberDALL = null;


        public DataTable ListarContasReceber()
        {
            DataTable dtable = new DataTable();

            contasreceberDALL = new ContasReceberDAL();
            dtable = contasreceberDALL.lista_contas_receber();
            try
            {
                
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }
        //*********************************************************************************************
        public DataTable lListarContasReceber_Opcional(ContasReceberMODEL contas)
        {
            DataTable dtable = new DataTable();
            try
            {
                contasreceberDALL = new ContasReceberDAL();
                dtable = contasreceberDALL.lista_contas_receber();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }
        //*********************************************************************************************
        public void GravaContasReceberDal(ContasReceberMODEL controle)
        {
            try
            {
                contasreceberDALL = new ContasReceberDAL();
                contasreceberDALL.salvarcontasreceber(controle);
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }
        //***********************************************************************************************
        public void exclui_ContaReceber(ContasReceberMODEL contas)
        {
            try
            {
                contasreceberDALL = new ContasReceberDAL();
                contasreceberDALL.excluicontasreceber(contas);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //*************************************************************************************************
        public void atualiza_contaS(ContasReceberMODEL contas)
        {
            try
            {
                contasreceberDALL = new ContasReceberDAL();
                contasreceberDALL.atualiza_contasreceber(contas);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        //************************************************************************************************
        public void atualiza_conta2(ContasReceberMODEL contas)
        {
            try
            {
                //contasreceberDALL = new ContasDAL();
                //contasreceberDALL.atualiza_contas(contas);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //************************************************************************************************
        public void darBaixaContaDal(ContasReceberMODEL baixaconta)
        {
            try
            {
                //contasreceberDALL = new ContasDAL();
                //contasreceberDALL(baixaconta);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        //************************************************************************************************
        public void PagarContasDal(ContasReceberMODEL controle)
        {
            try
            {
                //contasreceberDALL = new ContasReceberDAL();
                //contasreceberDALL.darBaixaConta(controle);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Money
{
    class ContasBLL
    {
        ContasDAL controledal = null;
         

        public DataTable lista_Controle_dal()
        {
            DataTable dtable = new DataTable();
            try
            {
                controledal = new ContasDAL();
                dtable = controledal.lista_controle();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }
        //*********************************************************************************************
        public DataTable lista_Controle_dalOpcional()
        {
            DataTable dtable = new DataTable();
            try
            {
                controledal = new ContasDAL();
                dtable = controledal.lista_controleOpcional();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }
        //*********************************************************************************************
        public void gravaContasDal(ContasMODEL controle)
        {
            try
            {
                controledal = new ContasDAL();
                controledal.SalvarConta(controle);
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }
        //***********************************************************************************************
        public void exclui_Conta(ContasMODEL contas)
        {
            try
            {
                controledal = new ContasDAL();
                controledal.excluiConta(contas);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
       
        //*************************************************************************************************
        public void atualiza_contaS(ContasMODEL contas)
        {
            try
            {
                controledal = new ContasDAL();
                controledal.atualiza_contas(contas);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        //************************************************************************************************
        public void atualiza_conta2(ContasMODEL contas)
        {
            try
            {
                controledal = new ContasDAL();
                controledal.atualiza_contas(contas);
            }
            catch (Exception erro)
            {
                throw erro;
            }          
        }

        //************************************************************************************************
        public void darBaixaContaDal(ContasMODEL baixaconta)
        {
            try
            {
                controledal = new ContasDAL();
                controledal.darBaixaConta(baixaconta);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        //************************************************************************************************
        public void PagarContasDal(ContasMODEL controle)
        {
            try
            {
                controledal = new ContasDAL();
                controledal.darBaixaConta(controle);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
       

       
    }
}

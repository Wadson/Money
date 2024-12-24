using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;


namespace Money
{
    class FormaPgtoBLL
    {
        FormaPgtoDAL FormaPgtoDAL = null;

        public DataTable ListaFormaPgto()
        {
            DataTable dtable = new DataTable();
            try
            {
                FormaPgtoDAL = new FormaPgtoDAL();
                dtable = FormaPgtoDAL.listaFormapgto();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }


        public void Salvar(FormaPgtoMODEL formapgto)
        {
            try
            {
                FormaPgtoDAL = new FormaPgtoDAL();
                FormaPgtoDAL.salvaFormaPgto(formapgto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Excluir(FormaPgtoMODEL formapgto)
        {
            try
            {
                FormaPgtoDAL = new FormaPgtoDAL();
                FormaPgtoDAL.ExcluiFormaPgto(formapgto);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }


        public void Alterar(FormaPgtoMODEL formapgto)
        {
            try
            {
                FormaPgtoDAL = new FormaPgtoDAL();
                FormaPgtoDAL.AtualizaFormaPgto(formapgto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }        
    }
}
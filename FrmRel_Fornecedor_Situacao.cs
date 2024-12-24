using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmRel_Fornecedor_Situacao : FrmBaseGeral
    {
         Boolean Situacao {get;set;}

        public FrmRel_Fornecedor_Situacao()
        {
            InitializeComponent();
        }

        private void Frm_Rel_Fornecedor_Periodo_Load(object sender, EventArgs e)
        {
            preencherComboBoxT(cmb_Forn, "SELECT idfornecedor,fornecedor FROM fornecedor", "idfornecedor", "fornecedor");
            // TODO: This line of code loads data into the 'bdfinancaDataSet.Fornecedor_e_Situacao' table. You can move, or remove it, as needed.
            Fornecedor = cmb_Forn.Text;
            
            this.Fornecedor_e_SituacaoTableAdapter.Fill_Fornecedor_Situacao(this.bdfinancaDataSet.Fornecedor_e_Situacao,Convert.ToBoolean(Situacao), Fornecedor);

            this.reportViewer1.RefreshReport();
        }
        public override void preencherComboBoxT(ComboBox combo, string querY, string id, string nome)
        {
            base.preencherComboBoxT(combo, querY, id, nome);
        }
       
        private void Frm_Rel_Fornecedor_Situacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Boolean situacao;
            Fornecedor = cmb_Forn.Text;


            if (rb_nao_pagos.Checked == true)
            {
                situacao = false;
                Status = "Não Pago";
            }
            else
            {
                situacao = true;
                Status = "Sim";
            }

            
            this.Fornecedor_e_SituacaoTableAdapter.Fill_Fornecedor_Situacao(this.bdfinancaDataSet.Fornecedor_e_Situacao, Convert.ToBoolean(situacao),Fornecedor);

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Status", Status));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Fornecedor", Fornecedor));          

            this.reportViewer1.RefreshReport();
        }
    }
}

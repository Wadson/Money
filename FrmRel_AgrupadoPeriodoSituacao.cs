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
    public partial class FrmRel_AgrupadoPeriodoSituacao : Form
    {
        DateTime datainicial, datafinal; Boolean situacao;
        public string Status;

        public FrmRel_AgrupadoPeriodoSituacao()
        {
            InitializeComponent();
           
        }
          


        private void FrmRel_AgrupadoPeriodoSituacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdfinancaDataSet.AgrupadoPeriodoSituacao' table. You can move, or remove it, as needed.
            //this.AgrupadoPeriodoSituacaoTableAdapter.Fill_AgrupadoPeriodoSituacao(this.bdfinancaDataSet.AgrupadoPeriodoSituacao, Convert.ToDateTime(datainicial), Convert.ToDateTime(datafinal), Convert.ToBoolean(situacao));
            //this.reportViewer1.RefreshReport();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            datainicial = Convert.ToDateTime(dt_Inicial.Text);
            datafinal = Convert.ToDateTime(dt_Final.Text);

            if (rb_nao_pagos.Checked == true)
            {
                situacao = false;
                Status = "Pago";
            }
            else
            {
                situacao = true;
                Status = "Não Pago";
            }
             this.AgrupadoPeriodoSituacaoTableAdapter.Fill_AgrupadoPeriodoSituacao(this.bdfinancaDataSet.AgrupadoPeriodoSituacao, Convert.ToDateTime(datainicial), Convert.ToDateTime(datafinal), Convert.ToBoolean(situacao));

             //DataFinalR 
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataInicialR", datainicial.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataFinalR", datafinal.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("SituacaoR", Status));

             this.reportViewer1.RefreshReport();

        }
    }
}

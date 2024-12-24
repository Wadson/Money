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
    public partial class FrmRelAgrupadoFormaPgtoSituacao : Form
    {
        DateTime datainicial, datafinal; Boolean situacao;
        public string Status;


        public FrmRelAgrupadoFormaPgtoSituacao()
        {
            InitializeComponent();
        }

        private void FrmRelAgrupadoFormaPgtoSituacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdfinancaDataSet.AgrupagoFormaPgtoSituacaoPeriodo' table. You can move, or remove it, as needed.
            //this.AgrupagoFormaPgtoSituacaoPeriodoTableAdapter.FillFormaPgto(this.bdfinancaDataSet.AgrupagoFormaPgtoSituacaoPeriodo);

            //this.reportViewer1.RefreshReport();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            datainicial = Convert.ToDateTime(dt_Inicial.Text);
            datafinal = Convert.ToDateTime(dt_Final.Text);

            if (rb_nao_pagos.Checked == true)
            {
                situacao = false;
                Status = "Não Pago";
            }
            else
            {
                situacao = true;
                Status = "Pago";
            }
            this.AgrupagoFormaPgtoSituacaoPeriodoTableAdapter.FillFormaPgto(this.bdfinancaDataSet.AgrupagoFormaPgtoSituacaoPeriodo, Convert.ToDateTime(datainicial), Convert.ToDateTime(datafinal), Convert.ToBoolean(situacao));

            //DataFinalR 
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DtInicial", datainicial.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DtFinal", datafinal.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Situac", Status));

            this.reportViewer1.RefreshReport();
        }
    }
}

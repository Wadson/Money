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
    public partial class FrmRel_Periodo_e_Situacao : Form
    {


         public DateTime datainicial, datafinal; Boolean situacao;
       

        public FrmRel_Periodo_e_Situacao()
        {
            InitializeComponent();
        }

        private void Frm_Rel_Periodo_e_Situacao_Load(object sender, EventArgs e)
        {
            if (rb_nao_pagos.Checked == true)
            {
                situacao = false;
            }
            else
                situacao = true;

            datainicial = Convert.ToDateTime(dt_Inicial.Text);
            datafinal = Convert.ToDateTime(dt_Final.Text);
            // TODO: This line of code loads data into the 'bdfinancaDataSet.PeriodoSituacao' table. You can move, or remove it, as needed.
            this.PeriodoSituacaoTableAdapter.FillPeriodoSituacao(this.bdfinancaDataSet.PeriodoSituacao, Convert.ToDateTime(datainicial), Convert.ToDateTime(datafinal),Convert.ToBoolean(situacao));

            this.reportViewer1.RefreshReport();
        }

        private void Frm_Rel_Periodo_e_Situacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.Dispose();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Boolean situacao;

            datainicial = Convert.ToDateTime(dt_Inicial.Text);
            datafinal = Convert.ToDateTime(dt_Final.Text);

            if (rb_nao_pagos.Checked == true)
            {
                situacao = false;
            }
            else
                situacao = true;

            this.PeriodoSituacaoTableAdapter.FillPeriodoSituacao(this.bdfinancaDataSet.PeriodoSituacao, Convert.ToDateTime(dt_Inicial.Text), Convert.ToDateTime(dt_Final.Text), Convert.ToBoolean(situacao));

            this.reportViewer1.RefreshReport();


        }
    }
}

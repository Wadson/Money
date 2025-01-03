using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmParcelamento : Money.FrmBaseGeral
    {
        public FrmParcelamento()
        {
            InitializeComponent();
        }
        int dias;
        private void GerarParcelas()
        {
            Id_Parcela = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryParcela).ToString());

            dias = Convert.ToInt32(txtDias.Value);
            /*IMPLEMENTADO DIA 18/12/2024 AS 20:34*/
            Cliente = txtNomeCliente.Text;

            Parcelas = Convert.ToInt32(txtQtdParcelas.Value);
            ValorTotal = Convert.ToDecimal(txtTotal.Text);
            Dt_Vcto_Parc = Convert.ToDateTime(dtPrimeiraParc.Text);
            ValorParc = ValorTotal / Parcelas;
            IdFormaPgto = IdFormaPgto;
            
            
            DataTable dt = new DataTable();

            dt.Columns.Add("id_parcela", typeof(int));
            dt.Columns.Add("valor_parcela", typeof(Decimal));
            dt.Columns.Add("num_parcela", typeof(int));
            dt.Columns.Add("dt_vcto_parcela", typeof(DateTime));
            dt.Columns.Add("id_venda", typeof(int));

            for (var i = 0; i < Parcelas; i++)
            {
                dt.Rows.Add(Id_Parcela++, ValorParc, (i + 1), Dt_Vcto_Parc.AddDays((i) * dias), txtIdVenda.Text);
            }
            if (Convert.ToString(IDCliente) != string.Empty)
            {
                dataGrid_Parcelas.DataSource = dt; //implementado dia 13/05/2017 as 21:29 por Wadson R. Lima              
            }           
        }

        private void txtQtdParcelas_ValueChanged(object sender, EventArgs e)
        {
            GerarParcelas();
        }
    }
}

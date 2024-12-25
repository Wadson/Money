using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmGerarParcelas : FrmBaseGeral
    {
        public FrmGerarParcelas()
        {
            InitializeComponent();
        }
        int dias;
        private void FrmGerarParcelas_Load(object sender, EventArgs e)
        {
        }
        private void GerarParcelas()
        {
            Id_Parcela = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryParcela).ToString());
            
            if (Convert.ToString(IDCliente) != string.Empty)
            {
                if (checkBoxIntervaloEntreParc.Checked == true)
                {
                    dias = Convert.ToInt32(txtDias.Text);
                }
                else
                {
                    dias = 30;
                    /*IMPLEMENTADO DIA 18/12/2024 AS 20:34*/                    
                    Cliente = txtNomeCliente.Text;
                    Parcelas = Convert.ToInt32(txtQtdParcelas.Value);
                }
                try
                {                   
                    ValorTotal = Convert.ToDecimal(txtTotal.Text);
                    Dt_Vcto_Parc = Convert.ToDateTime(dtPrimeiraParc.Text);
                    ValorParc = ValorTotal / Parcelas;                    
                    IdFormaPgto = IdFormaPgto;
                }
                catch
                {
                }
                DataTable dt = new DataTable();

                dt.Columns.Add("id_parcela", typeof(int));
                dt.Columns.Add("valor_parcela", typeof(Decimal));
                dt.Columns.Add("num_parcela", typeof(int));
                dt.Columns.Add("dt_vcto_parcela", typeof(DateTime));
                dt.Columns.Add("id_venda", typeof(int));

                for (var i = 0; i < Parcelas; i++)
                {
                    if (checkBoxIntervaloEntreParc.Checked == false)
                    {
                        dt.Rows.Add(Id_Parcela++, ValorParc, (i + 1), Dt_Vcto_Parc.AddMonths(i), txtIdVenda.Text);
                    }
                    if (checkBoxIntervaloEntreParc.Checked == true)
                    {
                        dt.Rows.Add(Id_Parcela++, ValorParc, (i + 1), Dt_Vcto_Parc.AddDays((i) * dias), txtIdVenda.Text);
                    }
                }
                //dataGrid_Parcelas.DataSource = dt; //implementado dia 13/05/2017 as 21:29 por Wadson R. Lima              

            }
            if (dataGrid_Parcelas.RowCount != 0)
            {
                foreach (DataGridViewRow row in dataGrid_Parcelas.Rows)
                {
                    row.Height = 15;
                }
            }
        }
        private void txtQtdParcelas_ValueChanged(object sender, EventArgs e)
        {
            GerarParcelas();
        }
        private void btnGerarParcelas_Click(object sender, EventArgs e)
        {
            GerarParcelas();
        }
        public void SalvarParcelas()
        {
            Id_Venda = RetornaUltimoCodigoCadastrado(QueryVendas);
            
            ParcelaModel objoParcela = new ParcelaModel();

            try
            {
                objoParcela.Idparcela = Convert.ToInt32(dataGrid_Parcelas.CurrentRow.Cells["id_parcela"].Value);
                objoParcela.Valor_parc = Convert.ToDecimal(dataGrid_Parcelas.CurrentRow.Cells["valor_parcela"].Value);
                objoParcela.Numparcela = Convert.ToInt32(dataGrid_Parcelas.CurrentRow.Cells["num_parcela"].Value);
                objoParcela.Datavenc = Convert.ToDateTime(dataGrid_Parcelas.CurrentRow.Cells["dt_vcto_parcela"].Value);
                objoParcela.IdVenda = Id_Venda;//Convert.ToInt32(dataGrid_Parcelas.CurrentRow.Cells[4].Value);

                ParcelaBLL parcela_bll = new ParcelaBLL();
                parcela_bll.Salvar_Parcelas(objoParcela);

                MessageBox.Show("Parcelas gravadas com sucesso!", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao gravar O REGISTRO!!! " + erro);
            }
        }
        private void checkBoxIntervaloEntreParc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIntervaloEntreParc.Checked == true)
            {
                txtDias.Enabled = true;
            }
            if (checkBoxIntervaloEntreParc.Checked == false)
            {
                txtDias.Enabled = false;
                txtDias.Value = 1;
            }
        }
        public void SalvarContasReceber()
        {
            Id_Parcela = RetornaUltimoCodigoCadastrado(QueryParcela);

            ContasReceberMODEL objoContaReceber = new ContasReceberMODEL();

            try
            {
                if (String.IsNullOrEmpty(Convert.ToString(Id_ContasReceber)) && String.IsNullOrEmpty(Convert.ToString(Id_Parcela)) && String.IsNullOrEmpty(Convert.ToString(IdFormaPgto)))
                {
                    MessageBox.Show("Informação!!", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    objoContaReceber.Id_contasreceber = Id_ContasReceber;
                    objoContaReceber.Id_parcela = Id_Parcela; //Convert.ToInt32(dataGrid_Parcelas.CurrentRow.Cells[0].Value);
                    objoContaReceber.Valor_parcela = ValorParc;
                    objoContaReceber.Id_formapgto = IdFormaPgto;
                    objoContaReceber.Status_conta = false;

                    ContasReceberBLL parcela_bll = new ContasReceberBLL();
                    parcela_bll.GravaContasReceberDal(objoContaReceber);

                    MessageBox.Show("Contas a Receber gravadas com sucesso!", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    dataGrid_Parcelas.DataSource = null;
                    LimpaCampo();
                    this.Close();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não tem nenhum item na grid para salvar!!"+erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarParcelas();
            SalvarContasReceber();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmCadParcelar : Money.FrmBaseGeral
    {
        public FrmCadParcelar()
        {
            InitializeComponent();
        }
        double dias;
        private void FrmParcelar_Load(object sender, EventArgs e)
        {
            preencherComboBoxT(cmbForma_Pgto, "SELECT idformapgto, formapgto FROM formapgto", "idformapgto", "formapgto");

            if (txtValorTotal.Text != string.Empty)
            {
                ValorParc = Convert.ToDecimal(txtValorTotal.Text);
                txtValorTotal.Text = ValorParc.ToString("N");
            }          
        }

        private void GerarParcelas()
        {
            Id_Parcela = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryParcela).ToString());
            Id_Venda = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryContas));

            if (Convert.ToString(IdFornecedor) != string.Empty)
            {
                if (checkBoxIntervaloEntreParc.Checked == true)
                {
                    dias = Convert.ToDouble(txtDias.Text);
                }
                else
                    dias = 30;

                Fornecedor = txtFornecedorCad.Text;
                Parcelas = Convert.ToInt32(txtQtdParcelas.Value);
             

                try
                {
                    ValorTotal = Convert.ToDecimal(txtValorTotal.Text) - Convert.ToDecimal(txtDesconto.Text); 

                    Dt_Vcto_Parc = Convert.ToDateTime(dtPrimeiraParc.Text);
                  
                    ValorParc = ValorTotal / Parcelas;
                 
                    FormaPgto = cmbForma_Pgto.Text;
                    Idcategoria = Idcategoria;
                    IdFormaPgto = IdFormaPgto;
                }
                catch
                {
                }
                DataTable dt = new DataTable();

                dt.Columns.Add("idparcela", typeof(int));
                dt.Columns.Add("idconta", typeof(int));
                dt.Columns.Add("num_parcela");
                dt.Columns.Add("fornecedor");
                dt.Columns.Add("descricao");
                dt.Columns.Add("datavenc", typeof(DateTime));
                dt.Columns.Add("valor_parc", typeof(Decimal));
                dt.Columns.Add("categoria");
                dt.Columns.Add("formapgto");
                dt.Columns.Add("idformapgto");

                for (var i = 0; i < Parcelas; i++)
                {
                    if (checkBoxIntervaloEntreParc.Checked == false)
                    {
                        //dt.Rows.Add(IdParcela++, IdConta, (i + 1 + " / " + Parcelas), Fornecedor, Descricaoo, Vencimento.AddMonths(i), ValorParc, categoria, FormaPgto, IdFormaPgto);
                        //dt.Rows.Add(IdParcela++, IdConta, (i + 1), Fornecedor, Descricaoo, Vencimento.AddMonths(i), ValorParc, categoria, FormaPgto, IdFormaPgto);
                        dt.Rows.Add(Id_Parcela++, Id_Venda, (i + 1 + " / " + Parcelas), Fornecedor, Descricao, Dt_Vcto_Parc.AddMonths(i), ValorParc, categoria, FormaPgto, IdFormaPgto);
                    }
                    if (checkBoxIntervaloEntreParc.Checked == true)
                    {
                        //dt.Rows.Add(IdParcela++, IdConta, (i + 1 + " / " + Parcelas), Fornecedor, Descricaoo, Vencimento.AddDays((i) * dias), ValorParc, categoria, FormaPgto,IdFormaPgto);
                        dt.Rows.Add(Id_Parcela++, Id_Venda, (i + 1 + " / " + Parcelas), Fornecedor, Descricao, Dt_Vcto_Parc.AddDays((i) * dias), ValorParc, categoria, FormaPgto, IdFormaPgto);
                        //dt.Rows.Add(IdParcela++, IdConta, (i + 1), Fornecedor, Descricaoo, Vencimento.AddDays((i) * dias), ValorParc, categoria, FormaPgto, IdFormaPgto);
                    }
                }
                dataGrid_Parcelas.DataSource = dt; //implementado dia 13/05/2017 as 21:29 por Wadson R. Lima              

            }
            if (dataGrid_Parcelas.RowCount != 0)
            {
                foreach (DataGridViewRow row in dataGrid_Parcelas.Rows)
                {
                    row.Height = 15;
                }
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
        private void gravar_Parcelas()
        {
            GravarConta();

            foreach (DataGridViewRow linha in dataGrid_Parcelas.Rows)
            {
                int posicao = 0;
                posicao = linha.Index;

                Id_Parcela = Convert.ToInt32(linha.Cells[0].Value);
                Id_Venda = Convert.ToInt32(linha.Cells[1].Value);
                Parcela = Convert.ToInt32(linha.Cells[2].Value);
                Dt_Vcto_Parc = Convert.ToDateTime(linha.Cells[5].Value);
                ValorParc = Convert.ToDecimal(linha.Cells[6].Value);
                Forma_Pgtoo = cmbForma_Pgto.Text;

                ParcelaModel objeto_parcela = new ParcelaModel();

                objeto_parcela.Idparcela = Id_Parcela;
                objeto_parcela.IdVenda = Id_Venda;
                objeto_parcela.Numparcela = Parcela;
                objeto_parcela.Valor_parc = ValorParc;
                objeto_parcela.Datavenc = Dt_Vcto_Parc;
                
                ParcelaBLL parcelabll = new ParcelaBLL();
                parcelabll.Salvar_Parcelas(objeto_parcela);
            }
            MessageBox.Show("Conta e parcelas gravadas com sucesso!!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ((FrmManutContasPagar)Application.OpenForms["FrmManutContasPagar"]).HabilitarTimer(true);
            this.Close();
        }
        public void limparCelulasDatagrid()
        {
            if (dataGrid_Parcelas.DataSource != null)
            {
                dataGrid_Parcelas.DataSource = null;
                dataGrid_Parcelas.AutoGenerateColumns = false;
            }
        }
        private void GravarConta()
        {
            Id_Venda = Convert.ToInt16(RetornaCodigoContaMaisUm(QueryContas));
            try
            {
                ContasMODEL objetocontas = new ContasMODEL();

                objetocontas.IDConta = Convert.ToInt32(Id_Venda);
                objetocontas.Datacadastro = Convert.ToDateTime(DataP);
                objetocontas.IDFornecedor = IdFornecedor;
                objetocontas.Descricao = Descricao;
                objetocontas.Idcategoria = Idcategoria;
                objetocontas.Idsubcategoria = Idsubcategoria;
                objetocontas.Idformapgto = IdFormaPgto;
                ContasBLL contasbll = new ContasBLL();

                contasbll.gravaContasDal(objetocontas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atenção" + ex, "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
       
        private void btnGerarParc_Click(object sender, EventArgs e)
        {            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            gravar_Parcelas();
        }

        private void txtValorTotal_Enter(object sender, EventArgs e)
        {
            txtValorTotal.BackColor = Color.Yellow;
        }

        private void txtValorTotal_Leave(object sender, EventArgs e)
        {
            if (txtValorTotal.Text != string.Empty)
            {
                ValorParc = Convert.ToDecimal(txtValorTotal.Text);
                txtValorTotal.Text = ValorParc.ToString("N");
            }
            else
                txtValorTotal.Text = "0,00";



            txtValorTotal.BackColor = Color.White;
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            if (txtDesconto.Text != string.Empty)
            {
                txtDesconto.BackColor = Color.White;
                ValorParc = Convert.ToDecimal(txtDesconto.Text);
                txtDesconto.Text = ValorParc.ToString("N");
            }
            else
                txtDesconto.Text = "0,00";


            GerarParcelas();



            txtDesconto.BackColor = Color.White;
        }

        private void txtDesconto_Enter(object sender, EventArgs e)
        {
            txtDesconto.BackColor = Color.Yellow;
        }

        private void txtQtdParcelas_ValueChanged(object sender, EventArgs e)
        {
            GerarParcelas();
        }

        private void txtDias_ValueChanged(object sender, EventArgs e)
        {
            GerarParcelas();
        }

        private void cmbForma_Pgto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IdFormaPgto = Convert.ToInt16(cmbForma_Pgto.SelectedValue);
            }
            catch
            {
            }
        }
    }
}

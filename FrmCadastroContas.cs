using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Windows.Threading;
using System.Diagnostics;
 

namespace Money
{
    public partial class FrmCadastroContas : Money.FrmBaseGeral
    {
        public int iDprimeiraParc { get; set; }
        public FrmCadastroContas()
        {
            InitializeComponent();
        }
        private void GerarParcelas()
        {
            IdParcela = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryParcela).ToString());
            IdConta = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryContas));

            if (lblIDFornecedor.Text != string.Empty)
            {
                double dias = Convert.ToDouble(txtDias.Text);

                Fornecedor = txtFornecedorCad.Text;
                Parcelas = Convert.ToInt32(txtQtdParcelas.Value);
                try { ValorTotal = Convert.ToDecimal(txtValorTotal.Text); }
                catch { }

                try
                {
                    Vencimento = Convert.ToDateTime(dtVencimento.Text);
                    Descricaoo = txtDescricao.Text;
                    ValorParc = ValorTotal / Parcelas;
                    CentroCusto = txtCentroCusto.Text;
                    FormaPgto = cmbForma_Pgto.Text;
                    IdCentroCusto = Convert.ToInt32(lblIdCentroCusto.Text);
                    IdFormaPgto = Convert.ToInt16(lblIdFormapgto.Text);
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
                dt.Columns.Add("centrocusto");
                dt.Columns.Add("formapgto");
                dt.Columns.Add("idformapgto");  

                for (var i = 0; i < Parcelas; i++)
                {
                    if (rbFixar.Checked == true)
                    {
                        dt.Rows.Add(IdParcela++, IdConta, (i + 1 + " / " + Parcelas), Fornecedor, Descricaoo, Vencimento.AddMonths(i), ValorParc, CentroCusto, FormaPgto, IdFormaPgto);
                    }
                    if (rbIntervalo.Checked == true)
                    {
                        dt.Rows.Add(IdParcela++, IdConta, (i + 1 + " / " + Parcelas), Fornecedor, Descricaoo, Vencimento.AddDays((i) * dias), ValorParc, CentroCusto, FormaPgto,IdFormaPgto);
                    }
                }
                dataGrid_Parcelas.DataSource = dt; //implementado dia 13/05/2017 as 21:29 por Wadson R. Lima              

            }          
        }
      
        private void Salvar_ParcelaUnica()
        {
            IdParcela = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryParcela).ToString());
            IdConta = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryContas));
            GravarConta();

            ParcelaModel objeto_parcela = new ParcelaModel();

            objeto_parcela.Idparcela = IdParcela;
            objeto_parcela.Idconta = IdConta;
            objeto_parcela.Numparcela = "1";
            objeto_parcela.Valor_parc = Convert.ToDecimal(ReplaceValores(txtValorTotal));
            objeto_parcela.Datavenc = Convert.ToDateTime(dtVencimento.Text);            
            objeto_parcela.Formapgto = cmbForma_Pgto.Text;           

            ParcelaBLL parcelabll = new ParcelaBLL();
            parcelabll.SalvarParcelasBLL(objeto_parcela);           
           
            MessageBox.Show("Conta gravada com sucesso!!","Informação!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

            LimpaCampo();
            txtIdConta.Text = Convert.ToString(RetornaCodigoContaMaisUm(QueryContas));
            IdParcela = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryParcela).ToString());
            AcrescenteZero_a_Esquerda2(txtIdConta);
            dtDataEmissao.Focus();
            txtValorTotal.Text = "0,00";
        }

        private void gravar_Parcelas()
        {
            GravarConta();

            foreach (DataGridViewRow linha in dataGrid_Parcelas.Rows)
            {
                int posicao = 0;
                posicao = linha.Index;

                IdParcela =      Convert.ToInt32(linha.Cells[0].Value);
                IdConta =        Convert.ToInt32(linha.Cells[1].Value);
                Parcela =                        linha.Cells[2].Value.ToString();
                Vencimento =  Convert.ToDateTime(linha.Cells[5].Value);
                ValorParc =    Convert.ToDecimal(linha.Cells[6].Value);               
                Forma_Pgtoo = cmbForma_Pgto.Text;

                ParcelaModel objeto_parcela = new ParcelaModel();

                objeto_parcela.Idparcela = IdParcela;
                objeto_parcela.Idconta = IdConta;
                objeto_parcela.Numparcela = Parcela;
                objeto_parcela.Valor_parc = ValorParc;
                objeto_parcela.Datavenc = Vencimento;
                objeto_parcela.Formapgto = Forma_Pgtoo;
              

                ParcelaBLL parcelabll = new ParcelaBLL();
                parcelabll.SalvarParcelasBLL(objeto_parcela);
            }
            MessageBox.Show("Conta e parcelas gravadas com sucesso!!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            LimpaCampo();
            cmbForma_Pgto.SelectedIndex = 0;

            IdConta = Convert.ToInt16(RetornaCodigoContaMaisUm(QueryContas));
            IdParcela = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryParcela).ToString());
            txtIdConta.Text = IdConta.ToString();

            AcrescenteZero_a_Esquerda2(txtIdConta);
            AcrescenteZero_a_Esquerda2(lblIDFornecedor);
            AcrescenteZero_a_Esquerda2(lblIdCentroCusto);

            dtDataEmissao.Focus();
            checkBoxGerarParcelas.Checked = false;
           
            btnSalvar.Enabled = true;
            groupBoxParcelam.Visible = false;
            txtDias.Text = "1";
            txtValorTotal.Text = "0,00";
            txtFornecedorCad.Focus();
            HabilitaBotesCadastro2();
        }
        private void GravarConta()
        {
            IdConta = Convert.ToInt16(RetornaCodigoContaMaisUm(QueryContas));
            try
            {                
                ContasMODEL objetocontas = new ContasMODEL();

                objetocontas.IDConta = Convert.ToInt32(IdConta);
                objetocontas.Datacadastro = Convert.ToDateTime(dtDataEmissao.Text);
                objetocontas.IDFornecedor = Convert.ToInt32(lblIDFornecedor.Text);
                objetocontas.Descricao = txtDescricao.Text;
                objetocontas.IdcentroCusto = Convert.ToInt32(lblIdCentroCusto.Text);
                objetocontas.Idformapgto = Convert.ToInt16(lblIdFormapgto.Text);
                ContasBLL contasbll = new ContasBLL();

                contasbll.gravaContasDal(objetocontas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atenção" + ex, "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
       
        private void AlterarParcela()
        {
            AlterarConta();

            if (lblIdParcela.Text != string.Empty)// erro no ID DA PARCELA
            {
                ParcelaModel parcelaModel = new ParcelaModel();

                parcelaModel.Valor_parc = Convert.ToDecimal(txtValorTotal.Text);
                parcelaModel.Datavenc = Convert.ToDateTime(dtVencimento.Text);
                parcelaModel.Idparcela = Convert.ToInt32(lblIdParcela.Text);
                parcelaModel.Formapgto = cmbForma_Pgto.Text;

                ParcelaBLL parcbll = new ParcelaBLL();

                parcbll.atualiza_parcelas(parcelaModel);              
                MessageBox.Show("Parcelas alteradas!!","Informe",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ((FrmManutContasPagar)Application.OpenForms["FrmManutContasPagar"]).HabilitarTimer(true);
                LimpaCampo();               
            }
        }
        private void AlterarConta()
        {
            if (txtIdConta.Text != string.Empty)
            {
                Fornecedor = txtFornecedorCad.Text;
                IdConta = Convert.ToInt16(txtIdConta.Text);

                Descricaoo = txtDescricao.Text;
                IdCentroCusto = Convert.ToInt32(lblIdCentroCusto.Text);

                ContasMODEL ContasModel = new ContasMODEL();

                ContasModel.Datacadastro = Convert.ToDateTime(dtDataEmissao.Text);
                ContasModel.IDFornecedor = Convert.ToInt32(lblIDFornecedor.Text);
                ContasModel.Descricao = txtDescricao.Text;
                ContasModel.IdcentroCusto = Convert.ToInt32(IdCentroCusto);
                ContasModel.IDConta = IdConta;

                ContasBLL contasbll = new ContasBLL();
                contasbll.atualiza_conta2(ContasModel);            
            }
        }
        public void limparCelulasDatagrid()
        {
            if (dataGrid_Parcelas.DataSource != null)
            {
                dataGrid_Parcelas.DataSource = null;
                dataGrid_Parcelas.AutoGenerateColumns = false;
            }
        }
            
        private void btnLocalizarFornecedor_Click(object sender, EventArgs e)
        {
            FrmLocalizaFornecedor pesquisacli = new FrmLocalizaFornecedor();
            pesquisacli.MdiParent = this.MdiParent;

            pesquisacli.Capturavalor = txtFornecedorCad.Text;
            txtFornecedorCad.Text = pesquisacli.Fornecedor;
            lblIDFornecedor.Text = pesquisacli.IdFornecedor.ToString();
            AcrescenteZero_a_Esquerda2(lblIDFornecedor);
            pesquisacli.TipoCadastro = "DEBITO";
            pesquisacli.Show();            

        }
        private void btnLocalizarCentroCusto_Click(object sender, EventArgs e)
        {
            FrmLocalizaCentro pesquisaCentro = new FrmLocalizaCentro();
            pesquisaCentro.MdiParent = this.MdiParent;

            pesquisaCentro.Capturavalor = txtCentroCusto.Text;
            pesquisaCentro.Show();

            IdCentroCusto = pesquisaCentro.IdCentro;
            txtCentroCusto.Text = pesquisaCentro.CentroCusto;
            lblIdCentroCusto.Text = pesquisaCentro.IdCentro.ToString();
            
            AcrescenteZero_a_Esquerda2(lblIdCentroCusto);
        }

        private void rbNão_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbSim_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtValorTotal_KeyUp(object sender, KeyEventArgs e)
        {
            string valorsemformato;
            valorsemformato = txtValorTotal.Text;
            valorsemformato = valorsemformato.Replace("R$", "").Replace(" ", "");
            txtValorTotal.Text = valorsemformato;
        }

        private void txtValorTotal_Enter(object sender, EventArgs e)
        {
            txtValorTotal.BackColor = Color.Yellow;
        }

        private void txtValorTotal_Click(object sender, EventArgs e)
        {
            string valorsemformato;
            valorsemformato = txtValorTotal.Text;
            valorsemformato = valorsemformato.Replace("R$", "").Replace(" ", "");
            txtValorTotal.Text = valorsemformato;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {           
        }
       

        private void txtQtdParcelas_ValueChanged(object sender, EventArgs e)
        {
            GerarParcelas();
        }
        public void HabilitaBotesCadastro2()
        {
            if (StatusOperacao == "NOVO")
            {
                btnAlterar.Enabled = false;
                btnSalvar.Enabled = true;
            }
            else if (StatusOperacao == "ALTERAR")
            {
                btnAlterar.Enabled = true;
                btnSalvar.Enabled = false;
            }         
        }
        public override void preencher_ComboBox(ComboBox combo, string querY, string campO)
        {
            base.preencher_ComboBox(combo, querY, campO);
        }
         
        private void FrmCadastroContas_Load(object sender, EventArgs e)
        {
            HabilitaBotesCadastro2();

            preencher_ComboBox(cmbForma_Pgto,"SELECT formapgto FROM formapgto","formapgto");
            FormaPgto = cmbForma_Pgto.Text;
            lblIdFormapgto.Text = BuscarRetornoVariavel("SELECT idformapgto FROM formapgto WHERE (formapgto = @Formapgto)", "@Formapgto", FormaPgto, "idformapgto").ToString();
            AcrescenteZero_a_Esquerda2(lblIdFormapgto);

            dtDataEmissao.Focus();

            if (StatusOperacao == "NOVO")
            {
                IdConta = Convert.ToInt16(RetornaCodigoContaMaisUm(QueryContas));
                txtIdConta.Text = IdConta.ToString();
                AcrescenteZero_a_Esquerda2(txtIdConta);
                AcrescenteZero_a_Esquerda2(lblIDFornecedor);
                AcrescenteZero_a_Esquerda2(lblIdCentroCusto);
            }
            if (StatusOperacao == "ALTERAR")
            {
                AcrescenteZero_a_Esquerda2(txtIdConta);
                AcrescenteZero_a_Esquerda2(lblIDFornecedor);
                AcrescenteZero_a_Esquerda2(lblIdCentroCusto);
                ValorParc = Convert.ToDecimal(txtValorTotal.Text);
                txtValorTotal.Text = ValorParc.ToString("N");
            }

        }

        private void txtValorTotal_Leave(object sender, EventArgs e)
        {
            if (txtValorTotal.Text != string.Empty)
            {
                ValorParc = Convert.ToDecimal(txtValorTotal.Text);
                txtValorTotal.Text = ValorParc.ToString("N");
            }
            txtValorTotal.BackColor = Color.White;
            HabilitaBotesCadastro2();
        }

        private void txtFornecedorCad_Leave(object sender, EventArgs e)
        {
            txtFornecedorCad.BackColor = Color.White;
        }

        private void txtFornecedorCad_Enter(object sender, EventArgs e)
        {
            txtFornecedorCad.BackColor = Color.Yellow;
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            txtDescricao.BackColor = Color.White;
            HabilitaBotesCadastro2();
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            txtDescricao.BackColor = Color.Yellow;
        }

        private void dataGrid_Parcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            try
            {
                linhaAtual = dataGrid_Parcelas.CurrentRow.Index;
                IdParcela = Convert.ToInt32(dataGrid_Parcelas[0, linhaAtual].Value);
                lblIdParcela.Text = dataGrid_Parcelas[0, linhaAtual].Value.ToString();
                IdConta = Convert.ToInt32(dataGrid_Parcelas[1, linhaAtual].Value);
                NumParcelas = dataGrid_Parcelas[2, linhaAtual].Value.ToString();
                txtFornecedorCad.Text = dataGrid_Parcelas[3, linhaAtual].Value.ToString();
                txtDescricao.Text = dataGrid_Parcelas[4, linhaAtual].Value.ToString();
                dtVencimento.Text = dataGrid_Parcelas[5, linhaAtual].Value.ToString();
                ValorParc = Convert.ToDecimal(dataGrid_Parcelas[6, linhaAtual].Value);
                IdFormaPgto = Convert.ToInt16(dataGrid_Parcelas[9,linhaAtual].Value);

                txtValorTotal.Text = ValorParc.ToString("N");

                dtDataEmissao.Text = dataGrid_Parcelas[8, linhaAtual].Value.ToString();

            }
            catch
            {
            }
        }

        private void txtCentroCusto_Leave(object sender, EventArgs e)
        {
            txtCentroCusto.BackColor = Color.White;
        }

        private void txtCentroCusto_Enter(object sender, EventArgs e)
        {
            txtCentroCusto.BackColor = Color.Yellow;
        }

        private void toolStripBtnNovo_Click(object sender, EventArgs e)
        {
        }

        private void toolStripBtnSalvar_Click(object sender, EventArgs e)
        {           
        }

        private void checkBoxGerarParcelas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGerarParcelas.Checked == true)
            {
                //SIM PARCELAR
                btnSalvar.Enabled = true;
                groupBoxParcelam.Visible = true;
                dataGrid_Parcelas.DataSource = null;
                GerarParcelas();
            }
            else
            {
                // NÃO PARCELAR
                btnSalvar.Enabled = true;
                groupBoxParcelam.Visible = false;
                txtQtdParcelas.Value = 1;
                txtDias.Value = 1;
            }
          
        }

        private void txtQtdParcelas_Leave(object sender, EventArgs e)
        {
            GerarParcelas();
        }
      
        private void txtDias_ValueChanged(object sender, EventArgs e)
        {
            GerarParcelas();
        }

        private void rbFixar_CheckedChanged(object sender, EventArgs e)
        {
            txtDias.Enabled = false;
        }

        private void rbIntervalo_CheckedChanged(object sender, EventArgs e)
        {
            txtDias.Enabled = true;
        }
        private void cmbForma_Pgto_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                FormaPgto = cmbForma_Pgto.Text;
                lblIdFormapgto.Text = BuscarRetornoVariavel("SELECT idformapgto FROM formapgto WHERE (formapgto = @Formapgto)", "@Formapgto", FormaPgto, "idformapgto").ToString();
                AcrescenteZero_a_Esquerda2(lblIdFormapgto);
            }
            catch
            { 
            }
        }      
      
        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            AlterarParcela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "NOVO")
            {
                if (checkBoxGerarParcelas.Checked)
                {
                    gravar_Parcelas();
                }
                else
                {
                    Salvar_ParcelaUnica();
                }
            }
            if (StatusOperacao == "ALTERAR")
            {
                AlterarParcela();
            }
            ((FrmManutContasPagar)Application.OpenForms["FrmManutContasPagar"]).HabilitarTimer(true);// Habilita Timer do outro form Obs: O timer no outro form executa um Método. 
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            FrmCadastroContas cadcontas = new FrmCadastroContas();
            cadcontas.StatusOperacao = "NOVO";

            IdConta = Convert.ToInt16(RetornaCodigoContaMaisUm(QueryContas));
            txtIdConta.Text = IdConta.ToString();
            AcrescenteZero_a_Esquerda2(txtIdConta);
            AcrescenteZero_a_Esquerda2(lblIDFornecedor);
            AcrescenteZero_a_Esquerda2(lblIdCentroCusto);

            HabilitaBotesCadastro2();           
            ((FrmPrincipal)Application.OpenForms["FrmPrincipal"]).HabilitarTimer(true);
        }

        private void lblIDFornecedor_TextChanged(object sender, EventArgs e)
        {

        }
      
    }
}

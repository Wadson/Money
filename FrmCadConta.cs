using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.Data;
//using System.Data.SqlClient;
using System.Windows.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;
 

namespace Money
{
    public partial class FrmCadConta : Money.FrmBaseGeral
    {
        public int iDprimeiraParc { get; set; }
        public FrmCadConta()
        {
            InitializeComponent();
            //preencherComboBoxT(cmbCategoria, "SELECT idcategoria, categoria FROM categoria", "idcategoria", "categoria");
        }
        public string idCateg { get;set;}
        public string idSubCat { get; set; }
      
        private void Salvar_ParcelaUnica()
        {
            GravarConta();

            ParcelaModel objeto_parcela = new ParcelaModel();

            objeto_parcela.Idparcela = IdParcela;
            objeto_parcela.Idconta = IdConta;
            objeto_parcela.Numparcela = "1";
            objeto_parcela.Valor_parc = Convert.ToDecimal(txtValorTotal.Text);
            objeto_parcela.Datavenc = Convert.ToDateTime(dtVencimento.Text);            
            objeto_parcela.Formapgto = txtFormapgto.Text;           

            ParcelaBLL parcelabll = new ParcelaBLL();
            parcelabll.SalvarParcelasBLL(objeto_parcela);           
           
            MessageBox.Show("Conta gravada com sucesso!!","Informação!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

            LimpaCampo();


            IdConta = RetornaCodigoContaMaisUm(QueryContas);
            IdParcela = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryParcela).ToString());
            
            dtDataEmissao.Focus();
            txtValorTotal.Text = "0,00";
        }

      
        private void GravarConta()
        {
            
            try
            {                
                ContasMODEL objetocontas = new ContasMODEL();

                objetocontas.IDConta = IdConta;
                objetocontas.Datacadastro = Convert.ToDateTime(dtDataEmissao.Text);
                objetocontas.IDFornecedor = Convert.ToInt32(txtIdFornecdor.Text);
                objetocontas.Descricao = txtDescricao.Text;
                objetocontas.Idcategoria = Convert.ToInt32(txtIdCategoria.Text);
                objetocontas.Idsubcategoria = Convert.ToInt32(txtIdSubCat.Text);
                objetocontas.Idformapgto = Convert.ToInt32(txtIdFormapgto.Text);
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

            ParcelaModel parcelaModel = new ParcelaModel();

            parcelaModel.Valor_parc = Convert.ToDecimal(txtValorTotal.Text);
            parcelaModel.Datavenc = Convert.ToDateTime(dtVencimento.Text);           
            parcelaModel.Idparcela = IdParcela;
            parcelaModel.Formapgto = txtFormapgto.Text;

            ParcelaBLL parcbll = new ParcelaBLL();

            parcbll.atualiza_parcelas(parcelaModel);
            MessageBox.Show("Parcelas alteradas!!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ((FrmManutContasPagar)Application.OpenForms["FrmManutContasPagar"]).HabilitarTimer(true);
            LimpaCampo(); 
        }
        private void AlterarConta()
        {
            if (IdConta != 0)
            {
                ContasMODEL ContasModel = new ContasMODEL();

                ContasModel.Datacadastro = Convert.ToDateTime(dtDataEmissao.Text);
                ContasModel.IDFornecedor = Convert.ToInt32(txtIdFornecdor.Text);
                ContasModel.Descricao = txtDescricao.Text;
                ContasModel.Idcategoria = Convert.ToInt32(txtIdCategoria.Text);
                ContasModel.Idsubcategoria = Convert.ToInt32(txtIdSubCat.Text);
                ContasModel.Idformapgto = Convert.ToInt32(txtIdFormapgto.Text);
                ContasModel.IDConta = IdConta;

                ContasBLL contasbll = new ContasBLL();
                contasbll.atualiza_conta2(ContasModel);            
            }
        }       
            
        private void btnLocalizarFornecedor_Click(object sender, EventArgs e)
        {
            FrmLocalizaFornecedor pesquisacli = new FrmLocalizaFornecedor();

            pesquisacli.Capturavalor = txtFornecedor.Text;

            txtIdFornecdor.Text = pesquisacli.IdFornecedor.ToString();
            pesquisacli.TipoCadastro = "DEBITO";
            pesquisacli.lblTitulo.Text = "PESQUISAR FORNECEDOR";
            //pesquisacli.StartPosition = FormStartPosition.CenterScreen;
            pesquisacli.Show();            

        }
        private void btnLocalizarcategoria_Click(object sender, EventArgs e)
        {            
        }       

      
        private void txtValorTotal_Click(object sender, EventArgs e)
        {
            //Força o cursor a ficar na direita
            //txtValorTotal.SelectionStart = txtValorTotal.TextLength + 1;           
        }

       
        public void HabilitaBotesCadastro2()
        {
            if (StatusOperacao == "NOVO")
            {
                btnSalvar.Enabled = true;
            }
            else if (StatusOperacao == "ALTERAR")
            {              
                btnSalvar.Enabled = true;
            }         
        }
          
        private void FrmCadastroContas_Load(object sender, EventArgs e)
        {
            HabilitaBotesCadastro2();           
            //preencherComboBoxT(cmbForma_Pgto,"SELECT idformapgto, formapgto FROM formapgto","idformapgto","formapgto");

            if (StatusOperacao == "NOVO")
            {
                IdConta = RetornaCodigoContaMaisUm(QueryContas);
                IdParcela = RetornaCodigoContaMaisUm(QueryParcela);
                txtFornecedor.Select();
            }
            if (StatusOperacao == "ALTERAR")
            {   
                ValorParc = Convert.ToDecimal(txtValorTotal.Text);
                txtValorTotal.Text = ValorParc.ToString("N");
            }

        }

        private void lblIDFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (txtValorTotal.Text.Substring(0) == ",")
                txtValorTotal.Text = "0" + txtValorTotal.Text;
        }
       
        private void txtValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != ',')
                    e.Handled = true;
                else if (txtValorTotal.Text.IndexOf(',') > 0)
                    e.Handled = true;
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (StatusOperacao == "NOVO")
            {
                IdConta = RetornaCodigoContaMaisUm(QueryContas);
                IdParcela = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryParcela).ToString());

                Salvar_ParcelaUnica();
            }
            if (StatusOperacao == "ALTERAR")
            {
                AlterarParcela();
            }
            ((FrmManutContasPagar)Application.OpenForms["FrmManutContasPagar"]).HabilitarTimer(true);// Habilita Timer do outro form Obs: O timer no outro form executa um Método. 
            LimpaCampo();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadConta cadcontas = new FrmCadConta();
            cadcontas.StatusOperacao = "NOVO";

            IdConta = Convert.ToInt16(RetornaCodigoContaMaisUm(QueryContas));           
           
            HabilitaBotesCadastro2();
            ((FrmManutContasPagar)Application.OpenForms["FrmManutContasPagar"]).HabilitarTimer(true);
        }

        private void dataGrid_Parcelas_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //Código para numerar o cabeçalho das linhas do datagrid
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void btnParcelar_Click(object sender, EventArgs e)
        {
            FrmCadParcelar f1 = new FrmCadParcelar();
           

            if (txtFornecedor.Text.Length == 0 )//|| )
            {
                errorProvider1.SetError((Control)txtFornecedor, "escolha um fornecedor!!!");
                
            }
            else
                errorProvider1.SetError(txtFornecedor, "");


            if (txtValorTotal.Text.Length == 0)
            {
                errorProvider1.SetError((Control)txtValorTotal, "O campo valor está vazio!!!");
            }
            else
            {
                errorProvider1.SetError(txtValorTotal, "");

                f1.txtIdConta.Text = IdConta.ToString();
                f1.txtFornecedorCad.Text = txtFornecedor.Text;
                f1.txtValorTotal.Text = txtValorTotal.Text;
                f1.IdFornecedor = Convert.ToInt32(txtIdFornecdor.Text);
                f1.Idcategoria = Convert.ToInt32(txtIdCategoria.Text);
                f1.Idsubcategoria = Convert.ToInt32(txtIdSubCat.Text);
                f1.IdFormaPgto = Convert.ToInt32(txtIdFormapgto.Text);
                f1.DataP = Convert.ToDateTime(dtDataEmissao.Text);
                f1.Descricaoo = txtDescricao.Text;
                f1.dtPrimeiraParc.Text = dtVencimento.Text;
                f1.cmbForma_Pgto.Text = txtFormapgto.Text;

                f1.lblTitulo.Text = "Tela de Parcelamento";
                f1.ShowDialog();
                ((FrmManutContasPagar)Application.OpenForms["FrmManutContasPagar"]).HabilitarTimer(true);
                LimpaCampo();
            }
        }

        private void txtValorTotal_Validating(object sender, CancelEventArgs e)
        {
            if (txtValorTotal.Text.Length == 0)
            {
                errorProvider1.SetError((Control)txtValorTotal, "An explanation of your time entry is required.");
            }
            else
            {
                errorProvider1.SetError(txtValorTotal, "");
            }
        }

        private void txtCategoria_Enter(object sender, EventArgs e)
        {
            txtIdCategoria.BackColor = Color.Honeydew;
            txtCategoria.BackColor = Color.Honeydew;

            txtCategoria.ForeColor = Color.Black;
            txtIdCategoria.ForeColor = Color.Black;
        }

        private void txtCategoria_Leave(object sender, EventArgs e)
        {
            txtIdCategoria.BackColor = Color.SteelBlue;
            txtCategoria.BackColor = Color.SteelBlue;
            
            txtCategoria.ForeColor = Color.White;
            txtIdCategoria.ForeColor = Color.White;

        }
        private void txtSubCategoria_Enter(object sender, EventArgs e)
        {
            txtIdSubCat.BackColor = Color.Honeydew;
            txtSubCategoria.BackColor = Color.Honeydew;

            txtSubCategoria.ForeColor = Color.Black;
            txtIdSubCat.ForeColor = Color.Black;
        }

        private void txtSubCategoria_Leave(object sender, EventArgs e)
        {
            txtIdSubCat.BackColor = Color.SteelBlue;
            txtSubCategoria.BackColor = Color.SteelBlue;

            txtSubCategoria.ForeColor = Color.White;
            txtIdSubCat.ForeColor = Color.White;
        }

        private void txtValorTotal_Enter(object sender, EventArgs e)
        {
            txtValorTotal.BackColor = Color.Honeydew;
            txtValorTotal.ForeColor = Color.Black;
        }


        private void txtValorTotal_Leave(object sender, EventArgs e)
        {
            if (txtValorTotal.Text != string.Empty)
            {
                ValorParc = Convert.ToDecimal(txtValorTotal.Text);
                txtValorTotal.Text = ValorParc.ToString("N");
            }
            txtValorTotal.BackColor = Color.SteelBlue;
            txtValorTotal.ForeColor = Color.White;

            HabilitaBotesCadastro2();
        }

        private void txtFornecedorCad_Leave(object sender, EventArgs e)
        {
            txtFornecedor.BackColor = Color.SteelBlue;
            //btnLocalizarFornecedor.BackColor = Color.SteelBlue;
            txtIdFornecdor.BackColor = Color.SteelBlue;
            txtFornecedor.ForeColor = Color.White;
            txtIdFornecdor.ForeColor = Color.White;
        }

        private void txtFornecedorCad_Enter(object sender, EventArgs e)
        {
            txtFornecedor.BackColor = Color.Honeydew;
            //btnLocalizarFornecedor.BackColor = Color.Honeydew;
            txtIdFornecdor.BackColor = Color.Honeydew;

            txtFornecedor.ForeColor = Color.Black;
            txtIdFornecdor.ForeColor = Color.Black;
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            txtDescricao.BackColor = Color.SteelBlue;
            txtDescricao.ForeColor = Color.White;
            HabilitaBotesCadastro2();
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            txtDescricao.BackColor = Color.Honeydew;
            txtDescricao.ForeColor = Color.Black;
        }
        private void btnLocalizarCategoria_Click_1(object sender, EventArgs e)
        {
            FrmLocalizaCentro pesquisaCat = new FrmLocalizaCentro();
            pesquisaCat.Capturavalor = txtCategoria.Text;
            pesquisaCat.lblTitulo.Text = "PESQUISAR CATEGORIA";
            pesquisaCat.Show();   
        }

        private void btnLocalizarSubCat_Click(object sender, EventArgs e)
        {
            FrmLocalizaSubCategoria pesquisaSubCat = new FrmLocalizaSubCategoria();
            pesquisaSubCat.Capturavalor = txtIdCategoria.Text;
            pesquisaSubCat.TipoPesquisa = "CADASTRO";
            pesquisaSubCat.lblTitulo.Text = "PESQUISAR SUB CATEGORIA";
            pesquisaSubCat.Show();  
        }

        private void btnLocalizarFormaPgto_Click(object sender, EventArgs e)
        {
            FrmLocalizarFormaPgto pesquisaFormaPgto = new FrmLocalizarFormaPgto();
            pesquisaFormaPgto.Capturavalor = txtFormapgto.Text;
            pesquisaFormaPgto.TipoCadastro = "DEBITO";
            pesquisaFormaPgto.lblTitulo.Text = "PESQUISAR FORMA DE PAGAMENTO";
            pesquisaFormaPgto.Show(); 
        }

        private void TxtFormapgto_Enter(object sender, EventArgs e)
        {
            txtFormapgto.BackColor = Color.Honeydew;
            txtFormapgto.ForeColor = Color.Black;
            txtIdFormapgto.BackColor = Color.Honeydew;
            txtIdFormapgto.ForeColor = Color.Black;
        }

        private void TxtFormapgto_Leave(object sender, EventArgs e)
        {
            txtFormapgto.BackColor = Color.SteelBlue;
            txtIdFormapgto.BackColor = Color.SteelBlue;

            txtIdFormapgto.ForeColor = Color.White;
            txtFormapgto.ForeColor = Color.White;
        }
    }
}

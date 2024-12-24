using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmCadFornecedor : FrmBaseGeral
    {
        //public string StatusOperacao;
        public FrmCadFornecedor()
        {
            InitializeComponent();
        }
        public void GravarRegistro()
        {
            FornecedorMODEL objfornecedor = new FornecedorMODEL();

            objfornecedor.ID_Fornecedor = Convert.ToInt32(txtCodigo.Text);
            objfornecedor.Fornecedor = txtFornecedor.Text;
            objfornecedor.Endere_fornecedor = txtEndereco.Text;

            FornecedorBLL fornecedorbll = new FornecedorBLL();

            fornecedorbll.Salvar(objfornecedor);
            MessageBox.Show("REGISTRO gravado com sucesso!", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            FrmManutFornecedor Form = new FrmManutFornecedor();

            txtCodigo.Text = RetornaCodigoContaMaisUm(QueryFornecedor).ToString();
            LimpaCampo();
            txtFornecedor.Select();
            try
            {
                //FornecedorMODEL objfornecedor = new FornecedorMODEL();

                //objfornecedor.ID_Fornecedor = Convert.ToInt32(txtCodigo.Text);
                //objfornecedor.Fornecedor = txtFornecedor.Text;
                //objfornecedor.Endere_fornecedor = txtEndereco.Text;              

                //FornecedorBLL fornecedorbll = new FornecedorBLL();

                //fornecedorbll.Salvar(objfornecedor);
                //MessageBox.Show("REGISTRO gravado com sucesso!", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //FrmManutFornecedor Form = new FrmManutFornecedor();

                //txtCodigo.Text = RetornaCodigoContaMaisUm(QueryFornecedor).ToString();
                //LimpaCampo();
                //txtFornecedor.Select();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao gravar O REGISTRO!!! " + erro);
            }            
        }
        public void AlterarRegistro()
        {
            try
            {
                FornecedorMODEL objfornecedor = new FornecedorMODEL();
              
                objfornecedor.Fornecedor = txtFornecedor.Text;                            
                objfornecedor.ID_Fornecedor = Convert.ToInt32(txtCodigo.Text);
                objfornecedor.Endere_fornecedor = txtEndereco.Text;

                FornecedorBLL fornecedorbll = new FornecedorBLL();

                fornecedorbll.Alterar(objfornecedor);
                MessageBox.Show("Registro Alterado com sucesso!", "Alteração!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);               
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterar O REGISTRO!!! " + erro);
            }
        }
        public override string EvitarDuplicado(string Tabela, string Campo, string CampoParametro)
        {
            return base.EvitarDuplicado(Tabela, Campo, CampoParametro);
        }
        public void AcrescenteZero_a_Esquerda()
        {
            string texto;
            string textofinal;
            int tamanho;
            textofinal = "";
            texto = txtCodigo.Text.ToString();
            if ((txtCodigo.Text.Length < 10))
            {
                tamanho = txtCodigo.Text.Length;
                for (int t = 1; (t <= (4 - tamanho)); t++)
                {
                    textofinal = (textofinal + "0");
                }

                txtCodigo.Text = (textofinal + txtCodigo.Text);
            }

            if ((txtCodigo.Text == "0000"))
            {
                //MessageBox.Show("DEVE SER DIGITADO ALGUM VALOR NO CAMPO CÓDIGO.","INFORMAÇÃO !", MessageBoxButtons.OK,MessageBoxIcon.Information);
                //txtCodForn.Text = "";
                //txtCodForn.Focus();
            }
        }
        private void FrmCadastroFornecedor_Load(object sender, EventArgs e)
        {           
            if (StatusOperacao == "ALTERAR")
            {               
                AcrescenteZero_a_Esquerda();                
            }
            if (StatusOperacao == "NOVO")
            {                             
                IdFornecedor = RetornaCodigoContaMaisUm(QueryFornecedor);
                txtCodigo.Text = RetornaCodigoContaMaisUm(QueryFornecedor).ToString();
                AcrescenteZero_a_Esquerda();
                txtFornecedor.Focus();                               
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {           
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {           
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                AlterarRegistro();
            }
            if (StatusOperacao == "NOVO")
            {
                EvitarDuplicado("fornecedor", "nome_fornecedor", txtFornecedor.Text);
                if (RetornoEvitaDuplicado == "0")
                {
                    GravarRegistro();
                }
                try
                {
                    ((FrmManutFornecedor)Application.OpenForms["FrmManutFornecedor"]).HabilitarTimer(true);
                }
                catch
                {
                }
            }
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            LimpaCampo();
            txtFornecedor.Focus();
        }

        private void txtFornecedor_Leave(object sender, EventArgs e)
        {
            txtFornecedor.BackColor = Color.White;
        }

        private void txtFornecedor_Enter(object sender, EventArgs e)
        {
            txtFornecedor.BackColor = Color.Yellow;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

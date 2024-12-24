using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmCadastroFornecedor : FrmBaseGeral
    {
        //public string StatusOperacao;
        public FrmCadastroFornecedor()
        {
            InitializeComponent();
        }
        public void GravarRegistro()
        {
            try
            {
                FornecedorMODEL objfornecedor = new FornecedorMODEL();

                objfornecedor.IDFornecedor = Convert.ToInt32(Codigo);
                objfornecedor.Fornecedor = txtFornecedor.Text;
                objfornecedor.Dtcadastro = Convert.ToDateTime(txtCadastro.Text);
                objfornecedor.Contato = txtContato.Text;
                objfornecedor.Cnpj = txtCnpj.Text;
                objfornecedor.Ie = txtInscricaoEstadual.Text;
                objfornecedor.Fone = txtFone1.Text;
                objfornecedor.Fone1 = txtFone2.Text;
                objfornecedor.Celular = txtCelular.Text;
                objfornecedor.Endereco = txtEndereco.Text;
                objfornecedor.Bairro = txtBairro.Text;
                objfornecedor.Cep = txtCep.Text;
                objfornecedor.Uf = txtUf.Text;
                objfornecedor.Email = txtEmail.Text;
                objfornecedor.Emissor = txtEmissor.Text;
                objfornecedor.Obs = txtObs.Text;
                objfornecedor.Rg = txtIdentidade.Text;
                objfornecedor.Cpf = txtCpf.Text;
                objfornecedor.Cidade = txtCidade.Text;

                FornecedorBLL fornecedorbll = new FornecedorBLL();

                fornecedorbll.Salvar(objfornecedor);
                MessageBox.Show("REGISTRO gravado com sucesso!", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);               
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao gravar O REGISTRO!!! " + erro);
            }
        }
        public void AlgerarRegistro()
        {
            try
            {
                FornecedorMODEL objfornecedor = new FornecedorMODEL();
              
                objfornecedor.Fornecedor = txtFornecedor.Text;
                objfornecedor.Dtcadastro = Convert.ToDateTime(txtCadastro.Text);
                objfornecedor.Contato = txtContato.Text;
                objfornecedor.Cnpj = txtCnpj.Text;
                objfornecedor.Ie = txtInscricaoEstadual.Text;
                objfornecedor.Fone = txtFone1.Text;
                objfornecedor.Fone1 = txtFone2.Text;
                objfornecedor.Celular = txtCelular.Text;
                objfornecedor.Endereco = txtEndereco.Text;
                objfornecedor.Bairro = txtBairro.Text;
                objfornecedor.Cep = txtCep.Text;
                objfornecedor.Uf = txtUf.Text;
                objfornecedor.Email = txtEmail.Text;
                objfornecedor.Emissor = txtEmissor.Text;
                objfornecedor.Obs = txtObs.Text;
                objfornecedor.Rg = txtIdentidade.Text;
                objfornecedor.Cpf = txtCpf.Text;
                objfornecedor.Cidade = txtCidade.Text;
                objfornecedor.IDFornecedor = Convert.ToInt32(Codigo);

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
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                AlgerarRegistro();
            }
            if (StatusOperacao == "NOVO")
            {
                EvitarDuplicado("fornecedor", "fornecedor", txtFornecedor.Text);
                if (RetornoEvitaDuplicado == "0")
                {
                   
                    GravarRegistro();
                    LimpaCampo();
                    txtFornecedor.Focus();
                    txtCadastro.Text = DateTime.Now.ToShortDateString();
                    txtCodigo.Text = RetornaCodigoContaMaisUm(QueryFornecedor).ToString();
                    AcrescenteZero_a_Esquerda();
                }
            }
            try
            {
                ((FrmPesquisaCadastroFornecedor)Application.OpenForms["FrmPesquisaCadastroFornecedor"]).HabilitarTimer(true);// Habilita Timer do outro form Obs: O timer no outro form executa um Método.
            }
            catch
            { 
            }
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
                return;
               
            }
            if (StatusOperacao == "NOVO")
            {
                Codigo = RetornaCodigoContaMaisUm(QueryFornecedor);
                txtCodigo.Text = RetornaCodigoContaMaisUm(QueryFornecedor).ToString();
                txtFornecedor.Focus();
                txtCadastro.Text = DateTime.Now.ToShortDateString();
                AcrescenteZero_a_Esquerda();
            }    
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

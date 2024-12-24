using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmCadastroFuncionario : Money.FrmBaseGeral
    {
        //public string StatusOperacao;

        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }
        public override string EvitarDuplicado(string Tabela, string Campo, string CampoParametro)
        {
            return base.EvitarDuplicado(Tabela, Campo, CampoParametro);
        }
        public void GravarRegistro()
        {
            funcionarioMODEL objetofuncionario = new funcionarioMODEL();

            try
            {
                //objetofuncionario.Idfuncionario = Convert.ToInt32(Codigo);
                objetofuncionario.Dtcadastro = Convert.ToDateTime(txtCadastro.Text);
                objetofuncionario.Funcionario = txtFuncionario.Text;
                objetofuncionario.Endereco = txtEndereco.Text;
                objetofuncionario.Cep = txtCep.Text;
                objetofuncionario.Bairro = txtBairro.Text;
                objetofuncionario.Cidade = txtCidade.Text;
                objetofuncionario.Fone = txtFone1.Text;
                objetofuncionario.Fone1 = txtFone2.Text;
                objetofuncionario.Celular = txtCelular.Text;
                objetofuncionario.Whatsapp = txtWhats.Text;
                objetofuncionario.Uf = txtUf.Text;
                objetofuncionario.Email = txtEmail.Text;
                objetofuncionario.Cpf = txtCpf.Text;
                objetofuncionario.Rg = txtRg.Text;
                objetofuncionario.Rgemissao = Convert.ToDateTime(txtRgEmissao.Text);
                objetofuncionario.Rgorgaoemissor = txtEmissor.Text;
                objetofuncionario.Comissao = txtComissao.Text;
                objetofuncionario.Obs = txtObs.Text;
                objetofuncionario.Mae = txtMae.Text;
                objetofuncionario.Pai = txtPai.Text;
                objetofuncionario.Conjuge = txtConjuge.Text;
                objetofuncionario.Dtnascimento = Convert.ToDateTime(txtNascimento.Text);
                objetofuncionario.Naturalidade = txtNaturalidade.Text;
                objetofuncionario.Estadocivil = txtEstadoCivil.Text;
                objetofuncionario.Grauinstrucao = txtGrauInstrucao.Text;
                objetofuncionario.Ctpsemissao = Convert.ToDateTime(txtCtpsEmissao.Text);
                objetofuncionario.Admissao = Convert.ToDateTime(txtAdmissao.Text);
                objetofuncionario.Ctps = txtCtps.Text;
                objetofuncionario.Ctpsserieuf = txtCtpsSerie.Text;
                objetofuncionario.Tituloeleitor = txtTituloEle.Text;
                objetofuncionario.Titulozona = txtTituloZona.Text;
                objetofuncionario.Titulosecao = txtTituloSecao.Text;
                objetofuncionario.Reservista = txtReservista.Text;
                objetofuncionario.Reservistacategoria = txtReservistaCategoria.Text;
                objetofuncionario.Pis = txtPis.Text;
                objetofuncionario.Funcao = txtFuncao.Text;
                objetofuncionario.Depto = txtDepto.Text;
                objetofuncionario.Salario = Convert.ToDouble(txtSalario.Text);

                FuncionarioBLL funcionariobll = new FuncionarioBLL();

                funcionariobll.Salvar(objetofuncionario);
                MessageBox.Show("REGISTRO gravado com sucesso!", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtFuncionario.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao gravar O REGISTRO!!! " + erro);
            }
        }
        public void AlgerarRegistro()
        {
            funcionarioMODEL objetofuncionario = new funcionarioMODEL();

            objetofuncionario.Dtcadastro = Convert.ToDateTime(txtCadastro.Text);
            objetofuncionario.Funcionario = txtFuncionario.Text;
            objetofuncionario.Endereco = txtEndereco.Text;
            objetofuncionario.Cep = txtCep.Text;
            objetofuncionario.Bairro = txtBairro.Text;
            objetofuncionario.Cidade = txtCidade.Text;
            objetofuncionario.Fone = txtFone1.Text;
            objetofuncionario.Fone1 = txtFone2.Text;
            objetofuncionario.Celular = txtCelular.Text;
            objetofuncionario.Whatsapp = txtWhats.Text;
            objetofuncionario.Uf = txtUf.Text;
            objetofuncionario.Email = txtEmail.Text;
            objetofuncionario.Cpf = txtCpf.Text;
            objetofuncionario.Rg = txtRg.Text;
            objetofuncionario.Rgemissao = Convert.ToDateTime(txtRgEmissao.Text);
            objetofuncionario.Rgorgaoemissor = txtEmissor.Text;
            objetofuncionario.Comissao = txtComissao.Text;
            objetofuncionario.Obs = txtObs.Text;
            objetofuncionario.Mae = txtMae.Text;
            objetofuncionario.Pai = txtPai.Text;
            objetofuncionario.Conjuge = txtConjuge.Text;
            objetofuncionario.Dtnascimento = Convert.ToDateTime(txtNascimento.Text);
            objetofuncionario.Naturalidade = txtNaturalidade.Text;
            objetofuncionario.Estadocivil = txtEstadoCivil.Text;
            objetofuncionario.Grauinstrucao = txtGrauInstrucao.Text;
            objetofuncionario.Ctpsemissao = Convert.ToDateTime(txtCtpsEmissao.Text);
            objetofuncionario.Admissao = Convert.ToDateTime(txtAdmissao.Text);
            objetofuncionario.Ctps = txtCtps.Text;
            objetofuncionario.Ctpsserieuf = txtCtpsSerie.Text;
            objetofuncionario.Tituloeleitor = txtTituloEle.Text;
            objetofuncionario.Titulozona = txtTituloZona.Text;
            objetofuncionario.Titulosecao = txtTituloSecao.Text;
            objetofuncionario.Reservista = txtReservista.Text;
            objetofuncionario.Reservistacategoria = txtReservistaCategoria.Text;
            objetofuncionario.Pis = txtPis.Text;
            objetofuncionario.Funcao = txtFuncao.Text;
            objetofuncionario.Depto = txtDepto.Text;
            objetofuncionario.Salario = Convert.ToDouble(txtSalario.Text);
            objetofuncionario.Idfuncionario = Convert.ToInt32(txtCodigo.Text);

            FuncionarioBLL funcionariobll = new FuncionarioBLL();

            funcionariobll.Alterar(objetofuncionario);
            MessageBox.Show("Registro Alterado com sucesso!", "Alteração!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            try
            {
               
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterar O REGISTRO!!! " + erro);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                AlgerarRegistro();
            }
            if (StatusOperacao == "NOVO")
            {
                EvitarDuplicado("fornecedor", "fornecedor", txtFuncionario.Text);
                if (RetornoEvitaDuplicado == "0")
                {

                    GravarRegistro();
                    LimpaCampo();
                    txtFuncionario.Focus();
                    txtCadastro.Text = DateTime.Now.ToShortDateString();
                    txtCodigo.Text = RetornaCodigoContaMaisUm(QueryFuncionario).ToString();
                    AcrescenteZero_a_Esquerda();
                }
            }
            ((FrmPesquisaCadastroFuncionario)Application.OpenForms["FrmPesquisaCadastroFuncionario"]).HabilitarTimer(true);// Habilita Timer do outro form Obs: O timer no outro form executa um Método.
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void FrmCadFuncionario_Load(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                AcrescenteZero_a_Esquerda();
                return;
            }
            if (StatusOperacao == "NOVO")
            {
                Codigo = RetornaCodigoContaMaisUm(QueryFuncionario);
                txtCodigo.Text = RetornaCodigoContaMaisUm(QueryFuncionario).ToString();
                txtFuncionario.Focus();
                txtCadastro.Text = DateTime.Now.ToShortDateString();
                AcrescenteZero_a_Esquerda();
            }  
        }
    }
}

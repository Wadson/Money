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
    public partial class FrmCadastroCliente : FrmBaseGeral
    {
        //public string StatusOperacao;

        public FrmCadastroCliente()
        {
            InitializeComponent();
        }
        private void GravarRegistros()
        {
            if (rbBloquear.Checked == true)
            {
                Status = "B";
            }
            if (rbRestringir.Checked == true)
            {
                Status = "R";
            }
            if (rbLiberar.Checked == true)
            {
                Status = "A";
            }
            ClienteMODEL objeto_Cliente = new ClienteMODEL();

            objeto_Cliente.Dtcadastro = Convert.ToDateTime(txtCadastro.Text);
            objeto_Cliente.Cliente = txtCliente.Text;
            objeto_Cliente.Dtnascimento = Convert.ToDateTime(txtNascimento.Text);
            objeto_Cliente.Naturalidade = txtNaturalidade.Text;
            objeto_Cliente.Nomepai = txtPai.Text;
            objeto_Cliente.Nomemae = txtMae.Text;
            objeto_Cliente.Conjuge = txtConjuge.Text;
            objeto_Cliente.Identidade = txtIdentidade.Text;
            objeto_Cliente.Cpf = txtCpf.Text;
            objeto_Cliente.Cnpj = txtCnpj.Text;
            objeto_Cliente.Ie = txtInscricaoEstadual.Text;
            objeto_Cliente.Fone = txtFone1.Text;
            objeto_Cliente.Fone1 = txtFone2.Text;
            objeto_Cliente.Celular = txtCelular.Text;
            objeto_Cliente.Contato = txtContato.Text;
            objeto_Cliente.Idcliente = Convert.ToInt32(Codigo);//IdCliente
            objeto_Cliente.Endereco = txtEndereco.Text;
            objeto_Cliente.Bairro = txtBairro.Text;
            objeto_Cliente.Cidade = txtCidade.Text;
            objeto_Cliente.Cep = txtCep.Text;
            objeto_Cliente.Uf = txtUf.Text;
            objeto_Cliente.Email = txtEmail.Text;
            objeto_Cliente.Emissor = txtEmissor.Text;
            objeto_Cliente.Obs = txtObs.Text;
            objeto_Cliente.Status = Status;

            ClienteBLL clienteBLL = new ClienteBLL();
            clienteBLL.Salvar(objeto_Cliente);
                        
            MessageBox.Show("Registro Salvo com Sucesso!!!","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            LimpaCampo();
            txtCodigo.Text = RetornaCodigoContaMaisUm(QueryCliente).ToString();
            txtCadastro.Text = DateTime.Now.ToShortDateString();
            AcrescenteZero_a_Esquerda();
            txtCliente.Focus();
        }
        private void AlterarRegistros()
        {
            if (rbBloquear.Checked == true)
            {
                Status = "B";
            }
            if (rbRestringir.Checked == true)
            {
                Status = "R";
            }
            if (rbLiberar.Checked == true)
            {
                Status = "A";
            }
            ClienteMODEL objeto_Cliente = new ClienteMODEL();

            objeto_Cliente.Dtcadastro = Convert.ToDateTime(txtCadastro.Text);
            objeto_Cliente.Cliente = txtCliente.Text;
            objeto_Cliente.Dtnascimento = Convert.ToDateTime(txtNascimento.Text);
            objeto_Cliente.Naturalidade = txtNaturalidade.Text;
            objeto_Cliente.Nomepai = txtPai.Text;
            objeto_Cliente.Nomemae = txtMae.Text;
            objeto_Cliente.Conjuge = txtConjuge.Text;
            objeto_Cliente.Identidade = txtIdentidade.Text;
            objeto_Cliente.Cpf = txtCpf.Text;
            objeto_Cliente.Cnpj = txtCnpj.Text;
            objeto_Cliente.Ie = txtInscricaoEstadual.Text;
            objeto_Cliente.Fone = txtFone1.Text;
            objeto_Cliente.Fone1 = txtFone2.Text;
            objeto_Cliente.Celular = txtCelular.Text;
            objeto_Cliente.Contato = txtContato.Text;            
            objeto_Cliente.Endereco = txtEndereco.Text;
            objeto_Cliente.Bairro = txtBairro.Text;
            objeto_Cliente.Cidade = txtCidade.Text;
            objeto_Cliente.Cep = txtCep.Text;
            objeto_Cliente.Uf = txtUf.Text;
            objeto_Cliente.Email = txtEmail.Text;
            objeto_Cliente.Emissor = txtEmissor.Text;
            objeto_Cliente.Obs = txtObs.Text;
            objeto_Cliente.Status = Status;            
            objeto_Cliente.Idcliente = Convert.ToInt32(Codigo);//IdCliente

            ClienteBLL clienteBLL = new ClienteBLL();

            clienteBLL.Alterar(objeto_Cliente);

            MessageBox.Show("Registro Alterado com Sucesso!!!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpaCampo();
            txtCodigo.Text = RetornaCodigoContaMaisUm(QueryCliente).ToString();
            Codigo = RetornaCodigoContaMaisUm(QueryCliente);
            txtCadastro.Text = DateTime.Now.ToShortDateString();
            txtCliente.Focus();
            this.Close();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                AlterarRegistros();
            }
            if (StatusOperacao == "NOVO")
            {
                GravarRegistros();
            }
            ((FrmPesquisaCadastroCliente)Application.OpenForms["FrmPesquisaCadastroCliente"]).HabilitarTimer(true);// Habilita Timer do outro form Obs: O timer no outro form executa um Método.
        }

        private void rbLiberar_CheckedChanged(object sender, EventArgs e)
        {
            Status = "A";
        }

        private void rbBloquear_CheckedChanged(object sender, EventArgs e)
        {
            Status = "B";
        }

        private void rbRestringir_CheckedChanged(object sender, EventArgs e)
        {
            Status = "R";
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
        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                AcrescenteZero_a_Esquerda();
                return;
            }
            if (StatusOperacao == "NOVO")
            {
                txtCodigo.Text = RetornaCodigoContaMaisUm(QueryCliente).ToString();
                Codigo = RetornaCodigoContaMaisUm(QueryCliente);
                txtCadastro.Text = DateTime.Now.ToShortDateString();
                txtCliente.Focus();
                AcrescenteZero_a_Esquerda();
            }  
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }         
    }
}

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
    public partial class FrmCadClientes : FrmBaseGeral
    {
        public FrmCadClientes()
        {
            InitializeComponent();
        }

        public void GravarRegistro()
        {
            try
            {
                ClienteMODEL objCliente = new ClienteMODEL();

                objCliente.Id_cliente = Convert.ToInt32(txtCodigoCli.Text);
                objCliente.Nome_cliente = txtNomeCliente.Text;
                objCliente.Dt_cadastro_cliente = Convert.ToDateTime(txtDTCadastroCli.Text);
                objCliente.Fone_cliente = txtTelefoneCli.Text;
                objCliente.Endereco_cliente = txtTelefoneCli.Text;
                objCliente.Bairro_cliente = txtBairroCliente.Text;
                objCliente.Id_cidade = Convert.ToInt32(txtIdCidade.Text);
                

                ClienteBLL cliente_bll = new ClienteBLL();

                cliente_bll.Salvar(objCliente);
                MessageBox.Show("REGISTRO gravado com sucesso!", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                FrmManutCliente Form = new FrmManutCliente();

                txtCodigoCli.Text = RetornaCodigoContaMaisUm(QueryClientes).ToString();
                LimpaCampo();
                txtNomeCliente.Select();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao gravar O REGISTRO!!! " + erro);
            }
        }
        public void AlterarRegistro()
        {
            ClienteMODEL obj_cliente = new ClienteMODEL();

            obj_cliente.Nome_cliente = txtNomeCliente.Text;
            obj_cliente.Dt_cadastro_cliente = Convert.ToDateTime(txtDTCadastroCli.Text);
            obj_cliente.Fone_cliente = txtTelefoneCli.Text;
            obj_cliente.Endereco_cliente = txtEnderecoCliente.Text;
            obj_cliente.Bairro_cliente = txtBairroCliente.Text;
            obj_cliente.Id_cidade = Convert.ToInt32(txtIdCidade.Text);

            obj_cliente.Id_cliente = Convert.ToInt32(txtCodigoCli.Text);

            ClienteBLL clinte_bll = new ClienteBLL();

            clinte_bll.Alterar(obj_cliente);
            MessageBox.Show("Registro Alterado com sucesso!", "Alteração!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
            try
            {
                //ClienteMODEL obj_cliente = new ClienteMODEL();

                //obj_cliente.Nome_cliente = txtNomeCliente.Text;
                //obj_cliente.Dt_cadastro_cliente = Convert.ToDateTime(txtDTCadastroCli.Text);
                //obj_cliente.Fone_cliente = txtTelefoneCli.Text;
                //obj_cliente.Endereco_cliente = txtEnderecoCliente.Text;
                //obj_cliente.Bairro_cliente = txtBairroCliente.Text;
                //obj_cliente.Cidade_cliente = txtCidadeCliente.Text;
                //obj_cliente.Estado_cliente = txtEstadoCliente.Text;
                //obj_cliente.Id_cliente = Convert.ToInt32(txtCodigoCli.Text);

                //ClienteBLL clinte_bll = new ClienteBLL();

                //clinte_bll.Alterar(obj_cliente);
                //MessageBox.Show("Registro Alterado com sucesso!", "Alteração!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //this.Close();
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
            texto = txtCodigoCli.Text.ToString();
            if ((txtCodigoCli.Text.Length < 10))
            {
                tamanho = txtCodigoCli.Text.Length;
                for (int t = 1; (t <= (4 - tamanho)); t++)
                {
                    textofinal = (textofinal + "0");
                }

                txtCodigoCli.Text = (textofinal + txtCodigoCli.Text);
            }

            if ((txtCodigoCli.Text == "0000"))
            {
                //MessageBox.Show("DEVE SER DIGITADO ALGUM VALOR NO CAMPO CÓDIGO.","INFORMAÇÃO !", MessageBoxButtons.OK,MessageBoxIcon.Information);
                //txtCodForn.Text = "";
                //txtCodForn.Focus();
            }
        }

        private void FrmCadClientes_Load(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                AcrescenteZero_a_Esquerda();
            }
            if (StatusOperacao == "NOVO")
            {
                IDCliente = RetornaCodigoContaMaisUm(QueryClientes);
                txtCodigoCli.Text = RetornaCodigoContaMaisUm(QueryClientes).ToString();
                AcrescenteZero_a_Esquerda();
                txtNomeCliente.Focus();
                txtDTCadastroCli.Text = DateTime.Now.ToShortDateString();
            }
        }
       
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                AlterarRegistro();
            }
            if (StatusOperacao == "NOVO")
            {
                EvitarDuplicado("cliente", "nome_cliente", txtNomeCliente.Text);
                if (RetornoEvitaDuplicado == "0")
                {
                    GravarRegistro();
                }
                try
                {
                    ((FrmManutCliente)Application.OpenForms["FrmManutCliente"]).HabilitarTimer(true);
                }
                catch
                {
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        string AplicarMascaraTelefone(string strNumero)
        {
            // por omissão tem 10 ou menos dígitos
            string strMascara = "{0:(00)0000-0000}";
            // converter o texto em número
            long lngNumero = Convert.ToInt64(strNumero);

            if (strNumero.Length == 11)
                strMascara = "{0:(00)00000-0000}";

            return string.Format(strMascara, lngNumero);
        }
        private void txtTelefoneCli_Leave(object sender, EventArgs e)
        {            
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            FrmLocalizarCidade frmLocalizarCidade = new FrmLocalizarCidade();
            frmLocalizarCidade.ShowDialog();
        }
    }
}

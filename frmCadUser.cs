using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Money
{
    public partial class frmCadUser : frmBase
    {
        # region Variáveis

        public string Idusuario { get; set; }
        public string Usuario { get; set; }
        public string Cpf { get; set; }
        public string Cpf2 { get; set; }
        
        public char Comdigito { get; set; }
        public int Digito01 { get; set; }
        public int Digito02 { get; set; }
        public string Query = "SELECT MAX(idusuario) FROM usuario";

        # endregion Variáveis

        public frmCadUser()
        {
            InitializeComponent();
        }

        public override void LimpaCampo()
        {
            base.LimpaCampo();
        }
                
        private void validarCPF()
        {
            string cpfSemPonto;
            cpfSemPonto = txtCpf.Text;
            cpfSemPonto = cpfSemPonto.Replace(",","").Replace("-","");


            if (cpfSemPonto.Length == 11)
            {
                try
                {
                    Cpf = txtCpf.Text.Trim();                    
                    Cpf2 = Cpf;
                    Cpf = Cpf.Remove(Cpf.Length - 2);

                    for (int i = 0; i < 9; i++)
                    {
                        Comdigito = char.Parse(Cpf.Substring(i, 1));
                        int temp = int.Parse(Comdigito.ToString()) * (10 - i);
                        Digito01 += temp;
                    }
                    Digito01 = Digito01 % 11;

                    if (Digito01 < 2)
                    {
                        Digito01 = 0;
                    }
                    else
                    {
                        Digito01 = 11 - Digito01;
                    }

                    Cpf += Digito01.ToString();
                    for (int i = 0; i < 10; i++)
                    {
                        Comdigito = char.Parse(Cpf.Substring(i, 1));
                        int temp = int.Parse(Comdigito.ToString()) * (11 - i);
                        Digito02 = Digito02 + temp;
                    }
                    Digito02 = Digito02 % 11;

                    if (Digito02 < 2)
                    {
                        Digito02 = 0;
                    }
                    else
                    {
                        Digito02 = 11 - Digito02;
                    }

                    Cpf += Digito02;

                    if (Cpf2 == Cpf)
                    {
                        lblSituacaoCPF.ForeColor = Color.Green;
                        lblSituacaoCPF.Text = "CPF Válido";
                    }   
                    
                    else
                    {
                        lblSituacaoCPF.ForeColor = Color.Red;
                        lblSituacaoCPF.Text = "CPF Inválido ";
                        txtCpf.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Campo númerico");
                }
                finally
                {
                    Digito01 = 0;
                    Digito02 = 0;
                }
            }
            else
            {
                MessageBox.Show("Campo CPF não pode ficar vazio\n Insira 11 números, sem pontos, vírgulas ou barras.", "Atenção para o Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
            }
        }

        public static void TexBoxSoNumero(KeyPressEventArgs e)
        {   
            if (char.IsLetter(e.KeyChar) || 
            char.IsSymbol(e.KeyChar) || 
            char.IsWhiteSpace(e.KeyChar) || 
            char.IsPunctuation(e.KeyChar)) 
                e.Handled = true;
        }

        private void frmCadUser_Load(object sender, EventArgs e)
        {
            Int32 codigo00;
            codigo00 = Convert.ToInt32(txt_CodUsuario.Text);
            codigo00 = codigo00 + 1;            
        }
        
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string valorsemformato;
                valorsemformato = txtCpf.Text;
                valorsemformato = valorsemformato.Replace(",", "").Replace("-", "");

                UsuarioModel objusuario = new UsuarioModel();

                objusuario.IDUsuario = Convert.ToInt32(txt_CodUsuario.Text);
                objusuario.Usuario = txt_Usuario.Text;
                objusuario.Cpf = Convert.ToUInt64(valorsemformato);
                objusuario.Senha = Convert.ToString(txtSenha.Text);
                objusuario.Repitasenha = Convert.ToString(txtSenhaRep.Text);
                objusuario.Nivelacesso = cmbNivelAcesso.Text;
                objusuario.Datacadastro = Convert.ToDateTime(dtCadastro.Text);

                UsuarioBLL usuariobll = new UsuarioBLL();

                if (txt_Usuario.Text == string.Empty)
                {
                    MessageBox.Show("Digite um nome de usuário.", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txt_Usuario.Focus();
                }
                else if (txtSenha.Text != txtSenhaRep.Text)
                {
                    MessageBox.Show("Senha não confere.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtSenha.Text = string.Empty;
                    txtSenhaRep.Text = string.Empty;
                    txtSenha.Focus();
                }
                else if (txtSenha.Text == string.Empty && txtSenhaRep.Text == string.Empty)
                {
                    MessageBox.Show("Digite uma senha", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtSenha.Text = string.Empty;
                    txtSenhaRep.Text = string.Empty;
                    txtSenha.Focus();
                }
                else
                {  
                    usuariobll.gravaUsuarioDal(objusuario);
                    MessageBox.Show("REGISTRO gravado com sucesso! ", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                   
                    LimpaCampo();                    
                    txt_CodUsuario.Text = CodigoMaisUm(Query).ToString();
                    txt_Usuario.Focus();
                    lblSituacaoCPF.Text = string.Empty;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Campo CPF não pode ficar vazio ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCpf.Focus();
            }
            catch (OverflowException ov)
            {
                MessageBox.Show("Overfow Exeção deu erro! " + ov);
            }
            catch (Win32Exception erro)
            {
                MessageBox.Show("Win32 Win32!!! \n" + erro);
            }
            catch (Exception)
            {
                MessageBox.Show("CPF já cadastrado! ","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtCpf.Focus();
            }            
        }
        
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            UsuarioModel objusuario = new UsuarioModel();

            try
            {
                string valorsemformato;
                valorsemformato = txtCpf.Text;
                valorsemformato = valorsemformato.Replace(",", "").Replace(",", "").Replace("-", "");

                objusuario.Usuario = txt_Usuario.Text;
                objusuario.Cpf = Convert.ToUInt64(valorsemformato);
                objusuario.Senha = Convert.ToString(txtSenha.Text);
                objusuario.Repitasenha = Convert.ToString(txtSenhaRep.Text);
                objusuario.Nivelacesso = cmbNivelAcesso.Text;
                objusuario.IDUsuario = Convert.ToInt32(txt_CodUsuario.Text);

                UsuarioBLL usuariobll = new UsuarioBLL();
                usuariobll.atualizaUsuarioDal(objusuario);
                MessageBox.Show("Usuário alterado ! ", "Informação !)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Não há dados para alterar. Localize um registro primeiro.", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            UsuarioModel objusuario = new UsuarioModel();
            if (MessageBox.Show("Excluir Registro ?", "Pergunta ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    objusuario.Usuario = txt_Usuario.Text;
                    objusuario.Senha = txt_Usuario.Text;
                    objusuario.IDUsuario = Convert.ToInt32(txt_CodUsuario.Text);


                    UsuarioBLL usuariobll = new UsuarioBLL();
                    usuariobll.excluiUsuarioDal(objusuario);
                    MessageBox.Show("Usuário Excluído com Sucesso ! ", "Informação !)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                catch (OleDbException)
                {
                    MessageBox.Show("Não há dados para deletar. Localize um registro primeiro.", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }    
        
        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (e.KeyChar == 13)
            {
                validarCPF();
            }
            TexBoxSoNumero(e);
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            validarCPF();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampo();            
            txt_CodUsuario.Text = CodigoMaisUm(Query).ToString();
        }
    }
}


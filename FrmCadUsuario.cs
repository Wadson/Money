using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Money
{
    public partial class FrmCadUsuario : FrmBaseGeral
    {       
        public FrmCadUsuario()
        {
            InitializeComponent();           
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
        public void Gravar()
        {
            try
            {
                UsuarioModel objusuario = new UsuarioModel();

                objusuario.IDUsuario = Convert.ToInt32(IdUsuario);
                objusuario.Nome = txtNome.Text;
                objusuario.Usuario = txtUsuario.Text;
                objusuario.Senha = Convert.ToString(txtSenha.Text);
                objusuario.Nivelacesso = cmbNivelAcesso.Text;               
                objusuario.Dtnascimento = Convert.ToDateTime(txtdtNascimento.Text);

                UsuarioBLL usuariobll = new UsuarioBLL();

                if (IdUsuario != 0 && txtUsuario.Text != string.Empty && cmbNivelAcesso.Text != string.Empty && txtSenha.Text == txtRepitasenha.Text)
                {
                    usuariobll.gravaUsuarioDal(objusuario);
                    MessageBox.Show("REGISTRO gravado com sucesso! ", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LimpaCampo();
                    IdUsuario = RetornaCodigoContaMaisUm(QueryUsuario);
                    txtUsuario.Focus();
                }                
            }
            catch (OverflowException ov)
            {
                MessageBox.Show("Overfow Exeção deu erro! " + ov);
            }
            catch (Win32Exception erro)
            {
                MessageBox.Show("Win32 Win32!!! \n" + erro);
            }
        }

        public void EvitaUsuarioDuplicado()
        {
            var conn = Conexao.Conex();

            SqlCeCommand queryVerificaNome = new SqlCeCommand("SELECT COUNT(*) FROM usuario WHERE usuario = @usuario", conn);
            string retorno;

            try
            {
                SqlCeParameter parametro = new SqlCeParameter();
                parametro.ParameterName = "@usuario";
                parametro.Value = txtUsuario.Text;
                queryVerificaNome.Parameters.Add(parametro);

                conn.Open();

                retorno = queryVerificaNome.ExecuteScalar().ToString();
                

                if (retorno != "0")
                {
                    MessageBox.Show("Usuário já cadastrado", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtUsuario.Focus();
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex, "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            finally
            {
                conn.Close();
            }            
        }
        public void EvitaNomeDuplicado()
        {
            var conn = Conexao.Conex();

            SqlCeCommand queryVerificaNome = new SqlCeCommand("SELECT COUNT(*) FROM usuario WHERE nome = @nome", conn);
            string retorno;

            try
            {
                SqlCeParameter parametro = new SqlCeParameter();
                parametro.ParameterName = "@nome";
                parametro.Value = txtNome.Text;
                queryVerificaNome.Parameters.Add(parametro);

                conn.Open();

                retorno = queryVerificaNome.ExecuteScalar().ToString();

                if (retorno != "0")
                {
                    MessageBox.Show("Nome já cadastrado", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex, "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            finally
            {
                conn.Close();
            }
        }
       
        //private void btnNo(object sender, EventArgs e)
        //{
        //    //txtNome.Select();
        //    //IdUsuario = RetornaCodigoContaMaisUm(QueryUsuario);
        //}

        private void Frm_Cad_Usuario_Load(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                AcrescenteZero_a_Esquerda();
                return;
               
            }
            if (StatusOperacao == "NOVO")
            {
                IdUsuario = RetornaCodigoContaMaisUm(QueryUsuario);
                txtCodigo.Text = RetornaCodigoContaMaisUm(QueryUsuario).ToString(); 
                txtUsuario.Focus();
                txtdtNascimento.Text = DateTime.Now.ToShortDateString();
            }
            AcrescenteZero_a_Esquerda();                      
        }

        //private void btnizar_Click(object sender, EventArgs e)
        //{
        //    Frm_Pesquisa_Usuario pesqusuario = new Frm_Pesquisa_Usuario();
        //    pesqusuario.ShowDialog();

        //    IdUsuario = pesqusuario.IdUsuario;
        //    txtNome.Text = pesqusuario.Nome;
        //    IdUsuario = pesqusuario.IdUsuario;           
        //    txtUsuario.Text = pesqusuario.Usuário;
        //    cmbNivelAcesso.Text = pesqusuario.NivelAcesso;
        //    dtNascimento.Text = pesqusuario.dtNascimento;
        //}

        private void txtNome_Leave(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.Ivory; lblNome.Visible = false; lblUsuario.Visible = false; lblData.Visible = false; lblSenha.Visible = false; lblConfSenha.Visible = false; lblNivel.Visible = false; 
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            EvitaUsuarioDuplicado(); txtUsuario.BackColor = Color.Ivory; lblNome.Visible = false; lblUsuario.Visible = false; lblData.Visible = false; lblSenha.Visible = false; lblConfSenha.Visible = false; lblNivel.Visible = false; 
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            Frm_Data2 data2 = new Frm_Data2(this);
            data2.ShowDialog();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.Yellow; lblNome.Visible = true; lblUsuario.Visible = false; lblData.Visible = false; lblSenha.Visible = false; lblConfSenha.Visible = false; lblNivel.Visible = false; 
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.Yellow; lblNome.Visible = false; lblUsuario.Visible = true; lblData.Visible = false; lblSenha.Visible = false; lblConfSenha.Visible = false; lblNivel.Visible = false; 
        }

        private void dtNascimento_Enter(object sender, EventArgs e)
        {
            txtdtNascimento.BackColor = Color.Yellow; lblNome.Visible = false; lblUsuario.Visible = false; lblData.Visible = true; lblSenha.Visible = false; lblConfSenha.Visible = false; lblNivel.Visible = false; 
        }

        private void dtNascimento_Leave(object sender, EventArgs e)
        {
            txtdtNascimento.BackColor = Color.Ivory; lblNome.Visible = false; lblUsuario.Visible = false; lblData.Visible = false; lblSenha.Visible = false; lblConfSenha.Visible = false; lblNivel.Visible = false; 
        }

        private void cmbNivelAcesso_Enter(object sender, EventArgs e)
        {
            cmbNivelAcesso.BackColor = Color.Yellow; lblNome.Visible = false; lblUsuario.Visible = false; lblData.Visible = false; lblSenha.Visible = false; lblConfSenha.Visible = false; lblNivel.Visible = true; 
        }

        private void cmbNivelAcesso_Leave(object sender, EventArgs e)
        {
            cmbNivelAcesso.BackColor = Color.Ivory; lblNome.Visible = false; lblUsuario.Visible = false; lblData.Visible = false; lblSenha.Visible = false; lblConfSenha.Visible = false; lblNivel.Visible = false; 
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.Yellow; lblNome.Visible = false; lblUsuario.Visible = false; lblData.Visible = false; lblSenha.Visible = true; lblConfSenha.Visible = false; lblNivel.Visible = false; 
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.Ivory; lblNome.Visible = false; lblUsuario.Visible = false; lblData.Visible = false; lblSenha.Visible = false; lblConfSenha.Visible = false; lblNivel.Visible = false; 
        }

        private void txtRepitasenha_Enter(object sender, EventArgs e)
        {
            txtRepitasenha.BackColor = Color.Yellow; lblNome.Visible = false; lblUsuario.Visible = false; lblData.Visible = false; lblSenha.Visible = false; lblConfSenha.Visible = true; lblNivel.Visible = false; 
        }

        private void txtRepitasenha_Leave(object sender, EventArgs e)
        {
            txtRepitasenha.BackColor = Color.Ivory; lblNome.Visible = false; lblUsuario.Visible = false; lblData.Visible = false; lblSenha.Visible = false; lblConfSenha.Visible = false; lblNivel.Visible = false; 
        }
        public void AlterarRegistro()
        {
            UsuarioModel objetoUsuario = new UsuarioModel();

            objetoUsuario.IDUsuario = Convert.ToInt32(txtCodigo.Text);
            objetoUsuario.Nome = txtNome.Text;
            objetoUsuario.Usuario = txtUsuario.Text;
            objetoUsuario.Dtnascimento = Convert.ToDateTime(txtdtNascimento.Text);
            objetoUsuario.Senha = txtUsuario.Text;
            objetoUsuario.Nivelacesso = cmbNivelAcesso.Text;
           

            UsuarioBLL usuarioBll = new UsuarioBLL();

            usuarioBll.atualizaUsuarioDal(objetoUsuario);
            MessageBox.Show("Registro Alterado com sucesso!", "Alteração!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            try
            {

                //this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterar O REGISTRO!!! " + erro);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FrmPesquisaUsuario pesquisausuario = new FrmPesquisaUsuario();

            if (StatusOperacao == "ALTERAR")
            {
                AlterarRegistro();
                
            }
            if (StatusOperacao == "NOVO")
            {
                EvitarDuplicado("usuario", "nome", txtNome.Text);
                if (RetornoEvitaDuplicado == "0")
                {
                    Gravar();
                    LimpaCampo();
                    txtNome.Focus();
                    txtdtNascimento.Text = DateTime.Now.ToShortDateString();
                    txtCodigo.Text = RetornaCodigoContaMaisUm(QueryFornecedor).ToString();
                    IdUsuario = RetornaCodigoContaMaisUm(QueryUsuario);
                    AcrescenteZero_a_Esquerda();
                    
                }
            }
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

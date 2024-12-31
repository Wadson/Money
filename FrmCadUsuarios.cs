using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Money
{
    public partial class FrmCadUsuarios : FrmBaseGeral
    {       
        public FrmCadUsuarios()
        {
            InitializeComponent();           
        }
      
        public void SalvarRegistro()
        {
            try
            {
                UsuarioModel objusuario = new UsuarioModel();

                objusuario.Id_usuario = Convert.ToInt32(txtCodigo.Text);
                objusuario.Nome = txtNome.Text;
                objusuario.Usuario = txtUsuario.Text;
                objusuario.Senha = Convert.ToString(txtSenha.Text);
                objusuario.Nivelacesso_usuario = cmbNivelAcesso.Text;               
                objusuario.Dt_nascimento = Convert.ToDateTime(txtdtNascimento.Text);
                objusuario.Email = txtEmail.Text;
                UsuarioBLL usuariobll = new UsuarioBLL();

                if (IdUsuario != 0 && txtUsuario.Text != string.Empty && cmbNivelAcesso.Text != string.Empty && txtSenha.Text == txtRepitasenha.Text)
                {
                    usuariobll.gravaUsuarioDal(objusuario);
                    MessageBox.Show("REGISTRO gravado com sucesso! ", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ((FrmManutUsuario)Application.OpenForms["FrmManutUsuario"]).HabilitarTimer(true);
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

            SqlCommand queryVerificaNome = new SqlCommand("SELECT COUNT(*) FROM usuario WHERE usuario = @Usuario", conn);
            string retorno;

            try
            {
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Usuario";
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

            SqlCommand queryVerificaNome = new SqlCommand("SELECT COUNT(*) FROM usuario WHERE usuario = @Usuario", conn);
            string retorno;

            try
            {
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@Usuario";
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
                AcrescenteZero_a_Esquerda2(txtCodigo); 
            }
            if (StatusOperacao == "NOVO")
            {
                IdUsuario = RetornaCodigoContaMaisUm(QueryUsuario);
                txtCodigo.Text = RetornaCodigoContaMaisUm(QueryUsuario).ToString(); 
                txtUsuario.Focus();                
            }                               
            AcrescenteZero_a_Esquerda2(txtCodigo);
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

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.Yellow; lblNome.Visible = true; lblUsuario.Visible = false; lblData.Visible = false; lblSenha.Visible = false; lblConfSenha.Visible = false; lblNivel.Visible = false; 
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.Yellow; lblNome.Visible = false; lblUsuario.Visible = true; lblData.Visible = false; lblSenha.Visible = false; lblConfSenha.Visible = false; lblNivel.Visible = false; 
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

            objetoUsuario.Id_usuario = Convert.ToInt32(txtCodigo.Text);
            objetoUsuario.Nome = txtNome.Text;
            objetoUsuario.Usuario = txtUsuario.Text;
            objetoUsuario.Dt_nascimento = Convert.ToDateTime(txtdtNascimento.Text);
            objetoUsuario.Senha = txtSenha.Text;
            objetoUsuario.Nivelacesso_usuario = cmbNivelAcesso.Text;
            objetoUsuario.Email = txtEmail.Text;


            UsuarioBLL usuarioBll = new UsuarioBLL();

            usuarioBll.atualizaUsuarioDal(objetoUsuario);
            MessageBox.Show("Registro Alterado com sucesso!", "Alteração!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ((FrmManutUsuario)Application.OpenForms["FrmManutUsuario"]).HabilitarTimer(true);// Habilita Timer do outro form Obs: O timer no outro form executa um Método.    
            LimpaCampo();
            this.Close();

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
            FrmManutUsuario pesquisausuario = new FrmManutUsuario();

            if (StatusOperacao == "ALTERAR")
            {
                AlterarRegistro();
            }
            if (StatusOperacao == "NOVO")
            {
                EvitarDuplicado("usuario", "usuario", txtNome.Text);
                if (RetornoEvitaDuplicado == "0")
                {
                    SalvarRegistro();
                    LimpaCampo();
                    txtNome.Focus();
                    txtdtNascimento.Text = DateTime.Now.ToShortDateString();

                    txtCodigo.Text = RetornaCodigoContaMaisUm(QueryUsuario).ToString();
                    IdUsuario = RetornaCodigoContaMaisUm(QueryUsuario);
                    AcrescenteZero_a_Esquerda2(txtCodigo);
                    ((FrmManutUsuario)Application.OpenForms["FrmManutUsuario"]).HabilitarTimer(true);
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampo();
            txtCodigo.Text = RetornaCodigoContaMaisUm(QueryUsuario).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.IO;
using Microsoft.VisualBasic;

using Microsoft.SqlServer;
using Microsoft.SqlServer.Server;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Data.SqlServerCe;

namespace Money
{
    public partial class FrmLogin : Form
    {
        public static string NivelAcesso;
        public static string usuarioConectado;
        public bool Conectado = false;
        //public string RetornoEvitaDuplicado { get; set; }
        public string UsuarioConectado { get; set; }
        DateTime DataHora;
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public string RetornoEvitaDuplicado { get; set; }
        public FrmLogin()
        {
            InitializeComponent();            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

             
        public void LocalizarNivelAcesso()
        {
            var conn = Conexao.Conex();

            SqlCommand comando = new SqlCommand("SELECT nivelacesso FROM usuario WHERE usuario = @Usuario", conn);
            if (txt_SenhaLog.Text != "" && txtUsuario.Text != "")
            {
                try
                {
                    SqlParameter parametro = new SqlParameter();
                    parametro.ParameterName = "@Usuario";
                    parametro.Value = txtUsuario.Text;
                    comando.Parameters.Add(parametro);

                    conn.Open();
                    RetornoEvitaDuplicado = comando.ExecuteScalar().ToString();

                    if (RetornoEvitaDuplicado != "0")
                    {
                        NivelAcesso = RetornoEvitaDuplicado;
                    }                    
                }
                catch
                {                    
                }
                finally
                {
                    conn.Close();
                }
            }
        }       
        private void btn_Logar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtUsuario.Text, txt_SenhaLog.Text);

            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmPrincip fr1 = new FrmPrincip();
                    fr1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
            //ValidaUser();
        }
       
        public void Inserir_usuario(int idusuario, string nome, string usuario, string senha)
        {
            try
            {
                var conn = Conexao.Conex();
                string verifica_banco = "SELECT count(*) FROM usuario";// novo
                var cmd2 = new SqlCommand(verifica_banco, conn);// Novo

                SqlCommand sql = new SqlCommand("INSERT INTO usuario (idusuario,nome, usuario, senha) VALUES (@idusuario, @nome, @usuario, @senha)", conn);

                sql.Parameters.AddWithValue("@idusuario", idusuario);
                sql.Parameters.AddWithValue("@nome", nome);
                sql.Parameters.AddWithValue("@usuario", usuario);
                sql.Parameters.AddWithValue("@senha", senha);

                conn.Open();

                Int32 count = Convert.ToInt32(cmd2.ExecuteScalar());
                if (count == 0)
                {
                    sql.ExecuteNonQuery();
                    lblProvisorio.Text = "Login Provisório: Usuário = admin, Senha = admin";
                    conn.Close();
                }
                else
                {

                }
            }
            catch
            {
            }
        }
       

        private void lblEsqueciSenha_Click(object sender, EventArgs e)
        {
            FrmResent_Senha resetsenha = new FrmResent_Senha();
            resetsenha.lblTitulo.Text = "RECUPERAÇÃO DE SENHA";
            resetsenha.ShowDialog();
        }

      
        public static void CreateDatabase_Tabela()
        {
            var Connection = Conexao.Conex();
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            path = path + @"\ScriptCriaBanco.sqlce";

            string script = File.ReadAllText(path);
          
            IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
                                     RegexOptions.Multiline | RegexOptions.IgnoreCase);

            Connection.Open();

            foreach (string commandString in commandStrings)
            {
                if (commandString.Trim() != "")
                {
                    using (var command = new SqlCommand(commandString, Connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            Connection.Close();           
        }               
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            penelLinhaUsuario.BackColor = Color.Blue;
            lblUsuario.Text = "";
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            penelLinhaUsuario.BackColor = Color.DimGray;
            lblUsuario.Text = "";           
        }

        private void txt_SenhaLog_Enter(object sender, EventArgs e)
        {
            PaneLinhaSenha.BackColor = Color.Blue;
            lblSenha.Text = "";
        }

        private void txt_SenhaLog_Leave(object sender, EventArgs e)
        {
            PaneLinhaSenha.BackColor = Color.DimGray;
            lblSenha.Text = "";            
        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {           
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }                
        private void barraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        public void ValidaUsuario()
        {
            string query = "SELECT nivelacesso FROM usuario WHERE usuario = @usuario and senha = @senha";
            string returnValue = "";
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-WR\\SQLEXPRESS;Initial Catalog=bdmoney;Integrated Security=True;"))
            {
                using (SqlCommand sqlcmd = new SqlCommand(query, con))
                {
                    sqlcmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = txtUsuario.Text;
                    sqlcmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = txt_SenhaLog.Text;
                    con.Open();
                    returnValue = (string)sqlcmd.ExecuteScalar();
                }
            }
            //EDIT to avoid NRE 
            if (String.IsNullOrEmpty(returnValue))
            {
                MessageBox.Show("Usuário ou senha incorretos!");
                return;
            }
            returnValue = returnValue.Trim();
            if (returnValue == "Admin")
            {
                MessageBox.Show("Você está logado como Administrador");
                FrmPrincip fr1 = new FrmPrincip();
                fr1.Show();
                this.Hide();
            }
            else if (returnValue == "User")
            {
                MessageBox.Show("Você está logado como Usuário");
                //UserHome fr2 = new UserHome();
                //fr2.Show();
                //this.Hide();
            }
        }


        private void ValidaUser()
        {            
           var conn = Conexao.Conex();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM usuario WHERE usuario = '" + txtUsuario.Text + "' AND senha = '" + txt_SenhaLog.Text + "'", conn);            
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                FrmPrincip home = new FrmPrincip();                
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataHora = DateTime.Now;
            lblData.Text = "Data: " + DataHora.ToLongDateString() + " ás:" + DataHora.ToLongTimeString();
        }
    }

}

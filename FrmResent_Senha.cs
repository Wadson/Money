using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Money
{
    public partial class FrmResent_Senha : FrmBaseGeral
    {
        public FrmResent_Senha()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void LocalizarUsuario()
        {
            var conn = Conexao.Conex();

            try
            {
                SqlCommand sqlcomm = new SqlCommand("SELECT usuario FROM usuario WHERE nome = @nome ", conn);
                sqlcomm.Parameters.AddWithValue("@nome", txtNome.Text);
               


                SqlCommand sqlcom2 = new SqlCommand("SELECT   senha FROM usuario WHERE nome = @nome ", conn);
                sqlcom2.Parameters.AddWithValue("@nome", txtNome.Text);
              


                conn.Open();

                lblUsuario.Text = sqlcomm.ExecuteScalar().ToString();
                lblSenha.Text = sqlcom2.ExecuteScalar().ToString();

            }
            catch
            {
                MessageBox.Show("Nada encontrado usuario", "Informe",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }

        private void FrmResentSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{tab}");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {            
        }

        private void btnLocalizarFornecedor_Click(object sender, EventArgs e)
        {
            LocalizarUsuario();           
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            penelLinhaUsuario.BackColor = Color.DimGray;
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            penelLinhaUsuario.BackColor = Color.DodgerBlue;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {           
        }
    }
}

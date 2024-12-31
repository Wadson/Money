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
    public partial class FrmManutUsuario : BasePesquisa
    {
        public FrmManutUsuario()
        {
            InitializeComponent();
        }     

        private void FrmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            ListaUsuario();   
        }
        public override void carregaGrid2Localizar(SqlCommand criterioSQL, DataGridView DatagridParametro)
        {
            base.carregaGrid2Localizar(criterioSQL, DatagridParametro);
        }
        public void ListaUsuario()
        {
            UsuarioBLL usuarioBll = new UsuarioBLL();
            dataGridPesquisa2.DataSource = usuarioBll.lista_Usuario_dal();            
        }
        private void CarregaDados()
        {
            FrmCadUsuarios cadUsuarios = new FrmCadUsuarios();   
           
            try
            {
                cadUsuarios.txtCodigo.Text = dataGridPesquisa2.CurrentRow.Cells["id_usuario"].Value.ToString();
                cadUsuarios.txtNome.Text = dataGridPesquisa2.CurrentRow.Cells["nome"].Value.ToString();
                Nome =                     dataGridPesquisa2.CurrentRow.Cells["nome"].Value.ToString();
                cadUsuarios.txtUsuario.Text = dataGridPesquisa2.CurrentRow.Cells["usuario"].Value.ToString();
                cadUsuarios.txtdtNascimento.Text = dataGridPesquisa2.CurrentRow.Cells["dt_nascimento"].Value.ToString();
                cadUsuarios.cmbNivelAcesso.Text = dataGridPesquisa2.CurrentRow.Cells["nivelacesso"].Value.ToString();
                cadUsuarios.txtSenha.Text = dataGridPesquisa2.CurrentRow.Cells["senha"].Value.ToString();
                cadUsuarios.txtEmail.Text = dataGridPesquisa2.CurrentRow.Cells["email"].Value.ToString();

                cadUsuarios.StatusOperacao = "ALTERAR";
                cadUsuarios.lblTitulo.Text = "ALTERAR" +" (( "+ Nome +"))";
                cadUsuarios.Text = "Money - Alterar registro" + " | " + Usuário;

                cadUsuarios.ShowDialog();

                ListaUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
            ((FrmManutUsuario)Application.OpenForms["FrmManutUsuario"]).HabilitarTimer(true);
        }
       
        public void ExcluirUsuario()
        {
            try
            {
                IdUsuario = Convert.ToInt32(dataGridPesquisa2.CurrentRow.Cells[0].Value);
                Nome = dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString();
                
                if (MessageBox.Show("Deseja Excluir? \n\n O Usuário: "+ Nome +" ??? ","Excluir",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UsuarioModel usuariomodel = new UsuarioModel();
                    usuariomodel.Id_usuario = Convert.ToInt32(IdUsuario);

                    UsuarioBLL usuariobll = new UsuarioBLL();
                    usuariobll.excluiUsuarioDal(usuariomodel);
                    MessageBox.Show("REGISTRO EXCLUÍDO!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ((FrmManutUsuario)Application.OpenForms["FrmManutUsuario"]).HabilitarTimer(true);
                    ListaUsuario();
                }
            }
            catch
            {
            }
        }
        private void LocalizaUsuario()
        {
            var conn = Conexao.Conex();

            SqlCommand sqlStringDesc = new SqlCommand(" SELECT id_usuario, nome_usuario, user_usuario, dt_nascimento, nivelacesso_usuario, senha_usuario, email_usuario FROM usuario WHERE nome_usuario  LIKE @criterio", conn);
            sqlStringDesc.Parameters.AddWithValue("@criterio", txtPesquisa.Text + "%");

            carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa2);
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            LocalizaUsuario();
        }
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadUsuarios childForm = new FrmCadUsuarios();
            childForm.lblTitulo.Text = "NOVO CADASTRO";
                childForm.StatusOperacao = "NOVO";
                childForm.ShowDialog();
            ((FrmManutUsuario)Application.OpenForms["FrmManutUsuario"]).HabilitarTimer(true);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CarregaDados();           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirUsuario();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListaUsuario();
            timer1.Enabled = false;
        }

        private void dataGridPesquisa2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaDados();
        }
           
    }
}

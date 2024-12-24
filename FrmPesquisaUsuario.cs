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
    public partial class FrmPesquisaUsuario : BasePesquisa
    {
        public FrmPesquisaUsuario()
        {
            InitializeComponent();
        }
        
        private void FrmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            ListaUsuario();
            DataGridViewRow row = this.dataGridPesquisa.RowTemplate;
            //row.DefaultCellStyle.BackColor = Color.Bisque;
            row.Height = 17;
            row.MinimumHeight = 17;            
        }
        public override void carregaGrid2Localizar(SqlCeCommand criterioSQL, DataGridView DatagridParametro)
        {
            base.carregaGrid2Localizar(criterioSQL, DatagridParametro);
        }       
        public void ListaUsuario()
        {
            UsuarioBLL usuarioBll = new UsuarioBLL();
            dataGridPesquisa.DataSource = usuarioBll.lista_Usuario_dal();
        }
        private void CarregaDados()
        {
            FrmCadUsuario f3 = new FrmCadUsuario();
           
            try
            {
                if (linhaAtual >= 0)
                {
                    f3.txtCodigo.Text = dataGridPesquisa[0, linhaAtual].Value.ToString();
                    f3.txtNome.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                    f3.txtUsuario.Text = dataGridPesquisa[2, linhaAtual].Value.ToString();

                    f3.txtdtNascimento.Text = dataGridPesquisa[3, linhaAtual].Value.ToString();
                    f3.cmbNivelAcesso.Text = dataGridPesquisa[4, linhaAtual].Value.ToString();
                    f3.txtSenha.Text = dataGridPesquisa[5, linhaAtual].Value.ToString();

                    f3.StatusOperacao = "ALTERAR";
                    f3.Text = "Alterar Fornecedor : > " + Nome;

                    f3.ShowDialog();
                    ListaUsuario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
        }
       
        public void ExcluirUsuario()
        {
            IdUsuario = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
            Nome = dataGridPesquisa[1, linhaAtual].Value.ToString();
            string message = "Deseja excluir este usuário? \n\nCódigo: " + IdUsuario + " \n\nUsuário: "+ Nome;
            string Titulo = "EXCLUSÃO?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icons = MessageBoxIcon.Question;

;            DialogResult result;
            try
            {
                result = MessageBox.Show(message, Titulo, buttons, icons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    UsuarioModel usuariomodel = new UsuarioModel();
                    usuariomodel.IDUsuario = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);

                    UsuarioBLL usuariobll = new UsuarioBLL();
                    usuariobll.excluiUsuarioDal(usuariomodel);
                    MessageBox.Show("REGISTRO EXCLUÍDO!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ListaUsuario();
                }
            }
            catch
            {
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            var conn = Conexao.Conex();

            if (rbtDescricao.Checked == true)
            {
                SqlCeCommand sqlStringNome = new SqlCeCommand("SELECT idusuario,nome, usuario, dtnascimento, nivelacesso, senha FROM usuario WHERE usuario LIKE @pesquisa", conn);
                sqlStringNome.Parameters.AddWithValue("@pesquisa", txtPesquisa.Text + "%");
                carregaGrid2Localizar(sqlStringNome, dataGridPesquisa);
            }
            if (rbtCodigo.Checked == true)
            {
                SqlCeCommand sqlStringNome = new SqlCeCommand("SELECT idusuario,nome, usuario, dtnascimento, nivelacesso, senha FROM usuario WHERE idusuario LIKE @pesquisa", conn);
                sqlStringNome.Parameters.AddWithValue("@pesquisa", txtPesquisa.Text + "%");
                carregaGrid2Localizar(sqlStringNome, dataGridPesquisa);
            }           
        }
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadUsuario caduser = new FrmCadUsuario();
            caduser.StatusOperacao = "NOVO";
            caduser.ShowDialog();
            ListaUsuario();
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

        private void dataGridPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaDados();
        }

        private void dataGridPesquisa_SelectionChanged(object sender, EventArgs e)
        {
            linhaAtual = dataGridPesquisa.CurrentRow.Index;
        }

        private void dataGridPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }      
    }
}

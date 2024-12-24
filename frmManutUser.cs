using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Money
{
    public partial class frmManutUser : Money.frmBase
    {
        frmCadUser cadusuario = new frmCadUser();

        public string Idusuario { get; set; }
        public string Usuario { get; set; }
        public string criterio, sqlString = "";
        private int linhaAtual = 0;

        public frmManutUser()
        {
            InitializeComponent();
        }

        public void CarregaDados()
        {
            try
            {
                UsuarioBLL usuariobll = new UsuarioBLL();
                dtgridPesqUser.DataSource = usuariobll.lista_Usuario_dal();
                FormataGrid();

                string contagem;
                contagem = dtgridPesqUser.RowCount.ToString();
                lblRegistros.Text = contagem;
            }
            catch 
            {
                MessageBox.Show("Restaure o banco de dados ", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }        

        private void FormataGrid()
        {
            dtgridPesqUser.RowsDefaultCellStyle.BackColor = Color.AliceBlue;            
            dtgridPesqUser.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;

            dtgridPesqUser.Columns[0].Width = 50;
            dtgridPesqUser.Columns[1].Width = 250;
            dtgridPesqUser.Columns[2].Width = 100;
            dtgridPesqUser.Columns[3].Width = 100;
            dtgridPesqUser.Columns[4].Width = 90; 

            dtgridPesqUser.Columns[0].HeaderText = "Código";
            dtgridPesqUser.Columns[1].HeaderText = "Usuário";
            dtgridPesqUser.Columns[2].HeaderText = "CPF";
            dtgridPesqUser.Columns[3].HeaderText = "Nivel de Acesso";
            dtgridPesqUser.Columns[4].HeaderText = "Data Cadastro";

            dtgridPesqUser.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dtgridPesqUser.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dtgridPesqUser.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dtgridPesqUser.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dtgridPesqUser.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dtgridPesqUser.Columns[2].DefaultCellStyle.Format = string.Format(@"000\.000\.000\-00");
            string contagem;
            contagem = dtgridPesqUser.RowCount.ToString();
            lblRegistros.Text = contagem;                        
        }

        private void carregaGrid(string criterioSQL)
        {           
            dtgridPesqUser.DataSource = null;

            string conecao = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Money\bin\Debug\bdfinance.accdb";
            OleDbConnection Conn = new OleDbConnection(conecao);

            OleDbCommand comandos = new OleDbCommand();
            comandos.CommandText = Convert.ToString(CommandType.Text);
            comandos.CommandText = sqlString;
            comandos.Connection = Conn;
           
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();

                    DataTable tabela = new DataTable();
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = comandos;
                    adapter.Fill(tabela);

                    if (tabela.Rows.Count > 0)
                    {
                        dtgridPesqUser.DataSource = tabela;
                        FormataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPesquisa.Focus();
                        txtPesquisa.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally { conecao.Clone(); }
        }
        private void CapturaDadosGrid()
        {
            frmCadUser cadusuario = new frmCadUser();

            try
            {
                Idusuario = dtgridPesqUser[0, linhaAtual].Value.ToString();

                if (linhaAtual >= 0)
                {
                    cadusuario.txt_CodUsuario.Text = dtgridPesqUser[0, linhaAtual].Value.ToString();
                    cadusuario.txt_Usuario.Text = dtgridPesqUser[1, linhaAtual].Value.ToString();
                    cadusuario.txtCpf.Text = dtgridPesqUser[2, linhaAtual].Value.ToString();
                    cadusuario.cmbNivelAcesso.Text = dtgridPesqUser[3, linhaAtual].Value.ToString();
                    cadusuario.dtCadastro.Text = dtgridPesqUser[4, linhaAtual].Value.ToString();

                    dtgridPesqUser.Update();
                    cadusuario.ShowDialog();
                    CarregaDados();
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }           
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadUser cadusuario = new frmCadUser();
            cadusuario.Query = "SELECT MAX(idusuario) FROM usuario";
            cadusuario.LimpaCampo();            
            cadusuario.txt_CodUsuario.Text = cadusuario.CodigoMaisUm(cadusuario.Query).ToString();

            cadusuario.txt_Usuario.Focus();
            cadusuario.Text = "Money - Cadastro de Usuário";            
            cadusuario.btnGravar.Enabled = true;

            cadusuario.btnAlterar.Enabled = false;
            cadusuario.btnExcluir.Enabled = false;
            
            cadusuario.ShowDialog();
            CarregaDados();
        }

        private void frmManutUser_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void dtgridPesqUser_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i = dtgridPesqUser.CurrentRow.Index;
            }
            catch
            {
                MessageBox.Show("Êpa! Esta grid não aceita classificação.","Atenção !",MessageBoxButtons.OK,MessageBoxIcon.None);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {                      
           
            try
            {
                Idusuario = dtgridPesqUser[0, linhaAtual].Value.ToString();

                if (linhaAtual >= 0)
                {
                    cadusuario.txt_CodUsuario.Text = dtgridPesqUser[0, linhaAtual].Value.ToString();
                    cadusuario.txt_Usuario.Text = dtgridPesqUser[1, linhaAtual].Value.ToString();
                    cadusuario.txtCpf.Text = dtgridPesqUser[2, linhaAtual].Value.ToString();
                    cadusuario.cmbNivelAcesso.Text = dtgridPesqUser[3, linhaAtual].Value.ToString();
                    cadusuario.dtCadastro.Text = dtgridPesqUser[4, linhaAtual].Value.ToString();

                    cadusuario.btnExcluir.Enabled = true;
                    cadusuario.btnAlterar.Enabled = false;
                    cadusuario.btnGravar.Enabled = false;
                    cadusuario.btnNovo.Enabled = false;
                    cadusuario.Text = "Money - Excluir Cadastro";

                    cadusuario.ShowDialog();
                    dtgridPesqUser.Update();
                    CarregaDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }                    
        }

        private void dtgridPesqUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }


        private void dtgridPesqUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Idusuario = dtgridPesqUser[0, linhaAtual].Value.ToString();

                if (linhaAtual >= 0)
                {
                    if (frmLogin.NivelAcesso == "Administrador")
                    {
                        cadusuario.txt_CodUsuario.Text = dtgridPesqUser[0, linhaAtual].Value.ToString();
                        cadusuario.txt_Usuario.Text = dtgridPesqUser[1, linhaAtual].Value.ToString();
                        cadusuario.txtCpf.Text = dtgridPesqUser[2, linhaAtual].Value.ToString();
                        cadusuario.cmbNivelAcesso.Text = dtgridPesqUser[3, linhaAtual].Value.ToString();
                        cadusuario.dtCadastro.Text = dtgridPesqUser[4, linhaAtual].Value.ToString();

                        cadusuario.btnAlterar.Enabled = true;
                        cadusuario.btnExcluir.Enabled = false;
                        cadusuario.btnGravar.Enabled = false;
                        cadusuario.btnNovo.Enabled = false;
                        cadusuario.Text = "Money - Alterar Cadastro";

                        cadusuario.ShowDialog();
                        dtgridPesqUser.Update();
                        CarregaDados();
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            criterio = txtPesquisa.Text.ToString();

            if (txtPesquisa.Text != "")
            {
                if (rbtDescricao.Checked == true)
                {                    
                    if (criterio != "")
                        sqlString = "SELECT idusuario, usuario, cpf, nivelacesso, datacadastro FROM usuario WHERE usuario LIKE '" + criterio + "%'";                    
                    carregaGrid(sqlString);
                }
                if (rbtCodigo.Checked == true)
                {                    
                    if (criterio != "")
                        sqlString = "SELECT idusuario, usuario, cpf, nivelacesso,datacadastro FROM usuario WHERE idusuario LIKE '" + criterio + "%'";
                    carregaGrid(sqlString);                    
                }
            }
            else
                CarregaDados();
        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Focus();
            txtPesquisa.Text = string.Empty;
        }

        private void rbtDescricao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Focus();
            txtPesquisa.Text = string.Empty;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Idusuario = dtgridPesqUser[0, linhaAtual].Value.ToString();

                if (linhaAtual >= 0)
                {
                    cadusuario.txt_CodUsuario.Text = dtgridPesqUser[0, linhaAtual].Value.ToString();
                    cadusuario.txt_Usuario.Text = dtgridPesqUser[1, linhaAtual].Value.ToString();
                    cadusuario.txtCpf.Text = dtgridPesqUser[2, linhaAtual].Value.ToString();
                    cadusuario.cmbNivelAcesso.Text = dtgridPesqUser[3, linhaAtual].Value.ToString();
                    cadusuario.dtCadastro.Text = dtgridPesqUser[4, linhaAtual].Value.ToString();

                    cadusuario.btnExcluir.Enabled = false;
                    cadusuario.btnGravar.Enabled = false;
                    cadusuario.btnNovo.Enabled = false;
                    cadusuario.Text = "Money - Alterar Cadastro";
                   
                    cadusuario.ShowDialog();                   
                    dtgridPesqUser.Update();
                    CarregaDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }                   
        }
    }
}

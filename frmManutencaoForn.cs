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
    public partial class frmManutencaoForn : Money.frmBase
    {
        frmCadFornecedor cadforn = new frmCadFornecedor();

        public int linhaAtual = 0;
        public OleDbConnection Conn;
        public OleDbCommand Comm;
        public DataTable dTable;
        public OleDbCommandBuilder comanBilder;
        public BindingSource bSouce;
        public OleDbDataAdapter da;
        string Query = "SELECT MAX(idfornecedor) FROM fornecedor";

        private string Idfornecedor { get; set; }
        public string Fornecedor { get; set; }
        public string Fone { get; set; }
        public string sqlString, criterio = "";

        public string conexao = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Money\bin\Debug\bdfinance.accdb";
        
        public frmManutencaoForn()
        {
            InitializeComponent();
        }
        private void CapturaDadosGrid()
        {
            try
            {
                Idfornecedor = dtgridPesqForn[0, linhaAtual].Value.ToString();

                if (linhaAtual >= 0)
                {
                    cadforn.txtCodig.Text = dtgridPesqForn[0, linhaAtual].Value.ToString();
                    cadforn.txt_NForn.Text = dtgridPesqForn[1, linhaAtual].Value.ToString();
                    cadforn.txtTelefone.Text = dtgridPesqForn[2, linhaAtual].Value.ToString();

                    dtgridPesqForn.Update();                   
                    cadforn.ShowDialog();
                    CarregaDados();  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }           
        }
        public void FormataGrid()
        {
            dtgridPesqForn.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dtgridPesqForn.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            
            dtgridPesqForn.Columns[0].Width = 60;
            dtgridPesqForn.Columns[1].Width = 345;
            dtgridPesqForn.Columns[2].Width = 80;

            dtgridPesqForn.Columns[0].HeaderText = "Código";
            dtgridPesqForn.Columns[1].HeaderText = "Fornecedor";
            dtgridPesqForn.Columns[2].HeaderText = "Fone";

            dtgridPesqForn.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dtgridPesqForn.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

            string contagem;
            contagem = dtgridPesqForn.RowCount.ToString();
            lblRegistros.Text = contagem;
        }

        public override void Conexao()
        {
            base.Conexao();
        }
        private void carregaGrid(string criterioSQL)
        {
            dtgridPesqForn.DataSource = null;

            Conn = new OleDbConnection(conexao);

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
                        dtgridPesqForn.DataSource = tabela;
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
            catch (Exception ex){ ex.Message.ToString();}
            finally { conexao.Clone(); }
        }
      
        public void CarregaDados()
        {
            Conn = new OleDbConnection(conexao);
            Comm = new OleDbCommand("SELECT * FROM fornecedor", Conn);
            da = new OleDbDataAdapter(Comm);
           
            dTable = new DataTable();
            
            Conn.Open();
            comanBilder = new OleDbCommandBuilder(da);
           
            da.Fill(dTable);
            bSouce = new BindingSource();
            bSouce.DataSource = dTable;
            dtgridPesqForn.DataSource = bSouce;

            FormataGrid();
        }

        private void frmManutencaoForn_Load(object sender, EventArgs e)
        {            
            if (frmLogin.NivelAcesso == "Operador")
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;               
            }
            CarregaDados();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {            
            cadforn.LimpaCampo();
            cadforn.txtCodig.Text = cadforn.CodigoMaisUm(Query).ToString();
            cadforn.txt_NForn.Focus();
            cadforn.Text = "Money - Cadastro de Fornecedores";            
            cadforn.btnGravar.Enabled = true;           

            cadforn.btnAlterar.Enabled = false;
            cadforn.btnExcluir.Enabled = false;
            cadforn.txt_NForn.Text = string.Empty;
            cadforn.txtTelefone.Text = string.Empty;

            cadforn.ShowDialog();
            CarregaDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            cadforn.Text = "Money - Alterar Cadastro";            
            cadforn.btnAlterar.Enabled = true;
            cadforn.btnGravar.Enabled = false;            
            cadforn.btnExcluir.Enabled = false;

            CapturaDadosGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {   
            cadforn.Text = "Money - Exclusão d Registro";            
            cadforn.btnExcluir.Enabled = true;
            cadforn.btnGravar.Enabled = false;
            cadforn.btnAlterar.Enabled = false;

            CapturaDadosGrid();                
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgridPesqForn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string contagem;

            if (txtPesquisa.Text != "")
            {
                if (rbtDescricao.Checked == true)
                {
                    criterio = txtPesquisa.Text.ToString();
                    if (criterio != "")
                        sqlString = "SELECT idfornecedor, fornecedor, fone FROM fornecedor WHERE fornecedor LIKE '" + criterio + "%'";
                    carregaGrid(sqlString);
                    
                    contagem = dtgridPesqForn.RowCount.ToString();
                    lblRegistros.Text = contagem;
                }
                if (rbtCodigo.Checked == true)
                {
                    criterio = txtPesquisa.Text.ToString();
                    if (criterio != "")
                        sqlString = "SELECT idfornecedor, fornecedor, fone FROM fornecedor WHERE idfornecedor LIKE '" + criterio + "%'";
                    carregaGrid(sqlString);

                    contagem = dtgridPesqForn.RowCount.ToString();
                    lblRegistros.Text = contagem;
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

        private void dtgridPesqForn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            cadforn.Text = "Money - Alterar Cadastro";
            cadforn.btnAlterar.Enabled = true;
            cadforn.btnGravar.Enabled = false;
            cadforn.btnExcluir.Enabled = false;
            CapturaDadosGrid();
        }
    }
}

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
    public partial class frmManutCidade : Money.frmBase
    {
        frmCadCidade cadcidade = new frmCadCidade();

        public int linhaAtual = 0;
        public OleDbConnection Conn;
        public OleDbCommand Comm;
        public DataTable dTable;
        public OleDbCommandBuilder comanBilder;
        public BindingSource bSouce;
        public OleDbDataAdapter da;

        string Query = "SELECT MAX(idCidade) FROM cidade";
        public string conexao = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Money\bin\Debug\bdfinance.accdb";

        public string Idcidade { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string sqlString, criterio = "";

        public frmManutCidade()
        {
            InitializeComponent();
        }
        private void CapturaDadosGrid()
        {
            try
            {
                Idcidade = dtGridCidade[0, linhaAtual].Value.ToString();

                if (linhaAtual >= 0)
                {
                    cadcidade.txtCodig.Text = dtGridCidade[0, linhaAtual].Value.ToString();
                    cadcidade.txtCidade.Text = dtGridCidade[1, linhaAtual].Value.ToString();
                    cadcidade.txtUf.Text = dtGridCidade[2, linhaAtual].Value.ToString();

                    dtGridCidade.Update();
                    cadcidade.ShowDialog();
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
            dtGridCidade.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dtGridCidade.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;


            dtGridCidade.Columns[0].Width = 50;
            dtGridCidade.Columns[1].Width = 390;
            dtGridCidade.Columns[2].Width = 40;
            
            dtGridCidade.Columns[0].HeaderText = "Código";
            dtGridCidade.Columns[1].HeaderText = "Cidade";
            dtGridCidade.Columns[2].HeaderText = "UF";
            
            dtGridCidade.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dtGridCidade.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

            string contagem;
            contagem = dtGridCidade.RowCount.ToString();
            lblRegistros.Text = contagem;
        }

        public override void Conexao()
        {
            base.Conexao();
        }
        private void carregaGrid(string criterioSQL)
        {
            dtGridCidade.DataSource = null;

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
                        dtGridCidade.DataSource = tabela;
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
            catch (Exception ex) { ex.Message.ToString(); }
            finally { conexao.Clone(); }
        }

        public void CarregaDados()
        {
            Conn = new OleDbConnection(conexao);
            Comm = new OleDbCommand("SELECT * FROM cidade", Conn);
            da = new OleDbDataAdapter(Comm);

            dTable = new DataTable();

            Conn.Open();
            comanBilder = new OleDbCommandBuilder(da);

            da.Fill(dTable);
            bSouce = new BindingSource();
            bSouce.DataSource = dTable;
            dtGridCidade.DataSource = bSouce;

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
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtGridCidade_CellClick(object sender, DataGridViewCellEventArgs e)
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
                        sqlString = "SELECT * FROM cidade WHERE cidade LIKE '" + criterio + "%'";
                    carregaGrid(sqlString);

                    contagem = dtGridCidade.RowCount.ToString();
                    lblRegistros.Text = contagem;
                }
                if (rbtCodigo.Checked == true)
                {                    
                    criterio = txtPesquisa.Text.ToString();
                    if (criterio != "")
                        sqlString = "SELECT * FROM cidade WHERE idcidade LIKE '" + criterio + "%'";
                    carregaGrid(sqlString);

                    contagem = dtGridCidade.RowCount.ToString();
                    lblRegistros.Text = contagem;
                }
            }
            else
                CarregaDados();
        }

        private void frmManutCidade_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cadcidade.LimpaCampo();
            cadcidade.txtCodig.Text = cadcidade.CodigoMaisUm(Query).ToString();
            cadcidade.txtCidade.Focus();
            cadcidade.Text = "Money - Cadastro de Cidades";
            cadcidade.btnGravar.Enabled = true;
           
            cadcidade.btnAlterar.Enabled = false;
            cadcidade.btnExcluir.Enabled = false;
            cadcidade.txtCidade.Text = string.Empty;
            cadcidade.txtUf.Text = string.Empty;
            
            cadcidade.ShowDialog();
            CarregaDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            cadcidade.Text = "Money - Alterar Cadastro";
            cadcidade.btnAlterar.Enabled = true;
            cadcidade.btnGravar.Enabled = false;
            cadcidade.btnExcluir.Enabled = false;

            CapturaDadosGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cadcidade.Text = "Money - Exclusão d Registro";
            cadcidade.btnExcluir.Enabled = true;
            cadcidade.btnGravar.Enabled = false;
            cadcidade.btnAlterar.Enabled = false;

            CapturaDadosGrid();
        }
    }
}

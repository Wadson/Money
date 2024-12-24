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
    public partial class frmManutReceita : Money.frmBase
    {
        private int linhaAtual = 0;
        private string criterio = "";
        public string sqlString = "";
        private OleDbConnection Conn;
        private OleDbCommand Comm;
        private DataTable dTable;
        private OleDbCommandBuilder comanBilder;
        private BindingSource bSouce;
        private OleDbDataAdapter da;

        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string DataRecebimento { get; set; }

        frmCadReceita cadreceita = new frmCadReceita();
        string Query = "SELECT MAX(Codigo) FROM receita";

        public frmManutReceita()
        {
            InitializeComponent();
        }
        public void CarregaDados()
        {
            Conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Money\bin\Debug\bdfinance.accdb");
            Comm = new OleDbCommand("SELECT  receita.Codigo, agenda.nome, receita.valor, receita.datareceb FROM   receita INNER JOIN  agenda ON receita.idagenda = agenda.idagenda", Conn);
            da = new OleDbDataAdapter(Comm);
           
            dTable = new DataTable();
            Conn.Open();
            comanBilder = new OleDbCommandBuilder(da);
            da.Fill(dTable);

            bSouce = new BindingSource();
            bSouce.DataSource = dTable;

            dataGridReceita.DataSource = bSouce;

            string contagem;
            contagem = dataGridReceita.RowCount.ToString();
            lblTotalRegistros.Text = contagem;
            FormataGrid();
        }

        public void CarregaTexBox()
        {
            Codigo = dataGridReceita[0, linhaAtual].Value.ToString();

            if (linhaAtual >= 0)
            {
                cadreceita.txtCodigo.Text = dataGridReceita[0, linhaAtual].Value.ToString();
                cadreceita.txtNome.Text = dataGridReceita[1, linhaAtual].Value.ToString();
                cadreceita.txtValor.Text = dataGridReceita[2, linhaAtual].Value.ToString();
                cadreceita.dtPickDataReceb.Text = dataGridReceita[3, linhaAtual].Value.ToString();

                cadreceita.ShowDialog();
            }
            //try
            //{
            //    Codigo = dataGridReceita[0, linhaAtual].Value.ToString();

            //    if (linhaAtual >= 0)
            //    {
            //        cadreceita.txtCodigo.Text = dataGridReceita[0, linhaAtual].Value.ToString();
            //        cadreceita.txtNome.Text = dataGridReceita[1, linhaAtual].Value.ToString();
            //        cadreceita.txtValor.Text = dataGridReceita[2, linhaAtual].Value.ToString();
            //        cadreceita.dtPickDataReceb.Text = dataGridReceita[3, linhaAtual].Value.ToString();

            //        cadreceita.ShowDialog();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro é esse o Erro achei..." + ex.Message);
            //}
            dataGridReceita.DataSource = null;
            CarregaDados();
        }
        public void FormataGrid()
        {
            dataGridReceita.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridReceita.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;

            dataGridReceita.Columns[0].Width = 50;
            dataGridReceita.Columns[1].Width = 270;
            dataGridReceita.Columns[2].Width = 100;
            dataGridReceita.Columns[3].Width = 120;
           

            dataGridReceita.Columns[0].HeaderText = "Código";
            dataGridReceita.Columns[1].HeaderText = "Nome";
            dataGridReceita.Columns[2].HeaderText = "Valor";
            dataGridReceita.Columns[3].HeaderText = "Data Recebimento";
           

            dataGridReceita.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridReceita.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridReceita.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridReceita.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
        
        }
        private void carregaGrid(string criterioSQL)
        {
            dataGridReceita.DataSource = null;

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
                        dataGridReceita.DataSource = tabela;
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
        private void btnGravar_Click(object sender, EventArgs e)
        {
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            cadreceita.LimpaCampo();
            cadreceita.Text = "Money - Alterar REgistro";
            cadreceita.txtCodigo.Text = cadreceita.CodigoMaisUm(Query).ToString();

            cadreceita.txtCodFonte.Focus();
            cadreceita.btnExcluir.Enabled = false;
            cadreceita.btnAlterar.Enabled = true;
            cadreceita.btnGravar.Enabled = false;
            cadreceita.btnLimpa.Enabled = true;

            CarregaTexBox();
            CarregaDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cadreceita.LimpaCampo();
            cadreceita.Text = "Money - Inclusão de receita";
            cadreceita.txtCodigo.Text = cadreceita.CodigoMaisUm(Query).ToString();

            cadreceita.txtCodFonte.Focus();
            cadreceita.btnExcluir.Enabled = true;
            cadreceita.btnAlterar.Enabled = false;
            cadreceita.btnGravar.Enabled = false;
            cadreceita.btnLimpa.Enabled = false;

            CarregaTexBox();
            CarregaDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cadreceita.LimpaCampo();
            cadreceita.Text = "Money - Inclusão de receita";
            cadreceita.txtCodigo.Text = cadreceita.CodigoMaisUm(Query).ToString();

            cadreceita.txtCodFonte.Focus();
            cadreceita.btnExcluir.Enabled = false;
            cadreceita.btnAlterar.Enabled = false;
            cadreceita.btnGravar.Enabled = true;
            cadreceita.btnLimpa.Enabled = true;

            cadreceita.ShowDialog();
            CarregaDados();
        }

        private void frmManutReceita_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void dataGridReceita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

        private void dataGridReceita_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i = dataGridReceita.CurrentRow.Index;

                Codigo = dataGridReceita.Rows[i].Cells[0].Value.ToString();
                Nome = dataGridReceita.Rows[i].Cells[1].Value.ToString();
                Valor = dataGridReceita.Rows[i].Cells[2].Value.ToString();
                DataRecebimento = dataGridReceita.Rows[i].Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Êpa! esta grid não aceita classificação", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string contagem;

            if (txtPesquisa.Text != "")
            {
                criterio = txtPesquisa.Text.ToString();
                if (criterio != "")
                    sqlString = "SELECT receita.Codigo, agenda.nome, receita.valor, receita.datareceb FROM receita INNER JOIN  agenda ON receita.idagenda = agenda.idagenda  WHERE nome LIKE '" + criterio + "%'";
                carregaGrid(sqlString);

                contagem = dataGridReceita.RowCount.ToString();
                lblTotalRegistros.Text = contagem;
            }
            else
                CarregaDados();
        }
    }
}

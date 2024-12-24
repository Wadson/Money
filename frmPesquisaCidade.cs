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
    public partial class frmPesquisaCidade : Money.frmPesquisaBase
    {
        public string IdCidade { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Capturavalor { get; set; }

        private int linhaAtual = 0;
        private string criterio = "";
        public string sqlString = "";
        private OleDbConnection Conn;
        private OleDbDataAdapter da;
        private DataSet ds;

        public frmPesquisaCidade()
        {
            InitializeComponent();
        }
        private void FormataGrid()
        {
            dataGridCidade.Columns[0].Width = 60;
            dataGridCidade.Columns[1].Width = 400;
            dataGridCidade.Columns[2].Width = 60;

            dataGridCidade.Columns[0].HeaderText = "Código";
            dataGridCidade.Columns[1].HeaderText = "Cidade";
            dataGridCidade.Columns[2].HeaderText = "UF";

            dataGridCidade.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridCidade.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
        }
        private void carregaGrid(string criterioSQL)
        {
            dataGridCidade.DataSource = null;
            ds = new DataSet();
            Conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Money\bin\Debug\bdfinance.accdb");
            try
            {
                Conn.Open();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            if (Conn.State == ConnectionState.Open)
            {
                try
                {
                    da = new OleDbDataAdapter(criterioSQL, Conn);
                    da.Fill(ds, "Tabela");
                    dataGridCidade.DataSource = ds;
                    dataGridCidade.DataMember = "Tabela";

                    FormataGrid();
                }
                catch
                {
                    MessageBox.Show("Nenhum registro encontrado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void CarregaDados()
        {
            dataGridCidade.DataSource = null;

            cidadeBLL cidadebll = new cidadeBLL();

            dataGridCidade.DataSource = cidadebll.listaCidade();

            FormataGrid();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "")
            {
                if (rbtDescricao.Checked == true)
                {
                    criterio = txtPesquisa.Text.ToString();
                    if (criterio != "")
                        sqlString = "SELECT idCidade, cidade, uf FROM cidade WHERE cidade LIKE '" + criterio + "%'";

                    carregaGrid(sqlString);
                }
                if (rbtCodigo.Checked == true)
                {
                    criterio = txtPesquisa.Text.ToString();
                    if (criterio != "")
                        sqlString = "SELECT idCidade, cidade, uf FROM cidade WHERE idCidade LIKE '" + criterio + "%'";

                    carregaGrid(sqlString);
                }
            }
            else
                CarregaDados();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (linhaAtual >= 0)
                {
                    frmCadLista cadlista = new frmCadLista();

                    cadlista.CodigoCidade = IdCidade;
                    cadlista.Cidade = Cidade;
                    cadlista.Uf = Uf;

                    dataGridCidade.Update();
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhum valor selecionado..." + ex.Message);
            }
        }

        private void frmPesquisaCidade_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataGridCidade.DataSource != null)
            {
                try
                {
                    IdCidade = dataGridCidade[0, linhaAtual].Value.ToString();
                    Cidade = dataGridCidade[1, linhaAtual].Value.ToString();
                    Uf = dataGridCidade[2, linhaAtual].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nenhum registro selecionado !\n\n" + ex.Message, "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                if (linhaAtual >= 1)
                {
                    frmCadLista listatelef = new frmCadLista();

                    listatelef.Codigo = IdCidade;
                    listatelef.Cidade = Cidade;
                    listatelef.Uf = Uf;

                    dataGridCidade.Update();
                }
            }
        }

        private void frmPesquisaCidade_Load(object sender, EventArgs e)
        {
            txtPesquisa.Text = Capturavalor;
            CarregaDados();
            txtPesquisa.SelectionStart = txtPesquisa.SelectionLength + 1;
        }

        private void dataGridCidade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

        private void dataGridCidade_SelectionChanged(object sender, EventArgs e)
        {
            try { int i = dataGridCidade.CurrentRow.Index; }
            catch (Exception ee) { MessageBox.Show("erro" + ee); }
        }

        private void dataGridCidade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}

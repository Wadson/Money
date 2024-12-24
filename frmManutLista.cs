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
    public partial class frmManutLista : Money.frmBase
    {
        frmCadLista cadlista = new frmCadLista();
        
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Fone { get; set; }
        public string Celular { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Email { get; set; }

        string Query = "SELECT MAX(idagenda) FROM agenda";

        private int linhaAtual = 0;
        private string criterio = "";
        public string sqlString = "";
        private OleDbConnection Conn;
        private OleDbCommand Comm;
        private DataTable dTable;
        private OleDbCommandBuilder comanBilder;
        private BindingSource bSouce;
        private OleDbDataAdapter da; 

        public frmManutLista()
        {
            InitializeComponent();
        }
        public override int CodigoMaisUm(string query)
        {
            return base.CodigoMaisUm(Query);
        }
        public void FormataGrid()
        {
            dataGridListaTelefonica.RowsDefaultCellStyle.BackColor = Color.AliceBlue;           
            dataGridListaTelefonica.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;

            dataGridListaTelefonica.Columns[0].Width = 50;
            dataGridListaTelefonica.Columns[1].Width = 300;
            dataGridListaTelefonica.Columns[2].Width = 100;
            dataGridListaTelefonica.Columns[3].Width = 100;
            dataGridListaTelefonica.Columns[4].Width = 250;
            dataGridListaTelefonica.Columns[5].Width = 200;
            dataGridListaTelefonica.Columns[6].Width = 40;
            dataGridListaTelefonica.Columns[7].Width = 120;            

            dataGridListaTelefonica.Columns[0].HeaderText = "Código";
            dataGridListaTelefonica.Columns[1].HeaderText = "Nome";
            dataGridListaTelefonica.Columns[2].HeaderText = "Fone";
            dataGridListaTelefonica.Columns[3].HeaderText = "Celular";
            dataGridListaTelefonica.Columns[4].HeaderText = "Endereço";
            dataGridListaTelefonica.Columns[5].HeaderText = "Cidade";
            dataGridListaTelefonica.Columns[6].HeaderText = "UF";
            dataGridListaTelefonica.Columns[7].HeaderText = "E-Mail";  

            dataGridListaTelefonica.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridListaTelefonica.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridListaTelefonica.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridListaTelefonica.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridListaTelefonica.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridListaTelefonica.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridListaTelefonica.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridListaTelefonica.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
        }
        public void CarregaDados()
        {          
            Conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Money\bin\Debug\bdfinance.accdb");
            Comm = new OleDbCommand("SELECT agenda.idagenda, agenda.nome, agenda.fone, agenda.celular, agenda.endereco, cidade.cidade, cidade.uf," +
                " agenda.email FROM  agenda INNER JOIN cidade ON agenda.idcidade = cidade.idCidade", Conn);
            da = new OleDbDataAdapter(Comm);

          
            dTable = new DataTable();           
            Conn.Open();          
            comanBilder = new OleDbCommandBuilder(da);          
            da.Fill(dTable);
           
            bSouce = new BindingSource();          
            bSouce.DataSource = dTable;
           
            dataGridListaTelefonica.DataSource = bSouce;

            string contagem;
            contagem = dataGridListaTelefonica.RowCount.ToString();
            lblTotalRegistros.Text = contagem;
            FormataGrid();
        }

        public void CarregaTexBox()
        {           
            try
            {
                Codigo = dataGridListaTelefonica[0, linhaAtual].Value.ToString();

                if (linhaAtual >= 0)
                {
                    cadlista.txtCodigo.Text = dataGridListaTelefonica[0, linhaAtual].Value.ToString();
                    cadlista.txtNome.Text = dataGridListaTelefonica[1,linhaAtual].Value.ToString();
                    cadlista.txtFonee.Text = dataGridListaTelefonica[2,linhaAtual].Value.ToString();
                    cadlista.txtCelular.Text = dataGridListaTelefonica[3,linhaAtual].Value.ToString();
                    cadlista.txtEndereco.Text  = dataGridListaTelefonica[4,linhaAtual].Value.ToString();
                    cadlista.txtCidade.Text  = dataGridListaTelefonica[5,linhaAtual].Value.ToString();
                    cadlista.txtUf.Text = dataGridListaTelefonica[6,linhaAtual].Value.ToString();
                    cadlista.txtEmail.Text  = dataGridListaTelefonica[7,linhaAtual].Value.ToString();

                    cadlista.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro é esse o Erro achei..." + ex.Message);
            }
            dataGridListaTelefonica.DataSource = null;
            CarregaDados();
        }

        private void carregaGrid(string criterioSQL)
        {           
            dataGridListaTelefonica.DataSource = null;

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
                        dataGridListaTelefonica.DataSource = tabela;
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

        private void dataGridListaTelefonica_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

        private void dataGridListaTelefonica_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i = dataGridListaTelefonica.CurrentRow.Index;

                Codigo = dataGridListaTelefonica.Rows[i].Cells[0].Value.ToString();
                Nome = dataGridListaTelefonica.Rows[i].Cells[1].Value.ToString();
                Fone = dataGridListaTelefonica.Rows[i].Cells[2].Value.ToString();
                Celular = dataGridListaTelefonica.Rows[i].Cells[3].Value.ToString();
                Endereco= dataGridListaTelefonica.Rows[i].Cells[4].Value.ToString();
                Cidade = dataGridListaTelefonica.Rows[i].Cells[5].Value.ToString();
                Uf = dataGridListaTelefonica.Rows[i].Cells[6].Value.ToString();
                Email = dataGridListaTelefonica.Rows[i].Cells[7].Value.ToString();
               
            }
            catch
            {
                MessageBox.Show("Êpa! esta grid não aceita classificação", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void frmManutLista_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cadlista.LimpaCampo();
            cadlista.Text = "Money - Lista Telefônica - Inclusão de Contatos";
            cadlista.txtCodigo.Text = cadlista.CodigoMaisUm(Query).ToString();

            cadlista.txtCodCidade.Focus();
            cadlista.btnExcluir.Enabled = false;
            cadlista.btnAlterar.Enabled = false;
            cadlista.btnGravar.Enabled = true;
            cadlista.btnLimpa.Enabled = true;
           
            cadlista.ShowDialog();
            CarregaDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            cadlista.Text = "Money - Lista Telefônica - Alterar cadastro";
            cadlista.btnAlterar.Enabled = true;
            cadlista.btnExcluir.Enabled = false;
            cadlista.btnGravar.Enabled = false;
            cadlista.btnLimpa.Enabled = false;           
            CarregaTexBox();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cadlista.Text = "Money - Lista Telefônica - Excluir cadastro";
            cadlista.btnAlterar.Enabled = false;
            cadlista.btnExcluir.Enabled = true;
            cadlista.btnGravar.Enabled = false;
            cadlista.btnLimpa.Enabled = false;
            CarregaTexBox();   
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string contagem;

            if (txtPesquisa.Text != "")
            {
                criterio = txtPesquisa.Text.ToString();
                if (criterio != "")
                    sqlString = "SELECT agenda.idagenda, agenda.nome, agenda.fone, agenda.celular, agenda.endereco, cidade.cidade, cidade.uf,agenda.email FROM  agenda INNER JOIN cidade ON agenda.idcidade = cidade.idCidade  WHERE nome LIKE '" + criterio + "%'";
                carregaGrid(sqlString);

                contagem = dataGridListaTelefonica.RowCount.ToString();
                lblTotalRegistros.Text = contagem;
            }
            else
                CarregaDados();
        }
    }
}

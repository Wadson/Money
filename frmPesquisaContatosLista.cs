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
    public partial class frmPesquisaContatosLista : Money.frmPesquisaBase
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
       

        private int linhaAtual = 0;
        private string criterio = "";
        public string sqlString = "";
        private OleDbConnection Conn;
        private OleDbDataAdapter da;
        private DataSet ds;
        public string Capturavalor { get; set; }

        public frmPesquisaContatosLista()
        {
            InitializeComponent();
        }
        private void FormataGrid()
        {
            dataGridAgenda.Columns[0].Width = 60;
            dataGridAgenda.Columns[1].Width = 400;
                          
            
            dataGridAgenda.Columns[0].HeaderText = "Código";
            dataGridAgenda.Columns[1].HeaderText = "Nome";
                        
            dataGridAgenda.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridAgenda.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
        }                
        private void carregaGrid(string criterioSQL)
        {
            dataGridAgenda.DataSource = null;
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
                    dataGridAgenda.DataSource = ds;
                    dataGridAgenda.DataMember = "Tabela";

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
            dataGridAgenda.DataSource = null;

            AgendaBLL agendabll = new AgendaBLL();

            dataGridAgenda.DataSource = agendabll.lista_Agenda2();

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
                        sqlString = "SELECT idagenda, nome FROM agenda WHERE nome LIKE '" + criterio + "%'";

                    carregaGrid(sqlString);
                }
                if (rbtCodigo.Checked == true)
                {
                    criterio = txtPesquisa.Text.ToString();
                    if (criterio != "")
                        sqlString = "SELECT idagenda, nome FROM cidade WHERE idagenda LIKE '" + criterio + "%'";

                    carregaGrid(sqlString);
                }
            }
            else
                CarregaDados();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (linhaAtual >= 0)
                {
                    frmCadReceita cadreceita = new frmCadReceita();

                    cadreceita.Codigo = Codigo;
                    cadreceita.Nome = Nome;


                    dataGridAgenda.Update();
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhum valor selecionado..." + ex.Message);
            }
        }

        private void dataGridAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

        private void dataGridAgenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void frmPesquisaContatosLista_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataGridAgenda.DataSource != null)
            {
                try
                {
                    Codigo = dataGridAgenda[0, linhaAtual].Value.ToString();
                    Nome = dataGridAgenda[1, linhaAtual].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nenhum registro selecionado !\n\n" + ex.Message, "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                if (linhaAtual >= 1)
                {
                    frmCadReceita cadreceita = new frmCadReceita();

                    cadreceita.Codigo = Codigo;
                    cadreceita.Nome = Nome;


                    dataGridAgenda.Update();
                }
            }
        }

        private void dataGridAgenda_SelectionChanged(object sender, EventArgs e)
        {
            try { int i = dataGridAgenda.CurrentRow.Index; }
            catch (Exception ee) { MessageBox.Show("erro" + ee); }
        }

        private void frmPesquisaContatosLista_Load(object sender, EventArgs e)
        {
            txtPesquisa.Text = Capturavalor;
            CarregaDados();
            txtPesquisa.SelectionStart = txtPesquisa.SelectionLength + 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Money
{
    public partial class frmPesquisaConta :Form
    {
        public string sqlString, criterio = "";

        public string CodConta { get; set; }    public string Contagem { get; set; }    public string Idfornecedor { get; set; }   
        public string Fornecedor { get; set; }  public string Valor { get; set; }       public DateTime Vencimento { get; set; } 
        public string Descricao { get; set; }   public DateTime Lancamento { get; set; }  public string Pagamento { get; set; }
        public string CentroCusto { get; set; } public string Parcela { get; set; }    public string CodParcela { get; set; } 
          
        private int linhaAtual = 0;

        public frmPesquisaConta()
        {
            InitializeComponent();
        }

        private void frmPesquisaConta_Load(object sender, EventArgs e)
        {
            preencher_Combo();
        }
        private void preencher_Combo()
        {
            var conn = Conexao.Conex();
            try
            {
                conn.Open();

                //string mSQL = "Select categoria from categorias";
                string Query = "SELECT centro_custo FROM centrocusto";

                SQLiteCommand cmd = new SQLiteCommand(Query, conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                System.Data.DataTable dtResultado = new System.Data.DataTable();
                da.Fill(dtResultado);
                this.cmbCentroCusto.DataSource = dtResultado;
                this.cmbCentroCusto.DisplayMember = "centro_custo";
                this.cmbCentroCusto.ValueMember = "centro_custo";
            }
            catch (SQLiteException sqle)
            {
                MessageBox.Show("Erro de acesso ao MySQL : " + sqle.Message, "Erro");
            }
            finally
            {
                conn.Close();
            }
        }
        private void formataGrid()
        {

            try
            {
                datagridpesquisa.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
                datagridpesquisa.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                               
                datagridpesquisa.Columns[0].Width = 70;
                datagridpesquisa.Columns[1].Width = 30;
                datagridpesquisa.Columns[2].Width = 260;
                datagridpesquisa.Columns[3].Width = 230;
                datagridpesquisa.Columns[4].Width = 40;
                datagridpesquisa.Columns[5].Width = 100;
                datagridpesquisa.Columns[6].Width = 70;
                datagridpesquisa.Columns[7].Width = 70;
                datagridpesquisa.Columns[8].Width = 70;
                datagridpesquisa.Columns[9].Width = 50;

                datagridpesquisa.Columns[0].HeaderText = "Dt.Cadastro";
                datagridpesquisa.Columns[1].HeaderText = "Cód";
                datagridpesquisa.Columns[2].HeaderText = "Fornecedor";
                datagridpesquisa.Columns[3].HeaderText = "Descrição";
                datagridpesquisa.Columns[4].HeaderText = "Parc";
                datagridpesquisa.Columns[5].HeaderText = "Centro de custo";
                datagridpesquisa.Columns[6].HeaderText = "Valor";
                datagridpesquisa.Columns[7].HeaderText = "Vencimento";
                datagridpesquisa.Columns[8].HeaderText = "Data Pgto";
                datagridpesquisa.Columns[9].HeaderText = "Id_Parc";


                datagridpesquisa.Columns[1].Visible = false;
                datagridpesquisa.Columns[9].Visible = false;


                datagridpesquisa.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                datagridpesquisa.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                datagridpesquisa.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                datagridpesquisa.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                datagridpesquisa.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
               
                datagridpesquisa.Columns[6].DefaultCellStyle.Format = "C";
            }
            catch
            {
                MessageBox.Show("O banco de dados não foi restaurado", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            ContaRegistros();
        }
        private void ContaRegistros()
        {
            Contagem = datagridpesquisa.RowCount.ToString();
            toolstripRegistros.Text = Contagem;
        }
        public void carregaGrid(string criterioSQL)
        {
            var conn = Conexao.Conex();

            SQLiteCommand comandos = new SQLiteCommand();
            comandos.CommandText = Convert.ToString(CommandType.Text);
            comandos.CommandText = sqlString;
            comandos.Connection = conn;

            try
            {
                conn.Open();

                System.Data.DataTable tabela = new System.Data.DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                adapter.SelectCommand = comandos;
                adapter.Fill(tabela);

                if (tabela.Rows.Count > 0)
                {
                    datagridpesquisa.DataSource = tabela;
                    formataGrid();
                }
                else
                {
                    datagridpesquisa.DataSource = null;
                    MessageBox.Show("Nenhum registro encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLocalizar.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally { conn.Close(); }

        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string criteriocmb = "";

            if (rbCentroCusto.Checked == true && checkBoxPagas.Checked == true)
            {
                criteriocmb = cmbCentroCusto.Text.ToString();

                sqlString = "SELECT controle.datacadastro ,controle.idcontrole, fornecedor.fornecedor, controle.descricao, parcelas.num_parcela, centrocusto.centro_custo, parcelas.valor_parc, parcelas.datavenc, parcelas.datapgto, parcelas.idparcela " +
                                  "FROM ((controle INNER JOIN fornecedor  ON controle.idfornecedor = fornecedor.idfornecedor) " +
                                  "                INNER JOIN parcelas    ON controle.idcontrole = parcelas.idcontrole)" +
                                  "                INNER JOIN centrocusto ON controle.idcentro = centrocusto.idcentro  WHERE centro_custo LIKE '" + criteriocmb + "%'AND pago = true ORDER BY datavenc";//WHERE pago = false ORDER BY datavenc", conn);

                carregaGrid(sqlString); formataGrid();
            }
            else if (rbCentroCusto.Checked == true && checkBoxNãoPagas.Checked == true)
            {
                criteriocmb = cmbCentroCusto.Text.ToString();

                sqlString = "SELECT controle.datacadastro ,controle.idcontrole, fornecedor.fornecedor, controle.descricao, parcelas.num_parcela, centrocusto.centro_custo, parcelas.valor_parc, parcelas.datavenc, parcelas.datapgto, parcelas.idparcela " +
                                  "FROM ((controle INNER JOIN fornecedor  ON controle.idfornecedor = fornecedor.idfornecedor) " +
                                  "                INNER JOIN parcelas    ON controle.idcontrole = parcelas.idcontrole)" +
                                  "                INNER JOIN centrocusto ON controle.idcentro = centrocusto.idcentro  WHERE centro_custo LIKE '" + criteriocmb + "%'AND pago = false ORDER BY datavenc";//WHERE pago = false ORDER BY datavenc", conn);

                carregaGrid(sqlString); formataGrid();
            }









            else if (rbFornecedor.Checked == true && checkBoxPagas.Checked == true)
            {
                criterio = txtLocalizar.Text.ToString();

                sqlString = "SELECT controle.datacadastro ,controle.idcontrole, fornecedor.fornecedor, controle.descricao, parcelas.num_parcela, centrocusto.centro_custo, parcelas.valor_parc, parcelas.datavenc, parcelas.datapgto, parcelas.idparcela " +
                                  "FROM ((controle INNER JOIN fornecedor  ON controle.idfornecedor = fornecedor.idfornecedor) " +
                                  "                INNER JOIN parcelas    ON controle.idcontrole = parcelas.idcontrole)" +
                                  "                INNER JOIN centrocusto ON controle.idcentro = centrocusto.idcentro  WHERE fornecedor LIKE '" + criterio + "%'AND pago = true ORDER BY datavenc";//WHERE pago = false ORDER BY datavenc", conn);

                carregaGrid(sqlString);
            }
            else if (rbFornecedor.Checked == true && checkBoxNãoPagas.Checked == true)
            {
                criterio = txtLocalizar.Text.ToString();

                sqlString = "SELECT controle.datacadastro ,controle.idcontrole, fornecedor.fornecedor, controle.descricao, parcelas.num_parcela, centrocusto.centro_custo, parcelas.valor_parc, parcelas.datavenc, parcelas.datapgto, parcelas.idparcela " +
                                  "FROM ((controle INNER JOIN fornecedor  ON controle.idfornecedor = fornecedor.idfornecedor) " +
                                  "                INNER JOIN parcelas    ON controle.idcontrole = parcelas.idcontrole)" +
                                  "                INNER JOIN centrocusto ON controle.idcentro = centrocusto.idcentro  WHERE fornecedor LIKE '" + criterio + "%'AND pago = false ORDER BY datavenc";//WHERE pago = false ORDER BY datavenc", conn);

                carregaGrid(sqlString); formataGrid();
            }









            else if (rbVencimento.Checked == true && checkBoxPagas.Checked == true)
            {
                sqlString = "SELECT controle.datacadastro ,controle.idcontrole, fornecedor.fornecedor, controle.descricao, parcelas.num_parcela, centrocusto.centro_custo," +
                             " parcelas.valor_parc, parcelas.datavenc, parcelas.datapgto, parcelas.idparcela " +
                             "FROM ((controle INNER JOIN fornecedor  ON controle.idfornecedor = fornecedor.idfornecedor) " +
                             "                INNER JOIN parcelas    ON controle.idcontrole = parcelas.idcontrole)" +
                             "                INNER JOIN centrocusto ON controle.idcentro = centrocusto.idcentro " +
                             "WHERE datavenc >= #" + dtInicial.Value.ToString("MM/dd/yyyy 00:00:00") + "# AND datavenc <= #" + dtFinal.Value.ToString("MM/dd/yyyy 23:59:59") + "# AND pago = true ORDER BY datavenc";

                carregaGrid(sqlString); formataGrid();
            }
            else if (rbVencimento.Checked == true && checkBoxNãoPagas.Checked == true)
            {
                sqlString = "SELECT controle.datacadastro ,controle.idcontrole, fornecedor.fornecedor, controle.descricao, parcelas.num_parcela, centrocusto.centro_custo," +
                             " parcelas.valor_parc, parcelas.datavenc, parcelas.datapgto, parcelas.idparcela " +
                             "FROM ((controle INNER JOIN fornecedor  ON controle.idfornecedor = fornecedor.idfornecedor) " +
                             "                INNER JOIN parcelas    ON controle.idcontrole = parcelas.idcontrole)" +
                             "                INNER JOIN centrocusto ON controle.idcentro = centrocusto.idcentro " +
                             "WHERE datavenc >= #" + dtInicial.Value.ToString("MM/dd/yyyy 00:00:00") + "# AND datavenc <= #" + dtFinal.Value.ToString("MM/dd/yyyy 23:59:59") + "# AND pago = false ORDER BY datavenc";

                carregaGrid(sqlString); formataGrid();
            }
            else
                MessageBox.Show("Selecione uma das opções \n\nPagas ou \n\n Não pagas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            dtFinal.Enabled = false; dtInicial.Enabled = false; cmbCentroCusto.Enabled = false; txtLocalizar.Enabled = true; txtLocalizar.Select();
            datagridpesquisa.DataSource = null;
        }

        private void rbVencimento_CheckedChanged(object sender, EventArgs e)
        {
            dtInicial.Enabled = true; dtFinal.Enabled = true; txtLocalizar.Enabled = false; dtInicial.Select(); cmbCentroCusto.Enabled = false;
            datagridpesquisa.DataSource = null;
        }

        private void rbCentroCusto_CheckedChanged(object sender, EventArgs e)
        {
            cmbCentroCusto.Enabled = true; dtInicial.Enabled = false; dtFinal.Enabled = false; txtLocalizar.Enabled = false; cmbCentroCusto.Select();
            datagridpesquisa.DataSource = null;
        }

        private void frmPesquisaConta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (datagridpesquisa.DataSource != null)
            {
                try
                {
                    Lancamento = Convert.ToDateTime(datagridpesquisa[0, linhaAtual].Value.ToString());
                    CodConta = datagridpesquisa[1, linhaAtual].Value.ToString();                    
                    Fornecedor = datagridpesquisa[2, linhaAtual].Value.ToString();
                    Descricao = datagridpesquisa[3, linhaAtual].Value.ToString();
                    Parcela = datagridpesquisa[4, linhaAtual].Value.ToString();
                    CentroCusto = datagridpesquisa[5, linhaAtual].Value.ToString();
                    Valor = datagridpesquisa[6, linhaAtual].Value.ToString();
                    Vencimento = Convert.ToDateTime(datagridpesquisa[7, linhaAtual].Value.ToString());
                    CodParcela = datagridpesquisa[9, linhaAtual].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nenhum registro selecionado !\n\n" + ex.Message, "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                if (linhaAtual >= 1)
                {
                    frmManutencao_Dois cadcontas = new frmManutencao_Dois();
                    cadcontas.CodConta = CodConta;
                    cadcontas.Lancamento = Convert.ToString(Lancamento);
                    cadcontas.Fornecedor = Fornecedor;
                    cadcontas.Descricao = Descricao;
                    cadcontas.Parcela = Parcela;
                    cadcontas.CentroCusto = CentroCusto;
                    cadcontas.Valor = Valor;
                    cadcontas.Vencimento = Convert.ToString(Vencimento);
                    cadcontas.CodParcela = CodParcela;

                    datagridpesquisa.Update();
                }
            }
        }

        private void datagridpesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

        private void datagridpesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();

        }

        private void datagridpesquisa_SelectionChanged(object sender, EventArgs e)
        {
            try { int i = datagridpesquisa.CurrentRow.Index; }
            catch (Exception ee) { MessageBox.Show("erro" + ee); }
        }

        private void frmPesquisaConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtLocalizar_Leave(object sender, EventArgs e)
        {
            txtLocalizar.BackColor = Color.White;
        }

        private void txtLocalizar_Enter(object sender, EventArgs e)
        {
            txtLocalizar.BackColor = Color.Yellow;
        }        
    }
}

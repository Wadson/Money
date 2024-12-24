using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Money
{
    public partial class FrmEstorno_Baixa : FrmBaseGeral    
    {
        private DateTime? Datee { get; set; } 
        

        public FrmEstorno_Baixa()
        {
            InitializeComponent();
            FixarCabecalhoDataGrid();
        }
        private void FixarCabecalhoDataGrid()
        {
            datagrid_Pesquisa.AutoGenerateColumns = false;
        }
        public void Botoes_Click(object sender, EventArgs e)
        {
            string botãnovo = ((System.Windows.Forms.Button)sender).Name; //é só Button
        }
        #region Métodos

        private void ContaRegistros()
        {
            Contagem = datagrid_Pesquisa.RowCount.ToString();
            lbl_Status_Null.Text = Contagem + "  Registro(s)";
            lbl_Status_Null.ForeColor = Color.Blue;
        }

        public void carregaGrid2(SqlCommand criterioSQL)
        {
            var conn = Conexao.Conex();
            criterioSQL.Connection = conn;
            try
            {
                conn.Open();

                System.Data.DataTable tabela = new System.Data.DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = criterioSQL;
                adapter.Fill(tabela);

                if (tabela.Rows.Count > 0)
                {
                    datagrid_Pesquisa.DataSource = tabela;
                    ContaRegistros();
                }
                if(tabela.Rows.Count == 0)
                {
                    lbl_Status_Null.Text = "Não há informações cadastradas que atendam ao filtro solicitado.";
                    lbl_Status_Null.ForeColor = Color.Red;

                    datagrid_Pesquisa.DataSource = tabela;
                    // Obter o número de celulas da gridview
                    int columnSpan = datagrid_Pesquisa.Rows[0].Cells.Count;
                    // Apaga todo o conteudo da primeira linha
                    datagrid_Pesquisa.Rows[0].Cells.Clear();
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally { conn.Close(); }

        }
        #endregion

        private void frmManutencao_Dois_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((Char)Keys.Return) == 0))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        #region Eventos

        private void frmManutencao_Dois_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = this.datagrid_Pesquisa.RowTemplate;
            row.Height = 17;
            row.MinimumHeight = 17;
            txt_Fornecedor.Focus();            
        }  
        private void btnSair_Click(object sender, EventArgs e)
        {           
        }       
        public void LocalizaConta_por_Fornecedor()
        {
            if (txt_Fornecedor.Text != string.Empty)
            {
                var conn = Conexao.Conex();
                SqlCommand sqlString = new SqlCommand("SELECT parcelas.idparcela, parcelas.idconta, parcelas.num_parcela, fornecedor.fornecedor, contas.descricao, parcelas.datavenc, parcelas.valor_parc, parcelas.datapgto, contas.datacadastro, " +
        "parcelas.valorpago, categoria.categoria, parcelas.formapgto FROM categoria INNER JOIN contas ON categoria.idcategoria = contas.idcategoria INNER JOIN fornecedor ON contas.idfornecedor = fornecedor.idfornecedor INNER JOIN parcelas ON contas.idconta = parcelas.idconta  WHERE fornecedor LIKE @Criterio AND pago = 1 ORDER BY datavenc", conn);

                sqlString.Parameters.AddWithValue("@Criterio", txt_Fornecedor.Text + "%");
                carregaGrid2(sqlString);
            }
            else
            {              
                lbl_Status_Null.Text = "Digite as iniciais de um fornecedor";
                lbl_Status_Null.ForeColor = Color.Red;
                datagrid_Pesquisa.DataSource = null;              
            }
        }
        private void txt_fornecedor_TextChanged(object sender, EventArgs e)
        {
            if (txt_Fornecedor.Text != null)
            {
                LocalizaConta_por_Fornecedor();
            }
            else
                datagrid_Pesquisa.DataSource = null;
        }
        private void txt_fornecedor_Leave(object sender, EventArgs e)
        {
            txt_Fornecedor.BackColor = Color.White;
        }

        private void txt_fornecedor_Enter(object sender, EventArgs e)
        {
            txt_Fornecedor.BackColor = Color.Yellow;
        }

        private void rb_fornecedor_CheckedChanged(object sender, EventArgs e)
        {
            txt_Fornecedor.Text = "";
            lbl_Status_Null.Visible = true;
            lbl_Status_Null.Text = "Digite as iniciais de um fornecedor";
            lbl_Status_Null.ForeColor = Color.Red;           
          
            txt_Fornecedor.Visible = true;           
            txt_Fornecedor.Select();

            datagrid_Pesquisa.DataSource = null;          

            lblFiltro.Visible = true;
            lblFiltro.Text = "Fornecedor";
            LimpaCampo();            
            btn_EstornarLancamento.Enabled = false;
        }

        private void rb_vencimento_CheckedChanged(object sender, EventArgs e)
        {                  
            txt_Fornecedor.Text = "";
          
            lbl_Status_Null.Text = "Digite uma data e clique em Localizar.";
            lbl_Status_Null.ForeColor = Color.Red;
                
                 
            txt_Fornecedor.Visible = false;

            datagrid_Pesquisa.DataSource = null;
            lblFiltro.Visible = true;
            lblFiltro.Text = "Escolha um intervalo de datas.";
            lbl_Status_Null.ForeColor = Color.Red;
            LimpaCampo();           
            btn_EstornarLancamento.Enabled = false;
        }

        #endregion
        private void Estornar_Pagamentos_()
        {
            foreach (DataGridViewRow linha in datagrid_Pesquisa.SelectedRows)
            {
                var conn = Conexao.Conex();
                SqlCommand sql = new SqlCommand("UPDATE parcelas SET valorpago = @ValorPago, datapgto = @Datapgto, pago = @Pago WHERE idparcela = @IDparcela", conn);

                int posicao = 0;
                posicao = linha.Index;
                conn.Open();

                Id_Parcela = Convert.ToInt32(linha.Cells[8].Value.ToString());
                //ValorParc = Convert.ToInt32(linha.Cells["valor_parc"].Value.ToString());
                int Pago = 0;

                sql.Parameters.AddWithValue("@Pago", Pago);
                sql.Parameters.AddWithValue("@IDparcela", Convert.ToInt32(Id_Parcela));
                sql.Parameters.AddWithValue("@Datapgto", DBNull.Value);
                sql.Parameters.AddWithValue("@ValorPago", 0);

                sql.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Registro(os) estornado(os) com sucesso!!!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void Estornar_Pagamentos()
        {
            ParcelaModel parcelamodel = new ParcelaModel();

            DateTime? dt = null;
            //DateTime datA = Convert.ToDateTime(dt);

            //***************
            //Nullable<DateTime> dt = null;
            //dt = new DateTime();

            //DateTime dt2 = dt ?? DateTime.MinValue;
            //***************
            
            //*****************************
          //var defauldata = default(DateTime?);
           //*******************************
            foreach (DataGridViewRow linha in datagrid_Pesquisa.SelectedRows)
            {
                int posicao = 0;
                posicao = linha.Index;
                Id_Parcela = Convert.ToInt32(linha.Cells[8].Value.ToString());
                ValorParc = Convert.ToInt32(linha.Cells[5].Value.ToString());

                parcelamodel.Valor_parc = ValorParc;
                parcelamodel.Datapgto = dt.Value;
                parcelamodel.Pago = 0;
                parcelamodel.Idparcela = Id_Parcela;


                ParcelaBLL parcelabll = new ParcelaBLL();
                parcelabll.BaixarParcelas(parcelamodel);
            }
            MessageBox.Show("Registro(os) estornado(os) com sucesso!!!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_EstornarLancamento_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estornar lançamentos?", "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Estornar_Pagamentos_();
                btnPesquiar.PerformClick();
            }
        }

        private void btnPesquiar_Click(object sender, EventArgs e)
        {
            if (txt_Fornecedor.Text != null)
            {
                LocalizaConta_por_Fornecedor();
            }
            else
                datagrid_Pesquisa.DataSource = null;
        }
    }
}
/*
 *  public void InicializaListView()
        {
            ColumnHeader header1 = this.listViewPesquisa.Columns.Add("Cod.Conta", 3 * Convert.ToInt32(listViewPesquisa.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header2 = this.listViewPesquisa.Columns.Add("Cadastro", 20 * Convert.ToInt32(listViewPesquisa.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header3 = this.listViewPesquisa.Columns.Add("Fornecedor", 20 * Convert.ToInt32(listViewPesquisa.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header4 = this.listViewPesquisa.Columns.Add("Historico", 13 * Convert.ToInt32(listViewPesquisa.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header5 = this.listViewPesquisa.Columns.Add("Parcela", 13 * Convert.ToInt32(listViewPesquisa.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header6 = this.listViewPesquisa.Columns.Add("Valor", 25 * Convert.ToInt32(listViewPesquisa.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header7 = this.listViewPesquisa.Columns.Add("Vencimento", 15 * Convert.ToInt32(listViewPesquisa.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header8 = this.listViewPesquisa.Columns.Add("Pagamento", 20 * Convert.ToInt32(listViewPesquisa.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header9 = this.listViewPesquisa.Columns.Add("Cod.P", 4 * Convert.ToInt32(listViewPesquisa.Font.SizeInPoints), HorizontalAlignment.Left);
            // exibe detalhes
            listViewPesquisa.View = View.Details;
            // permite ao usuário editar o texto
            listViewPesquisa.LabelEdit = true;
            // permite ao usuário rearranjar as colunas
            listViewPesquisa.AllowColumnReorder = true;
            // Selecione o item e subitem quando um seleção for feita
            listViewPesquisa.FullRowSelect = true;
            // Exibe as linhas no ListView
            listViewPesquisa.GridLines = true;
        }
        private void carregaLista()
        {
            var conn = Conexao.Conex();

            SqlCommand sql = new SqlCommand("SELECT contas.idconta   as idconta," +
                                            "contas.datacadastro as datacadastro, " +
                                            "fornecedor.fornecedor as fornecedor," +
                                            "contas.descricao    as descricao," +
                                            "parcelas.num_parcela  as num_parcela, " +
                                            "parcelas.valor_parc   as valor_parc," +
                                            "parcelas.datavenc     as datavenc," +
                                            "parcelas.datapgto     as datapgto," +
                                            "parcelas.idparcela    as idparcela FROM parcelas " +
                                    "INNER JOIN contas ON contas.idconta = parcelas.idconta " +
                                    "INNER JOIN fornecedor ON contas.idfornecedor = fornecedor.idfornecedor WHERE parcelas.pago = 0 ORDER BY datavenc", conn);

            SqlDataAdapter daControle = new SqlDataAdapter(sql);

            DataSet ds = new DataSet();
            DataTable dtprecos = new DataTable();
            daControle.Fill(ds, "parcelas");
           

            DataTable dtable = ds.Tables["parcelas"];
          

            listViewPesquisa.Items.Clear();

            // exibe os itens no controle ListView 
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                // Somente as linhas que não foram deletadas
                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["idconta"].ToString());
                    lvi.SubItems.Add(drow["datacadastro"].ToString());
                    lvi.SubItems.Add(drow["Fornecedor"].ToString());
                    lvi.SubItems.Add(drow["Descricao"].ToString());
                    lvi.SubItems.Add(drow["Parcela"].ToString());
                    lvi.SubItems.Add(drow["Valor"].ToString());
                    lvi.SubItems.Add(drow["Vencimento"].ToString());
                    lvi.SubItems.Add(drow["Pagamento"].ToString());
                    lvi.SubItems.Add(drow["idparcela"].ToString());
                    // Inclui os itens no ListView
                    listViewPesquisa.Items.Add(lvi);
                }
            }
        }

        //public void GetDaDos()
        //{
        //    var Conn = Conexao.Conex();
        //    try
        //    {               

        //        // preenche o dataset 
        //        string strSQL = "SELECT contas.idconta   as idconta," +
        //                                    "contas.datacadastro as datacadastro, " +
        //                                    "fornecedor.fornecedor as fornecedor," +
        //                                    "contas.descricao    as descricao," +
        //                                    "parcelas.num_parcela  as num_parcela, " +
        //                                    "parcelas.valor_parc   as valor_parc," +
        //                                    "parcelas.datavenc     as datavenc," +
        //                                    "parcelas.datapgto     as datapgto," +
        //                                    "parcelas.idparcela    as idparcela FROM parcelas " +
        //                            "INNER JOIN contas ON contas.idconta = parcelas.idconta " +
        //                            "INNER JOIN fornecedor ON contas.idfornecedor = fornecedor.idfornecedor WHERE parcelas.pago = 0 ORDER BY datavenc";

        //        ds = new DataSet();
        //        daContas = new SqlDataAdapter(strSQL, Conn);
        //        daContas.Fill(ds, "agenda");
        //    }
        //    catch (Exception ex)
        //    {
        //        string msg = ex.Message.ToString();

        //        MessageBox.Show(msg, "Não foi possivel acessar os dados.",
        //        MessageBoxButtons.OK, MessageBoxIcon.Error);

        //        this.Close();
        //        return;
        //    }
        //}

        private void carregaGrid_ListView(string criterioSQL)
        {
            var conn = Conexao.Conex();

            SqlCommand comandos = new SqlCommand();
            comandos.CommandText = Convert.ToString(CommandType.Text);
            comandos.CommandText = sqlString;
            comandos.Connection = conn;
            //*****************************************Consegui com a ajuda do FORUM MSDN****************dia 06-05-2013*********************************
            try
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();

                    DataTable tabela = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = comandos;
                    adapter.Fill(tabela);

                    if (tabela.Rows.Count > 0)
                    {
                        for (int i = 0; i < tabela.Rows.Count; i++)
                        {
                            DataRow drow = tabela.Rows[i];

                            // Somente as linhas que não foram deletadas
                            if (drow.RowState != DataRowState.Deleted)
                            {
                                ListViewItem lvi = new ListViewItem(drow["idconta"].ToString());
                                lvi.SubItems.Add(drow["datacadastro"].ToString());
                                lvi.SubItems.Add(drow["Fornecdor"].ToString());
                                lvi.SubItems.Add(drow["Historico"].ToString());
                                lvi.SubItems.Add(drow["Parcela"].ToString());
                                lvi.SubItems.Add(drow["Valor"].ToString());
                                lvi.SubItems.Add(drow["Vencimento"].ToString());
                                lvi.SubItems.Add(drow["Pagamento"].ToString());
                                lvi.SubItems.Add(drow["Idparcela"].ToString());
                                // Inclui os itens no ListView
                                listViewPesquisa.Items.Add(lvi);
                         
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_fornecedor.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally { conn.Clone(); }
            //***************************************************************************************************************************************
        }   
 * 
 * 
 * 
            //*********************************************Mostrar resultado do baco em uma LABEL********************************************************************************
            var sqlString_Mess = "SELECT SUM(valor_parc) FROM parcelas WHERE strftime('%m',datavenc) = '" + dateTimePick_Mes.Value.Month.ToString("00") + "' AND pago = 0";
            using (var cmd = new SqlCommand(sqlString_Mess, conn))
            {
                lblMes_total.Text = cmd.ExecuteScalar().ToString();
            }
            //************************************************************************///AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA*/
/*

 public void Colorir_Linhas()
        {
            foreach (DataGridViewRow dgvr in datagrid_Pesquisa.Rows)
            {
                DateTime hoje = DateTime.Now.Date; //pega somente a data atual do sistema

                DateTime Vencimento = Convert.ToDateTime(dgvr.Cells[6].Value.ToString().Replace("00:00:00", null));

                if (Vencimento < hoje)
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Red;    //colori as linhas do dataGridView
                    dgvr.DefaultCellStyle.ForeColor = Color.White; //muda a cor da fonte
                }
                else if (Vencimento == hoje)
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Yellow;
                    dgvr.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (Vencimento > hoje)
                {
                    datagrid_Pesquisa.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
                    datagrid_Pesquisa.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
        }

*/
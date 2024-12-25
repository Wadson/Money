using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class frmPesquiaDinamicaVendas : Money.FrmBaseGeral
    {
        public frmPesquiaDinamicaVendas()
        {
            InitializeComponent();
        }

        private string sqlListaCliente = "SELECT id_cliente, nome_cliente FROM cliente";
        private string sqlListaContas = "SELECT id_venda, dt_venda FROM venda";
        private string sqlListaItensVenda = "SELECT * FROM itensvenda";
        private string sqllistaParcelas = "SELECT * FROM parcelas";
        private string sqlListaContasReceber = "SELECT * FROM contasreceber";
        public void CarregarDataGrid(string SqlString, DataGridView MyDataGrid)
        {
            var conn = Conexao.Conex();

            SqlCommand comandos = new SqlCommand();
            comandos.CommandText = Convert.ToString(CommandType.Text);
            comandos.CommandText = SqlString;
            comandos.Connection = conn;

            //try
            //{

            //}
            //catch (Exception ex)
            //{
            //    ex.Message.ToString();
            //}
            //finally { conn.Close(); }
            conn.Open();

            System.Data.DataTable tabela = new System.Data.DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comandos;
            adapter.Fill(tabela);

            if (tabela.Rows.Count > 0)
            {
                MyDataGrid.DataSource = tabela;                
            }
            else
            {
                MyDataGrid.DataSource = null;
                //MessageBox.Show("Nenhum registro encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //lbl_Fornecedo.Text = "0";
            }
            conn.Close();
        }
        private void ContaRegistros(DataGridView dataGrid, Label nomelistagem)
        {
            if (dataGrid.DataSource != null)
            {
                Contagem = dataGrid.RowCount.ToString();
                nomelistagem.Text = Contagem;
            }
            else
                lblContaCliente.Text = "0";
        }
       
        private void frmPesquiaDinamicaVendas_Load(object sender, EventArgs e)
        {
            CarregarDataGrid(sqlListaCliente,dataGridCliente);
            CarregarDataGrid(sqlListaContas, dataGridVendas);
            CarregarDataGrid(sqlListaItensVenda, dataGridItensVenda);
            CarregarDataGrid(sqllistaParcelas, dataGridParcelas);
            CarregarDataGrid(sqlListaContasReceber, dataGridContasReceber);

            ContaRegistros(dataGridCliente, lblContaCliente);
            ContaRegistros(dataGridVendas, lblContaVendas);
            ContaRegistros(dataGridItensVenda, lblContaItensVenda);
            ContaRegistros(dataGridParcelas, lblContaParcelas);
            ContaRegistros(dataGridContasReceber, lblContaContasReceber);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void dataGridCliente_SelectionChanged(object sender, EventArgs e)
        {
            linhaAtual = dataGridCliente.CurrentRow.Index;

            if (dataGridCliente.DataSource != null)
            {
                try
                {
                    IDCliente = Convert.ToInt32(dataGridCliente.Rows[linhaAtual].Cells[0].Value);
                    Cliente = dataGridCliente.Rows[linhaAtual].Cells[1].Value.ToString();

                    SqlString = "SELECT id_venda, dt_venda FROM venda WHERE id_cliente LIKE  '" + IDCliente + "'";
                    CarregarDataGrid(SqlString, dataGridVendas);
                }
                catch
                {
                }
            }
            else
            {
                dataGridCliente.DataSource = null;
                dataGridVendas.DataSource = null;
                dataGridItensVenda.DataSource = null;
                dataGridParcelas.DataSource = null;
                dataGridContasReceber.DataSource = null;

                //dataGridCliente.Columns.Add("Cód.Conta", "Coluna");//Acrescenta colunas
                //dataGridView1.Columns.Add("Coluna2", "Coluna2");//Acrescenta colunas

                //MessageBox.Show("Nenhuma Conta para o fornecedor selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblContaCliente.Text = "0";
                lblContaVendas.Text = "0";
                lblContaItensVenda.Text = "0";
                lblContaParcelas.Text = "0";
                lblContaContasReceber.Text = "0";

            }
        }

        private void dataGridVendas_SelectionChanged(object sender, EventArgs e)
        {
            linhaAtual = dataGridVendas.CurrentRow.Index;

            if (dataGridVendas.DataSource != null)
            {
                try
                {
                    Id_Venda = Convert.ToInt32(dataGridVendas.Rows[linhaAtual].Cells[0].Value);

                    SqlString = "SELECT * FROM itensvenda WHERE id_venda LIKE  '" + Id_Venda + "'";
                    CarregarDataGrid(SqlString, dataGridItensVenda);
                }
                catch
                {
                }
            }
            else
            {                
                dataGridVendas.DataSource = null;
                dataGridItensVenda.DataSource = null;
                dataGridParcelas.DataSource = null;
                dataGridContasReceber.DataSource = null;

                //MessageBox.Show("Nenhuma Conta para o fornecedor selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                lblContaVendas.Text = "0";
                lblContaItensVenda.Text = "0";
                lblContaParcelas.Text = "0";
                lblContaContasReceber.Text = "0";
            }
        }

        private void dataGridItensVenda_SelectionChanged(object sender, EventArgs e)
        {
            linhaAtual = dataGridItensVenda.CurrentRow.Index;

            if (dataGridItensVenda.DataSource != null)
            {
                try
                {
                    Id_Venda = Convert.ToInt32(dataGridItensVenda.Rows[linhaAtual].Cells[2].Value);

                    SqlString = "SELECT * FROM parcelas WHERE id_venda LIKE  '" + Id_Venda + "'";
                    CarregarDataGrid(SqlString, dataGridParcelas);
                }
                catch
                {
                }
            }
            else
            {                
                dataGridItensVenda.DataSource = null;
                dataGridParcelas.DataSource = null;
                dataGridContasReceber.DataSource = null;

                //MessageBox.Show("Nenhuma Conta para o fornecedor selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                lblContaItensVenda.Text = "0";
                lblContaParcelas.Text = "0";
                lblContaContasReceber.Text = "0";
            }
        }

        private void dataGridParcelas_SelectionChanged(object sender, EventArgs e)
        {
            linhaAtual = dataGridParcelas.CurrentRow.Index;

            if (dataGridParcelas.DataSource != null)
            {
                try
                {
                    Id_Venda = Convert.ToInt32(dataGridParcelas.Rows[linhaAtual].Cells[4].Value);

                    SqlString = "SELECT * FROM contasreceber WHERE id_venda LIKE  '" + Id_Venda + "'";
                    CarregarDataGrid(SqlString, dataGridContasReceber);
                }
                catch
                {
                }
            }
            else
            {               
                dataGridParcelas.DataSource = null;
                dataGridContasReceber.DataSource = null;
                //MessageBox.Show("Nenhuma Conta para o fornecedor selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                lblContaParcelas.Text = "0";
                lblContaContasReceber.Text = "0";
            }
        }
       
        
        private void ExcluirCliente_Selecionado()
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente Excluir esse cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {                    
                    ClienteMODEL clienteModel = new ClienteMODEL();
                    clienteModel.Id_cliente = IDCliente;

                    ClienteBLL clienteBLL = new ClienteBLL();
                    clienteBLL.Excluir(clienteModel);

                    MessageBox.Show("Cliente(es) Excluido(os) com Sucesso !", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
            }
            catch
            {
            }
            txtPesquisa.Text = "";

        }
        private void ExcluirVenda_Selecionada()
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente Excluir esse cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    VendaMODEL vendaModel = new VendaMODEL();
                    vendaModel.Id_venda = Id_Venda;

                    VendaBLL vendaBLL = new VendaBLL();
                    vendaBLL.ExcluirVenda(vendaModel);

                    MessageBox.Show("Venda(es) Excluido(os) com Sucesso !", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
            }
            txtPesquisa.Text = "";
        }
        private void Excluir_ItensVenda_Selecionados()
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente Excluir esse cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ItensVendaMODEL itensvendaModel = new ItensVendaMODEL();
                    itensvendaModel.Id_itensvenda = Id_Itensvenda;

                    ItensVendaBLL itensVendaBll = new ItensVendaBLL();
                    itensVendaBll.ExcluirItensVenda(itensvendaModel);

                    MessageBox.Show("Itens de Venda Excluido com Sucesso !", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
            }
            txtPesquisa.Text = "";

        }
        private void ExcluirParcelas_Selecionada()
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente Excluir esse cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    VendaMODEL vendaModel = new VendaMODEL();
                    vendaModel.Id_venda = Id_Venda;

                    VendaBLL vendaBLL = new VendaBLL();
                    vendaBLL.ExcluirVenda(vendaModel);

                    MessageBox.Show("Venda(es) Excluido(os) com Sucesso !", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
            }
            txtPesquisa.Text = "";

        }
        private void ExcluirContasReceber_Selecionados()
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente Excluir esse cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ContasReceberMODEL contasreceberModel = new ContasReceberMODEL();
                    contasreceberModel.Id_contasreceber = Id_ContasReceber;

                    ContasReceberBLL contasreceberBll = new ContasReceberBLL();
                    contasreceberBll.exclui_ContaReceber(contasreceberModel);

                    MessageBox.Show("Contas a Receber Excluido(os) com Sucesso !", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
            }
            txtPesquisa.Text = "";

        }
        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            ExcluirCliente_Selecionado();
        }

        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {
           ExcluirVenda_Selecionada();
        }

        private void btnExcluirItensVenda_Click(object sender, EventArgs e)
        {
           Excluir_ItensVenda_Selecionados();
        }

        private void btnExcluirParcelas_Click(object sender, EventArgs e)
        {
            ExcluirParcelas_Selecionada();
        }

        private void btnExcluirContaReceber_Click(object sender, EventArgs e)
        {
            ExcluirContasReceber_Selecionados();
        }
    }
}

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
    public partial class frmPesquiaDinamica : FrmBaseGeral
    {        
        public frmPesquiaDinamica()
        {
            InitializeComponent();
            LinhasDatagrid();          
        }
        private void LinhasDatagrid()
        {
            dataGrid_fornecedor.AutoGenerateColumns = false;
            dataGrid_Parcelas.AutoGenerateColumns = false;                
            datagrid_contas.AutoGenerateColumns = false;
        }  
        private void ContaRegistros_fornecedor()
        {
            if (dataGrid_fornecedor.DataSource != null)
            {
                Contagem = dataGrid_fornecedor.RowCount.ToString();
                lblFornecedor.Text = Contagem;
            }
            else
                lblFornecedor.Text = "0";
        }

        private void ContaRegistros_Contas()
        {
            if (datagrid_contas.DataSource != null)
            {
                Contagem = datagrid_contas.RowCount.ToString();
                lblcontas.Text = Contagem;
            }
            else
                lblcontas.Text = "0";
            
        }
        private void ContaRegistros_Parcelas()
        {
            if (dataGrid_Parcelas.DataSource != null)
            {
                Contagem = dataGrid_Parcelas.RowCount.ToString();
                lblparcela.Text = Contagem;
            }
            else
                lblparcela.Text = "0";            
        }       

        public void carregaGrid_Contas(string criterioSQL)
        {
            var conn = Conexao.Conex();

            SqlCommand comandos = new SqlCommand();
            comandos.CommandText = Convert.ToString(CommandType.Text);
            comandos.CommandText = SqlString;
            comandos.Connection = conn;

            try
            {
                conn.Open();

                System.Data.DataTable tabela = new System.Data.DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comandos;
                adapter.Fill(tabela);

                if (tabela.Rows.Count > 0)
                {
                    datagrid_contas.DataSource = tabela;
                   
                    ContaRegistros_fornecedor();
                    ContaRegistros_Contas();
                    ContaRegistros_Parcelas();
                }
                else
                {
                    datagrid_contas.DataSource = null;
                    dataGrid_Parcelas.DataSource = null;
                    //MessageBox.Show("Nenhuma Conta para o fornecedor selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblcontas.Text = "0";
                    lblparcela.Text = "0";
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally { conn.Close(); }

        }

        public void carregaGrid_Fornecedor(string criterioSQL)
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
                dataGrid_fornecedor.DataSource = tabela;
               
                ContaRegistros_fornecedor();
            }
            else
            {
                dataGrid_fornecedor.DataSource = null;
                MessageBox.Show("Nenhum registro encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //lbl_Fornecedo.Text = "0";
            }
            conn.Close();
        }
        public void carregaGrid_Parcelas(string criterioSQL_parcelas)
        {
            var conn = Conexao.Conex();

            SqlCommand comandos = new SqlCommand();
            comandos.CommandText = Convert.ToString(CommandType.Text);
            comandos.CommandText = SqlString;
            comandos.Connection = conn;

            try
            {
                conn.Open();

                System.Data.DataTable tabela = new System.Data.DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comandos;
                adapter.Fill(tabela);

                if (tabela.Rows.Count > 0)
                {
                    dataGrid_Parcelas.DataSource = tabela;
                  
                    ContaRegistros_Parcelas();
                }
                else
                {
                    dataGrid_Parcelas.DataSource = null;
                    //MessageBox.Show("Conta sem parcela", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                    lblparcela.Text = "0";
                    
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally { conn.Close(); }

        }
      
        private void CarregaDados()
        {
            SqlString = "SELECT idfornecedor, fornecedor FROM fornecedor";
            carregaGrid_Fornecedor(SqlString);

            if (dataGrid_fornecedor.RowCount != 0)
            {
                foreach (DataGridViewRow row in dataGrid_fornecedor.Rows)
                {
                    row.Height = 15;
                }
            }
        }
        private void Carrega_Contas()
        {
            SqlString = "SELECT * from Contas";
            carregaGrid_Contas(SqlString);
        }
        private void ExcluirDiretoGrid()
        {
            if (this.datagrid_contas.SelectedRows.Count > 0)
            {
                var conn = Conexao.Conex();
                conn.Open();

                string idconta = (string)(this.datagrid_contas.SelectedRows[0].Cells[0].Value.ToString());

                DialogResult apagar = MessageBox.Show("Deseja realmente excluir essa conta orfã ", "Atenção ! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (apagar == DialogResult.Yes)
                {
                    SqlCommand Cnn_Command_Conta = new SqlCommand();      
                    SqlDataAdapter adapter_Conta = new SqlDataAdapter(); 
                    try
                    {

                        Cnn_Command_Conta.Connection = conn; 

                        Cnn_Command_Conta.Parameters.AddWithValue("idconta", idconta);                    
                        Cnn_Command_Conta.CommandText = "DELETE FROM contas WHERE idconta = @idconta";    

                        Cnn_Command_Conta.CommandType = CommandType.Text;
                        adapter_Conta.DeleteCommand = Cnn_Command_Conta;
                        int resultado = Cnn_Command_Conta.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Conta Excluído com succeso !", "Atenção ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGrid_Parcelas.DataSource = null;
                        CarregaDados();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.GetBaseException().ToString());
                    }
                    finally { };
                }
            }
            else
            {
                MessageBox.Show("Você tem que selecionar um registo", "Opa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_excluir_conta_Click(object sender, EventArgs e)
        {
            Contagem = dataGrid_Parcelas.RowCount.ToString();
            if (MessageBox.Show("Deseja Excluir a conta: " +Id_Venda+" do Fornecedor: "+ Fornecedor +" e a(as) "+Contagem+" parcelas? ", "Exclusão!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Excluir_Contas_Selecionados();
            }
           
        }
        private void Excluir_Contas_Selecionados()
        {
            try
            {
                ContasMODEL contasMode = new ContasMODEL();

                contasMode.IDConta = Id_Venda;

                ContasBLL contasBLL = new ContasBLL();
                contasBLL.exclui_Conta(contasMode);

                MessageBox.Show("Conta(as) Excluida(as) com Sucesso !", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                datagrid_contas.DataSource = DBNull.Value; dataGrid_Parcelas.DataSource = DBNull.Value;
                CarregaDados();
            }
            catch
            {
            }
        }
        private void Excluir_Parcelas_Selecionados()
        {              
            if (MessageBox.Show("Fornecedor(es) Excluido(os) com Sucesso !", "Question!",       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow linha in dataGrid_Parcelas.SelectedRows)
                    {
                        ParcelaModel parcelam = new ParcelaModel();
                        parcelam.Idparcela = Id_Parcela;

                        ParcelaBLL parcelabll = new ParcelaBLL();
                        parcelabll.excluir_Todas_Parcelas(parcelam);
                    }
                    MessageBox.Show("Parcela(as) Excluida(as) com Sucesso !", "Question!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    datagrid_contas.DataSource = DBNull.Value;
                    dataGrid_Parcelas.DataSource = DBNull.Value;
                    CarregaDados();
                }
                catch
                {
                }
            }
        }
        private void Excluir_Fornecedor_Selecionados()
        {
            try
            {
                if( MessageBox.Show("Fornecedor(es) Excluido(os) com Sucesso !", "Informação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    FornecedorMODEL fornecedorBll = new FornecedorMODEL();
                    fornecedorBll.ID_Fornecedor = IdFornecedor;

                    FornecedorBLL fornecedorBLL = new FornecedorBLL();
                    fornecedorBLL.excluiFornecedorDal(fornecedorBll);

                    MessageBox.Show("Fornecedor(es) Excluido(os) com Sucesso !", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaDados();
                }              
            }
            catch
            {
            }          
            txtPesquisa.Text = "";

        }
        private void ExcluirConta()
        {
            ContasMODEL objprecos = new ContasMODEL();
            try
            {
                string idconta = (string)(this.datagrid_contas.SelectedRows[0].Cells[0].Value.ToString());

                if (MessageBox.Show("Deseja realmente excluir este registro ?", "Pergunta.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objprecos.IDConta = Convert.ToInt32(idconta);

                    ContasBLL precosbll = new ContasBLL();
                    precosbll.exclui_Conta(objprecos);
                    MessageBox.Show("Registro excluido com sucesso ! ", "Informação !)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    datagrid_contas.DataSource = DBNull.Value; dataGrid_Parcelas.DataSource = DBNull.Value;
                    CarregaDados();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Não há dados para alterar. Localize um registro primeiro.", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Localizar2(string criterioSQL)
        {
            var conn = Conexao.Conex();

            dataGrid_fornecedor.DataSource = null;
            SqlCommand comandos = new SqlCommand();
            comandos.CommandText = Convert.ToString(CommandType.Text);
            comandos.CommandText = criterioSQL;
            comandos.Connection = conn;
            try
            {
                conn.Open();
                DataTable tabela = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comandos;
                adapter.Fill(tabela);

                if (tabela.Rows.Count > 0)
                {
                    dataGrid_fornecedor.DataSource = tabela;
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    txtPesquisa.Focus();
                    txtPesquisa.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally { conn.Close(); }

        }       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sqlStringDesc = "SELECT idfornecedor, fornecedor FROM fornecedor WHERE fornecedor  LIKE '" + txtPesquisa.Text + "%'";
            string sqlStringCod = "SELECT idfornecedor, fornecedor FROM fornecedor WHERE idfornecedor LIKE '" + txtPesquisa.Text + "%'";

            Localizar2(sqlStringDesc);            
        }

        private void btnExcluirFornecedor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Excluir o fornecedor: \n\n" +Fornecedor +"?", "Exclusão!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Excluir_Fornecedor_Selecionados();
            }
        }

        private void btnExcluirParcela_Click(object sender, EventArgs e)
        {
            Excluir_Parcelas_Selecionados();
        }

        private void frm_Pesquia_Dinamica_Load(object sender, EventArgs e)
        {
            CarregaDados();
            DataGridViewRow row = this.datagrid_contas.RowTemplate;
            row.Height = 17;
            row.MinimumHeight = 17;

            DataGridViewRow row1 = this.dataGrid_fornecedor.RowTemplate;
            row1.Height = 17;
            row1.MinimumHeight = 17;

            DataGridViewRow row2 = this.dataGrid_Parcelas.RowTemplate;
            row2.Height = 17;
            row2.MinimumHeight = 17;
        }

        private void dataGrid_fornecedor_SelectionChanged(object sender, EventArgs e)
        {
            linhaAtual = dataGrid_fornecedor.CurrentRow.Index;
            if (dataGrid_fornecedor.DataSource != null)
            {
                try
                {
                    linhaAtual = dataGrid_fornecedor.CurrentRow.Index;
                    IdFornecedor = Convert.ToInt32(dataGrid_fornecedor.Rows[linhaAtual].Cells[0].Value);
                    Fornecedor = dataGrid_fornecedor.Rows[linhaAtual].Cells[1].Value.ToString();

                    SqlString = "SELECT idconta, datacadastro, idfornecedor, descricao FROM contas WHERE idfornecedor LIKE  '" + IdFornecedor + "'";
                    carregaGrid_Contas(SqlString);

                }
                catch
                {
                }
            }
        }

        private void datagrid_contas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                linhaAtual = datagrid_contas.CurrentRow.Index;

                Id_Venda = Convert.ToInt32(datagrid_contas.Rows[linhaAtual].Cells[0].Value);

                SqlString = "SELECT * FROM parcelas WHERE idconta LIKE  '" + Id_Venda + "'";
                carregaGrid_Parcelas(SqlString);

                txtCodigo.Text = datagrid_contas.Rows[linhaAtual].Cells[0].Value.ToString();
                //txtDescricao.Text = datagrid_contas.Rows[linhaAtual].Cells[3].Value.ToString();

                Contagem = dataGrid_Parcelas.Rows.Count.ToString();
            }
            catch
            {
            }
            ContaRegistros_Parcelas();
        }

        private void datagrid_contas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                linhaAtual = datagrid_contas.CurrentRow.Index;

                Id_Venda = Convert.ToInt32(datagrid_contas.Rows[linhaAtual].Cells[0].Value);

                SqlString = "SELECT * FROM parcelas WHERE idconta LIKE  '" + Id_Venda + "'";
                carregaGrid_Parcelas(SqlString);


                txtCodigo.Text = datagrid_contas.Rows[linhaAtual].Cells[0].Value.ToString();
                //txtDescricao.Text = datagrid_contas.Rows[linhaAtual].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void dataGrid_Parcelas_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid_Parcelas.DataSource != null)
            {
                try
                {
                    linhaAtual = dataGrid_Parcelas.CurrentRow.Index;
                    Id_Parcela = Convert.ToInt32(dataGrid_Parcelas.Rows[linhaAtual].Cells[0].Value.ToString());
                }
                catch
                {
                }
            }
        }
    }
}
/*
 * sqlString = "SELECT controle.datacadastro,  controle.idcontrole,  fornecedor.fornecedor,  controle.descricao,  parcelas.num_parcela,  categoria.centro_custo,  parcelas.valor_parc, " +
                             "parcelas.datavenc,  parcelas.datapgto,  parcelas.idparcela  FROM controle INNER JOIN fornecedor  ON controle.idfornecedor = fornecedor.idfornecedor " +
                             "INNER JOIN parcelas    ON controle.idcontrole = parcelas.idcontrole   INNER JOIN categoria ON controle.idcentro = categoria.idcentro " +
                             "WHERE fornecedor LIKE '" + cmb_fornecedor + "%' AND pago = 0 ORDER BY datavenc";
*/
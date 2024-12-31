using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Data.SqlTypes;
using System.Windows.Controls;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Office.Interop.Word;
using System.Data.Linq.Mapping;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Common;
using DataTable = System.Data.DataTable;
using System.Linq;



namespace Money
{
    public partial class FrmVendas : Money.FrmBaseGeral
    {
        public int iDprimeiraParc { get; set; }
        public FrmVendas()
        {
            InitializeComponent();
            //preencherComboBoxT(cmbCategoria, "SELECT idcategoria, categoria FROM categoria", "idcategoria", "categoria");
        }
        int dias;
        public string idCateg { get; set; }
        public string idSubCat { get; set; }

        private void Salvar_Venda()
        {
            VendaMODEL objeto_venda = new VendaMODEL();

            objeto_venda.Id_venda = Convert.ToInt32(txtIdVenda.Text);
            objeto_venda.Dt_venda = Convert.ToDateTime(dtDataVenda.Text);
            objeto_venda.Id_cliente = Convert.ToInt32(IDCliente);            

            VendaBLL vendabll = new VendaBLL();
            vendabll.SalvarVenda(objeto_venda);

            MessageBox.Show("Conta gravada com sucesso!!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);            

            txtIdVenda.Text = RetornaCodigoContaMaisUm(QueryVendas).ToString();
            Id_Venda = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryVendas).ToString());

            dtDataVenda.Focus();
            txtTotal.Text = "0,00";
        }

        private void Salvar_ItensVenda()
        {
            ItensVendaMODEL objeto_itensvenda = new ItensVendaMODEL();

            objeto_itensvenda.Id_itensvenda = Convert.ToInt32(Id_Itensvenda);
            objeto_itensvenda.Id_produto = Convert.ToInt32(IdProduto);
            objeto_itensvenda.Qtd_produto = Convert.ToInt32(txtQuantidade.Text);
            objeto_itensvenda.Valor_produto = Convert.ToDouble(txtValorProduto.Text);
            //objeto_venda.Status_venda = Convert.ToDateTime(dtVencimento.Text);

            ItensVendaBLL itensvendabll = new ItensVendaBLL();
            itensvendabll.SalvarItensVenda(objeto_itensvenda);

            MessageBox.Show("Conta gravada com sucesso!!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            LimpaCampo();

            txtIdVenda.Text = RetornaCodigoContaMaisUm(QueryVendas).ToString();
            Id_Venda = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryVendas).ToString());

            dtDataVenda.Focus();
            txtTotal.Text = "0,00";
        }
        private void Salvar_Parcelas()
        {
            ItensVendaMODEL objeto_itensvenda = new ItensVendaMODEL();

            objeto_itensvenda.Id_itensvenda = Convert.ToInt32(Id_Itensvenda);
            objeto_itensvenda.Id_produto = Convert.ToInt32(IdProduto);
            objeto_itensvenda.Qtd_produto = Convert.ToInt32(txtQuantidade.Text);
            objeto_itensvenda.Valor_produto = Convert.ToDouble(txtValorProduto.Text);
            //objeto_venda.Status_venda = Convert.ToDateTime(dtVencimento.Text);

            ItensVendaBLL itensvendabll = new ItensVendaBLL();
            itensvendabll.SalvarItensVenda(objeto_itensvenda);

            MessageBox.Show("Conta gravada com sucesso!!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            LimpaCampo();

            txtIdVenda.Text = RetornaCodigoContaMaisUm(QueryVendas).ToString();
            Id_Venda = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryVendas).ToString());

            dtDataVenda.Focus();
            txtTotal.Text = "0,00";
        }  

        private void txtValorTotal_Click(object sender, EventArgs e)
        {
            //Força o cursor a ficar na direita
            //txtValorTotal.SelectionStart = txtValorTotal.TextLength + 1;           
        }


        public void HabilitaBotesCadastro2()
        {
            if (StatusOperacao == "NOVO")
            {
                //btnSalvar.Enabled = true;
            }
            else if (StatusOperacao == "ALTERAR")
            {
                //btnSalvar.Enabled = true;
            }
        }
        private void NovoCodigo()
        {//Traz o último código cadastrado + 1, para novo cadastro
            Id_Venda = RetornaCodigoContaMaisUm(QueryVendas);
            Id_Itensvenda = RetornaCodigoContaMaisUm(QueryItensVenda);
            Id_ContasReceber = RetornaCodigoContaMaisUm(QueryContasReceber);            
            Id_Parcela = RetornaCodigoContaMaisUm(QueryParcela);                 
        }
       
        private void FrmCadastroContas_Load(object sender, EventArgs e)
        {
            NovoCodigo();

            txtIdVenda.Text = Id_Venda.ToString();
            //AcrescenteZero_a_Esquerda2(txtIdVenda);  


            var nomeComputador = Environment.MachineName;
            lblEstação.Text = nomeComputador;
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
            //lblHoraAtual.Text = DateTime.UtcNow.ToString("HH:mm:ss");

            //preencherComboBoxT(cmbForma_Pgto, "SELECT * FROM formapgto", "id_formapgto", "formapgto");            
        }

        private void lblIDFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (txtTotal.Text.Substring(0) == ",")
                txtTotal.Text = "0" + txtTotal.Text;
        }

        private void txtValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != ',')
                    e.Handled = true;
                else if (txtTotal.Text.IndexOf(',') > 0)
                    e.Handled = true;
            }
        }
      
        private void txtPrecoVenda_Validating(object sender, CancelEventArgs e)
        {
            if (txtValorProduto.Text.Length == 0)
            {
                //errorProvider1.SetError((Control)txtPrecoVenda, "An explanation of your time entry is required.");
            }
            else
            {
                errorProvider1.SetError(txtValorProduto, "");
            }
        }
       
        private void PesquisaIdFormaPGTO()
        {
            var conn = Conexao.Conex();
            
            SqlCommand comando = new SqlCommand("SELECT id_formapgto FROM formapgto WHERE formapgto LIKE @criterio", conn);
            //comando.Parameters.AddWithValue("@criterio", nome_FormaPgto + "%");

            /* Aqui no CommandType tem que definir se vai utilizar uma Stored Procedure ou uma query */
            comando.CommandType = CommandType.Text; /* Quando usa Query */
            /* Aqui tem que preencher e adicionar os parametros*/
            comando.Parameters.Add(new SqlParameter("@criterio", nome_FormaPgto + "%"));

            conn.Open();
            DbDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                /* No dr["Nome do Campo da query que quer associar a Textbox */
                //txtIdFormaPgto.Text = dr["id_formapgto"].ToString(); // Essa funciona para TexBox
                IdFormaPgto = Convert.ToInt32(dr["id_formapgto"].ToString());
            }
            conn.Close();
        }
       
        public void ToMoney(System.Windows.Forms.TextBox text, string format = "N")
        {
            double value;
            if (double.TryParse(text.Text, out value))
            {
                text.Text = value.ToString(format);
            }
            else
            {
                text.Text = "0,00";
            }
        }
        private void TirarZeroEsquerda(System.Windows.Forms.TextBox tx)
        {
            string valor = tx.Text;
            string NovoValorSemZero = valor.TrimStart('0');
            tx.Text = NovoValorSemZero;
        }
        private void btnLocalizarProduto_Click(object sender, EventArgs e)
        {
            FrmLocalizaProduto localizaProduto = new FrmLocalizaProduto();
            localizaProduto.lblTitulo.Text = "Localizar Produtos";
            localizaProduto.ShowDialog();

            ToMoney(txtValorProduto);
            ToMoney(txtTotal);
            txtQuantidade.Focus();
            CalculaPrecoTotal();
            //AcrescenteZero_a_Esquerda2(txtIdProduto);
        }

        private void txtPrecoVenda_Enter(object sender, EventArgs e)
        {
            txtValorProduto.BackColor = Color.Yellow;
        }
        private void CalculaPrecoTotal()
        {
            txtTotal.Text = txtTotal.Text;

            try
            {
                if (txtQuantidade.Text != string.Empty && txtValorProduto.Text != string.Empty)
                {
                    decimal precovenda = decimal.Parse(txtValorProduto.Text);
                    int quantidade = int.Parse(txtQuantidade.Text);
                    decimal subtotal = precovenda * quantidade;
                    txtTotal.Text = subtotal.ToString();

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Atenção!", "Erro" + ex, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            CalculaPrecoTotal();
            
            txtQuantidade.BackColor = Color.White;
        }        
        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero e virgula", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero e virgula", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero e virgula", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero e virgula", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void IncluirItensNaGrid()
        {
            DataTable dt = new DataTable();
            dt = (DataTable)dataGridVendas.DataSource;            

            Num_Parcelas = 1;

            int zeroColumn = Id_Itensvenda++;
            string primeiraColumn = txtProduto.Text;
            string segundaColumn = txtQuantidade.Text;
            string terceiraColumn = txtValorProduto.Text;
            string quartaColumn = txtTotal.Text;
            string quintaColumn = dtpVencimento.Text;
            string sextaColumn = txtIdProduto.Text;
            string setimaColumn = txtIdVenda.Text;
            int oitavaColumn =    Id_Parcela++;
            string nonaColumn = txtValorProduto.Text;
            int decimaColumn = Num_Parcelas++;            
            bool decimaPriSegColumn = false;
            int decimaSegColumn = Id_ContasReceber++;

            string[] row = { zeroColumn++.ToString(), primeiraColumn, segundaColumn, terceiraColumn, quartaColumn, quintaColumn, sextaColumn, setimaColumn, (oitavaColumn++).ToString(), nonaColumn, decimaColumn++.ToString(), decimaPriSegColumn.ToString(), decimaSegColumn++.ToString() };
            dataGridVendas.Rows.Add(row);
            foreach (DataGridViewRow Row in dataGridVendas.Rows)
            {
                foreach (DataGridViewCell cell in Row.Cells)
                {
                    if (cell.ColumnIndex == dataGridVendas.Columns["valor_produto"].Index)
                    {
                        cell.Style.Format = "N";
                    }
                    if (cell.ColumnIndex == dataGridVendas.Columns["total"].Index)
                    {
                        cell.Style.Format = "N";
                    }
                }
            }

            //somar datagrid
            
            // fim
            ValorParc = Convert.ToDecimal(txtValorProduto.Text);

           
            txtProduto.Focus();

            txtIdProduto.Text = "";
            txtProduto.Text = "";
            txtQuantidade.Text = "";
            txtValorProduto.Text = "";
            txtTotal.Text = "";
            txtProduto.Focus();
            SomarGrid();    
        }
        public void SomarGrid()
        {            
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridVendas.Rows)
            {
                if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["total"].Value)))
                    total += Convert.ToDecimal(row.Cells["total"].Value);
            }

            txtTotalGrid.Text = Convert.ToDouble(total).ToString("N");
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (Id_Venda != 0 && Id_Itensvenda != 0)
            {
                IncluirItensNaGrid();               
            }
        }
        public void SalvarVenda()
        {
            if (dataGridVendas.Rows.Count != 0)
            {
                VendaMODEL objVenda = new VendaMODEL();

                objVenda.Id_venda = Convert.ToInt32(txtIdVenda.Text);
                objVenda.Dt_venda = Convert.ToDateTime(dtDataVenda.Text);
                objVenda.Id_cliente = Convert.ToInt32(IDCliente);

                VendaBLL venda_bll = new VendaBLL();

                venda_bll.SalvarVenda(objVenda);
                //MessageBox.Show("VENDA gravada com sucesso!", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }           
            //try
            //{


            //}
            //catch (Exception erro)
            //{
            //    MessageBox.Show("Não tem nenhum item na grid para salvar!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        
        public void SalvarItensVenda()
        {
            if (dataGridVendas.Rows.Count >= 1)
            {
                ItensVendaMODEL objItensVenda = new ItensVendaMODEL();
                objItensVenda.Id_itensvenda = Convert.ToInt32(dataGridVendas.CurrentRow.Cells["id_itensvenda"].Value);
                objItensVenda.Qtd_produto = Convert.ToInt32(dataGridVendas.CurrentRow.Cells["qtd_produto"].Value);
                objItensVenda.Valor_produto = Convert.ToDouble(dataGridVendas.CurrentRow.Cells["valor_produto"].Value);
                objItensVenda.Id_produto = Convert.ToInt32(dataGridVendas.CurrentRow.Cells["id_produto"].Value);
                objItensVenda.Id_venda = Convert.ToInt32(dataGridVendas.CurrentRow.Cells["id_venda"].Value);
                objItensVenda.Num_parcela = Convert.ToInt32(dataGridVendas.CurrentRow.Cells["num_parcela"].Value);//Convert.ToInt32(1);

                ItensVendaBLL Itensvenda_bll = new ItensVendaBLL();
                Itensvenda_bll.SalvarItensVenda(objItensVenda);                
            }            
        }
        public void SalvarParcelas()
        {
            ParcelaModel objoParcela = new ParcelaModel();

            if (dataGridVendas.Rows.Count >= 1)
            {
                foreach (DataGridViewRow row in dataGridVendas.Rows) //for (int i = 0; i < dataGridVendas.Rows.Count; i++)
                {

                    objoParcela.Idparcela = Convert.ToInt32(row.Cells["id_parcela"].Value);
                    objoParcela.Valor_parc = Convert.ToDecimal(row.Cells["valor_parcela"].Value);
                    objoParcela.Numparcela = Convert.ToInt32(row.Cells["num_parcela"].Value);
                    objoParcela.Datavenc = Convert.ToDateTime(row.Cells["dt_vcto_parcela"].Value);
                    objoParcela.IdVenda = Convert.ToInt32(row.Cells["id_venda"].Value);


                    //objoParcela.Idparcela = Convert.ToInt32(dataGridVendas.CurrentRow.Cells["id_parcela"].Value);
                    //objoParcela.Valor_parc = Convert.ToDecimal(dataGridVendas.CurrentRow.Cells["valor_parcela"].Value);
                    //objoParcela.Numparcela = Convert.ToInt32(dataGridVendas.CurrentRow.Cells["num_parcela"].Value);
                    //objoParcela.Datavenc = Convert.ToDateTime(dataGridVendas.CurrentRow.Cells["dt_vcto_parcela"].Value);
                    //objoParcela.IdVenda = Convert.ToInt32(dataGridVendas.CurrentRow.Cells["id_venda"].Value);

                    ParcelaBLL parcela_bll = new ParcelaBLL();
                    parcela_bll.Salvar_Parcelas(objoParcela);
                }
               
            }
        }
        public void SalvarContasReceber()
        {
            ContasReceberMODEL objoContaReceber = new ContasReceberMODEL();

            if (dataGridVendas.Rows.Count >= 1)
            {
                foreach (DataGridViewRow row in dataGridVendas.Rows)//for (int i = 0; i <= dataGridVendas.Rows.Count - 1; i++)
                {
                    objoContaReceber.Id_contasreceber = Convert.ToInt32(row.Cells["id_contasreceber"].Value);
                    objoContaReceber.Id_parcela = Convert.ToInt32(row.Cells["id_parcela"].Value);
                    objoContaReceber.Valor_parcela = Convert.ToDecimal(row.Cells["valor_parcela"].Value);
                    objoContaReceber.Status_conta = Convert.ToBoolean(row.Cells["status_conta"].Value);

                                        //objoContaReceber.Id_contasreceber = Id_ContasReceber;
                    //objoContaReceber.Id_parcela = Convert.ToInt32(dataGridVendas.CurrentRow.Cells["id_parcela"].Value);
                    //objoContaReceber.Valor_parcela = Convert.ToDecimal(dataGridVendas.CurrentRow.Cells["valor_parcela"].Value);
                    //objoContaReceber.Status_conta = Convert.ToBoolean(dataGridVendas.CurrentRow.Cells["status_conta"].Value);

                    ContasReceberBLL parcela_bll = new ContasReceberBLL();
                    parcela_bll.GravaContasReceberDal(objoContaReceber);                    
                }
            }
                   
            LimpaCampo();
            dataGridVendas.Rows.Clear();
            dataGridVendas.Refresh();

            ((frmManutContasReceber)System.Windows.Forms.Application.OpenForms["frmManutContasReceber"]).HabilitarTimer(true);
            MessageBox.Show("Vendas gravadas com sucesso!", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void txtQuantidade_Enter(object sender, EventArgs e)
        {
            txtQuantidade.BackColor = Color.Yellow;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            SalvarVenda();
            SalvarItensVenda();           
            SalvarParcelas();
            SalvarContasReceber();

            LimpaCampo();           

            txtNomeCliente.Enabled = false;
            txtProduto.Enabled = false;
            btnFinalizar.Enabled = false;

            btnLocalizarCliente.Enabled = false;
            btnLocalizarProduto.Enabled = false;
            btnIncluir.Enabled = false;
        }

       
        private void txtNomeCliente_Enter(object sender, EventArgs e)
        {
            txtNomeCliente.BackColor = Color.Yellow;
        }

        private void txtNomeCliente_Leave(object sender, EventArgs e)
        {
            txtNomeCliente.BackColor= Color.White;
        }

        private void txtProduto_Enter(object sender, EventArgs e)
        {
            txtProduto.BackColor = Color.Yellow;
        }

        private void txtProduto_Leave(object sender, EventArgs e)
        {
            txtProduto.BackColor= Color.White;
        }
      
        private void txtNomeCliente_KeyDown(object sender, KeyEventArgs e)
        {            
        }
        private void ExcluirLinhaDataGridView()
        {
            if (dataGridVendas.SelectedRows.Count == 0)
            {
                // Se entrar aqui é porque  não tem linha selecionado no grid
                MessageBox.Show("Nenhum Item Selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                // Se cair no else é porque tem uma linha selecionada no grid
                // Removendo a linha selecionada  
                dataGridVendas.Rows.RemoveAt(dataGridVendas.CurrentRow.Index);
            }
        }
        private void txtValorProduto_Leave(object sender, EventArgs e)
        {
            txtValorProduto.BackColor = Color.White;
            txtTotal.Text = txtTotal.Text;

            try
            {
                if (txtValorProduto.Text != string.Empty && txtQuantidade.Text != string.Empty)
                {
                    decimal precovenda = decimal.Parse(txtValorProduto.Text);
                    int quantidade = int.Parse(txtQuantidade.Text);
                    decimal subtotal = precovenda * quantidade;
                    txtTotal.Text = subtotal.ToString();                    
                    if (txtValorProduto.Text != string.Empty)
                    {
                        ToMoney(txtValorProduto);
                        ToMoney(txtTotal);
                    }
                
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Atenção!", "Erro" + ex, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnParcelar_Click(object sender, EventArgs e)
        {
            FrmGerarParcelas gerarparc = new FrmGerarParcelas();
            SalvarVenda();
            SalvarItensVenda();
            
            if (dataGridVendas.Rows.Count != 0)
            {
                gerarparc.txtIdVenda.Text = txtIdVenda.Text;
                gerarparc.txtTotal.Text = dataGridVendas.CurrentRow.Cells[4].Value.ToString();
                gerarparc.txtNomeCliente.Text = txtNomeCliente.Text;

                gerarparc.Id_ContasReceber = Id_ContasReceber;
                gerarparc.Id_Parcela = Id_Parcela;
                gerarparc.ValorParc = ValorParc;
                gerarparc.IdFormaPgto = IdFormaPgto;


                gerarparc.ShowDialog();
                gerarparc.lblTitulo.Text = "Gerar Parcelas para o Cliente:"+Nome;
                btnParcelar.Enabled = false;
            }
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonNao_CheckedChanged(object sender, EventArgs e)
        {
            btnFinalizar.Enabled = true;
            btnParcelar.Enabled = false;
        }

        private void radioButtonSim_CheckedChanged(object sender, EventArgs e)
        {
            btnFinalizar.Enabled = false;
            btnParcelar.Enabled = true;
        }
        private void btnExcluirItemGrid_Click(object sender, EventArgs e)
        {
            ExcluirLinhaDataGridView();
        }
        public override DataTable LocalizarGeral(SqlCommand comando)
        {
            return base.LocalizarGeral(comando);
        }
        public override int BuscarRetornoVariavel(string sqlComando, string Nomeparametro, string parametro, string campoTabela)
        {
            return base.BuscarRetornoVariavel(sqlComando, Nomeparametro, parametro, campoTabela);
        }
        private void cmbForma_Pgto_SelectedValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    txtIdFormaPgto.Text = cmbForma_Pgto.SelectedValue.ToString();
            //}
            //catch   { }
        }
      
        private void btnLocalizarCliente_Click_1(object sender, EventArgs e)
        {
            FrmLocalizaCliente pesquisacli = new FrmLocalizaCliente();

            pesquisacli.TipoCadastro = "DEBITO";           
            pesquisacli.lblTitulo.Text = "Localizar Clientes";
            pesquisacli.Show();
        }
      
      

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text = "";
            txtProduto.Text = "";
            txtQuantidade.Text = "";
            txtValorProduto.Text = "";
            txtTotal.Text = "";
            txtIdProduto.Text = "";
            txtIdVenda.Text = "";

            txtNomeCliente.Enabled = true;
            txtProduto.Enabled = true;
            btnFinalizar.Enabled = true;

            btnLocalizarCliente.Enabled = true;
            btnLocalizarProduto.Enabled = true;
            btnIncluir.Enabled = true;
            txtIdVenda.Text = RetornaCodigoContaMaisUm(QueryVendas).ToString();
            NovoCodigo();
            //AcrescenteZero_a_Esquerda2(txtIdVenda);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
    public static class TextFormadoDinheiro
    {
        public static void ParaDouble(this TexBox text, string format = "N")
        {
            double value;
            if (double.TryParse(text.Text, out value))
            {
                text.Text = value.ToString(format);
            }
            else
            {
                text.Text = "0,00";
            }
        }
    }
}

/*
 * 
 * 
 * 
 * private void txtValorTotal_KeyUp(object sender, KeyEventArgs e)
        {
            string valorsemformato;
            valorsemformato = txtValorTotal.Text;
            valorsemformato = valorsemformato.Replace("R$", "").Replace(" ", "");
            txtValorTotal.Text = valorsemformato;
        }
 * */


/*
 private void GerarParcelas()
        {
            IdParcela = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryParcela).ToString());
            IdVenda = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryVendas));

            if (Convert.ToString(IDCliente) != string.Empty)
            {
                if (checkBoxIntervaloEntreParc.Checked == true)
                {
                    dias = Convert.ToInt32(txtDias.Text);
                }
                else
                {
                    dias = 30;

                    //IMPLEMENTADO DIA 18/12/2024 AS 20:34


Fim da implementação acima
Cliente = txtNomeCliente.Text;
Parcelas = Convert.ToInt32(txtQtdParcelas.Value);
                }
                
            

                try
{
    //ValorTotal = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtDesconto.Text);
    ValorTotal = Convert.ToDecimal(txtTotal.Text);
    Dt_Vcto_Parc = Convert.ToDateTime(dtPrimeiraParc.Text);

    ValorParc = ValorTotal / Parcelas;
    FormaPgto = cmbForma_Pgto.Text;
    IdFormaPgto = IdFormaPgto;
}
catch
{
}
DataTable dt = new DataTable();

dt.Columns.Add("id_parcela", typeof(int));
dt.Columns.Add("valor_parcela", typeof(Decimal));
dt.Columns.Add("num_parcela", typeof(int));
dt.Columns.Add("dt_vcto_parcela", typeof(DateTime));
dt.Columns.Add("id_venda", typeof(int));

for (var i = 0; i < Parcelas; i++)
{
    if (checkBoxIntervaloEntreParc.Checked == false)
    {
        dt.Rows.Add(IdParcela++, ValorParc, (i + 1), Dt_Vcto_Parc.AddMonths(i), IdVenda);
    }
    if (checkBoxIntervaloEntreParc.Checked == true)
    {
        dt.Rows.Add(IdParcela++, ValorParc, (i + 1), Dt_Vcto_Parc.AddDays((i) * dias), IdVenda);
    }
}
dataGrid_Parcelas.DataSource = dt; //implementado dia 13/05/2017 as 21:29 por Wadson R. Lima              

            }
            if (dataGrid_Parcelas.RowCount != 0)
{
    foreach (DataGridViewRow row in dataGrid_Parcelas.Rows)
    {
        row.Height = 15;
    }
}
*/
/*
 *EVITA QUE TEXTO, SÓ ACEITA NÚMERO E VIRGULA
 * private void textbox11_num(object sender, KeyPressEventArgs e)
{
    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Decimal && e.KeyChar != (char)Keys.Oemcomma && e.KeyChar != (char)Keys.OemPeriod)
    {
        e.Handled = true;
        MessageBox.Show("este campo aceita somente numero e virgula");
    }
}
 */
/*
 private void preencherCBFormaPgto()
        {
            SqlConnection connection = null;
            String scon = "Data Source=DESKTOP-WR\\SQLEXPRESS;Initial Catalog=bdmoney;Integrated Security=True;";
            connection = new SqlConnection(scon);
            try
            {
                connection.Open();
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Falha ao efetuar a conexão. Erro: " + sqle);
            }
            String scom = "SELECT * FROM formapgto";
            SqlDataAdapter da = new SqlDataAdapter(scom, connection);
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            cmbFormaPgto.DataSource = null;
            da.Fill(dtResultado);
            cmbFormaPgto.DataSource = dtResultado;
            cmbFormaPgto.ValueMember = "id_formapgto";
            cmbFormaPgto.DisplayMember = "formapgto";
            cmbFormaPgto.SelectedItem = "";
            cmbFormaPgto.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
private void GerarParcelas()
        {
            IdParcela = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryParcela).ToString());
            IdVenda = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryVendas));

            if (Convert.ToString(IDCliente) != string.Empty)
            {
                if (checkBoxIntervaloEntreParc.Checked == true)
                {
                    dias = Convert.ToInt32(txtDias.Text);
                }
                else
                    dias = 30;

                Cliente = txtNomeCliente.Text;
                Parcelas = Convert.ToInt32(txtQtdParcelas.Value);

                try
                {
                    //ValorTotal = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtDesconto.Text);
                    ValorTotal = Convert.ToDecimal(txtTotal.Text);
                    Dt_Vcto_Parc = Convert.ToDateTime(dtPrimeiraParc.Text);

                    ValorParc = ValorTotal / Parcelas;
                    FormaPgto = cmbForma_Pgto.Text;                    
                    IdFormaPgto = IdFormaPgto;
                }
                catch
                {
                }
                DataTable dt = new DataTable();

                dt.Columns.Add("id_parcela", typeof(int));
                dt.Columns.Add("valor_parcela", typeof(Decimal));
                dt.Columns.Add("num_parcela", typeof(int));
                dt.Columns.Add("dt_vcto_parcela", typeof(DateTime));
                dt.Columns.Add("id_venda", typeof(int));

                for (var i = 0; i < Parcelas; i++)
                {
                    if (checkBoxIntervaloEntreParc.Checked == false)
                    {
                        dt.Rows.Add(IdParcela++, ValorParc, (i + 1), Dt_Vcto_Parc.AddMonths(i), IdVenda );                                             
                    }
                    if (checkBoxIntervaloEntreParc.Checked == true)
                    {
                        dt.Rows.Add(IdParcela++, ValorParc, (i + 1), Dt_Vcto_Parc.AddDays((i) * dias ), IdVenda);
                    }
                }
                dataGrid_Parcelas.DataSource = dt; //implementado dia 13/05/2017 as 21:29 por Wadson R. Lima              

            }
            if (dataGrid_Parcelas.RowCount != 0)
            {
                foreach (DataGridViewRow row in dataGrid_Parcelas.Rows)
                {
                    row.Height = 15;
                }
            }
        }


string quantidadeDeParcelas = cmbForma_Pgto.Text;
            switch (quantidadeDeParcelas)
            {
                case "30 DIAS":
                    txtQtdParcelas.Value = 1;
                    break;
                case "30/60 DIAS":
                    txtQtdParcelas.Value = 2;
                    break;
                case "30/60/90 DIAS":
                    txtQtdParcelas.Value = 3;
                    break;
                case "30/60/90/120 DIAS":
                    txtQtdParcelas.Value = 4;
                    break;
                case "30/60/120/150 DIAS":
                    txtQtdParcelas.Value = 5;
                    break;
                case "30/60/90/120/150/180 DIAS":
                    txtQtdParcelas.Value = 6;
                    break;
            }
 
 */
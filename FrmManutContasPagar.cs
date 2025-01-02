using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;

namespace Money
{
    public partial class FrmManutContasPagar : FrmBaseGeral
    {
        public FrmManutContasPagar()
        {
            InitializeComponent();            
        }
      
        private string mes { get; set; }
        private int ano { get; set; }
        public bool Cadastrar;
        public bool Agrupado;
       

        public string comandoAgrupado;      
     
        public string Sql = "SELECT contas.idconta, parcelas.idparcela, fornecedor.idfornecedor, categoria.idcategoria, subcategoria.idsubcategoria, formapgto.idformapgto, fornecedor.fornecedor, categoria.categoria, subcategoria.subcategoria, " +
                         " formapgto.formapgto, parcelas.num_parcela, parcelas.valor_parc, parcelas.datapgto, parcelas.valorpago, contas.datacadastro, contas.descricao, parcelas.datavenc  " +
                         " FROM contas INNER JOIN  categoria ON contas.idcategoria = categoria.idcategoria INNER JOIN  formapgto ON contas.idformapgto = formapgto.idformapgto INNER JOIN  " +
                         " fornecedor ON contas.idfornecedor = fornecedor.idfornecedor INNER JOIN parcelas ON contas.idconta = parcelas.idconta INNER JOIN  subcategoria ON contas.idsubcategoria = subcategoria.idsubcategoria  ";



        private void CapturaDadosGrid2()
        {
            int QtdParcelas = 0;                 
           
            Id_Venda = BuscarRetornoVariavel("SELECT datacadastro FROM contas WHERE (idconta = @idconta)", "@idconta", Convert.ToString(Id_Venda), "idconta");
            IdFornecedor =  BuscarRetornoVariavel("SELECT idfornecedor FROM fornecedor WHERE (fornecedor = @fornecedor)", "@fornecedor", Fornecedor, "idfornecedor");         
            QtdParcelas =  BuscarRetornoVariavel("SELECT COUNT(*) AS Quantidade FROM parcelas WHERE (idconta = @idconta)", "@idconta", Convert.ToString(Id_Venda),  "Quantidade");
            //dataPrimeira =  BuscarRetornoVariavel("SELECT MIN(datavenc) AS PrimeiraData FROM parcelas WHERE (idconta = @idconta)", "@idconta", Convert.ToString(IdConta), "PrimeiraData");
            DataP.ToShortDateString();         
        }       
   

        private void ContaRegistros()
        {
            Contagem = dataGridPesquisa.Rows.Count.ToString();

            if (Contagem != string.Empty)
            {
                lblContaRegistros.Text = Convert.ToString(Contagem.ToString());
            }
        }
        public void SomaGrid()
        {
            if (dataGridPesquisa.DataSource != null)
            {
                decimal soma = 0;
                foreach (DataGridViewRow dr in dataGridPesquisa.Rows)
                {
                    soma += Convert.ToDecimal(dr.Cells[11].Value);

                    lblTotalPesquisa.Text = Convert.ToString(soma);
                    lblTotalPesquisa.Text = Convert.ToDouble(lblTotalPesquisa.Text).ToString("N");
                }
            }
        }
        
        private void LocalizarContas()
        {          
            string criterio = "";
            criterio = txtPesquisa.Text.ToString();

            if (rbFornecedor.Checked == true)
            {
                PesquisarDinamicoDataGrid(Sql, "WHERE fornecedor.fornecedor LIKE '" + criterio + "%' AND pago = 0 ORDER BY datavenc", dataGridPesquisa, lblMensagem);
            }
            if (rbFormapgto.Checked == true)
            {
                PesquisarDinamicoDataGrid(Sql, "WHERE formapgto.formapgto LIKE '" + criterio + "%' AND pago = 0 ORDER BY datavenc", dataGridPesquisa, lblMensagem);
            }
            ContaRegistros();
            SomaGrid();
        }
        private void ListarContas()
        {
            PesquisarDinamicoDataGrid(Sql, " AND pago = 0 ORDER BY datavenc", dataGridPesquisa, lblMensagem);
            ContaRegistros();
            SomaGrid();
        }
       
        
        private void Excluir_Selecionados()
        {
            if(MessageBox.Show("Excluir Registro(s)??", "Atenção!!!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                foreach (DataGridViewRow linha in dataGridPesquisa.SelectedRows)
                {
                    Id_Venda = Convert.ToInt16(linha.Cells[0].Value.ToString());
                    try
                    {
                        ParcelaModel parcelaMMOd = new ParcelaModel();
                        parcelaMMOd.IdVenda = Id_Venda;
                        ParcelaBLL parcelaBLL = new ParcelaBLL();
                        parcelaBLL.excluir_Todas_Parcelas(parcelaMMOd);
                        //*********************************************
                        ContasMODEL contasmodel = new ContasMODEL();
                        contasmodel.IDConta = Id_Venda;
                        ContasBLL contasbll = new ContasBLL();
                        contasbll.exclui_Conta(contasmodel);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Excluir os Registros Selecionados !" + ex, "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                ((FrmManutContasPagar)System.Windows.Forms.Application.OpenForms["FrmManutContasPagar"]).HabilitarTimer(true);
                MessageBox.Show("Registro(s) Excluido(s) com Sucesso !", "Exclusão!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
      
        private void Quitar_Varios()
        {
            foreach (DataGridViewRow linha in dataGridPesquisa.SelectedRows)
            {
                Pagamento = DateTime.Now;
                Pago = 1;

                Id_Parcela = Convert.ToInt16(linha.Cells[1].Value.ToString());
                ValorParc = Convert.ToDecimal(linha.Cells[11].Value.ToString());
                Pagamento = Pagamento;

                ParcelaModel parcelass = new ParcelaModel();

                parcelass.Valorpago = ValorParc;
                parcelass.Datapgto = Pagamento;
                parcelass.Pago = Pago;
                parcelass.Idparcela = Id_Parcela;

                ParcelaBLL parcbll = new ParcelaBLL();
                parcbll.BaixarParcelas(parcelass);

            }
            MessageBox.Show("Parcelas quitadas", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ((FrmManutContasPagar)System.Windows.Forms.Application.OpenForms["FrmManutContasPagar"]).HabilitarTimer(true);
        }

       
        private void txtFornecedor_TextChanged(object sender, EventArgs e)
        {
            LocalizarContas();
        }
        public void HabilitarTimer(bool habilitar)
        {
            timerAtualizaMetodo.Enabled = habilitar;
        }   
        private void timerAtualizaMetodo_Tick(object sender, EventArgs e)
        {
            btnLocalizar.PerformClick();
            timerAtualizaMetodo.Enabled = false;
        }
        private void AlterarSelecionados()
        {
            DateTime DataV = new DateTime();
            DataV = Convert.ToDateTime(null);

            foreach (DataGridViewRow linha in dataGridPesquisa.SelectedRows)
            {
                Id_Parcela = Convert.ToInt16(linha.Cells[1].Value.ToString());
                Dt_Vcto_Parc = Convert.ToDateTime(linha.Cells[16].Value.ToString());
                ValorParc = Convert.ToDecimal(linha.Cells[11].Value.ToString());
                FormaPgto = linha.Cells[9].Value.ToString();

                ParcelaModel parcelass = new ParcelaModel();

                parcelass.Idparcela = Id_Parcela;
                parcelass.Valor_parc = ValorParc;
                parcelass.Datavenc = Dt_Vcto_Parc;
                parcelass.Datapgto = DataV;
                
                ParcelaBLL parcbll = new ParcelaBLL();
                parcbll.atualiza_parcelas(parcelass);

            }
            MessageBox.Show("Parcelas Alteradas", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExibirDetalhe()
        {
            int QtdParcelas = 0;
            DateTime dataPrimeira = new DateTime();           

          
            FrmDetalhe f3 = new FrmDetalhe();
            
            f3.txtIdConta.Text = dataGridPesquisa.CurrentRow.Cells[0        ].Value.ToString();
            Id_Venda = Convert.ToInt32(dataGridPesquisa.CurrentRow.Cells[0   ].Value);
            f3.txtIdParcela.Text = dataGridPesquisa.CurrentRow.Cells[1      ].Value.ToString();
            f3.lblIdFornecedor.Text = dataGridPesquisa.CurrentRow.Cells[2   ].Value.ToString();
            f3.lblIdCategoria.Text = dataGridPesquisa.CurrentRow.Cells[3    ].Value.ToString();
            f3.lblIDSubCategoria.Text = dataGridPesquisa.CurrentRow.Cells[4 ].Value.ToString();
            f3.lblIdFormapgto.Text = dataGridPesquisa.CurrentRow.Cells[5    ].Value.ToString();
            f3.txtFornecedor.Text = dataGridPesquisa.CurrentRow.Cells[6     ].Value.ToString();
            f3.txtcategoria.Text = dataGridPesquisa.CurrentRow.Cells[7      ].Value.ToString();
            f3.txtSubCategoria.Text = dataGridPesquisa.CurrentRow.Cells[8   ].Value.ToString();
            f3.txtFormapgto.Text = dataGridPesquisa.CurrentRow.Cells[9      ].Value.ToString();
            f3.txtParcela.Text = dataGridPesquisa.CurrentRow.Cells[10       ].Value.ToString();
            f3.txtValorParc.Text = dataGridPesquisa.CurrentRow.Cells[11     ].Value.ToString();
            ValorParc = Convert.ToDecimal(dataGridPesquisa.CurrentRow.Cells[11].Value.ToString());
            f3.dtPgto.Text = dataGridPesquisa.CurrentRow.Cells[12           ].Value.ToString();
            f3.txtValorPago.Text = dataGridPesquisa.CurrentRow.Cells[13     ].Value.ToString();
            f3.dtEmissao.Text = Convert.ToString(dataGridPesquisa.CurrentRow.Cells[14].Value);
            f3.txtDescricao.Text = dataGridPesquisa.CurrentRow.Cells[15].Value.ToString();
            f3.dtVencimento.Text = Convert.ToString(dataGridPesquisa.CurrentRow.Cells[16].Value);
            
            dataPrimeira = Convert.ToDateTime(BuscarRetornoVariavelData("SELECT MIN(datavenc) AS PrimeiraData FROM parcelas WHERE (idconta = @idconta)", "@idconta", Convert.ToString(Id_Venda), "PrimeiraData"));
            QtdParcelas = BuscarRetornoVariavel("SELECT COUNT(num_parcela) AS QTDParcelas FROM parcelas WHERE (idconta = @idconta)", "@idconta", Convert.ToString(Id_Venda), "QTDParcelas");

            f3.txtQtdparcelas.Text = QtdParcelas.ToString();

            f3.txtParc.Text = f3.txtValorParc.Text;
           
            ValorTotal = ValorParc * QtdParcelas;
            f3.txtValorTotal.Text = ValorTotal.ToString();//IMPLEMENTANDO DIA 25/07/2018 AS 19:41
            f3.txtValorTotal.Text = Convert.ToDouble(f3.txtValorTotal.Text).ToString("N");          
            f3.txtValorParc.Text = Convert.ToDouble(f3.txtValorParc.Text).ToString("N");
            f3.txtParc.Text = Convert.ToDouble(f3.txtParc.Text).ToString("N");
           
                  
            if (f3.txtValorPago.Text != string.Empty)
            {
                f3.txtValorPago.Text = Convert.ToDouble(f3.txtValorPago.Text).ToString("N");
            }


            f3.Show();
        }       
        private void LimpaLabelTotais()
        {
            lblTotalPesquisa.Text = "0,00";
            lblContaRegistros.Text = "0,00";
            lblTotalSelecionado.Text = "0,00";
        }
        private void txtFornecedor_Enter(object sender, EventArgs e)
        {
            txtPesquisa.BackColor = Color.Yellow;           
        }

        private void txtFornecedor_Leave(object sender, EventArgs e)
        {
            txtPesquisa.BackColor = Color.SteelBlue;           
        }
        private void txtFornecedor_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.BackColor = Color.Yellow;           
        }
         
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmVendas childForm = new FrmVendas();

            childForm.StatusOperacao = "NOVO";
            childForm.lblTitulo.Text = "NOVO CADASTRO";
            HabilitaBotesCadastro();
            childForm.ShowDialog();
        }
        //private void CapturarDadosGrid()
        //{
        //    linhaAtual = dataGridPesquisa.CurrentRow.Index;

        //    FrmVendas f3 = new FrmVendas();
        //    Cadastrar = false;
        //    f3.btnSalvar.Enabled = true;
        //    //f3.btnParcelar.Enabled = false;
        //    f3.btnNovo.Enabled = false;

        //    f3.IdVenda = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);            
        //    f3.IdParcela = Convert.ToInt32(dataGridPesquisa[1, linhaAtual].Value);           
        //    f3.txtNomeCliente.Text = dataGridPesquisa[6, linhaAtual].Value.ToString();
        //    Fornecedor = dataGridPesquisa[6, linhaAtual].Value.ToString();            
        //    f3.txtProduto.Text = dataGridPesquisa[8, linhaAtual].Value.ToString();           
        //    f3.NumParcelas = dataGridPesquisa[10, linhaAtual].Value.ToString();           
        //    f3.dtDataVenda.Text = Convert.ToString(dataGridPesquisa[14, linhaAtual].Value);
            

        //    f3.StatusOperacao = "ALTERAR";
        //    f3.lblTitulo.Text = "ALTERAR" + " " + Fornecedor;
        //    f3.Text = "MONEY - Alterar registro:  " + " | " + Fornecedor;
        //    f3.ShowDialog();
        //    try
        //    {

        //    }
        //    catch (Exception EX)
        //    {
        //        MessageBox.Show("Atenção" + EX, "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    ((FrmManutContasPagar)System.Windows.Forms.Application.OpenForms["FrmManutContasPagar"]).HabilitarTimer(true);
        //}
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //CapturarDadosGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o(s) registro(s) selecionado(s)?", "Atenção! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Excluir_Selecionados();
                ((FrmManutContasPagar)System.Windows.Forms.Application.OpenForms["FrmManutContasPagar"]).HabilitarTimer(true);// Habilita Timer do outro form Obs: O timer no outro form executa um Método.    
                btnLocalizar.PerformClick();
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            LocalizarContas();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Deseja quitar todos os registros selecionados?", "Escolha!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (escolha == DialogResult.Yes)
            {
                Quitar_Varios();
            }
            else if (escolha == DialogResult.No)
            {
                FrmQuitar f3 = new FrmQuitar(this);
                f3.MdiParent = this.MdiParent;

                if (dataGridPesquisa.DataSource != null)
                {
                    linhaAtual = dataGridPesquisa.CurrentRow.Index;

                    if (linhaAtual >= 0)
                    {
                        f3.Id_Venda = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value.ToString());
                        f3.Id_Parcela = Convert.ToInt32(dataGridPesquisa[1, linhaAtual].Value.ToString());   
                        f3.Fornecedor = dataGridPesquisa[6, linhaAtual].Value.ToString();
                        Fornecedor = dataGridPesquisa[6, linhaAtual].Value.ToString();
                        f3.Parcela = Convert.ToInt32(dataGridPesquisa[10, linhaAtual].Value);
                        f3.ValorParc = Convert.ToDecimal(dataGridPesquisa[11, linhaAtual].Value.ToString());
                        f3.Cadastro = Convert.ToDateTime(dataGridPesquisa[14, linhaAtual].Value.ToString());
                        f3.Descricao = dataGridPesquisa[15, linhaAtual].Value.ToString();
                        f3.Dt_Vcto_Parc = Convert.ToDateTime(dataGridPesquisa[16, linhaAtual].Value.ToString());

                        f3.Show();
                        ((FrmManutContasPagar)System.Windows.Forms.Application.OpenForms["FrmManutContasPagar"]).HabilitarTimer(true);
                    }
                }
            }
            
        }

        private void cmbTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }
        public void HabilitaBotesCadastro()
        {
            if (StatusOperacao == "NOVO")
            {
                btnAlterar.Enabled = false;
                btnNovo.Enabled = true;
                btnExcluir.Enabled = false;
                btnPagar.Enabled = false;                
            }
            else if (StatusOperacao == "ALTERAR")
            {
                btnAlterar.Enabled = true;
                btnNovo.Enabled = true;
                btnExcluir.Enabled = true;
                btnPagar.Enabled = true;                
            }
        }

        private void dataGridPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibirDetalhe();
        }

        private void dataGridPesquisa_SelectionChanged(object sender, EventArgs e)
        {            
            if (dataGridPesquisa.DataSource != null)
            {
                decimal soma = 0;

                foreach (DataGridViewRow dr in dataGridPesquisa.SelectedRows)
                {
                    soma += Convert.ToDecimal(dr.Cells[11].Value);

                    lblTotalSelecionado.Text = Convert.ToString(soma);
                    lblTotalSelecionado.Text = Convert.ToDouble(lblTotalSelecionado.Text).ToString("N");
                }
            }
            else
            {
                LimpaLabelTotais();
            }
        }

        private void FrmManutContasPagar_Load(object sender, EventArgs e)// É Privado
        {
        //    if (Criterio == "NORMAL")
        //    {
        //        ListarContas();
        //    }
        //    else if (Criterio == "VENCIDOS")
        //    {
        //        PesquisarDinamicoDataGrid(Sql, " WHERE datavenc < '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' AND pago = 0 ", dataGridPesquisa, lblMensagem);
        //    }
        //    else if (Criterio == "VENCEHOJE")
        //    {
        //        PesquisarDinamicoDataGrid(Sql, " WHERE datavenc = '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' AND pago = 0 ", dataGridPesquisa, lblMensagem);
        //    }
        //    else if(Criterio == "TODOS")
        //    {
        //        ListarContas();
        //    }
        //    else if (Criterio == "AVENCER")
        //    {
        //        PesquisarDinamicoDataGrid(Sql, " WHERE datavenc > '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' AND pago = 0 ", dataGridPesquisa, lblMensagem);
        //    }
        //    SomaGrid();
        //    ContaRegistros();
        }

        private void rbFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Focus();
            txtPesquisa.Text = "";
        }

        private void rbFormapgto_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Focus();
            txtPesquisa.Text = "";
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridPesquisa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //DateTime dataAtual = new DateTime();
            //dataAtual.ToShortDateString();
            //if(dataGridPesquisa.Columns[e.ColumnIndex].Name == "valor_parc")
            //{
            //    if(Convert.ToDouble(e.Value) <= 10)
            //    {
            //        e.CellStyle.ForeColor = Color.Red;
            //        e.CellStyle.BackColor = Color.Yellow;
            //    }
            //}
        }
    }
}



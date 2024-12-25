using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class frmManutContasReceber : BasePesquisa
    {
        private bool StatusConta;
        public frmManutContasReceber()
        {
            InitializeComponent();
        }
     
        public void ListarContasReceber()
        {
            ContasReceberBLL receitasbll = new ContasReceberBLL();
            dataGridContasReceber.DataSource = receitasbll.ListarContasReceber();           
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmVendas childForm = new FrmVendas();
            childForm.lblTitulo.Text = "Cadastro de Contas a Receber";
                childForm.StatusOperacao = "NOVO";
                childForm.ShowDialog();                  
        }

        private void frmManutReceitas_Load(object sender, EventArgs e)
        {
            ListarContasReceber();
        }
        private void CarregaDados()
        {            
            FrmDetalheVenda f3 = new FrmDetalheVenda();

            try
            {
                f3.lblCodCliente.Text = dataGridContasReceber.CurrentRow.Cells["id_cliente"].Value.ToString();
                f3.txtCodVenda.Text = dataGridContasReceber.CurrentRow.Cells["id_venda"].Value.ToString();
                f3.txtIdItensVenda.Text = dataGridContasReceber.CurrentRow.Cells["id_itensvenda"].Value.ToString();
                f3.txtIdParcela.Text = dataGridContasReceber.CurrentRow.Cells["id_parcela"].Value.ToString();
                f3.txtIdContReceber.Text = dataGridContasReceber.CurrentRow.Cells["id_contasreceber"].Value.ToString();

                f3.txtNomeCliente.Text = dataGridContasReceber.CurrentRow.Cells["nome_cliente"].Value.ToString();
                f3.lblCodProduto.Text = dataGridContasReceber.CurrentRow.Cells["id_produto"].Value.ToString();
                f3.txtNomeProduto.Text = dataGridContasReceber.CurrentRow.Cells["nome_produto"].Value.ToString();
                f3.txtNumParcela.Text = dataGridContasReceber.CurrentRow.Cells["num_parcela"].Value.ToString();
                f3.txtDataVenc.Text = dataGridContasReceber.CurrentRow.Cells["dt_vcto_parcela"].Value.ToString();
                f3.txtDataVenda.Text = dataGridContasReceber.CurrentRow.Cells["dt_venda"].Value.ToString();
                f3.txtQuantidadeProduto.Text = dataGridContasReceber.CurrentRow.Cells["qtd_produto"].Value.ToString();                
                f3.txtValorParc.Text = dataGridContasReceber.CurrentRow.Cells["valor_parcela"].Value.ToString();
                StatusConta = Convert.ToBoolean(dataGridContasReceber.CurrentRow.Cells["status_conta"].Value);

                f3.Id_ContasReceber = Convert.ToInt32(dataGridContasReceber.CurrentRow.Cells["id_itensvenda"].Value);
                f3.Id_Parcela = Convert.ToInt32(dataGridContasReceber.CurrentRow.Cells["id_parcela"].Value);                

                if (StatusConta == true)
                {
                    f3.txtStatusParcela.Text = "Paga";
                }
                else { f3.txtStatusParcela.Text = "Aberta"; }

                //f3.txtStatusParcela.Text = dataGridContasReceber.CurrentRow.Cells["status_conta"].Value.ToString();
                f3.txtCodVenda.Text = dataGridContasReceber.CurrentRow.Cells["id_venda"].Value.ToString();

                Cliente = dataGridContasReceber.CurrentRow.Cells["nome_cliente"].Value.ToString();

                ////f3.lblTituloCadReceitas.Text = "Alterar Valores Recebidos";
                f3.Text = "Alterar Conta :  "+" | " + Nome;

                f3.ShowDialog();
                ListarContasReceber();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
        }

        public void ExcluirReceitas()
        {
            Codigo = Convert.ToInt32(dataGridContasReceber.CurrentRow.Cells[0].Value);
            Fornecedor = dataGridContasReceber.CurrentRow.Cells[3].Value.ToString();

            if (MessageBox.Show("Excluir? Código:" + Codigo + " : " + Fornecedor + " ", "Excluir!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ReceitasMODEL receitasMODEL = new ReceitasMODEL();
                receitasMODEL.IdReceita = Convert.ToInt32(Codigo);

                ReceitasBLL receitasbll = new ReceitasBLL();
                receitasbll.excluireceitasDal(receitasMODEL);
                MessageBox.Show("REGISTRO EXCLUÍDO!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ((frmManutContasReceber)Application.OpenForms["frmManutReceitas"]).HabilitarTimer(true);
                ListarContasReceber();
            }

        }
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmDetalheVenda f3 = new FrmDetalheVenda();
            f3.StatusOperacao = "ALTERAR";
            CarregaDados();
        }      

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FrmDetalheVenda f3 = new FrmDetalheVenda();
            f3.StatusOperacao = "EXCLUIR";
            //f3.lblTitulo.Text = "Excluir a conta do cliente "+" "+ Cliente;
            f3.lblTitulo2.Text = "Excluir a conta do cliente " + " " + Cliente;
            CarregaDados();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListarContasReceber();
            timer1.Enabled = false;            
        }

        private void dataGridPesquisa2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaDados();
        }
    }
}
/*
 DataGridViewRow row = this.dataGridPesquisa2.RowTemplate;           
            row.Height = 17;
            row.MinimumHeight = 17;
*/
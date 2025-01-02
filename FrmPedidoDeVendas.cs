using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmPedidoDeVendas : Money.FrmBaseGeral
    {
        public FrmPedidoDeVendas()
        {
            InitializeComponent();
        }
        private void NovoCodigo()
        {//Traz o último código cadastrado + 1, para novo cadastro
            Id_Venda = RetornaCodigoContaMaisUm(QueryVendas);
            Id_Itensvenda = RetornaCodigoContaMaisUm(QueryItensVenda);
            Id_ContasReceber = RetornaCodigoContaMaisUm(QueryContasReceber);
            Id_Parcela = RetornaCodigoContaMaisUm(QueryParcela);
        }
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

            objeto_itensvenda.Id_itensvenda = Id_Itensvenda;
            objeto_itensvenda.Id_produto = IdProduto;
            objeto_itensvenda.Qtd_produto = QtdProduto;
            objeto_itensvenda.Valor_produto = ValorProduto;
            
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

            objeto_itensvenda.Id_itensvenda = Id_Itensvenda;
            objeto_itensvenda.Id_produto = IdProduto;
            objeto_itensvenda.Qtd_produto = QtdProduto;
            objeto_itensvenda.Valor_produto = ValorProduto;
            
            ItensVendaBLL itensvendabll = new ItensVendaBLL();
            itensvendabll.SalvarItensVenda(objeto_itensvenda);

            MessageBox.Show("Conta gravada com sucesso!!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            LimpaCampo();

            txtIdVenda.Text = RetornaCodigoContaMaisUm(QueryVendas).ToString();
            Id_Venda = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryVendas).ToString());

            dtDataVenda.Focus();
            txtTotal.Text = "0,00";
        }

        private void FrmPedidoDeVendas_Load(object sender, EventArgs e)
        {
            NovoCodigo();
            txtIdVenda.Text = Id_Venda.ToString();
        }

        private void btnLocalizarCliente_Click(object sender, EventArgs e)
        {
            FrmLocalizaCliente frmlocalizacliente = new FrmLocalizaCliente();
            frmlocalizacliente.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncluirProduto_Click(object sender, EventArgs e)
        {
            frmManutProduto frmManutProduto = new frmManutProduto();
            frmManutProduto.ShowDialog();
        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimirPedido_Click(object sender, EventArgs e)
        {

        }
    }
}

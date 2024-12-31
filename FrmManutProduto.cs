using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Money
{
    public partial class frmManutProduto : BasePesquisa
    {
        public frmManutProduto()
        {
            InitializeComponent();
        }
        public void ListaProduto()
        {
            ProdutoBLL produtobll = new ProdutoBLL();
            dataGridPesquisa2.DataSource = produtobll.Lista_Produto();           
        }
        public void ExcluirProduto()
        {
            IdProduto = Convert.ToInt32(dataGridPesquisa2.CurrentRow.Cells[0].Value);
            NomeProduto = dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString();          
            
            if(MessageBox.Show("Excluir? Código:"+ IdProduto +" : "+ NomeProduto +" ","Excluir!!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                ProdutosMODEL produtoMODEL = new ProdutosMODEL();
                produtoMODEL.Id_produto = Convert.ToInt32(Codigo);
                
                ProdutoBLL produtobll = new ProdutoBLL();
                produtobll.ExcluirProduto(produtoMODEL);
                MessageBox.Show("REGISTRO EXCLUÍDO!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ((FrmManutFornecedor)Application.OpenForms["frmManutProduto"]).HabilitarTimer(true);
                ListaProduto();
            }            
        }
        private void FrmPesquisaCadastroFornecedor_Load(object sender, EventArgs e)
        {           
        }
     
        private void CarregaDados()
        {
            FrmCadProduto f3 = new FrmCadProduto();
            try
            {
                f3.IdProduto = Convert.ToInt32(dataGridPesquisa2.CurrentRow.Cells["id_produto"].Value.ToString());
                f3.txtIdProduto.Text = dataGridPesquisa2.CurrentRow.Cells["id_produto"].Value.ToString();
                f3.txtProduto.Text = dataGridPesquisa2.CurrentRow.Cells["nome_produto"].Value.ToString();
                NomeProduto = dataGridPesquisa2.CurrentRow.Cells["nome_produto"].Value.ToString();
                f3.txtDescricaoProduto.Text = dataGridPesquisa2.CurrentRow.Cells["descricao_produto"].Value.ToString();
                f3.txtMarcaProduto.Text = dataGridPesquisa2.CurrentRow.Cells["marca_produto"].Value.ToString();
                f3.txtPrecoCustoProduto.Text = dataGridPesquisa2.CurrentRow.Cells["precocusto_produto"].Value.ToString();
                f3.txtLucroProduto.Text = dataGridPesquisa2.CurrentRow.Cells["lucro_produto"].Value.ToString();
                f3.txtPrecoVendaProduto.Text = dataGridPesquisa2.CurrentRow.Cells["precovenda_produto"].Value.ToString();

                f3.StatusOperacao = "ALTERAR";
                f3.lblTitulo.Text = "Alterar"+" "+NomeProduto;
                f3.Text = "Money - Alterar Registro" + " | " + dataGridPesquisa2.CurrentRow.Cells["nome_produto"].Value.ToString();    
                f3.ShowDialog();
                ListaProduto();               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
        }
        public override void carregaGrid2Localizar(System.Data.SqlClient.SqlCommand criterioSQL, DataGridView DatagridParametro)
        {
            base.carregaGrid2Localizar(criterioSQL, DatagridParametro);
        }
        public void Pesquisar22()
        {
            string pesquisa = txtPesquisa.Text + "%";

            SqlCommand sqlStringNome = new SqlCommand("SELECT * FROM produto  WHERE nome_produto LIKE @Pesquisa");

            sqlStringNome.Parameters.AddWithValue("@Pesquisa", pesquisa);
            carregaGrid2Localizar(sqlStringNome, dataGridPesquisa2);           
        }
        private void rbtDescricao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = ""; txtPesquisa.Focus();
        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = ""; txtPesquisa.Focus();
        }


        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Pesquisar22();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadProduto childForm = new FrmCadProduto();

            childForm.StatusOperacao = "NOVO";
            childForm.lblTitulo.Text = "Inclusão de Produtos - Cadastro";
            
            childForm.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CarregaDados();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirProduto();
        }
      
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ListaProduto();
            timer1.Enabled = false;
        }

        private void FrmPesquisaCadastroFornecedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //FrmCadConta cadtcontas = new FrmCadConta();
            //try
            //{
            //    if (dataGridPesquisa2.DataSource != null)
            //    {
            //        try
            //        {
            //            IdProduto = Convert.ToInt32(dataGridPesquisa2.CurrentRow.Cells[0].Value);
            //            NomeProduto = dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString();
            //        }
            //        catch
            //        {
            //        }
            //        cadtcontas.IdFornecedor = IdFornecedor;
            //        cadtcontas.txtFornecedor.Text = Fornecedor;
            //    }
            //}
            //finally { }
        }

        private void dataGridPesquisa2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaDados();
        }
        private void frmManutProduto_Load(object sender, EventArgs e)
        {
            ListaProduto();
        }
    }
}

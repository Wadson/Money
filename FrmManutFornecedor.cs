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
    public partial class FrmManutFornecedor : BasePesquisa
    {
        public FrmManutFornecedor()
        {
            InitializeComponent();
        }
        public void ListaFornecedor()
        {
            FornecedorBLL fornecedorbll = new FornecedorBLL();
            dataGridPesquisa2.DataSource = fornecedorbll.lista_Fornecedor_dal();
           
        }
        public void ExcluirFornecedor()
        {


            Codigo = Convert.ToInt32(dataGridPesquisa2.CurrentRow.Cells[0].Value);
            Fornecedor = dataGridPesquisa2.CurrentRow.Cells[2].Value.ToString();          

            if(MessageBox.Show("Excluir? Código:"+ Codigo +" : "+ Fornecedor +" ","Excluir!!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                FornecedorMODEL fornecedorMODEL = new FornecedorMODEL();
                fornecedorMODEL.ID_Fornecedor = Convert.ToInt32(Codigo);

                FornecedorBLL fornecedorbll = new FornecedorBLL();
                fornecedorbll.excluiFornecedorDal(fornecedorMODEL);
                MessageBox.Show("REGISTRO EXCLUÍDO!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ((FrmManutFornecedor)Application.OpenForms["FrmManutFornecedor"]).HabilitarTimer(true);
                ListaFornecedor();
            }
            
        }
        private void FrmPesquisaCadastroFornecedor_Load(object sender, EventArgs e)
        {
            ListaFornecedor();
        }

     
        private void CarregaDados()
        {
            FrmCadFornecedor f3 = new FrmCadFornecedor();
            try
            {
                f3.txtCodigo.Text = dataGridPesquisa2.CurrentRow.Cells[0].Value.ToString();
                f3.IdFornecedor = Convert.ToInt32(dataGridPesquisa2.CurrentRow.Cells[0].Value);

                f3.txtEndereco.Text = dataGridPesquisa2.CurrentRow.Cells[2].Value.ToString();
                f3.txtFornecedor.Text = dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString();
                Fornecedor = dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString();
                f3.StatusOperacao = "ALTERAR";
                f3.lblTitulo.Text = "ALTERAR"+" "+Fornecedor;
                    f3.Text = "Money - Alterar dados" + " | " + dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString();    
                    f3.ShowDialog();
                    ListaFornecedor();               
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

            SqlCommand sqlStringNome = new SqlCommand("SELECT * FROM fornecedor  WHERE nome_fornecedor LIKE @Pesquisa");

            sqlStringNome.Parameters.AddWithValue("@Pesquisa", pesquisa);
            carregaGrid2Localizar(sqlStringNome, dataGridPesquisa2);
           
        }

        private void rbtDescricao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Pesquisar22();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadFornecedor childForm = new FrmCadFornecedor();

                childForm.StatusOperacao = "NOVO";
            childForm.lblTitulo.Text = "NOVO CADASTRO";
                childForm.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CarregaDados();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirFornecedor();
        }
      
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ListaFornecedor();
            timer1.Enabled = false;
        }

        private void FrmPesquisaCadastroFornecedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmVendas cadtcontas = new FrmVendas();
            try
            {
                if (dataGridPesquisa2.DataSource != null)
                {
                    try
                    {
                        IdFornecedor = Convert.ToInt32(dataGridPesquisa2.CurrentRow.Cells[0].Value.ToString());
                        Fornecedor = dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString();
                    }
                    catch
                    {
                    }

                    cadtcontas.IdFornecedor = IdFornecedor;
                    cadtcontas.txtNomeCliente.Text = Fornecedor;
                }
            }
            finally { }
        }

        private void dataGridPesquisa2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaDados();
        }

    }
}

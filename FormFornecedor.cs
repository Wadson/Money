using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Money
{
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
        }
        public int linhaAtual { get; set; }
        public int Codigo { get; set; }
        public string Fornecedor { get; set; }




        public void ListaFornecedor()
        {
            FornecedorBLL fornecedorbll = new FornecedorBLL();
            dataGridPesquisa.DataSource = fornecedorbll.lista_Fornecedor_dal();            
        }
        public void ExcluirFornecedor()
        {
            linhaAtual = dataGridPesquisa.CurrentRow.Index;
            
            Codigo = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
            
            Fornecedor = dataGridPesquisa[2, linhaAtual].Value.ToString();

            if (MessageBox.Show("Excluir? Código:" + Codigo + " : " + Fornecedor + " ", "Excluir!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        private void FormProductos_Load(object sender, EventArgs e)
        {
            ListaFornecedor();
        }


        private void CarregaDados()
        {
            linhaAtual = dataGridPesquisa.CurrentRow.Index;

            FrmCadFornecedor f3 = new FrmCadFornecedor();
            try
            {
                if (linhaAtual >= 0)
                {
                    
                    f3.IdFornecedor = Convert.ToInt32(dataGridPesquisa.CurrentRow.Cells[0].Value);

                    f3.txtCodigo.Text =     dataGridPesquisa.CurrentRow.Cells[0].Value.ToString();
                    f3.txtFornecedor.Text = dataGridPesquisa.CurrentRow.Cells[1].Value.ToString();
                    f3.txtEndereco.Text = dataGridPesquisa.CurrentRow.Cells[2].Value.ToString();


                    f3.StatusOperacao = "ALTERAR";

                    f3.ShowDialog();
                    ListaFornecedor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCadFornecedor frm = new FrmCadFornecedor();
            frm.StatusOperacao = "NOVO";
            frm.ShowDialog();
        }

      
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //formventa frm = Owner as formventa;
            //frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //frm.txtcategoria.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //frm.txtdescrip.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //frm.txtprecio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //frm.txtstock.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //this.Close();
        }
        public void carregaGrid2Localizar(SqlCommand criterioSQL)
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
                    dataGridPesquisa.DataSource = tabela;
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
        
        public void Pesquisar22()
        {
            string pesquisa = txtPesquisa.Text + "%";

            SqlCommand sqlStringNome = new SqlCommand("SELECT * FROM fornecedor  WHERE fornecedor LIKE @Pesquisa");
            sqlStringNome.Parameters.AddWithValue("@Pesquisa", pesquisa);
            carregaGrid2Localizar(sqlStringNome);
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Pesquisar22();
        }
    }
}

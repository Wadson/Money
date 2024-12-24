using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Money
{
    public partial class FrmManutcategoria : BasePesquisa
    {
        public FrmManutcategoria()
        {
            InitializeComponent();
        }
      
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastro_categoria childForm = new FrmCadastro_categoria();          
            childForm.StatusOperacao = "NOVO";
            childForm.lblTitulo.Text = "NOVO CADASTRO";
            childForm.ShowDialog();
        }       
        public override void carregaGrid2Localizar(SqlCommand criterioSQL, DataGridView DatagridParametro)
        {
            base.carregaGrid2Localizar(criterioSQL, DatagridParametro);
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string criterio = txtPesquisa.Text + "%";
            SqlCommand sqlStringDesc = new SqlCommand("SELECT idcategoria, categoria FROM categoria WHERE categoria  LIKE @Criterio");
            sqlStringDesc.Parameters.AddWithValue("@Criterio", criterio);
            carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa2);    
        }
        private void CarregaDados()
        {
            FrmCadastro_categoria f3 = new FrmCadastro_categoria();
           
            try
            {
                f3.txtCodigo.Text = dataGridPesquisa2.CurrentRow.Cells[0].Value.ToString();
                f3.txtNome.Text = dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString();
                Nome = dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString();
                    f3.StatusOperacao = "ALTERAR";
                f3.lblTitulo.Text = "ALTERAR" + " " + Nome;
                    f3.Text = "Money - Alterar Registro" + " | " + dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString(); 

                    f3.ShowDialog();                   
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
        }
       
        public void Listacategoria()
        {
            categoriaBLL cenrtrobll = new categoriaBLL();
            dataGridPesquisa2.DataSource = cenrtrobll.lista_Centro_Custo();    
            
        }
        public void Excluircategoria()
        {
            Codigo = Convert.ToInt32(dataGridPesquisa2.CurrentRow.Cells[0].Value);
            Nome = dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString();

            if (MessageBox.Show("Excluir? Código:  " + Codigo + " : " + Nome + " ", "Excluir!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                categoriaModel centromodel = new categoriaModel();
                centromodel.Idcategoria = Convert.ToInt32(dataGridPesquisa2.CurrentRow.Cells[0].Value);

                categoriaBLL centrobll = new categoriaBLL();
                centrobll.Excluir(centromodel);
                MessageBox.Show("REGISTRO EXCLUÍDO!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ((FrmManutcategoria)Application.OpenForms["FrmManutcategoria"]).HabilitarTimer(true);
                Listacategoria();
            }
            
        }      
        private void btnAlterar_Click(object sender, EventArgs e)
        {           
            CarregaDados();
        }

        private void FrmPesquisacategoria_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridPesquisa2.RowTemplate;            
            row.Height = 17;
            row.MinimumHeight = 17;           
            Listacategoria();            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluircategoria();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Listacategoria();
            timer1.Enabled = false;
        }

        private void FrmPesquisacategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmVendas cadcontas = new FrmVendas();

            if (dataGridPesquisa2.DataSource != null)
            {
                try
                {
                    Idcategoria = Convert.ToInt32(dataGridPesquisa2.CurrentRow.Cells[0].Value.ToString());
                    categoria = dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString();
                }
                catch
                {
                }
               
                    //cadcontas.txtIdCategoria.Text = Idcategoria.ToString();
                    //cadcontas.txtEnderecoCliente.Text = categoria;                    
               
            }
        }

        private void dataGridPesquisa2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaDados();
        }
              
    }
}

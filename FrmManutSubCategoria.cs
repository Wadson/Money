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
    public partial class FrmManutSubCategoria : Money.FrmBaseManutencao
    {
        public FrmManutSubCategoria()
        {
            InitializeComponent();
        }
    
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadSubCategoria childForm = new FrmCadSubCategoria();
            childForm.StatusOperacao = "NOVO";
            childForm.lblTitulo.Text = "CADASTRO DE SUBCATEGORIA";
            childForm.ShowDialog();
            ((FrmManutSubCategoria)Application.OpenForms["FrmManutSubCategoria"]).HabilitarTimer(true);
        }
        public override void carregaGrid2Localizar(System.Data.SqlClient.SqlCommand criterioSQL, DataGridView DatagridParametro)
        {
            base.carregaGrid2Localizar(criterioSQL, DatagridParametro);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string criterio = txtPesquisa.Text + "%";
            SqlCommand sqlStringDesc = new SqlCommand("SELECT * FROM subcategoria WHERE subcategoria  LIKE @Criterio");
            sqlStringDesc.Parameters.AddWithValue("@Criterio", criterio);
            carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa2);
        }
        private void CarregaDados()
        {
            FrmCadSubCategoria f3 = new FrmCadSubCategoria();
         
            try
            {
               
                    f3.txtCodigo.Text = dataGridPesquisa2.CurrentRow.Cells[0].Value.ToString();
                    f3.txtNome.Text = dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString();
                    Nome = dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString();
                //f3.cmbCategoria.Text = dataGridPesquisa2.CurrentRow.Cells[2].Value.ToString();
                    f3.txtidCategoria.Text = dataGridPesquisa2.CurrentRow.Cells[2].ToString();
                    f3.StatusOperacao = "ALTERAR";
                f3.lblTitulo.Text = "ALTERAR"+" "+ Nome;
                    f3.Text = "Alterar Sub Categoria : > " + Nome;

                    f3.ShowDialog();
                ((FrmManutSubCategoria)Application.OpenForms["FrmManutSubCategoria"]).HabilitarTimer(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
        }
        public void ListaSubcategoria()
        {
            SubsubCategoriaBLL subcategoriabll = new SubsubCategoriaBLL();
            dataGridPesquisa2.DataSource = subcategoriabll.listaSubsubCategoria();           
        }
        public void ExcluirSubcategoria()
        {

            Codigo = Convert.ToInt32(dataGridPesquisa2.CurrentRow.Cells[0].Value);
            Codigo2 = Convert.ToInt32(dataGridPesquisa2.CurrentRow.Cells[1].Value);
            Nome = dataGridPesquisa2.CurrentRow.Cells[2].Value.ToString();

            if (MessageBox.Show("Excluir? Código:  " + Codigo + " : " + Nome + " ", "Excluir!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SubCategoriaMODEL subcatmodel = new SubCategoriaMODEL();
                subcatmodel.Idcategoria = Convert.ToInt32(dataGridPesquisa2.CurrentRow.Cells[0].Value);

                SubsubCategoriaBLL subcatbll = new SubsubCategoriaBLL();
                subcatbll.Excluir(subcatmodel);
                MessageBox.Show("REGISTRO EXCLUÍDO!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ((FrmManutSubCategoria)Application.OpenForms["FrmManutSubCategoria"]).HabilitarTimer(true);
                ListaSubcategoria();
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void FrmManutSubCategoria_Load(object sender, EventArgs e)
        {
            ListaSubcategoria(); 
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirSubcategoria();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListaSubcategoria();
            timer1.Enabled = false;
        }

        private void FrmManutSubCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmCadSubCategoria cadsubcat = new FrmCadSubCategoria();

            if (dataGridPesquisa2.RowCount != 00)
            {
                try
                {
                    IdSubCategoria = Convert.ToInt32(dataGridPesquisa2.CurrentRow.Cells["id_subcategoria"].Value.ToString());
                    IdCategoria = Convert.ToInt32(dataGridPesquisa2.CurrentRow.Cells["id_categoria"].Value.ToString());
                    subcategoria = dataGridPesquisa2.CurrentRow.Cells["nome_subcategoria"].Value.ToString();
                    //id_categoria
                    cadsubcat.Idcategoria = IdCategoria;
                    cadsubcat.txtNome.Text = subcategoria;
                    cadsubcat.Idsubcategoria = IdSubCategoria;
                }
                catch(Exception EX)
                {
                    MessageBox.Show("Erro: " + EX.Message);
                }   
            }
        }

        private void dataGridPesquisa2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaDados();
        }      
        
    }
}

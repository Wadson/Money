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
    public partial class FrmLocalizaSubCategoria : FrmBasePesquisa
    {
        public FrmLocalizaSubCategoria()
        {
            InitializeComponent();
        }
        private void LocalizaSubcategoria()
        {
            try
            {
                var conn = Conexao.Conex();
                if (rbtDescricao.Checked == true)
                {
                    SqlCommand sqlStringDesc = new SqlCommand("SELECT idsubcategoria, subcategoria FROM subcategoria WHERE subcategoria  LIKE @criterio", conn);
                    sqlStringDesc.Parameters.AddWithValue("@criterio", txtPesquisa.Text + "%");

                    carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa);
                }
                if (rbtCodigo.Checked == true)
                {
                    SqlCommand sqlStringCod = new SqlCommand("SELECT idsubcategoria, subcategoria FROM subcategoria  WHERE idsubcategoria LIKE @Criterio", conn);
                    sqlStringCod.Parameters.AddWithValue("@Criterio", txtPesquisa.Text + "%");
                    carregaGrid2Localizar(sqlStringCod, dataGridPesquisa);
                }
            }
            catch
            {
            }
        }
        public void ListaSubcategoria()
        {
            var conn = Conexao.Conex();
            SqlCommand sqlStringDesc = new SqlCommand("SELECT idsubcategoria, subcategoria FROM subcategoria", conn);
            carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa);
        }
        public void ListaSubcategoriaSelect()
        {
            var conn = Conexao.Conex();
            SqlCommand sqlStringDesc = new SqlCommand("SELECT idsubcategoria, subcategoria FROM subcategoria WHERE idcategoria = @Criterio ", conn);
            sqlStringDesc.Parameters.AddWithValue("@Criterio", Capturavalor);
            carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa);
        }
        private void FrmLocalizaSubCategoria_Load(object sender, EventArgs e)
        {
            if (TipoPesquisa == "CADASTRO")
            {
                txtPesquisa.Visible = false;
                FrmVendas cad = new FrmVendas();
                //txtPesquisa.Text = Capturavalor;               
                categoria = Capturavalor;                
                //txtPesquisa.SelectionStart = txtPesquisa.TextLength;
                ListaSubcategoriaSelect();
            }
        }

      
        private void FrmLocalizaSubCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmVendas cadcontas = new FrmVendas();

            if (dataGridPesquisa.DataSource != null)
            {
                linhaAtual = dataGridPesquisa.CurrentRow.Index;

                try
                {                   
                    //((FrmCadConta)Application.OpenForms["FrmCadConta"]).txtProduto.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                    //((FrmCadConta)Application.OpenForms["FrmCadConta"]).txtIdSubCat.Text = dataGridPesquisa[0, linhaAtual].Value.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nenhum registro selecionado !\n\n" + ex.Message, "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            LocalizaSubcategoria();
        }
    }
}

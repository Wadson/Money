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
    public partial class FrmLocalizaCentro : FrmBasePesquisa
    {
        public int Qtd_caractere { get; set; }
        public FrmLocalizaCentro()
        {
            InitializeComponent();
        }       
        private void Frm_Pesquisa_Centro_Load(object sender, EventArgs e)
        {
            FrmVendas cad = new FrmVendas();
            
            txtPesquisa.Text = Capturavalor;
            txtPesquisa.SelectionStart = txtPesquisa.TextLength;
            
            Localizacategoria();
        }
        private void Localizacategoria()
        {
            try
            {
                var conn = Conexao.Conex();
                if (rbtDescricao.Checked == true)
                {
                    SqlCommand sqlStringDesc = new SqlCommand("SELECT idcategoria, categoria FROM categoria WHERE categoria  LIKE @criterio", conn);
                    sqlStringDesc.Parameters.AddWithValue("@criterio", txtPesquisa.Text + "%");

                    carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa);
                }
                if (rbtCodigo.Checked == true)
                {
                    SqlCommand sqlStringCod = new SqlCommand("SELECT idcategoria, categoria FROM categoria  WHERE idcategoria LIKE @Criterio", conn);
                    sqlStringCod.Parameters.AddWithValue("@Criterio", txtPesquisa.Text + "%");
                    carregaGrid2Localizar(sqlStringCod, dataGridPesquisa);
                }               
            }
            catch
            {
            }
        }     
        public void Listacategoria()
        {
            var conn = Conexao.Conex();
            SqlCommand sqlStringDesc = new SqlCommand("SELECT idcategoria, categoria FROM categoria", conn);
            carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa);           
        }
        private void Frm_Pesquisa_Centro_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmVendas cadcontas = new FrmVendas();
         
            if (dataGridPesquisa.DataSource != null)
            {
                linhaAtual = dataGridPesquisa.CurrentRow.Index;

                try
                {                    
                    ((FrmVendas)Application.OpenForms["FrmCadConta"]).txtIdVenda.Text = dataGridPesquisa[0, linhaAtual].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nenhum registro selecionado !\n\n" + ex.Message, "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }             
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Localizacategoria();
        }

        private void dataGridPesquisa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}

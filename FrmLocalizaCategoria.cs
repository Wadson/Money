using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Money
{
    public partial class FrmLocalizaCategoria : Money.FrmBase_Pesquisa
    {
        public int Qtd_caractere { get; set; }
        public FrmLocalizaCategoria()
        {
            InitializeComponent();
        }       
        private void Frm_Pesquisa_Centro_Load(object sender, EventArgs e)
        {
            FrmCadConta cad = new FrmCadConta();
           
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
                    SqlCeCommand sqlStringDesc = new SqlCeCommand("SELECT idcategoria, categoria FROM categoria WHERE categoria  LIKE @criterio", conn);
                    sqlStringDesc.Parameters.AddWithValue("@criterio", txtPesquisa.Text + "%");

                    carregaGrid2Localizar(sqlStringDesc);
                }
                if (rbtCodigo.Checked == true)
                {
                    SqlCeCommand sqlStringCod = new SqlCeCommand("SELECT idcategoria, categoria FROM categoria  WHERE idcategoria LIKE @Criterio", conn);
                    sqlStringCod.Parameters.AddWithValue("@Criterio", txtPesquisa.Text + "%");
                    carregaGrid2Localizar(sqlStringCod);
                }               
            }
            catch
            {
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Localizacategoria();
        }
        public void Listacategoria()
        {
            var conn = Conexao.Conex();
            SqlCeCommand sqlStringDesc = new SqlCeCommand("SELECT idcategoria, categoria FROM categoria", conn);
            carregaGrid2Localizar(sqlStringDesc);           
        }
        private void Frm_Pesquisa_Centro_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmCadConta cadcontas = new FrmCadConta();
         
            if (dataGridPesquisa.DataSource != null)
            {
                linhaAtual = dataGridPesquisa.CurrentRow.Index;

                try
                {
                    ((FrmCadConta)Application.OpenForms["FrmCadConta"]).txtIdCategoria.Text = dataGridPesquisa[0, linhaAtual].Value.ToString();
                    ((FrmCadConta)Application.OpenForms["FrmCadConta"]).txtCategoria.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nenhum registro selecionado !\n\n" + ex.Message, "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }             
            }
        }

    }
}

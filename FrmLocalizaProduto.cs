using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmLocalizaProduto : Money.FrmBasePesquisa
    {
        public FrmLocalizaProduto()
        {
            InitializeComponent();
        }
        private void LocalizaProduto()
        {
            var conn = Conexao.Conex();
            if (rbtDescricao.Checked == true)
            {
                SqlCommand sqlStringDesc = new SqlCommand("SELECT id_produto, nome_produto, precovenda_produto FROM produto WHERE nome_produto  LIKE @criterio", conn);
                sqlStringDesc.Parameters.AddWithValue("@criterio", txtPesquisa.Text + "%");

                carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa);
            }
            if (rbtCodigo.Checked == true)
            {
                SqlCommand sqlStringCod = new SqlCommand("SELECT id_produto, nome_pruduto, precovenda_produto FROM produto WHERE id_produto LIKE @Criterio", conn);
                sqlStringCod.Parameters.AddWithValue("@Criterio", txtPesquisa.Text + "%");
                carregaGrid2Localizar(sqlStringCod, dataGridPesquisa);
            }
        }
        public void ListaProduto()
        {
            var conn = Conexao.Conex();
            SqlCommand sqlStringDesc = new SqlCommand("SELECT id_produto, nome_pruduto, recovenda_produto FROM produto", conn);

            carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa);
        }
        private void FrmLocalizaProduto_Load(object sender, EventArgs e)
        {
            txtPesquisa.Text = Capturavalor;
            txtPesquisa.SelectionStart = txtPesquisa.TextLength; //Coloca o cursos no final do texto                               

            this.txtPesquisa.Focus();
            LocalizaProduto();
        }

        private void FrmLocalizaProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmVendas cadcontas = new FrmVendas();

            if (dataGridPesquisa.DataSource != null)
            {
                linhaAtual = dataGridPesquisa.CurrentRow.Index;
                
                
                ((FrmVendas)Application.OpenForms["FrmVendas"]).IdProduto = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
                ((FrmVendas)Application.OpenForms["FrmVendas"]).txtProduto.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                ((FrmVendas)Application.OpenForms["FrmVendas"]).txtValorProduto.Text = dataGridPesquisa[2, linhaAtual].Value.ToString();
                ((FrmVendas)Application.OpenForms["FrmVendas"]).txtQuantidade.Focus();
            }
        }
       
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            LocalizaProduto();
        }
    }
}

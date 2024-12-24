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
    public partial class FrmLocalizarFormaPgto : FrmBase_Pesquisa
    {
        public FrmLocalizarFormaPgto()
        {
            InitializeComponent();
        }


        public string TipoCadastro { get; set; }


        private void LocalizaFormaPgto()
        {
            var conn = Conexao.Conex();
            if (rbtDescricao.Checked == true)
            {
                SqlCommand sqlStringDesc = new SqlCommand("SELECT idformapgto, formapgto FROM formapgto WHERE formapgto  LIKE @criterio", conn);
                sqlStringDesc.Parameters.AddWithValue("@criterio", txtPesquisa.Text + "%");

                carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa);
            }
            if (rbtCodigo.Checked == true)
            {
                SqlCommand sqlStringCod = new SqlCommand("SELECT idformapgto, formapgto FROM formapgto WHERE idformapgto LIKE @Criterio", conn);
                sqlStringCod.Parameters.AddWithValue("@Criterio", txtPesquisa.Text + "%");
                carregaGrid2Localizar(sqlStringCod, dataGridPesquisa);
            }
        }

        public void ListaFormaPgto()
        {
            var conn = Conexao.Conex();
            SqlCommand sqlStringDesc = new SqlCommand("SELECT idformapgto, formapgto FROM formapgto", conn);
            carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            LocalizaFormaPgto();
        }

        private void FrmLocalizarFormaPgto_FormClosing(object sender, FormClosingEventArgs e)
        {

            FrmVendas cadcontas = new FrmVendas();
           

            if (TipoCadastro == "DEBITO")
            {
                if (dataGridPesquisa.DataSource != null)
                {
                    linhaAtual = dataGridPesquisa.CurrentRow.Index;

                    //((FrmCadConta)Application.OpenForms["FrmCadConta"]).IdFormaPgto = dataGridPesquisa[1, linhaAtual].Value.ToString();
                    //((FrmCadConta)Application.OpenForms["FrmCadConta"])..Text = dataGridPesquisa[0, linhaAtual].Value.ToString();
                }
            }
            if (TipoCadastro == "CREDITO")
            {

                if (dataGridPesquisa.DataSource != null)
                {
                    linhaAtual = dataGridPesquisa.CurrentRow.Index;

                    try
                    {
                        ((FrmVendas)Application.OpenForms["FrmCadReceitas"]).txtIdProduto.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                        ((FrmVendas)Application.OpenForms["FrmCadReceitas"]).IdFornecedor = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Atenção", "Erro"+ Ex, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            if (TipoCadastro == "PESQUISAR")
            {

                if (dataGridPesquisa.DataSource != null)
                {
                    linhaAtual = dataGridPesquisa.CurrentRow.Index;

                    try
                    {
                        //((FrmCadConta)Application.OpenForms["FrmCadConta"]).txtFormapgto.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                        //((FrmCadConta)Application.OpenForms["FrmCadConta"]).txtIdFormapgto.Text = dataGridPesquisa[0, linhaAtual].Value.ToString();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Atenção", "Erro"+Ex, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void FrmLocalizarFormaPgto_Load(object sender, EventArgs e)
        {
            txtPesquisa.SelectionStart = txtPesquisa.TextLength; //Coloca o cursos no final do texto                               

            this.txtPesquisa.Focus();
            ListaFormaPgto(); 
        }
    }
}

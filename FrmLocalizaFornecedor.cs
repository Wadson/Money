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
    public partial class FrmLocalizaFornecedor : FrmBase_Pesquisa
    {
        public int Qtd_caractere { get; set; }
        public string Contato { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public string FONE { get; set; }
        public string FONE1 { get; set; }
        public string TipoCadastro { get; set; }
        public FrmLocalizaFornecedor()
        {
            InitializeComponent();
            
        }      

        private void LocalizaFornecedor()
        {
            var conn = Conexao.Conex();
            if (rbtDescricao.Checked == true)
            {
                SqlCommand sqlStringDesc = new SqlCommand("SELECT idfornecedor, fornecedor FROM fornecedor WHERE fornecedor  LIKE @criterio", conn);
                sqlStringDesc.Parameters.AddWithValue("@criterio", txtPesquisa.Text + "%");

                carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa);
            }
            if (rbtCodigo.Checked == true)
            {
                SqlCommand sqlStringCod = new SqlCommand("SELECT idfornecedor, fornecedor FROM fornecedor WHERE idfornecedor LIKE @Criterio", conn);
                sqlStringCod.Parameters.AddWithValue("@Criterio", txtPesquisa.Text + "%");
                carregaGrid2Localizar(sqlStringCod, dataGridPesquisa);
            }            
        }
     
        private void Frm_Pesquisa_Fornecedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmVendas cadcontas = new FrmVendas();
           
            if (TipoCadastro == "DEBITO")
            {
                if (dataGridPesquisa.DataSource != null)
                {
                    linhaAtual = dataGridPesquisa.CurrentRow.Index;

                    ((FrmVendas)Application.OpenForms["FrmCadConta"]).txtNomeCliente.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                    ((FrmVendas)Application.OpenForms["FrmCadConta"]).txtIdVenda.Text = dataGridPesquisa[0, linhaAtual].Value.ToString();                   
                }
            }
            if (TipoCadastro == "CREDITO")
            {

                if (dataGridPesquisa.DataSource != null)
                {
                    linhaAtual = dataGridPesquisa.CurrentRow.Index;

                    try
                    {                      
                        ((FrmVendas)Application.OpenForms["FrmCadReceitas"]).IdFornecedor = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
                        //((FrmVendas)Application.OpenForms["FrmCadReceitas"]).IdFornecedor = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Atenção", "Erro"+Ex, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        //((FrmManutContasPagar)Application.OpenForms["FrmManutContasPagar"]).txtPesquisa.Text = Fornecedor;

                        //((FrmCadConta)Application.OpenForms["FrmCadConta)"]).txtIdFornecdor.Text = dataGridPesquisa[0, linhaAtual].ToString();
                        //((FrmCadConta)Application.OpenForms["FrmCadConta)"]).txtNomeCliente.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Atenção", "Erro"+Ex, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
      
        public void ListaFornecedor()
        {
            var conn = Conexao.Conex();
            SqlCommand sqlStringDesc = new SqlCommand("SELECT idfornecedor, fornecedor FROM fornecedor", conn);

            carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa);           
        }
        private void Frm_Pesquisa_Fornecedor_Load(object sender, EventArgs e)
        {
            txtPesquisa.Text = Capturavalor;
            txtPesquisa.SelectionStart = txtPesquisa.TextLength; //Coloca o cursos no final do texto                               
           
            this.txtPesquisa.Focus();
            LocalizaFornecedor();           
        }
       
        public void HabilitarTimer(bool habilitar)
        {
            timeAtualizaMedoto.Enabled = habilitar;
        }
        private void timeAtualizaMedoto_Tick(object sender, EventArgs e)
        {
            ListaFornecedor();
            timeAtualizaMedoto.Enabled = false; 
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            LocalizaFornecedor();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
        }
    }
}

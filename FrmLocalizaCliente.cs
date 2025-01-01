using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmLocalizaCliente : FrmBase_Pesquisa
    {
        public FrmLocalizaCliente()
        {
            InitializeComponent();
        }

        public int Qtd_caractere { get; set; }
        public string Contato { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public string FONE { get; set; }
        public string FONE1 { get; set; }
        public string TipoCadastro { get; set; }


        private void LocalizaCliente()
        {
            var conn = Conexao.Conex();
            if (rbtDescricao.Checked == true)
            {
                SqlCommand sqlStringDesc = new SqlCommand("SELECT id_cliente, nome_cliente FROM cliente WHERE nome_cliente  LIKE @criterio", conn);
                sqlStringDesc.Parameters.AddWithValue("@criterio", txtPesquisa.Text + "%");

                carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa);
            }
            if (rbtCodigo.Checked == true)
            {
                SqlCommand sqlStringCod = new SqlCommand("SELECT id_cliente, nome_cliente FROM cliente WHERE id_cliente LIKE @Criterio", conn);
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
                    ((FrmVendas)Application.OpenForms["FrmCadConta"]).IDCliente = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
                }
            }
            if (TipoCadastro == "CREDITO")
            {
                if (dataGridPesquisa.DataSource != null)
                {
                    linhaAtual = dataGridPesquisa.CurrentRow.Index;

                    try
                    {
                        //((FrmCadReceitas)Application.OpenForms["FrmCadReceitas"]).txtFornecedor.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                        //((FrmCadReceitas)Application.OpenForms["FrmCadReceitas"]).lblIDFornecedor.Text = dataGridPesquisa[0, linhaAtual].Value.ToString();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Atenção", "Erro" + Ex, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                        ((FrmVendas)Application.OpenForms["FrmCadConta)"]).IDCliente = Convert.ToInt32(dataGridPesquisa[0, linhaAtual]);
                        ((FrmVendas)Application.OpenForms["FrmCadConta)"]).txtNomeCliente.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Atenção", "Erro" + Ex, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        public void ListaCliente()
        {
            var conn = Conexao.Conex();
            SqlCommand sqlStringDesc = new SqlCommand("SELECT id_cliente, nome_cliente FROM cliente", conn);

            carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa);
        }
        private void Frm_Pesquisa_Fornecedor_Load(object sender, EventArgs e)
        {
            txtPesquisa.Text = Capturavalor;
            txtPesquisa.SelectionStart = txtPesquisa.TextLength; //Coloca o cursos no final do texto                               

            this.txtPesquisa.Focus();
            LocalizaCliente();
        }

        public void HabilitarTimer(bool habilitar)
        {
            timeAtualizaMedoto.Enabled = habilitar;
        }
        private void timeAtualizaMedoto_Tick(object sender, EventArgs e)
        {
        }      

        private void FrmLocalizaCliente_Load(object sender, EventArgs e)
        {
            txtPesquisa.SelectionStart = txtPesquisa.TextLength; //Coloca o cursos no final do texto                               

            this.txtPesquisa.Focus();
            ListaCliente();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            LocalizaCliente();
        }

        private void FrmLocalizaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmVendas FrmVend = new FrmVendas();

            try
            {
                if (dataGridPesquisa.DataSource != null)
                {
                    linhaAtual = dataGridPesquisa.CurrentRow.Index;
                    //((FrmVendas)Application.OpenForms["FrmVendas"]).txtIdCliente.Text = dataGridPesquisa[0, linhaAtual].Value.ToString();
                    ((FrmVendas)Application.OpenForms["FrmVendas"]).IDCliente = int.Parse(dataGridPesquisa[0, linhaAtual].Value.ToString());
                    ((FrmVendas)Application.OpenForms["FrmVendas"]).txtNomeCliente.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                    ((FrmVendas)Application.OpenForms["FrmVendas"]).txtProduto.Focus();

                }
            }

            catch (Exception Ex)
            {
                MessageBox.Show("Atenção", "Erro" + Ex, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

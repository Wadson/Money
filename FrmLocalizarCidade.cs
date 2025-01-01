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
    public partial class FrmLocalizarCidade : Money.FrmBasePesquisa
    {
        public FrmLocalizarCidade()
        {
            InitializeComponent();
        }
        public void ListaCidade()
        {
            var conn = Conexao.Conex();
            SqlCommand sqlStringDesc = new SqlCommand("SELECT cidade.id, cidade.nome, estado.nome AS Expr1, cidade.uf AS Expr2 FROM cidade INNER JOIN estado ON cidade.uf = estado.id", conn);

            carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa2);
        }
        private void FrmLocalizarCidade_Load(object sender, EventArgs e)
        {
            ListaCidade();
        }

        private void FrmLocalizarCidade_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmCadClientes FrmCadCli = new FrmCadClientes();

            try
            {
                if (dataGridPesquisa2.DataSource != null)
                {
                    linhaAtual = dataGridPesquisa2.CurrentRow.Index;
                    //((FrmVendas)Application.OpenForms["FrmVendas"]).txtIdCliente.Text = dataGridPesquisa[0, linhaAtual].Value.ToString();
                    ((FrmCadClientes)Application.OpenForms["FrmCadClientes"]).IDCidade = int.Parse(dataGridPesquisa2[0, linhaAtual].Value.ToString());
                    ((FrmCadClientes)Application.OpenForms["FrmCadClientes"]).txtCidadeCliente.Text = dataGridPesquisa2[1, linhaAtual].Value.ToString();
                    ((FrmCadClientes)Application.OpenForms["FrmCadClientes"]).txtIdCidade.Text = dataGridPesquisa2[0, linhaAtual].Value.ToString();
                    ((FrmCadClientes)Application.OpenForms["FrmCadClientes"]).txtEstadoCliente.Text = dataGridPesquisa2[2, linhaAtual].Value.ToString();

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Atenção", "Erro" + Ex, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LocalizaCliente()
        {
            var conn = Conexao.Conex();
            if (rbtDescricao.Checked == true)
            {
                SqlCommand sqlStringDesc = new SqlCommand("SELECT cidade.id, cidade.nome, estado.nome AS Expr1, cidade.uf AS Expr2 FROM cidade INNER JOIN estado ON cidade.uf = estado.id WHERE (cidade.nome LIKE @criterio)", conn);
                sqlStringDesc.Parameters.AddWithValue("@criterio", txtPesquisa.Text + "%");

                carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa2);
            }
            if (rbtCodigo.Checked == true)
            {
                SqlCommand sqlStringCod = new SqlCommand("SELECT * FROM cliente WHERE id LIKE @Criterio", conn);
                sqlStringCod.Parameters.AddWithValue("@Criterio", txtPesquisa.Text + "%");
                carregaGrid2Localizar(sqlStringCod, dataGridPesquisa2);
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            LocalizaCliente();
        }
    }
}

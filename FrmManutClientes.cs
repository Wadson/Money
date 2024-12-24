using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmManutClientes : Form
    {
        public FrmManutClientes()
        {
            InitializeComponent();
        }

        public int linhaAtual { get; set; }
        public int Codigo { get; set; }
        public string Cliente { get; set; }


        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        public void ListaClientes()
        {
            ClienteBLL cliente_bll = new ClienteBLL();
            dataGridPesquisa.DataSource = cliente_bll.Lista_Cliente();
        }
        public void ExcluirClientes()
        {
            linhaAtual = dataGridPesquisa.CurrentRow.Index;

            Codigo = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
            Cliente = dataGridPesquisa[1, linhaAtual].Value.ToString();

            if (MessageBox.Show("Excluir Cliente: " + Cliente + " ?", "Exclusão de Registro!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClienteMODEL cliente_MODEL = new ClienteMODEL();
                cliente_MODEL.Id_cliente = Convert.ToInt32(Codigo);

                ClienteBLL cliente_bll = new ClienteBLL();
                cliente_bll.Excluir(cliente_MODEL);
                MessageBox.Show("REGISTRO EXCLUÍDO!!" + Cliente + "", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ((FrmManutClientes)Application.OpenForms["FrmManutClientes"]).HabilitarTimer(true);
                ListaClientes();
            }

        }

        private void CarregaDados()
        {
            linhaAtual = dataGridPesquisa.CurrentRow.Index; 

            FrmCadClientes f3 = new  FrmCadClientes();
            
            try
            {
                if (linhaAtual >= 0)
                {
                    f3.IDCliente = Convert.ToInt32(dataGridPesquisa.CurrentRow.Cells[0].Value);
                    f3.txtCodigoCli.Text = dataGridPesquisa.CurrentRow.Cells[0].Value.ToString();
                    f3.txtNomeCliente.Text = dataGridPesquisa.CurrentRow.Cells[1].Value.ToString();
                    f3.txtDTCadastroCli.Text = dataGridPesquisa.CurrentRow.Cells[2].Value.ToString();
                    f3.txtTelefoneCli.Text = dataGridPesquisa.CurrentRow.Cells[3].Value.ToString();
                    string Cliente = dataGridPesquisa.CurrentRow.Cells[1].Value.ToString();
                    f3.txtEnderecoCliente.Text = dataGridPesquisa.CurrentRow.Cells[4].Value.ToString();
                    f3.txtBairroCliente.Text = dataGridPesquisa.CurrentRow.Cells[5].Value.ToString();
                    f3.txtCidadeCliente.Text = dataGridPesquisa.CurrentRow.Cells[6].Value.ToString();
                    f3.txtEstadoCliente.Text = dataGridPesquisa.CurrentRow.Cells[7].Value.ToString();

                    f3.StatusOperacao = "ALTERAR";
                    f3.lblTitulo.Text = "ALTERAR" + " " + Cliente;
                    f3.Text = "Money - Alterar dados" + " | " + dataGridPesquisa.CurrentRow.Cells[2].Value.ToString();

                    f3.ShowDialog();
                    ListaClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ListaClientes();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCadClientes cadcli = new FrmCadClientes();
            cadcli.StatusOperacao = "NOVO";
            cadcli.lblTitulo.Text = "NOVO CADASTRO";
            cadcli.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListaClientes();
            timer1.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirClientes();
        }       
        public void LocalizarCliente()
        {
            string pesquisa = txtPesquisa.Text + "%";

            SqlCommand sqlStringNome = new SqlCommand("SELECT * FROM cliente  WHERE nome_cliente LIKE @Pesquisa");

            sqlStringNome.Parameters.AddWithValue("@Pesquisa", pesquisa);
            //carregaGrid2Localizar(sqlStringNome, dataGridPesquisa);

        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            LocalizarCliente();
        }
    }
}

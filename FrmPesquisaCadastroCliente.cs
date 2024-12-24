using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Money
{
    public partial class FrmPesquisaCadastroCliente : Form
    {
        public int linhaAtual { get; set; }public string Nome { get; set; }

        public FrmPesquisaCadastroCliente()
        {
            InitializeComponent();
        }
        public void ListaCliente()
        {
            ClienteBLL clientebll = new ClienteBLL();
            dataGridPesquisa.DataSource = clientebll.Lista_Cliente();
        }
        private void FrmPesquisaCadastroCliente_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridPesquisa.RowTemplate;
            //row.DefaultCellStyle.BackColor = Color.Bisque;
            row.Height = 17;
            row.MinimumHeight = 17;
            ListaCliente();            
        }
        public void PesquisarLocal(SqlCeCommand criterioSQL)
        {
            var conn = Conexao.Conex();
            criterioSQL.Connection = conn;
            try
            {
                conn.Open();
                System.Data.DataTable tabela = new System.Data.DataTable();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter();
                adapter.SelectCommand = criterioSQL;
                adapter.Fill(tabela);

                if (tabela.Rows.Count > 0)
                {
                    dataGridPesquisa.DataSource = tabela;
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtPesquisa.Focus();
                    txtPesquisa.Text = string.Empty;
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally { conn.Close(); }
        }
        public void Pesquisar22()
        {
            Frm_Base_Pesquisa pesquisa = new Frm_Base_Pesquisa();
            var conn = Conexao.Conex();
           

            if (rbtDescricao.Checked == true)
            {
                SqlCeCommand sqlStringNome = new SqlCeCommand("SELECT * FROM clientes  WHERE cliente LIKE @cliente", conn);
                sqlStringNome.Parameters.AddWithValue("@cliente", txtPesquisa.Text + "%");
                PesquisarLocal(sqlStringNome);
            }
            if (rbtCodigo.Checked == true)
            {
                SqlCeCommand sqlStringCodigo = new SqlCeCommand("SELECT * FROM clientes  WHERE idcliente LIKE @idcliente", conn);
                sqlStringCodigo.Parameters.AddWithValue("@idcliente", txtPesquisa.Text + "%");
                PesquisarLocal(sqlStringCodigo);
            }            
        }       

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void rbtDescricao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void dataGridPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                linhaAtual = int.Parse(e.RowIndex.ToString());
            }
            catch
            {
            }      
        }

        private void dataGridPesquisa_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                linhaAtual = dataGridPesquisa.CurrentRow.Index;
            }
            catch
            {
            }    
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Pesquisar22();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente cadcli = new FrmCadastroCliente();
            cadcli.StatusOperacao = "NOVO";
            cadcli.ShowDialog();
        }
        private void CarregaDados()
        {
            FrmCadastroCliente f3 = new FrmCadastroCliente();
            try
            {
                if (linhaAtual >= 0)
                {

                    f3.txtCodigo.Text = dataGridPesquisa[0, linhaAtual].Value.ToString(); f3.Codigo = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
                    f3.txtCadastro.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                    f3.txtCliente.Text = dataGridPesquisa[2, linhaAtual].Value.ToString();
                    Nome = dataGridPesquisa[2, linhaAtual].Value.ToString();
                    f3.txtNascimento.Text = dataGridPesquisa[3, linhaAtual].Value.ToString();
                    f3.txtNaturalidade.Text = dataGridPesquisa[4, linhaAtual].Value.ToString();
                    f3.txtPai.Text = dataGridPesquisa[5, linhaAtual].Value.ToString();
                    f3.txtMae.Text = dataGridPesquisa[6, linhaAtual].Value.ToString();
                    f3.txtConjuge.Text = dataGridPesquisa[7, linhaAtual].Value.ToString();
                    f3.txtIdentidade.Text = dataGridPesquisa[8, linhaAtual].Value.ToString();
                    f3.txtCpf.Text = dataGridPesquisa[9, linhaAtual].Value.ToString();
                    f3.txtCnpj.Text = dataGridPesquisa[10, linhaAtual].Value.ToString();
                    f3.txtInscricaoEstadual.Text = dataGridPesquisa[11, linhaAtual].Value.ToString();
                    f3.txtFone1.Text = dataGridPesquisa[12, linhaAtual].Value.ToString();
                    f3.txtFone2.Text = dataGridPesquisa[13, linhaAtual].Value.ToString();
                    f3.txtContato.Text = dataGridPesquisa[14, linhaAtual].Value.ToString();
                    f3.txtCelular.Text = dataGridPesquisa[15, linhaAtual].Value.ToString();
                    f3.txtEndereco.Text = dataGridPesquisa[16, linhaAtual].Value.ToString();
                    f3.txtBairro.Text = dataGridPesquisa[17, linhaAtual].Value.ToString();
                    f3.txtCidade.Text = dataGridPesquisa[18, linhaAtual].Value.ToString();
                    f3.txtCep.Text = dataGridPesquisa[19, linhaAtual].Value.ToString();
                    f3.txtUf.Text = dataGridPesquisa[20, linhaAtual].Value.ToString();
                    f3.txtEmail.Text = dataGridPesquisa[21, linhaAtual].Value.ToString();
                    f3.txtEmissor.Text = dataGridPesquisa[22, linhaAtual].Value.ToString();
                    f3.txtObs.Text = dataGridPesquisa[23, linhaAtual].Value.ToString();
                    f3.StatusOperacao = "ALTERAR";
                    f3.Text = "Alterar cliente : > " + Nome;

                    f3.ShowDialog();
                    ListaCliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }           
        }
        public void ExcluirCliente()
        {
            string Codigo = dataGridPesquisa[0, linhaAtual].Value.ToString();
            Nome = dataGridPesquisa[2, linhaAtual].Value.ToString();
            string Endereco = dataGridPesquisa[10, linhaAtual].Value.ToString();

            if (MessageBox.Show("Excluir? Código:" + Codigo + " : " + Nome + "  " + Endereco + " ", "Excluir!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClienteMODEL clinteModel = new ClienteMODEL();
                clinteModel.Idcliente = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);

                ClienteBLL clienteBll = new ClienteBLL();
                clienteBll.Excluir(clinteModel);
                MessageBox.Show("REGISTRO EXCLUÍDO!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ListaCliente();
            }

        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {               
            CarregaDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCliente();
        }

        private void dataGridPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaDados();
        }
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ListaCliente();
            timer1.Enabled = false;
        }
    }
}

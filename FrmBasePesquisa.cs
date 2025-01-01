using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.IO;

namespace Money
{
    public partial class FrmBasePesquisa : Form
    {
        public FrmBasePesquisa()
        {
            InitializeComponent();
        }
        public string QueryFornecedor = "SELECT MAX(idfornecedor) FROM fornecedor";
        public string QueryCentro = "SELECT MAX(idcategoria) FROM categoria";
        public string QueryReceita = "SELECT MAX(idreceita) FROM receitas";
        public string QueryParcela = "SELECT MAX(idparcela) FROM parcelas";
        public string QueryContas = "SELECT MAX(idconta) FROM contas";

        public string Usuário { get; set; }
        public string NivelAcesso { get; set; }

        public int IdConta { get; set; }
        public int IdCliente { get; set; }
        public int IdCategoria { get; set; }
        public int IdParcela { get; set; }
        public int IdFornecedor { get; set; }
        public int IdReceita { get; set; }
        public int IdUsuario { get; set; }
        public int idmodelo { get; set; }
        public int Idmarca { get; set; }
        public int idfuncionario { get; set; }
        public int IdSituacao { get; set; }
        public string Situacao { get; set; }

        public string Fornecedor { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Funcionario { get; set; }
        public string Cliente { get; set; }
        public string categoria { get; set; }
        public string EventoBotao { get; set; }
        public string Descricao { get; set; }
        public string Parcela { get; set; }
        public string Documento { get; set; }
        public string String_Busca_codigo { get; set; }
        public string Capturavalor { get; set; }
        public string Contagem { get; set; }


        public int linhaAtual { get; set; }
        public string TipoPesquisa { get; set; }
        public string criterio { get; set; }
        public string sqlString { get; set; }
        public string sqlString1 { get; set; }
        public string sqlString2 { get; set; }
        public double Valor { get; set; }

        public DateTime PrevReceb { get; set; }
        public DateTime Cadastro { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime Pagamento { get; set; }
        private DateTime Data { get; set; }

        public bool umavez { get; set; }
        public bool parcelado { get; set; }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);




        private void FrmBasePesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        public void carregaGrid2Localizar(SqlCommand criterioSQL, DataGridView dataGridPesqParam)
        {
            var conn = Conexao.Conex();
            criterioSQL.Connection = conn;
            try
            {
                conn.Open();
                System.Data.DataTable tabela = new System.Data.DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = criterioSQL;
                adapter.Fill(tabela);

                if (tabela.Rows.Count > 0)
                {
                    dataGridPesqParam.DataSource = tabela;
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
        private void FrmBasePesquisa_Load(object sender, EventArgs e)
        {            
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

        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
            txtPesquisa.BackColor = Color.Yellow;
        }

        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            txtPesquisa.BackColor = Color.White;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

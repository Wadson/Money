using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Money
{
    public partial class BasePesquisa : Form
    {
        public BasePesquisa()
        {
            InitializeComponent();           
        }
      
        public string RetornoEvitaDuplicado { get; set; }
        public string QueryMarca = "SELECT MAX(idmarca) FROM marcas";
        public string QueryProduto = "SELECT MAX(id_produto) FROM produto";
        public string QueryGrupo = "SELECT MAX(idgrupo) FROM grupos";

        public string QueryParcelasReceitas = "SELECT MAX(idparcelasR) FROM parcelasReceitas";

        public string QueryUsuario = "SELECT MAX(idusuario) FROM usuario";
        public string QueryFuncionario = "SELECT MAX(idfuncionario) FROM funcionarios";
        public string QueryFornecedor = "SELECT MAX(idfornecedor) FROM fornecedor";
        public string QueryCliente = "SELECT MAX(idcliente) FROM clientes";
        public string QueryCentro = "SELECT MAX(idcategoria) FROM categoria";
        public string QueryReceita = "SELECT MAX(idreceita) FROM receitas";
        public string QueryParcela = "SELECT MAX(idparcela) FROM parcelas";

        public string QueryContasReceber = "SELECT MAX(id_contasreceber) FROM contasreceber";


        public string Usuário { get; set; }
        public string NivelAcesso { get; set; }
        public string NomeProduto { get; set; }
        public int Codigo { get; set; }
        public int Codigo2 { get; set; }
        public int Codigo3 { get; set; }
        public int IdProduto { get; set; }
        public int IdSubCategoria { get; set; }
        public int IdCategoria { get; set; }
        public string queryfor { get; set; }
        public string Nome { get; set; }
        public string categoria { get; set; }
        public string subcategoria { get; set; }
        public string EventoBotao { get; set; }
        public string Descricao { get; set; }
        public string Parcela { get; set; }
        public string Documento { get; set; }
        public string String_Busca_codigo { get; set; }
        public string Capturavalor { get; set; }
        public string Contagem { get; set; }
        public string criterio { get; set; }
        public string sqlString { get; set; }
        public string sqlString1 { get; set; }
        public string sqlString2 { get; set; }
        public double Valor { get; set; }
        public DateTime Cadastro { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime Pagamento { get; set; }
        public DateTime Data { get; set; }
        public DateTime dtNascimento { get; set; }
        public bool umavez { get; set; }
        public bool parcelado { get; set; }
        public string Status { get; set; }
        public string FormaPgto { get; set; }
        public int IdFormaPgto { get; set; }
        public int IdConta { get; set; }
        public int IdParcela { get; set; }
        public int IdParcelaR { get; set; }
        public int IdFornecedor { get; set; }
        public int Idcategoria { get; set; }
        public int IdCliente { get; set; }
        public int IdReceita { get; set; }
        public int IdUsuario { get; set; }
        public int Qtd_caractere { get; set; }
        public string Fornecedor { get; set; } //1
        public string FormadePgto { get; set; }
        public string Cliente { get; set; }

        public string StatusOperacao { get; set; } 
        public DateTime PrevReceb { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime Datas { get; set; }
        public DateTime DtNascimento { get; set; }

              
        public virtual void LimpaCampo()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
                if (c is MaskedTextBox)
                {
                    (c as MaskedTextBox).Text = "";
                }

                if (c is DateTimePicker) c.Text = null; if (c is ComboBox) c.Text = string.Empty; //Implementado por Wadson só esta linha

                if (c is Panel)
                {
                    for (int i = 0; i < c.Controls.Count; i++)
                    {
                        if (c.Controls[i] is TextBox)
                        {
                            (c.Controls[i] as TextBox).Text = "";
                        }
                        if (c.Controls[i] is MaskedTextBox)
                        {
                            (c.Controls[i] as MaskedTextBox).Text = "";
                        }
                        if (c.Controls[i] is ComboBox)
                        {
                            (c.Controls[i] as ComboBox).Text = "";
                        }
                    }
                }

                if (c is GroupBox)
                {
                    for (int i = 0; i < c.Controls.Count; i++)
                    {
                        if (c.Controls[i] is TextBox)
                        {
                            (c.Controls[i] as TextBox).Text = "";
                        }
                        if (c.Controls[i] is ComboBox)
                        {
                            (c.Controls[i] as ComboBox).Text = "";
                        }
                        //********************IMPLEMENTADO POR WADSON RODRIGUS LIMA
                        if (c.Controls[i] is MaskedTextBox)
                        {
                            (c.Controls[i] as MaskedTextBox).Text = "";
                        }
                        if (c.Controls[i] is DateTimePicker)
                        {
                            (c.Controls[i] as DateTimePicker).Text = null;
                        }//*********************FIM DA IMPLEMENTAÇÃO 
                    }
                }
                if (c is DataGridView)
                {
                    (c as DataGridView).DataSource = null;
                }
            }

        }
        public DataTable LocalizarGeral(SqlCommand comando)
        {
            var conn = Conexao.Conex();

            comando.Connection = conn;
            try
            {
                conn.Open();
                SqlDataAdapter daCliente = new SqlDataAdapter();
                daCliente.SelectCommand = comando;
                DataTable dt = new DataTable();
                daCliente.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }
       
        public virtual int RetornaCodigoContaMaisUm(string query)
        {
            var conn = Conexao.Conex();
            object codigo = 0;
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query.ToString();

                codigo = cmd.ExecuteScalar();

            }
            catch (SqlException erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                if ((cmd != null))
                {
                    cmd.Dispose();
                }
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return (codigo == null || codigo == DBNull.Value) ? 1 : (Convert.ToInt32(codigo) + 1);
        }
        private void BasePesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                //if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //{
                //    this.Close();
                //}
            }   
        }

        public virtual void carregaGrid2Localizar(SqlCommand criterioSQL, DataGridView DatagridParametro)
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
                    DatagridParametro.DataSource = tabela;
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
        private void BasePesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{tab}");
            }
        }

        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            txtPesquisa.BackColor = Color.White;
        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {            
        }

        private void rbtDescricao_CheckedChanged(object sender, EventArgs e)
        {          
        }

        private void BasePesquisa_Load(object sender, EventArgs e)
        {
        }

        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
            txtPesquisa.BackColor = Color.Yellow;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

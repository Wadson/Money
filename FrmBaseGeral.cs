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
    public partial class FrmBaseGeral : Form
    {
        public string RetornoEvitaDuplicado { get; set; }      
      
        public string QueryUsuario = "SELECT MAX(id_usuario) FROM usuario";       
        public string QueryFornecedor = "SELECT MAX(id_fornecedor) FROM fornecedor";
        public string QueryProduto = "SELECT MAX(id_produto) FROM produto";

        public string QueryVendas = "SELECT MAX(id_venda) FROM venda";
        public string QueryItensVenda = "SELECT MAX(id_itensvenda) FROM itensvenda";
        public string QueryParcela = "SELECT MAX(id_parcela) FROM parcelas";
        public string QueryContas = "SELECT MAX(id_contasreceber) FROM contasreceber";

        public string QueryCentro = "SELECT MAX(id_categoria) FROM categoria";
        public string QueryFormaPag = "SELECT MAX(id_formapgto) FROM formapgto";
        public string QueryContasReceber = "SELECT MAX(id_contasreceber) FROM contasreceber";
        public string QuerySubCat = "SELECT MAX(id_subcategoria) FROM subcategoria";
        public string QueryClientes = "SELECT MAX(id_cliente)  FROM cliente";

        private int IdCliente;
        public int IDCliente { get; set; }
        public int IDCidade { get; set; }
        public int Id_Itensvenda { get; set; }
        public int Id_Parcela { get; set; }
        public string StatusOperacao { get; set; }
        public string nome_FormaPgto { get; set; }
        public string Usuário { get; set; }
        public string NivelAcesso { get; set; }
        public string QueryFor { get; set; }          
     
        public string EventoBotao { get; set; }
        public string Descricaoo { get; set; }
        public int Parcela { get; set; }

        public string Forma_Pgtoo { get; set; }
        public string categoria { get; set; }
        public string subcategoria { get; set; }
        public string String_Busca_codigo { get; set; }
        public string Capturavalor { get; set; }
        public string Contagem { get; set; }
        public string Criterio { get; set; }
        public string SqlString { get; set; }
        public string SqlString1 { get; set; }
        public string SqlString2 { get; set; }
        public Char Status { get; set; }
        public string Fornecedor { get; set; }
        public string Cliente { get; set; }
        public string Titulo { get; set; }
        public string Nome { get; set; }
        
        public string FormaPgto { get; set; }
        public double NumParcelas { get; set; }

        public int Num_Parcelas { get; set; }
        public SqlCommand Comm { get; set; }

        object reTornn;
              
        public DateTime Cadastro { get; set; }
        public DateTime Dt_Vcto_Parc { get; set; }
        public DateTime Pagamento { get; set; }         
        
        public DateTime DtNascimento { get; set; }
        public DateTime DataP { get; set; }

        public bool umavez { get; set; }
        public bool parcelado { get; set; }
        public bool Statusconta { get; set; }

        public int linhaAtual { get; set; }
       
        public int Id_Venda { get; set; }
     
        public int Id_ContasReceber { get; set; }
        public int IdFornecedor { get; set; }
        public int IdProduto { get; set; }
                
        public int IdUsuario { get; set; }
        public int Qtd_caractere { get; set; }
        public decimal Parcelas { get; set; }
        public int Pago { get; set; }
        public int Idcategoria { get; set; }
        public int Idsubcategoria { get; set; }
      
        public int IdFormaPgto { get; set; }
        public int IdReceitas { get; set; }
        public int QtdProduto { get; set; }

        public decimal ValorTotal { get; set; }
        public decimal ValorParc { get; set; }
        public decimal ValorProduto { get; set; }

        private bool mover;
        private int CX, CY;

        public FrmBaseGeral()
        {
            InitializeComponent();            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        public virtual void preencherComboBoxT(ComboBox combo, string querY, string id, string nome)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand cmd = new SqlCommand(querY, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable Dt = new DataTable();

                conn.Open();

                da.Fill(Dt);

                combo.DataSource = Dt;
                combo.DisplayMember = nome;
                combo.ValueMember = id;
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Erro de acesso ao SqlCe : " + sqle.Message, "Erro");
            }
            finally
            {
                conn.Close();
            }
        }      

        public void FormataNumeroReplace(string valorsemformato, TexBox txtValor)
        { 
            valorsemformato = txtValor.Text;
            valorsemformato = valorsemformato.Replace("R$", "").Replace(" ", "");
            txtValor.Text = valorsemformato;
        }

        public void carregaGrid2Localizar(string comando, DataGridView DatagridParametro)
        {
            var conn = Conexao.Conex();
            SqlCommand criterioSQL = new SqlCommand(comando);
            
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
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally { conn.Close(); }
        }
        public void carregaGrid2LocalizarFormaPgto(string comando, DataGridView DatagridParametro)
        {
            var conn = Conexao.Conex();
            SqlCommand criterioSQL = new SqlCommand(comando);

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
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally { conn.Close(); }
        }


       
        public void HabilitaBotes(Button btnalterar, Button btnexcluir, Button btnpagar, DataGridView datagridi_pesquisa)
        {
            if (datagridi_pesquisa.DataSource != null)
            {
                btnalterar.Enabled = true;
                btnexcluir.Enabled = true;
                btnpagar.Enabled = true;
            }
            else
            {
                btnalterar.Enabled = false;
                btnexcluir.Enabled = false;
                btnpagar.Enabled = false;
            }
        }
        public void HabilitaBotes2(ToolStripButton btnalterar, ToolStripButton btnexcluir, ToolStripButton btnpagar, DataGridView datagridi_pesquisa, RadioButton rbQuitadas)
        {
            if (datagridi_pesquisa.DataSource != null & rbQuitadas.Checked == false)
            {
                btnalterar.Enabled = true;
                btnexcluir.Enabled = true;
                btnpagar.Enabled = true;
            }
            else if(datagridi_pesquisa.DataSource == null)
            {
                btnalterar.Enabled = false;
                btnexcluir.Enabled = false;
                btnpagar.Enabled = false;
            }
            else if (datagridi_pesquisa.DataSource != null & rbQuitadas.Checked == true)
            {
                btnalterar.Enabled = true;
                btnexcluir.Enabled = true;
                btnpagar.Enabled = false;
            }
        }
      
        public void PesquisarDinamicoDataGrid(string Sql1, string Sql2, DataGridView DataGridPesquisa, Label Mensagemm)
        {
            var conn = Conexao.Conex();

            SqlCommand comandos = new SqlCommand();
            comandos.CommandText = Convert.ToString(CommandType.Text);
            comandos.CommandText = Sql1 + Sql2;

            comandos.Connection = conn;

            try
            {
                conn.Open();

                System.Data.DataTable tabela = new System.Data.DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comandos;
                adapter.Fill(tabela);

                if (tabela.Rows.Count > 0)
                {
                    DataGridPesquisa.DataSource = tabela;
                    Mensagemm.Text = "";
                }
                else
                {
                    Mensagemm.Text = "Nenhum registro encontrado";
                 
                    if (tabela.Rows.Count == 0)
                    {
                        DataGridPesquisa.DataSource = tabela;
                        tabela.Clear();
                    }
                }
            }
            catch (DataException ex)
            {
                MessageBox.Show("Atenção",ex.ToString());// ex,"Informe", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            finally { conn.Close(); }
        }

        public string ReplaceValores(TextBox TxTValor)
        {            
            string valorsemformato = TxTValor.Text;
            valorsemformato = valorsemformato.ToString().Replace("R$", "").Replace(" ", "");           
            return valorsemformato;
        }
        public virtual int RetornaUltimoCodigo(string query)
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
                MessageBox.Show("Erro! +" + erro, "Atenção!" + erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return (codigo == null || codigo == DBNull.Value) ? 1 : (Convert.ToInt32(codigo));
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
                MessageBox.Show("Erro! +" +erro, "Atenção!"+erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void FrmBaseGeral_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //this.Close();
                if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }   
        }
      
        public virtual DataTable LocalizarGeral(SqlCommand comando)
        {
            var conn = Conexao.Conex();
            comando.Connection = conn;
            try
            {
                conn.Open();
                SqlDataAdapter daCliente = new SqlDataAdapter();
                daCliente.SelectCommand = comando;
                DataTable dtGeral = new DataTable();
                daCliente.Fill(dtGeral);

                return dtGeral;
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


        public void somarGeral(string sql, string parametro1, string parametro2, Label resultado)
        {
            try
            {
                using (var conn = Conexao.Conex())
                {
                    conn.Open();
                    using (var comm = conn.CreateCommand())
                    {
                        comm.CommandText = sql;//"SELECT SUM(valor_parc) FROM parcelas WHERE datavenc < @Data AND pago = 0";
                        comm.Parameters.AddWithValue(parametro1, parametro2);//"@Data", DateTime.Now.ToString("yyyy-MM-dd 00:00:00"));

                        string retorno;
                        if (comm != null)
                        {
                            retorno = comm.ExecuteScalar().ToString();
                            double total_vencido = string.IsNullOrEmpty(retorno) ? 0 : double.Parse(retorno);
                            resultado.Text = total_vencido.ToString("N");
                        }
                        else
                        {
                            resultado.Text = "0,00";
                        }
                        conn.Close();
                    }
                }
            }
            catch
            {
            }
        }
        //**************************************************************
      
        public virtual int BuscarRetornoVariavel(string sqlComando,string Nomeparametro, string parametro, string campoTabela )
        {          
            var Conn = Conexao.Conex();
            SqlCommand comando = new SqlCommand(sqlComando);
            comando.Parameters.AddWithValue(Nomeparametro, parametro);//("@criterio", txtPesquisa.Text + "%");
            Conn.Open();
            
            if (Conn.State == ConnectionState.Open)
            {                
                DataSet ds = new DataSet();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.SelectCommand.Connection = Conn;
                adaptador.Fill(ds);
                reTornn = ds.Tables[0].Rows[0][campoTabela];
                
            }
            return Convert.ToInt32(reTornn); 
        }
        public string BuscarRetornoVariavelString(string sqlComando, string Nomeparametro, string parametro, string campoTabela)
        {
            var Conn = Conexao.Conex();
            SqlCommand comando = new SqlCommand(sqlComando);
            comando.Parameters.AddWithValue(Nomeparametro, parametro);//("@criterio", txtPesquisa.Text + "%");
            Conn.Open();

            if (Conn.State == ConnectionState.Open)
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.SelectCommand.Connection = Conn;
                adaptador.Fill(ds);
                reTornn = ds.Tables[0].Rows[0][campoTabela];

            }
            return Convert.ToString(reTornn);
        }       

        public DateTime BuscarRetornoVariavelData(string sqlComando, string parametro, string parametro2, string campoTabela)
        {

            var Conn = Conexao.Conex();
            SqlCommand comando = new SqlCommand(sqlComando);
            comando.Parameters.AddWithValue(parametro, parametro2);//("@criterio", txtPesquisa.Text + "%");
            Conn.Open();

            if (Conn.State == ConnectionState.Open)
            {

                DataSet dt = new DataSet();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.SelectCommand.Connection = Conn;
                adaptador.Fill(dt);
                DataP = Convert.ToDateTime(dt.Tables[0].Rows[0][campoTabela]);

            }
            return Convert.ToDateTime(DataP);
        }
        private void FrmBaseGeral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{tab}");
            }
        }
       
        public virtual void LimpaCampo()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
               
                if (c is DateTimePicker) c.Text = null;

                if (c is Panel)
                {
                    for (int i = 0; i < c.Controls.Count; i++)
                    {
                        if (c.Controls[i] is TextBox)
                        {
                            (c.Controls[i] as TextBox).Text = "";
                        }
                        if (c.Controls[i] is ComboBox)
                        {
                            (c.Controls[i] as ComboBox).SelectedIndex = -1;
                        }
                    }
                }
                if (c is ComboBox)
                {
                    (c as ComboBox).SelectedIndex = -1;
                }
                if (c is GroupBox)
                {
                    for (int i = 0; i < c.Controls.Count; i++)
                    {
                        if (c.Controls[i] is TextBox)
                        {
                            (c.Controls[i] as TextBox).Text = "";
                        }  
                        if (c.Controls[i] is DateTimePicker)
                        {
                            (c.Controls[i] as DateTimePicker).Text = null;
                        }
                        if (c.Controls[i] is ComboBox)
                        {
                            (c.Controls[i] as ComboBox).SelectedIndex = -1;
                        }
                    }
                }               
            }

        }

        public void AcrescenteZero_a_Esquerda2(TextBox TxtResultado)
        {
            string texto;
            string textofinal;
            int tamanho;
            textofinal = "";
            texto = TxtResultado.Text.ToString();
            if ((TxtResultado.Text.Length < 10))
            {
                tamanho = TxtResultado.Text.Length;
                for (int t = 1; (t <= (6 - tamanho)); t++)
                {
                    textofinal = (textofinal + "0");
                }

                TxtResultado.Text = (textofinal + TxtResultado.Text);
            }

            if ((TxtResultado.Text == "000000"))
            {
                //MessageBox.Show("DEVE SER DIGITADO ALGUM VALOR NO CAMPO CÓDIGO.","INFORMAÇÃO !", MessageBoxButtons.OK,MessageBoxIcon.Information);
                //txtCodForn.Text = "";
                //txtCodForn.Focus();
            }            
        }
       
        public virtual int RetornaUltimoCodigoCadastrado(string query)
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
            return (codigo == null || codigo == DBNull.Value) ? 1 : (Convert.ToInt32(codigo));
        }
        public virtual string EvitarDuplicado(string Tabela, string Campo, string CampoParametro)
        {
            var conn = Conexao.Conex();

            SqlCommand comando = new SqlCommand("SELECT COUNT(*) FROM " + Tabela + " WHERE " + Campo + " = @criterio", conn);

            try
            {
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@criterio";
                parametro.Value = CampoParametro;
                comando.Parameters.Add(parametro);

                conn.Open();
                RetornoEvitaDuplicado = comando.ExecuteScalar().ToString();

                if (RetornoEvitaDuplicado != "0")
                {
                    MessageBox.Show("Registro já cadastrado", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
            finally
            {
                conn.Close();
            }
            return RetornoEvitaDuplicado;
        }

        private void FrmBaseGeral_Load(object sender, EventArgs e)
        {
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelFormat_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CX = e.X;
                CY = e.Y;
                mover = true;
            }
        }
    }
}
//this.WindowState = FormWindowState.Minimized;
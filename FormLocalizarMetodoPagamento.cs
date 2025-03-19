using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Money.BLL;
using Money.DAL;
using Money.MODEL;
namespace Money
{
    public partial class FormLocalizarMetodoPagamento : KryptonForm
    {
        protected int LinhaAtual = -1;
        public int MetodoPgtoID { get; set; }
        public string NomeMetodoPgto { get; set; }

        public string MetodoPgtoSelecionado { get; set; }
        public Form FormChamador { get; set; }

        private bool isSelectingMetodo = false;
        private Form formChamador;
       

        public FormLocalizarMetodoPagamento(Form formChamador, string textoDigitado)
        {
            InitializeComponent();

            Utilitario.AdicionarEfeitoFocoEmTodos(this);
            // Verifica se o formulário chamador é válido
            if (formChamador != null)
            {
                this.FormChamador = formChamador;
            }
            this.Owner = formChamador;

            txtPesquisa.Text = textoDigitado; // Define a letra pressionada no campo de pesquisa
            txtPesquisa.SelectionStart = txtPesquisa.Text.Length; // Coloca o cursor no final
            txtPesquisa.Focus(); // Foca o campo para continuar digitando

            // Configurar o TextBox para capturar o evento KeyDown
            this.txtPesquisa.KeyDown += new KeyEventHandler(dgvPesquisa_KeyDown);
            this.dgvPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPesquisa_KeyDown);
            this.dgvPesquisa.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgvPesquisa_DataBindingComplete);

            // Verificar se o DataGridView foi inicializado
            if (dgvPesquisa == null)
            {
                throw new Exception("O controle DataGridView 'dgvPesquisa' não foi inicializado no formulário.");
            }
        }
        private void ConfigurarDataGridView()
        {
            dgvPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;            
            dgvPesquisa.AllowUserToAddRows = false;
            dgvPesquisa.ReadOnly = true;
        }

        private void PersonalizarColunas()
        {
            if (dgvPesquisa.DataSource != null && dgvPesquisa.Columns.Count > 0)
            {
                if (dgvPesquisa.Columns.Contains("MetodoPgtoID"))
                {
                    dgvPesquisa.Columns["MetodoPgtoID"].HeaderText = "ID Método Pgto";
                    dgvPesquisa.Columns["MetodoPgtoID"].Width = 80;
                    dgvPesquisa.Columns["MetodoPgtoID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
                }

                if (dgvPesquisa.Columns.Contains("NomeMetodoPagamento"))
                {
                    dgvPesquisa.Columns["NomeMetodoPagamento"].HeaderText = "Nome do Método";
                    dgvPesquisa.Columns["NomeMetodoPagamento"].Width = 350;
                }
            }
        }

        private void CarregarMetodosPagamento(string filtro = null)
        {
            var bll = new MetodosPagamentoBLL();
            var lista = bll.PesquisarMetodoPagamento(filtro);

            dgvPesquisa.DataSource = lista;
            ConfigurarDataGridView();
            // PersonalizarColunas será chamado no evento DataBindingComplete
        }

        private void SelecionarMetodoPgto()
        {
            if (isSelectingMetodo) return;
            isSelectingMetodo = true;

            try
            {
                LinhaAtual = ObterLinhaAtual();
                if (LinhaAtual < 0 || LinhaAtual >= dgvPesquisa.Rows.Count)
                {
                    MessageBox.Show("Linha inválida.");
                    return;
                }

                if (dgvPesquisa["NomeMetodoPagamento", LinhaAtual]?.Value == null ||
                    dgvPesquisa["MetodoPgtoID", LinhaAtual]?.Value == null)
                {
                    MessageBox.Show("Dados do método de pagamento inválidos.");
                    return;
                }

                MetodoPgtoID = int.Parse(dgvPesquisa["MetodoPgtoID", LinhaAtual].Value.ToString());
                NomeMetodoPgto = dgvPesquisa["NomeMetodoPagamento", LinhaAtual].Value.ToString();
                MetodoPgtoSelecionado = NomeMetodoPgto;

                if (this.Owner is FormCadastroDespesa frmCadastroDespesa)
                {
                    frmCadastroDespesa.MetodoPgtoID = MetodoPgtoID;
                    frmCadastroDespesa.txtMetodoPgto.Text = NomeMetodoPgto;

                    frmCadastroDespesa.BeginInvoke((Action)(() =>
                    {
                        frmCadastroDespesa.btnSalvar.Focus();
                    }));
                }

                this.Close();
            }
            finally
            {
                isSelectingMetodo = false;
            }
        }

        public int ObterLinhaAtual()
        {
            return dgvPesquisa.CurrentRow?.Index ?? -1;
        }

       
        private void FrmBase_KeyDown(object sender, KeyEventArgs e)
        {           
        }       
        private void FormLocalizarCategoria_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CarregarMetodosPagamento();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            MetodosPagamentoDAL dao = new MetodosPagamentoDAL();
            dgvPesquisa.DataSource = dao.PesquisarMetodoPagamento(nome);
            ConfigurarDataGridView();
        }

        private void dgvPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && dgvPesquisa.CurrentCell?.RowIndex == 0)
            {
                txtPesquisa.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (dgvPesquisa.CurrentRow != null)
                {
                    LinhaAtual = dgvPesquisa.CurrentRow.Index;
                    SelecionarMetodoPgto();
                }
            }
        }

        private void dgvPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarMetodoPgto();
        }

        private void dgvPesquisa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPesquisa.CurrentRow != null)
            {
                LinhaAtual = dgvPesquisa.CurrentRow.Index;
            }
        }

        private void FormLocalizarCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            SelecionarMetodoPgto();
        }
        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dgvPesquisa.Focus();
                if (dgvPesquisa.Rows.Count > 0)
                {
                    // Verificar se a célula é visível antes de defini-la como CurrentCell
                    DataGridViewCell primeiraCelulaVisivel = null;

                    foreach (DataGridViewCell celula in dgvPesquisa.Rows[0].Cells)
                    {
                        if (celula.Visible)
                        {
                            primeiraCelulaVisivel = celula;
                            break;
                        }
                    }

                    if (primeiraCelulaVisivel != null)
                    {
                        dgvPesquisa.CurrentCell = primeiraCelulaVisivel;
                    }
                }
            }
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarMetodoPgto();
        }

        private void dgvPesquisa_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PersonalizarColunas(); // Personaliza as colunas após o DataSource estar completamente vinculado
        }
    }
}

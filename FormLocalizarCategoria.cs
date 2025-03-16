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
namespace Money
{
    public partial class FormLocalizarCategoria : KryptonForm
    {
        protected int LinhaAtual = -1;
        public int categoriaID { get; set; }
        public string nomeCategoria { get; set; }

        public string categoriaSelecionado { get; set; }
        public Form FormChamador { get; set; }

        private bool isSelectingVendedor = false;
        private Form formChamador;
        public new int ObterLinhaAtual()
        {
            return LinhaAtual;
        }

        public FormLocalizarCategoria(Form formChamador, string textoDigitado)
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
        }
       
        private void ConfigurarDataGridView()
        {
            dgvPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecionar linha inteira            
            dgvPesquisa.AllowUserToAddRows = false; // Impedir que o usuário adicione linhas manualmente
            dgvPesquisa.ReadOnly = true; // Somente leitura

            if (dgvPesquisa.Columns.Count > 0)
            {
                dgvPesquisa.Columns["CategoriaID"].HeaderText = "ID Categoria"; // Nome da coluna
                dgvPesquisa.Columns["CategoriaID"].Width = 100; // Tamanho fixo para ID
                dgvPesquisa.Columns["CategoriaID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter; // Centraliza o ID

                dgvPesquisa.Columns["NomeCategoria"].HeaderText = "Nome da Categoria"; // Nome da coluna
                dgvPesquisa.Columns["NomeCategoria"].Width = 450; // Aumenta o tamanho da coluna Nome
            }
        }

        private void CarregarCategorias(string filtro = null)
        {
            var bll = new CategoriasBLL();
            var lista = bll.PesquisarCategoria(filtro);

            dgvPesquisa.DataSource = lista;
            ConfigurarDataGridView(); // Chama a configuração após carregar os dados
        }

        private void SelecionarCategoria()
        {
            // Verifica se o processo de seleção de produto já está em andamento
            if (isSelectingVendedor) return;
            isSelectingVendedor = true;

            try
            {
                // Obtém a linha atual selecionada na grid
                LinhaAtual = ObterLinhaAtual();
                if (LinhaAtual < 0 || LinhaAtual >= dgvPesquisa.Rows.Count)
                {
                    // Verifica se a linha obtida é válida
                    MessageBox.Show("Linha inválida.");
                    return;
                }
                // Verifica e obtém os valores das células NomeProduto e PrecoDeVenda
                if (dgvPesquisa["NomeCategoria", LinhaAtual]?.Value == null ||
                    dgvPesquisa["CategoriaID", LinhaAtual]?.Value == null)
                {
                    // Caso os valores não sejam válidos, exibe uma mensagem de erro
                    MessageBox.Show("Dados do produto inválidos.");
                    return;
                }

                // Converte o valor da célula NomeProduto para string
                categoriaID = int.Parse(dgvPesquisa["CategoriaID", LinhaAtual].Value.ToString());
                nomeCategoria = dgvPesquisa["NomeCategoria", LinhaAtual].Value.ToString();

                // Acrescenta zeros à esquerda do ProdutoID
                string numeroComZeros = Utilitario.AcrescentarZerosEsquerda(categoriaID, 4);

                // Obtém a instância do formulário FrmControleEntregas (ou usa uma existente)
                if (this.Owner is FormCadastroDespesa frmControleDeEntregas)
                {
                    // Preenche os campos no formulário FrmPedido com os dados do produto
                    frmControleDeEntregas.CategoriaID = categoriaID;
                    frmControleDeEntregas.txtCategoria.Text = nomeCategoria;

                    // Definir o foco no próximo campo usando BeginInvoke para evitar conflitos
                    frmControleDeEntregas.BeginInvoke((Action)(() =>
                    {
                        frmControleDeEntregas.txtNumeroParcelas.Focus();
                    }));
                }
                // Fecha o formulário FrmLocalizarProduto
                this.Close();
                
            }
            finally
            {
                // Certifica-se de que a variável isSelectingProduct seja false ao final do processo
                isSelectingVendedor = false;
            }
        }
        private void FrmBase_KeyDown(object sender, KeyEventArgs e)
        {            
        }       
        private void FormLocalizarCategoria_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CarregarCategorias();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string textoPesquisa = txtPesquisa.Text.ToLower();
            string nome = "%" + txtPesquisa.Text + "%";
            CategoriasDAL dao = new CategoriasDAL();

            dgvPesquisa.DataSource = dao.PesquisarCategoria(nome);
            ConfigurarDataGridView();
        }

        private void dgvPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && dgvPesquisa.CurrentCell.RowIndex == 0)
            {
                txtPesquisa.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita o "beep" do Enter no DataGridView

                if (dgvPesquisa.CurrentRow != null)
                {
                    LinhaAtual = dgvPesquisa.CurrentRow.Index; // Atualiza a linha atual corretamente
                    SelecionarCategoria();
                }
            }
        }

        private void dgvPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarCategoria();
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
            SelecionarCategoria();
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
            SelecionarCategoria();
        }
    }
}

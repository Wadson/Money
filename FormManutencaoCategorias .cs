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
using Money.MODEL;
namespace Money
{
    public partial class FormManutencaoCategorias : KryptonForm   {

        private CategoriasModel TipoAtual { get; set; } // Armazena o tipo selecionado
        private readonly CategoriasBLL categoriabll = new CategoriasBLL();
        private string StatusOperacao;

        public FormManutencaoCategorias(string statusOperacao = "CONSULTA")
        {
            InitializeComponent();           
            CarregarDados();
            StatusOperacao = statusOperacao;

            dgvCategorias.SelectionChanged += dgvTiposReceita_SelectionChanged; // Associe o evento aqui
        }

        public void PersonalizarDataGridView(KryptonDataGridView dgv)
        {
            if (dgv.Columns.Count == 0) return; // Evita erro caso não existam colunas

            // Desativar ajuste automático para evitar conflitos
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Ajustar nome das colunas
            dgv.Columns[0].HeaderText = "Código";
            dgv.Columns[1].HeaderText = "Nome Categoria";

            // Ajustar largura fixa da coluna de índice 1
            dgv.Columns[1].Width = 350;

            // Centralizar conteúdo da coluna de índice 0
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Outras personalizações para a coluna "Código"
            dgv.Columns[0].DefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Italic);
            dgv.Columns[0].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen;
            dgv.Columns[0].DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;

            // Ajustar automaticamente as demais colunas sem alterar a largura definida da coluna 1
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tornar o grid somente leitura
            dgv.ReadOnly = true;
        }

        private void CarregarDados(string nomeTipo = null)
        {
            try
            {
                var tipos = categoriabll.PesquisarCategoria(nomeTipo);
                dgvCategorias.DataSource = null;  // Limpa o DataSource antes de atribuir novos dados
                dgvCategorias.DataSource = tipos;
                dgvCategorias.ClearSelection();   // Remove seleções prévias
                PersonalizarDataGridView(dgvCategorias);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimparCampos()
        {           
            txtPesquisa.Clear();
            TipoAtual = null;           
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }
        public void AtualizarDataGrid()
        {
            CarregarDados(); // Reutiliza o método existente para recarregar os dados
        }
        private void CarregaDados()
        {
            FormCadastroCategorias form = new FormCadastroCategorias(StatusOperacao, this);

            try
            {
                switch (StatusOperacao)
                {
                    case "NOVO":
                        ConfigurarFormulario(form, "CADASTRO DE CATEGORIA", Color.FromArgb(8, 142, 254), "NOVO", true, "Salvar", true);
                        form.ShowDialog();                        
                        break;

                    case "ALTERAR":
                        PreencherCampos(form);
                        ConfigurarFormulario(form, "ALTERAR REGISTRO", Color.Orange, "ALTERAR", false, "Alterar", true);
                        form.ShowDialog();                        
                        break;

                    case "EXCLUSÃO":
                        PreencherCampos(form);
                        ConfigurarFormulario(form, "EXCLUSÃO DE REGISTRO", Color.Red, "EXCLUSÃO", false, "Excluir", false);
                        DesabilitarCampos(form);
                        form.ShowDialog();                       
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherCampos(FormCadastroCategorias form)
        {
            if (TipoAtual != null)
            {
                form.txtCategoriaID.Text = TipoAtual.CategoriaID.ToString();
                form.txtNomeCategoria.Text = TipoAtual.NomeCategoria;
            }
        }

        private void ConfigurarFormulario(FormCadastroCategorias form, string lblStatusText, Color lblStatusColor, string statusOperacao, bool habilitarNovo, string btnSalvarText, bool habilitarCampos)
        {
            form.lblStatus.Text = lblStatusText;
            form.lblStatus.ForeColor = lblStatusColor;
            form.StatusOperacao = statusOperacao; // Passa para o form filho
            form.btnSalvar.Text = btnSalvarText;
            form.btnNovo.Enabled = habilitarNovo;
            form.txtCategoriaID.Enabled = habilitarCampos;
            form.txtNomeCategoria.Enabled = habilitarCampos;
        }

        private void DesabilitarCampos(FormCadastroCategorias form)
        {
            form.txtCategoriaID.Enabled = false;
            form.txtNomeCategoria.Enabled = false;
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            StatusOperacao = "NOVO";
            CarregaDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (TipoAtual == null)
            {
                MessageBox.Show("Selecione um tipo para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StatusOperacao = "ALTERAR";
            CarregaDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (TipoAtual == null)
            {
                MessageBox.Show("Selecione um tipo para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StatusOperacao = "EXCLUSÃO";
            CarregaDados();
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarDados(txtPesquisa.Text);
        }

        private void FormCadastroTiposReceita_Load(object sender, EventArgs e)
        {           
            CarregarDados(); // Carrega os dados ao abrir o formulário
        }

        private void dgvTiposReceita_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            {
                var selectedRow = dgvCategorias.SelectedRows[0];
                TipoAtual = new CategoriasModel
                {
                    CategoriaID = Convert.ToInt32(selectedRow.Cells[0].Value),
                    NomeCategoria = selectedRow.Cells[1].Value.ToString()
                };
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else
            {
                TipoAtual = null;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }
    }
}

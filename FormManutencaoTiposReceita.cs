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
    public partial class FormManutencaoTiposReceita : KryptonForm   {

        private TiposReceitaModel TipoAtual { get; set; } // Armazena o tipo selecionado
        private readonly TiposReceitaBLL objetoBll = new TiposReceitaBLL();
        private string StatusOperacao;

        public FormManutencaoTiposReceita(string statusOperacao = "CONSULTA")
        {
            InitializeComponent();           
            CarregarDados();
            StatusOperacao = statusOperacao;

            dgvTiposReceita.SelectionChanged += dgvTiposReceita_SelectionChanged; // Associe o evento aqui
        }

        public void PersonalizarDataGridView(KryptonDataGridView dgv)
        {
            if (dgv == null || dgv.Columns.Count == 0) return; // Evita erro caso o grid esteja vazio

            // Desativar ajuste automático para evitar conflitos
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Verificar se as colunas existem antes de acessá-las
            if (dgv.Columns.Contains("TipoID"))
            {
                dgv.Columns["TipoID"].HeaderText = "Código";
                dgv.Columns["TipoID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["TipoID"].DefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Italic);
                dgv.Columns["TipoID"].DefaultCellStyle.ForeColor = Color.DarkGreen;
                dgv.Columns["TipoID"].DefaultCellStyle.BackColor = Color.LightBlue;
            }

            if (dgv.Columns.Contains("NomeTipo"))
            {
                dgv.Columns["NomeTipo"].HeaderText = "Descrição";
            }

            if (dgv.Columns.Contains("Descricao"))
            {
                dgv.Columns["Descricao"].Width = 350;
            }

            // Ajustar automaticamente as demais colunas, respeitando larguras fixas definidas
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tornar o grid somente leitura
            dgv.ReadOnly = true;
        }



        private void CarregarDados(string nomeTipo = null)
        {
            try
            {
                var tipos = objetoBll.Pesquisar(nomeTipo);
                dgvTiposReceita.DataSource = null;
                dgvTiposReceita.DataSource = tipos;
                dgvTiposReceita.ClearSelection();
                PersonalizarDataGridView(dgvTiposReceita);
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
            FormCadastroTipoReceita form = new FormCadastroTipoReceita(StatusOperacao, this); // Passe "this" como parâmetro

            try
            {
                switch (StatusOperacao)
                {
                    case "NOVO":
                        ConfigurarFormulario(form, "NOVO CADASTRO TIPOS DE RECEITAS", Color.FromArgb(8, 142, 254), "NOVO", true, "Salvar", true);
                        form.ShowDialog();
                        // Remova a chamada CarregarDados aqui, pois será feita pelo formulário filho
                        break;

                    case "ALTERAR":
                        PreencherCampos(form);
                        ConfigurarFormulario(form, "ALTERAR REGISTRO", Color.Orange, "ALTERAR", false, "Alterar", true);
                        form.ShowDialog();
                        // Remova a chamada CarregarDados aqui
                        break;

                    case "EXCLUSÃO":
                        PreencherCampos(form);
                        ConfigurarFormulario(form, "EXCLUSÃO DE REGISTRO", Color.Red, "EXCLUSÃO", false, "Excluir", false);
                        DesabilitarCampos(form);
                        form.ShowDialog();
                        // Remova a chamada CarregarDados aqui
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherCampos(FormCadastroTipoReceita form)
        {
            if (TipoAtual != null)
            {
                form.txtTipoReceitaID.Text = TipoAtual.TipoReceitaID.ToString();
                form.txtNomeTipo.Text = TipoAtual.NomeTipoReceita;
            }
        }

        private void ConfigurarFormulario(FormCadastroTipoReceita form, string lblStatusText, Color lblStatusColor, string statusOperacao, bool habilitarNovo, string btnSalvarText, bool habilitarCampos)
        {
            form.lblStatus.Text = lblStatusText;
            form.lblStatus.ForeColor = lblStatusColor;
            form.StatusOperacao = statusOperacao; // Passa para o form filho
            form.btnSalvar.Text = btnSalvarText;
            form.btnNovo.Enabled = habilitarNovo;
            form.txtTipoReceitaID.Enabled = habilitarCampos;
            form.txtNomeTipo.Enabled = habilitarCampos;
        }

        private void DesabilitarCampos(FormCadastroTipoReceita form)
        {
            form.txtTipoReceitaID.Enabled = false;
            form.txtNomeTipo.Enabled = false;
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
            if (dgvTiposReceita.SelectedRows.Count > 0)
            {
                var selectedRow = dgvTiposReceita.SelectedRows[0];
                TipoAtual = new TiposReceitaModel
                {
                    TipoReceitaID = Convert.ToInt32(selectedRow.Cells[0].Value),
                    NomeTipoReceita = selectedRow.Cells[1].Value.ToString()
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

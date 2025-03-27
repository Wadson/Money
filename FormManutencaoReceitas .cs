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
    public partial class FormManutencaoReceitas : KryptonForm   
    {
        private ReceitasModel TipoAtual { get; set; } // Armazena o tipo selecionado
        private readonly ReceitasBLL objetoBll = new ReceitasBLL();
        private string StatusOperacao;

        public FormManutencaoReceitas(string statusOperacao = "CONSULTA")
        {
            InitializeComponent();           
            CarregarDados();
            StatusOperacao = statusOperacao;

            dgvReceitas.SelectionChanged += dgvTiposReceita_SelectionChanged; // Associe o evento aqui
        }

        public void PersonalizarDataGridView(KryptonDataGridView dgv)
        {
            if (dgv.Columns.Count == 0)
            {
                MessageBox.Show("Nenhuma coluna disponível no DataGridView.");
                return;
            }

            // Desativar ajuste automático completamente
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Verificar e ajustar cada coluna
            if (dgv.Columns.Contains("ReceitaID"))
            {
                dgv.Columns["ReceitaID"].HeaderText = "Código";
                dgv.Columns["ReceitaID"].Width = 100;
                dgv.Columns["ReceitaID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["ReceitaID"].DefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Italic);
                dgv.Columns["ReceitaID"].DefaultCellStyle.ForeColor = Color.DarkGreen;
                dgv.Columns["ReceitaID"].DefaultCellStyle.BackColor = Color.LightBlue;
            }

            if (dgv.Columns.Contains("Descricao"))
            {
                dgv.Columns["Descricao"].HeaderText = "Descrição";
                dgv.Columns["Descricao"].Width = 350; // Largura fixa de 400 pixels
            }

            if (dgv.Columns.Contains("Valor"))
            {
                dgv.Columns["Valor"].HeaderText = "Valor";
                dgv.Columns["Valor"].Width = 120;
                dgv.Columns["Valor"].DefaultCellStyle.Format = "C2"; // Formato monetário
            }

            if (dgv.Columns.Contains("DataRecebimento"))
            {
                dgv.Columns["DataRecebimento"].HeaderText = "Data do\nRecebimento";
                dgv.Columns["DataRecebimento"].Width = 100;
                dgv.Columns["DataRecebimento"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Formato short
            }

            if (dgv.Columns.Contains("NomeTipoReceita"))
            {
                dgv.Columns["NomeTipoReceita"].HeaderText = "Tipo de Receita";
                dgv.Columns["NomeTipoReceita"].Width = 200;
            }

            if (dgv.Columns.Contains("DataCadastro"))
            {
                dgv.Columns["DataCadastro"].HeaderText = "Data do\nCadastro";
                dgv.Columns["DataCadastro"].Width = 120;
                dgv.Columns["DataCadastro"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Formato short
            }

            if (dgv.Columns.Contains("TipoID"))
            {
                dgv.Columns["TipoID"].Visible = false; // Ocultar TipoID
            }

            // Tornar o grid somente leitura
            dgv.ReadOnly = true;           
        }

        private void CarregarDados(string nomeTipo = null)
        {
            try
            {
                var tipos = objetoBll.Pesquisar(nomeTipo);
                dgvReceitas.DataSource = null;  // Limpa o DataSource antes de atribuir novos dados
                dgvReceitas.DataSource = tipos;
                dgvReceitas.ClearSelection();   // Remove seleções prévias
                PersonalizarDataGridView(dgvReceitas);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimparCampos()
        {           
            txtPesquisar.Clear();
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
            FormCadastroReceita form = new FormCadastroReceita(StatusOperacao, this);

            try
            {
                switch (StatusOperacao)
                {
                    case "NOVO":
                        ConfigurarFormulario(form, "CADASTRO DE RECEITAS", Color.FromArgb(8, 142, 254), "NOVO", true, "Salvar", true);
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
        private void PreencherCampos(FormCadastroReceita form)
        {
            if (TipoAtual != null)
            {
                form.txtReceitaID.Text = TipoAtual.ReceitaID.ToString();
                form.txtDescricao.Text = TipoAtual.Descricao;
                form.txtValor.Text = TipoAtual.ValorDaReceita.ToString();
                form.dtpDataCadastro.Value = TipoAtual.DataCadastro;
                form.cmbTipoReceita.SelectedValue = TipoAtual.TipoID;
                form.dtpDataRecebimento.Value = TipoAtual.DataRecebimento;
            }
        }

        private void ConfigurarFormulario(FormCadastroReceita form, string lblStatusText, Color lblStatusColor, string statusOperacao, bool habilitarNovo, string btnSalvarText, bool habilitarCampos)
        {
            form.lblStatus.Text = lblStatusText;
            form.lblStatus.ForeColor = lblStatusColor;
            form.StatusOperacao = statusOperacao; // Passa para o form filho
            form.btnSalvar.Text = btnSalvarText;
            form.btnNovo.Enabled = habilitarNovo;
            form.txtReceitaID.Enabled = habilitarCampos;
            form.txtDescricao.Enabled = habilitarCampos;
            form.txtValor.Enabled = habilitarCampos;
        }

        private void DesabilitarCampos(FormCadastroReceita form)
        {
            form.txtReceitaID.Enabled = false;
            form.txtDescricao.Enabled = false;
        }

        private void FormCadastroTiposReceita_Load(object sender, EventArgs e)
        {           
            CarregarDados(); // Carrega os dados ao abrir o formulário
        }

        private void dgvTiposReceita_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReceitas.SelectedRows.Count > 0)
            {
                var selectedRow = dgvReceitas.SelectedRows[0];
                TipoAtual = new ReceitasModel
                {
                    ReceitaID = Convert.ToInt32(selectedRow.Cells["ReceitaID"].Value),
                    Descricao = selectedRow.Cells["Descricao"].Value.ToString(),
                    ValorDaReceita = Convert.ToDecimal(selectedRow.Cells["ValorDaReceita"].Value),
                    DataRecebimento = Convert.ToDateTime(selectedRow.Cells["DataRecebimento"].Value),
                    TipoID = selectedRow.Cells["TipoID"].Value == null ? (int?)null : Convert.ToInt32(selectedRow.Cells["TipoID"].Value),
                    DataCadastro = Convert.ToDateTime(selectedRow.Cells["DataCadastro"].Value),
                    NomeTipoReceita = selectedRow.Cells["NomeTipoReceita"].Value?.ToString() // Corrigido de "NomeTipo" para "NomeTipoReceita"
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

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            CarregarDados(txtPesquisar.Text);
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            StatusOperacao = "NOVO";
            CarregaDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

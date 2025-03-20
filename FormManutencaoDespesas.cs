using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DocumentFormat.OpenXml.Wordprocessing;
using Money.BLL;
using Money.DAL;
using Money.MODEL;
namespace Money
{
    public partial class FormManutencaoDespesas : KryptonForm   
    {
        private DespesasModel TipoAtual { get; set; } // Armazena o tipo selecionado        
        private readonly DespesasBLL despesasBLL = new DespesasBLL();
        private string StatusOperacao;

        public FormManutencaoDespesas(string statusOperacao = "CONSULTA")
        {
            InitializeComponent();
            StatusOperacao = statusOperacao;
            AtualizarDataGrid(); // Carrega os dados e totais ao abrir o formulário
            dgvDespesa.SelectionChanged += dgvDespesa_SelectionChanged; // Associe o evento aqui

            radioPagas.CheckedChanged += radioPagas_CheckedChanged;
            radioPendentes.CheckedChanged += radioPendentes_CheckedChanged;

            Utilitario.AdicionarEfeitoFocoEmTodos(this);
        }


        public void PersonalizarDataGridView(DataGridView dgvDespesa)
        {
            dgvDespesa.AutoGenerateColumns = false;
            dgvDespesa.EnableHeadersVisualStyles = false; // Permite personalizar o cabeçalho

            // Alternância de cores das linhas
            dgvDespesa.RowsDefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            dgvDespesa.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;

            // Personalização do cabeçalho
            dgvDespesa.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkBlue;
            dgvDespesa.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvDespesa.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dgvDespesa.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Centralizar colunas específicas
            string[] colunasCentralizadas = { "DespesaID", "CategoriaID", "MetodoPgtoID", "NumeroParcelas" };
            foreach (var coluna in colunasCentralizadas)
            {
                if (dgvDespesa.Columns.Contains(coluna))
                {
                    dgvDespesa.Columns[coluna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

            // Ajuste do AutoSizeMode para evitar que a tabela fique muito apertada
            dgvDespesa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Definições das colunas
            if (dgvDespesa.Columns.Contains("DespesaID"))
            {
                dgvDespesa.Columns["DespesaID"].Visible = false; // Oculta a coluna
            }

            if (dgvDespesa.Columns.Contains("Descricao"))
            {
                dgvDespesa.Columns["Descricao"].HeaderText = "Descrição";
                dgvDespesa.Columns["Descricao"].Width = 350;
            }

            if (dgvDespesa.Columns.Contains("Valor"))
            {
                dgvDespesa.Columns["Valor"].HeaderText = "Valor";
                dgvDespesa.Columns["Valor"].Width = 80;
                dgvDespesa.Columns["Valor"].DefaultCellStyle.Format = "C2";
                dgvDespesa.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDespesa.Columns["Valor"].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;
            }

            if (dgvDespesa.Columns.Contains("DataVencimento"))
            {
                dgvDespesa.Columns["DataVencimento"].HeaderText = " Data\nVencto";
                dgvDespesa.Columns["DataVencimento"].Width = 80;
                dgvDespesa.Columns["DataVencimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dgvDespesa.Columns.Contains("Status"))
            {
                dgvDespesa.Columns["Status"].HeaderText = "Status";
                dgvDespesa.Columns["Status"].Width = 60;                
            }
            if (dgvDespesa.Columns.Contains("NumeroParcelas"))
            {
                dgvDespesa.Columns["NumeroParcelas"].HeaderText = "  Nº\nParc.";
                dgvDespesa.Columns["NumeroParcelas"].Width = 60;
            }
            if (dgvDespesa.Columns.Contains("ValorParcela"))
            {
                dgvDespesa.Columns["ValorParcela"].HeaderText = "  Valor \nParcela";
                dgvDespesa.Columns["ValorParcela"].Width = 80;
                dgvDespesa.Columns["ValorParcela"].DefaultCellStyle.Format = "C2";
                dgvDespesa.Columns["ValorParcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDespesa.Columns["ValorParcela"].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;
            }
            if (dgvDespesa.Columns.Contains("NomeCategoria"))
            {
                dgvDespesa.Columns["NomeCategoria"].HeaderText = "Categoria";
                dgvDespesa.Columns["NomeCategoria"].Width = 100;
            }
            if (dgvDespesa.Columns.Contains("CategoriaID"))
            {
                dgvDespesa.Columns["CategoriaID"].Visible = false; // Oculta a coluna
            }

            if (dgvDespesa.Columns.Contains("MetodoPgtoID"))
            {
                dgvDespesa.Columns["MetodoPgtoID"].Visible = false; // Oculta a coluna
            }
            if (dgvDespesa.Columns.Contains("DataCriacao"))
            {
                dgvDespesa.Columns["DataCriacao"].Visible = false; // Oculta a coluna
            }
            if (dgvDespesa.Columns.Contains("DataPgto"))
            {
                dgvDespesa.Columns["DataPgto"].HeaderText = " Data\nPagamento";
                dgvDespesa.Columns["DataPgto"].Width = 100;
                dgvDespesa.Columns["DataPgto"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            dgvDespesa.ReadOnly = true;
        }

        private void CarregarDados(string nomeTipo = null, bool? pago = null)
        {
            try
            {
                var tipos = despesasBLL.Pesquisar(nomeTipo, pago); // Passar o filtro de pagamento
                dgvDespesa.DataSource = null;
                dgvDespesa.DataSource = tipos;
                PersonalizarDataGridView(dgvDespesa);
                AtualizarTotais();
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
            CarregarDados(); // Chama o método de carregamento de dados
        }

        private void AtualizarTotais()
        {
            try
            {
                var despesas = dgvDespesa.DataSource as List<DespesasModel>;
                if (despesas != null)
                {
                    var despesasAbertas = despesas.Where(d => !d.Pago);
                    decimal valorTotalAberto = despesasAbertas.Sum(d => d.Valor);
                    int qtdItensPendentes = despesasAbertas.Count();
                                       
                    txtValorTotalAberto.Text = valorTotalAberto.ToString("C2", CultureInfo.CurrentCulture);
                    txtQtdItens.Text = qtdItensPendentes.ToString();
                }
                else
                {
                    txtValorTotalAberto.Text = "R$ 0,00";
                    txtQtdItens.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao calcular totais: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirFormularioCadastro()
        {
            FormCadastroDespesa form = new FormCadastroDespesa(StatusOperacao, this);

            try
            {
                switch (StatusOperacao)
                {
                    case "NOVO":
                        ConfigurarFormulario(form, "NOVO", true, "Salvar", true);
                        form.btnSalvar.BackColor = System.Drawing.Color.FromArgb(1, 128, 255);
                        form.panelTitulo.BackColor = System.Drawing.Color.FromArgb(1, 128, 255);                        
                        form.btnSalvar.ForeColor = System.Drawing.Color.White;
                        form.lblTitulo.Text = "Nova Despesa";
                        form.ShowDialog();
                        break;

                    case "ALTERAR":
                        PreencherCampos(form);
                        ConfigurarFormulario(form, "ALTERAR", true, "Alterar", true);
                        form.btnSalvar.BackColor = System.Drawing.Color.OrangeRed;
                        form.btnSalvar.ForeColor = System.Drawing.Color.White;
                        form.lblTitulo.Text = "Alterar Despesa";
                        form.panelTitulo.BackColor = System.Drawing.Color.OrangeRed;
                        form.btnNovo.Visible = false;                                                
                        form.dtpDataCadastro.Enabled = false;
                        form.ShowDialog();
                        break;

                    case "PAGAR":
                        PreencherCampos(form);
                        ConfigurarFormulario(form, "PAGAR", true, "Confirmar Pgto", true);
                        DesabilitarCampos(form);
                        form.btnSalvar.BackColor = System.Drawing.Color.RoyalBlue;
                        form.panelTitulo.BackColor = System.Drawing.Color.RoyalBlue;
                        form.btnSalvar.ForeColor = System.Drawing.Color.White;
                        form.lblDataCadastro_e_Pagamento.Text = "Data Pagamento";
                        form.lblTitulo.Text = "Pagar Despesa";
                        form.ShowDialog();
                        break;

                    case "EXCLUSÃO":
                        PreencherCampos(form);
                        ConfigurarFormulario(form, "EXCLUSÃO", true, "Excluir", true);
                        DesabilitarCampos(form);
                        form.btnSalvar.BackColor = System.Drawing.Color.Red;
                        form.panelTitulo.BackColor = System.Drawing.Color.Red;
                        form.btnSalvar.ForeColor = System.Drawing.Color.White;
                        form.lblTitulo.Text = "Excluir Despesa";
                        form.ShowDialog();
                        break;
                }
                if (form.Salvou)
                {
                    AtualizarDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                form.Dispose();
            }
        }

        private void PreencherCampos(FormCadastroDespesa form)
        {
            if (TipoAtual != null)
            {
                // Preenche os campos de texto e data
                form.txtDespesaID.Text = TipoAtual.DespesaID.ToString();
                form.txtDescricao.Text = TipoAtual.Descricao;
                form.txtValorTotal.Text = TipoAtual.Valor.ToString();
                form.dtpDataVencimento.Value = TipoAtual.DataVencimento;
                form.cmbStatus.SelectedItem = TipoAtual.Status;
                form.txtNumeroParcelas.Text = TipoAtual.NumeroParcelas.ToString();
                form.txtValorParcela.Text = TipoAtual.ValorParcela.ToString();
                
                
                form.CategoriaID = Convert.ToInt32(TipoAtual.CategoriaID);
                form.MetodoPgtoID = Convert.ToInt32(TipoAtual.MetodoPgtoID);

                int _categoriaID = Convert.ToInt32(TipoAtual.CategoriaID);                
                form.txtCategoria.Text = Utilitario.PesquisarPorCodigoExibirEmTexbox("Categorias", "CategoriaID", "NomeCategoria",_categoriaID);

                int _metodoPgtoID = Convert.ToInt32(TipoAtual.MetodoPgtoID);
                form.txtMetodoPgto.Text = Utilitario.PesquisarPorCodigoExibirEmTexbox("MetodosPagamento", "MetodoPgtoID", "NomeMetodoPagamento", _metodoPgtoID);

            }
        }

        public void ConfigurarFormulario(FormCadastroDespesa form, string operacao, bool camposHabilitados, string textoBotao, bool botaoHabilitado)
        {            
            form.StatusOperacao = operacao;
            form.btnSalvar.Text = textoBotao;
            form.btnSalvar.Enabled = botaoHabilitado;
        }

        private void DesabilitarCampos(FormCadastroDespesa form)
        {
            form.txtDespesaID.Enabled = false;
            form.txtDescricao.Enabled = false;
            form.txtValorTotal.Enabled = false;
            form.dtpDataVencimento.Enabled = false;
            form.cmbStatus.Enabled = false;
            form.txtNumeroParcelas.Enabled = false;
            form.txtValorParcela.Enabled = false;
            form.txtCategoria.Enabled = false;
            form.txtMetodoPgto.Enabled = false;            
            form.btnNovo.Visible = false;
            form.btnLocalizarCategoria.Enabled = false;
            form.btnLocalizarMetodoPagamento.Enabled = false;
            form.groupBoxParcelar.Enabled = false;
        }


        private void FormCadastroTiposReceita_Load(object sender, EventArgs e)
        {
            radioPendentes.Checked = true; // Define Pendentes como padrão
            CarregarDados(); // Carrega os dados iniciais
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            StatusOperacao = "NOVO";
            CarregarDados();
            AbrirFormularioCadastro(); // Chama diretamente o formulário sem recarregar dados
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (TipoAtual == null)
            {
                MessageBox.Show("Selecione um tipo para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StatusOperacao = "ALTERAR";
            AbrirFormularioCadastro(); // Chama diretamente o formulário sem recarregar dados
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Relatório Despesas");
                var data = dgvDespesa.DataSource as List<DespesasModel>;
                if (data != null)
                {
                    worksheet.Cell(1, 1).InsertTable(data);
                    worksheet.Columns().AdjustToContents();
                }
                workbook.SaveAs("RelatorioDespesas.xlsx");
            }
            MessageBox.Show("Relatório exportado para Excel!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Verifica se há pelo menos uma linha selecionada
            if (dgvDespesa.SelectedRows.Count == 0) // Substitua "dataGridView1" pelo nome real do seu DataGridView
            {
                MessageBox.Show("Selecione pelo menos um registro para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se apenas uma linha estiver selecionada ou se o usuário escolher excluir apenas uma
            if (dgvDespesa.SelectedRows.Count == 1 ||
                MessageBox.Show("Deseja excluir apenas o registro atual?",
                                "Excluir Despesas",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1,
                                0,
                                "Único",
                                "Todos") == DialogResult.Yes)
            {
                if (TipoAtual == null)
                {
                    MessageBox.Show("Selecione um tipo para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                StatusOperacao = "EXCLUSÃO";
                AbrirFormularioCadastro(); // Mantém o fluxo atual para excluir um único registro
            }
            else // Excluir todos os selecionados
            {
                int numeroSelecionados = dgvDespesa.SelectedRows.Count;
                if (MessageBox.Show($"Deseja realmente excluir todos os {numeroSelecionados} registros selecionados?",
                                    "Confirmação de Exclusão",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        DespesasBLL objetoBll = new DespesasBLL(); // Instancie sua BLL aqui
                        foreach (DataGridViewRow row in dgvDespesa.SelectedRows)
                        {
                            int despesaId = Convert.ToInt32(row.Cells["DespesaID"].Value); // Substitua "DespesaID" pelo nome real da coluna
                            objetoBll.Excluir(despesaId);
                        }
                        MessageBox.Show($"{numeroSelecionados} despesas excluídas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarDataGrid(); // Atualiza o DataGrid após a exclusão
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir os registros: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            bool? pago = null; // null significa "sem filtro" por padrão
            if (radioPagas.Checked)
            {
                pago = true; // Filtrar por despesas pagas
            }
            else if (radioPendentes.Checked)
            {
                pago = false; // Filtrar por despesas pendentes
            }
            CarregarDados(txtPesquisa.Text, pago); // Passa o texto da pesquisa e o filtro de pago
        }

        private void btnPagarConta_Click(object sender, EventArgs e)
        {
            if (TipoAtual == null)
            {
                MessageBox.Show("Selecione um tipo para Pagar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StatusOperacao = "PAGAR";
            AbrirFormularioCadastro(); // Chama diretamente o formulário sem recarregar dados
        }

        private void radioPagas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPagas.Checked)
            {
                CarregarDados(txtPesquisa.Text, true); // Exibir apenas pagas
            }
        }

        private void radioPendentes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPendentes.Checked)
            {
                CarregarDados(txtPesquisa.Text, false); // Exibir apenas pendentes
            }
        }

        private void dgvDespesa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDespesa.Columns[e.ColumnIndex].Name == "DataVencimento")
            {
                if (e.Value != null && DateTime.TryParse(e.Value.ToString(), out DateTime dataVencimento))
                {
                    DateTime hoje = DateTime.Today;

                    if (dataVencimento < hoje) // Vencidas
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.Red;
                        e.CellStyle.ForeColor = System.Drawing.Color.White;
                    }
                    else if (dataVencimento.Date == hoje) // Vence hoje
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.Orange;
                        e.CellStyle.ForeColor = System.Drawing.Color.White;
                    }
                    else // Não vencidas (futuras)
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.LightGreen;
                        e.CellStyle.ForeColor = System.Drawing.Color.Black;
                    }
                }
            }
        }

        private void dgvDespesa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDespesa.SelectedRows.Count > 0)
            {
                TipoAtual = dgvDespesa.SelectedRows[0].DataBoundItem as DespesasModel;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnExcel.Enabled = true;
                btnPagarConta.Enabled = true;
            }
            else
            {
                TipoAtual = null;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnExcel.Enabled = false;
                btnPagarConta.Enabled = false;
            }
        }
    }
}

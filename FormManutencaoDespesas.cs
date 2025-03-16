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
            dgvDespesas.SelectionChanged += dgvTiposReceita_SelectionChanged; // Associe o evento aqui
        }


        public void PersonalizarDataGridView(KryptonDataGridView dgvDespesas)
        {
            if (dgvDespesas.Columns.Count == 0)
            {
                MessageBox.Show("Nenhuma coluna disponível no DataGridView de despesas.");
                return;
            }

            dgvDespesas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            if (dgvDespesas.Columns.Contains("DespesaID"))
            {
                dgvDespesas.Columns["DespesaID"].HeaderText = "Código";
                dgvDespesas.Columns["DespesaID"].Width = 100;
                dgvDespesas.Columns["DespesaID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDespesas.Columns["DespesaID"].DefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Italic);
                dgvDespesas.Columns["DespesaID"].DefaultCellStyle.ForeColor = Color.DarkGreen;
                dgvDespesas.Columns["DespesaID"].DefaultCellStyle.BackColor = Color.LightBlue;
            }

            if (dgvDespesas.Columns.Contains("Descricao"))
            {
                dgvDespesas.Columns["Descricao"].HeaderText = "Descrição";
                dgvDespesas.Columns["Descricao"].Width = 400;
            }

            if (dgvDespesas.Columns.Contains("Valor"))
            {
                dgvDespesas.Columns["Valor"].HeaderText = "Valor";
                dgvDespesas.Columns["Valor"].Width = 120;
                dgvDespesas.Columns["Valor"].DefaultCellStyle.Format = "C2";
            }

            if (dgvDespesas.Columns.Contains("DataVencimento"))
            {
                dgvDespesas.Columns["DataVencimento"].HeaderText = "Data Vencimento";
                dgvDespesas.Columns["DataVencimento"].Width = 120;
                dgvDespesas.Columns["DataVencimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvDespesas.Columns.Contains("Status"))
            {
                dgvDespesas.Columns["Status"].HeaderText = "Status";
                dgvDespesas.Columns["Status"].Width = 100;
            }

            if (dgvDespesas.Columns.Contains("NumeroParcelas"))
            {
                dgvDespesas.Columns["NumeroParcelas"].HeaderText = "Nº Parcelas";
                dgvDespesas.Columns["NumeroParcelas"].Width = 100;
            }

            if (dgvDespesas.Columns.Contains("ValorParcela"))
            {
                dgvDespesas.Columns["ValorParcela"].HeaderText = "Valor Parcela";
                dgvDespesas.Columns["ValorParcela"].Width = 120;
                dgvDespesas.Columns["ValorParcela"].DefaultCellStyle.Format = "C2";
            }

            if (dgvDespesas.Columns.Contains("CategoriaID"))
            {
                dgvDespesas.Columns["CategoriaID"].HeaderText = "Categoria ID";
                dgvDespesas.Columns["CategoriaID"].Width = 100;
            }

            if (dgvDespesas.Columns.Contains("MetodoPgtoID"))
            {
                dgvDespesas.Columns["MetodoPgtoID"].HeaderText = "Método Pgto ID";
                dgvDespesas.Columns["MetodoPgtoID"].Width = 100;
            }

            if (dgvDespesas.Columns.Contains("Pago"))
            {
                dgvDespesas.Columns["Pago"].HeaderText = "Pago";
                dgvDespesas.Columns["Pago"].Width = 80;
            }

            if (dgvDespesas.Columns.Contains("DataCriacao"))
            {
                dgvDespesas.Columns["DataCriacao"].HeaderText = "Data Criação";
                dgvDespesas.Columns["DataCriacao"].Width = 120;
                dgvDespesas.Columns["DataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            dgvDespesas.ReadOnly = true;
        }

        private void CarregarDados(string nomeTipo = null)
        {
            try
            {
                var tipos = despesasBLL.Pesquisar(nomeTipo);
                dgvDespesas.DataSource = null;
                dgvDespesas.DataSource = tipos;
                // Não chamar ClearSelection() aqui para preservar a seleção quando necessário               
                PersonalizarDataGridView(dgvDespesas);
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
                var despesas = dgvDespesas.DataSource as List<DespesasModel>;
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
                        form.btnSalvar.BackColor = Color.FromArgb(1, 128, 255);
                        form.panelTitulo.BackColor = Color.FromArgb(1, 128, 255);                        
                        form.btnSalvar.ForeColor = Color.White;
                        form.lblTitulo.Text = "Nova Despesa";
                        form.ShowDialog();
                        break;

                    case "ALTERAR":
                        PreencherCampos(form);
                        ConfigurarFormulario(form, "ALTERAR", true, "Alterar", true);
                        form.btnSalvar.BackColor = Color.OrangeRed;
                        form.btnSalvar.ForeColor = Color.White;
                        form.lblTitulo.Text = "Alterar Despesa";
                        form.panelTitulo.BackColor = Color.OrangeRed;
                        form.ShowDialog();
                        break;

                    case "PAGAR":
                        PreencherCampos(form);
                        ConfigurarFormulario(form, "PAGAR", true, "Pagar", true);
                        DesabilitarCampos(form);
                        form.btnSalvar.BackColor = Color.RoyalBlue;
                        form.panelTitulo.BackColor = Color.RoyalBlue;
                        form.btnSalvar.ForeColor = Color.White;
                        form.lblDataCadastro_e_Pagamento.Text = "Data Pagamento";
                        form.lblTitulo.Text = "Pagar Despesa";
                        form.ShowDialog();
                        break;

                    case "EXCLUSÃO":
                        PreencherCampos(form);
                        ConfigurarFormulario(form, "EXCLUSÃO", true, "Excluir", true);
                        DesabilitarCampos(form);
                        form.btnSalvar.BackColor = Color.Red;
                        form.panelTitulo.BackColor = Color.Red;
                        form.btnSalvar.ForeColor = Color.White;
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
            btnNovo.Enabled = false;
        }


        private void FormCadastroTiposReceita_Load(object sender, EventArgs e)
        {           
            CarregarDados(); // Carrega os dados ao abrir o formulário
        }

        private void dgvTiposReceita_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDespesas.SelectedRows.Count > 0)
            {
                TipoAtual = dgvDespesas.SelectedRows[0].DataBoundItem as DespesasModel;
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

        private void dgvDespesas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
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
                var data = dgvDespesas.DataSource as List<DespesasModel>;
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
            if (TipoAtual == null)
            {
                MessageBox.Show("Selecione um tipo para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StatusOperacao = "EXCLUSÃO";
            AbrirFormularioCadastro(); // Chama diretamente o formulário sem recarregar dados
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarDados(txtPesquisa.Text);
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
    }
}

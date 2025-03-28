





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
using Money.MODEL;
using Color = System.Drawing.Color;
using View = System.Windows.Forms.View;
using System.Runtime.InteropServices;

namespace Money
{
    public partial class FormManutencaoDespesas : KryptonForm
    {
        private DespesasModel TipoAtual { get; set; }
        private readonly DespesasBLL despesasBLL = new DespesasBLL();
        private readonly ParcelasBLL parcelasBLL = new ParcelasBLL(); // Adicionado para acessar parcelas
        private string StatusOperacao;

        public FormManutencaoDespesas(string statusOperacao = "CONSULTA")
        {
            InitializeComponent();
            StatusOperacao = statusOperacao;

            radioPagas.CheckedChanged += radioPagas_CheckedChanged;
            radioPendentes.CheckedChanged += radioPendentes_CheckedChanged;
            Utilitario.AdicionarEfeitoFocoEmTodos(this);

            AtualizarListView();
            lstvDespesas.SelectedIndexChanged += lstvDespesas_SelectedIndexChanged;
        }

        private void PersonalizarListView(ListView lstvDespesas)
        {
            lstvDespesas.View = View.Details;
            lstvDespesas.FullRowSelect = true;
            lstvDespesas.GridLines = true;

            lstvDespesas.BackColor = Color.FromArgb(0, 33, 71);
            lstvDespesas.ForeColor = Color.White;

            lstvDespesas.HeaderStyle = ColumnHeaderStyle.Clickable;
            lstvDespesas.OwnerDraw = false;

            lstvDespesas.Columns.Clear();
            lstvDespesas.Columns.Add("DespesaID", 0); // Oculta
            lstvDespesas.Columns.Add("Descrição", 400);
            lstvDespesas.Columns.Add("Valor Total", 100, HorizontalAlignment.Right);
            lstvDespesas.Columns.Add("Data Compra", 100, HorizontalAlignment.Center);
            lstvDespesas.Columns.Add("Categoria", 100);
            lstvDespesas.Columns.Add("Método Pgto", 100);
            lstvDespesas.Columns.Add("Nº Parcelas", 80, HorizontalAlignment.Center);
            lstvDespesas.Columns.Add("Data Vencto", 100, HorizontalAlignment.Center);
            lstvDespesas.Columns.Add("Valor Parcela", 100, HorizontalAlignment.Right);
            lstvDespesas.Columns.Add("Pago", 50, HorizontalAlignment.Center);
            lstvDespesas.Columns.Add("Data Pgto", 100, HorizontalAlignment.Center);

            ApplyHeaderBackgroundColor(lstvDespesas, Color.FromArgb(0, 120, 215));
        }

        private void CarregarDados(string nomeTipo = null, bool? pago = null)
        {
            try
            {
                lstvDespesas.BeginUpdate();
                lstvDespesas.Items.Clear();
                PersonalizarListView(lstvDespesas);

                var despesas = despesasBLL.Pesquisar(nomeTipo);
                var parcelas = parcelasBLL.Pesquisar();
                DateTime hoje = DateTime.Today;

                foreach (var despesa in despesas)
                {
                    var parcelasDespesa = parcelas.Where(p => p.DespesaID == despesa.DespesaID).ToList();
                    foreach (var parcela in parcelasDespesa)
                    {
                        if (pago.HasValue && parcela.Pago != pago.Value) continue;

                        var item = new ListViewItem(new[] {
                            despesa.DespesaID.ToString(),
                            despesa.Descricao,
                            despesa.ValorDaCompra.ToString("C2", CultureInfo.CurrentCulture),
                            despesa.DataCriacao.ToString("dd/MM/yyyy"),
                            despesa.NomeCategoria ?? "",
                            Utilitario.PesquisarPorCodigoExibirEmTexbox("MetodosPagamento", "MetodoPgtoID", "NomeMetodoPagamento", despesa.MetodoPgtoID ?? 0),
                            $"{parcela.NumeroParcela}/{parcelasDespesa.Count}",
                            parcela.DataVencimento.ToString("dd/MM/yyyy"),
                            parcela.ValorParcela.ToString("C2", CultureInfo.CurrentCulture),
                            parcela.Pago ? "Sim" : "Não",
                            parcela.DataPagamento?.ToString("dd/MM/yyyy") ?? ""
                        });

                        item.Tag = new { Despesa = despesa, Parcela = parcela };

                        item.UseItemStyleForSubItems = false;
                        item.BackColor = lstvDespesas.Items.Count % 2 == 0 ? Color.FromArgb(0, 33, 71) : Color.FromArgb(70, 70, 70);
                        item.ForeColor = Color.White;

                        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                        {
                            subItem.BackColor = item.BackColor;
                            subItem.ForeColor = Color.White;
                        }

                        if (parcela.DataVencimento < hoje && !parcela.Pago)
                            item.SubItems[7].BackColor = Color.Red;
                        else if (parcela.DataVencimento.Date == hoje && !parcela.Pago)
                            item.SubItems[7].BackColor = Color.Orange;
                        else if (!parcela.Pago)
                            item.SubItems[7].BackColor = Color.Green;

                        item.SubItems[8].BackColor = Color.FromArgb(255, 245, 220);
                        item.SubItems[8].ForeColor = Color.DarkRed;

                        lstvDespesas.Items.Add(item);
                    }
                }

                lstvDespesas.EndUpdate();
                AtualizarTotais(parcelas.Where(p => despesas.Any(d => d.DespesaID == p.DespesaID)).ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private const int LVM_SETBKCOLOR = 0x1001;
        private const int HDM_SETBKCOLOR = 0x1204;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        private void ApplyHeaderBackgroundColor(ListView listView, Color color)
        {
            IntPtr header = SendMessage(listView.Handle, 0x1200, IntPtr.Zero, IntPtr.Zero);
            if (header != IntPtr.Zero)
            {
                int colorRef = ColorTranslator.ToWin32(color);
                SendMessage(header, HDM_SETBKCOLOR, IntPtr.Zero, (IntPtr)colorRef);
                listView.Refresh();
            }
        }

        private void AtualizarTotais(List<ParcelasModel> parcelas)
        {
            try
            {
                if (parcelas != null)
                {
                    var parcelasAbertas = parcelas.Where(p => !p.Pago);
                    decimal valorTotalAberto = parcelasAbertas.Sum(p => p.ValorParcela);
                    int qtdItensPendentes = parcelasAbertas.Count();

                    txtValorTotalAberto.Text = valorTotalAberto.ToString("N2", CultureInfo.CurrentCulture);
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

        public void AtualizarListView()
        {
            CarregarDados();
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
            CarregarDados();
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
                        form.btnNovo.Visible = false;
                        form.dtpDataCadastro.Enabled = false;
                        form.ShowDialog();
                        break;

                    case "PAGAR":
                        PreencherCampos(form);
                        ConfigurarFormulario(form, "PAGAR", true, "Confirmar Pgto", true);
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
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var parcelaAtual = (lstvDespesas.SelectedItems[0].Tag as dynamic)?.Parcela as ParcelasModel;

                form.txtDespesaID.Text = TipoAtual.DespesaID.ToString();
                form.txtDescricao.Text = TipoAtual.Descricao;
                form.txtValorTotal.Text = TipoAtual.ValorDaCompra.ToString("N2", CultureInfo.CurrentCulture);
                form.dtpDataCadastro.Value = TipoAtual.DataCriacao;
                form.CategoriaID = TipoAtual.CategoriaID ?? 0;
                form.MetodoPgtoID = TipoAtual.MetodoPgtoID ?? 0;

                if (parcelaAtual != null)
                {
                    form.txtNumeroParcelas.Text = $"{parcelaAtual.NumeroParcela}/{parcelasBLL.Pesquisar(TipoAtual.DespesaID).Count}";
                    form.txtValorParcela.Text = parcelaAtual.ValorParcela.ToString("N2", CultureInfo.CurrentCulture);
                    form.dtpDataVencimento.Value = parcelaAtual.DataVencimento;
                    form.radiobtnPago.Checked = parcelaAtual.Pago;
                    form.radiobtnPendente.Checked = !parcelaAtual.Pago;
                }

                form.txtCategoria.Text = Utilitario.PesquisarPorCodigoExibirEmTexbox("Categorias", "CategoriaID", "NomeCategoria", form.CategoriaID);
                form.txtMetodoPgto.Text = Utilitario.PesquisarPorCodigoExibirEmTexbox("MetodosPagamento", "MetodoPgtoID", "NomeMetodoPagamento", form.MetodoPgtoID);
            }
        }

        private void lstvDespesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvDespesas.SelectedItems.Count > 0)
            {
                var selectedItem = lstvDespesas.SelectedItems[0];
                var data = selectedItem.Tag as dynamic;
                TipoAtual = data.Despesa as DespesasModel;

                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnExcel.Enabled = true;
                btnPagarConta.Enabled = !data.Parcela.Pago; // Desabilita se já pago
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

        public void ConfigurarFormulario(FormCadastroDespesa form, string operacao, bool camposHabilitados, string textoBotao, bool botaoHabilitado)
        {
            form.StatusOperacao = operacao;
            form.btnSalvar.Text = textoBotao;
            form.btnSalvar.Enabled = botaoHabilitado;
        }

        private void FormManutencaoDespesas_Load(object sender, EventArgs e)
        {
            radioPendentes.Checked = true;
            CarregarDados();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            StatusOperacao = "NOVO";
            AbrirFormularioCadastro();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (TipoAtual == null)
            {
                MessageBox.Show("Selecione uma despesa para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StatusOperacao = "ALTERAR";
            AbrirFormularioCadastro();
        }

        private void DesabilitarCampos(FormCadastroDespesa form)
        {
            form.txtDespesaID.Enabled = false;
            form.txtDescricao.Enabled = false;
            form.txtValorTotal.Enabled = false;
            form.dtpDataVencimento.Enabled = false;
            form.txtNumeroParcelas.Enabled = false;
            form.txtValorParcela.Enabled = false;
            form.txtCategoria.Enabled = false;
            form.txtMetodoPgto.Enabled = false;
            form.btnNovo.Visible = false;
            form.btnLocalizarCategoria.Enabled = false;
            form.btnLocalizarMetodoPagamento.Enabled = false;
            form.groupBoxParcelar.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // Código para exportar para Excel (mantido como está, mas pode ser ajustado se necessário)
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lstvDespesas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um registro para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lstvDespesas.SelectedItems.Count == 1 || 
                MessageBox.Show("Deseja excluir apenas o registro atual?", "Excluir Despesas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (TipoAtual == null)
                {
                    MessageBox.Show("Selecione uma despesa para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                StatusOperacao = "EXCLUSÃO";
                AbrirFormularioCadastro();
            }
            else
            {
                int numeroSelecionados = lstvDespesas.SelectedItems.Count;
                if (MessageBox.Show($"Deseja realmente excluir todos os {numeroSelecionados} registros selecionados?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        foreach (ListViewItem item in lstvDespesas.SelectedItems)
                        {
                            int despesaId = Convert.ToInt32(item.SubItems[0].Text);
                            despesasBLL.Excluir(despesaId);
                        }
                        MessageBox.Show($"{numeroSelecionados} despesas excluídas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarListView();
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
            bool? pago = null;
            if (radioPagas.Checked)
                pago = true;
            else if (radioPendentes.Checked)
                pago = false;
            CarregarDados(txtPesquisa.Text, pago);
        }

        private void btnPagarConta_Click(object sender, EventArgs e)
        {
            if (TipoAtual == null)
            {
                MessageBox.Show("Selecione uma despesa para pagar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StatusOperacao = "PAGAR";
            AbrirFormularioCadastro();
        }

        private void radioPagas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPagas.Checked)
                CarregarDados(txtPesquisa.Text, true);
        }

        private void radioPendentes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPendentes.Checked)
                CarregarDados(txtPesquisa.Text, false);
        }
    }
}
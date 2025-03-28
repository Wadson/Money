












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

namespace Money
{
    public partial class FormCadastroDespesa : KryptonForm
    {
        private readonly DespesasBLL objetoBll = new DespesasBLL();
        private readonly PagamentosBLL pagamentosBll = new PagamentosBLL();
        private readonly ParcelasBLL parcelasBll = new ParcelasBLL(); // Adicionado para manipular parcelas
        public string StatusOperacao { get; set; }
        private string QueryDespesa = "SELECT MAX(DespesaID) FROM Despesas";
        public bool Salvou { get; private set; } = false;
        private readonly FormManutencaoDespesas _formPai;
        public int DespesaID { get; set; }
        public List<ParcelasModel> ParcelasGeradas { get; set; } = new List<ParcelasModel>(); // Alterado para ParcelasModel
        public int CategoriaID { get; set; }
        public int MetodoPgtoID { get; set; }
        private bool bloqueiaPesquisa = false;
        private bool bloqueiaEventosTextChanged = false;

        public FormCadastroDespesa(string statusOperacao, FormManutencaoDespesas formPai)
        {
            InitializeComponent();
            StatusOperacao = statusOperacao;
            Utilitario.AdicionarEfeitoFocoEmTodos(this);
            _formPai = formPai;

            if (StatusOperacao == "ALTERAR" || StatusOperacao == "EXCLUSÃO" || StatusOperacao == "PAGAR")
            {
                txtCategoria.TextChanged -= txtCategoria_TextChanged;
                txtMetodoPgto.TextChanged -= txtMetodoPgto_TextChanged;
            }

            radiobtnNao.CheckedChanged += radiobtnNao_CheckedChanged;
            radiobtnSim.CheckedChanged += radiobtnSim_CheckedChanged;
            ConfigurarFormularioInicial();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (StatusOperacao == "ALTERAR" || StatusOperacao == "EXCLUSÃO" || StatusOperacao == "PAGAR")
            {
                txtCategoria.TextChanged += txtCategoria_TextChanged;
                txtMetodoPgto.TextChanged += txtMetodoPgto_TextChanged;
            }
            base.OnFormClosing(e);
        }

        private void ConfigurarFormularioInicial()
        {
            if (StatusOperacao == "NOVO")
            {
                int codigo = Utilitario.GerarProximoCodigo(QueryDespesa);
                txtDespesaID.Text = Utilitario.AcrescentarZerosEsquerda(codigo, 5);
                bloqueiaEventosTextChanged = false;
            }
            else if (StatusOperacao == "ALTERAR" || StatusOperacao == "EXCLUSÃO" || StatusOperacao == "PAGAR")
            {
                bloqueiaEventosTextChanged = true;
            }
            btnParcelar.Enabled = false;
        }

        private void FormCadastroDespesa_Load(object sender, EventArgs e)
        {
            if (StatusOperacao == "NOVO")
            {
                int codigo = Utilitario.GerarProximoCodigo(QueryDespesa);
                txtDespesaID.Text = Utilitario.AcrescentarZerosEsquerda(codigo, 5);
                btnLocalizarCategoria.Enabled = false;
                btnLocalizarMetodoPagamento.Enabled = false;
            }
        }

        private void FormCadastroDespesa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtValorTotal_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtValorTotal.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal valorTotal))
            {
                txtValorTotal.Text = valorTotal.ToString("N2", CultureInfo.CurrentCulture);
                CalcularValorParcela();
            }
            else if (!string.IsNullOrWhiteSpace(txtValorTotal.Text))
            {
                MessageBox.Show("Valor total inválido! Digite um número válido.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorTotal.Focus();
            }
        }

        private void CalcularValorParcela()
        {
            if (decimal.TryParse(txtValorTotal.Text, out decimal valorTotal) && !string.IsNullOrWhiteSpace(txtNumeroParcelas.Text))
            {
                string numeroParcelasText = txtNumeroParcelas.Text.Trim();
                int totalParcelas;

                if (numeroParcelasText.Contains("/"))
                {
                    string[] partes = numeroParcelasText.Split('/');
                    if (partes.Length == 2 && int.TryParse(partes[1], out totalParcelas) && totalParcelas > 0)
                    {
                        decimal valorParcela = valorTotal / totalParcelas;
                        txtValorParcela.Text = valorParcela.ToString("F2", CultureInfo.CurrentCulture);
                    }
                    else
                    {
                        txtValorParcela.Text = valorTotal.ToString("F2", CultureInfo.CurrentCulture);
                    }
                }
                else if (int.TryParse(numeroParcelasText, out totalParcelas) && totalParcelas > 0)
                {
                    decimal valorParcela = valorTotal / totalParcelas;
                    txtValorParcela.Text = valorParcela.ToString("F2", CultureInfo.CurrentCulture);
                }
                else
                {
                    txtValorParcela.Text = valorTotal.ToString("F2", CultureInfo.CurrentCulture);
                }
            }
            else
            {
                txtValorParcela.Text = txtValorTotal.Text;
            }
        }

        private void Parcelamento()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDescricao.Text) || string.IsNullOrWhiteSpace(txtValorTotal.Text))
                {
                    MessageBox.Show("Preencha a descrição e o valor antes de gerar parcelas!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string numeroParcelasTexto = txtNumeroParcelas.Text.Trim();
                int numeroParcelas;

                if (numeroParcelasTexto.Contains("/"))
                {
                    string[] partes = numeroParcelasTexto.Split('/');
                    if (partes.Length != 2 || !int.TryParse(partes[1], out numeroParcelas) || numeroParcelas <= 0)
                    {
                        MessageBox.Show("O número total de parcelas (à direita do '/') deve ser maior que zero!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (!int.TryParse(numeroParcelasTexto, out numeroParcelas) || numeroParcelas <= 0)
                {
                    MessageBox.Show("O número de parcelas deve ser maior que zero!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal valorTotal = decimal.Parse(txtValorTotal.Text, CultureInfo.CurrentCulture);

                var frmGerarParcelas = new FormGerarParcelas(
                    txtDescricao.Text.Trim(),
                    valorTotal,
                    dtpDataVencimento.Value,
                    numeroParcelasTexto
                );

                if (frmGerarParcelas.ShowDialog() == DialogResult.OK)
                {
                    ParcelasGeradas = frmGerarParcelas.Parcelas.Select(p => new ParcelasModel
                    {
                        NumeroParcela = int.Parse(p.NumeroParcelas.Split('/')[0]),
                        ValorParcela = p.ValorParcela ?? 0m,
                        DataVencimento = p.DataVencimento,
                        Pago = false,
                        DataPagamento = null
                    }).ToList();

                    if (ParcelasGeradas.Count > 0)
                    {
                        txtNumeroParcelas.Text = $"{ParcelasGeradas.Count}/{ParcelasGeradas.Count}";
                        txtValorParcela.Text = ParcelasGeradas.First().ValorParcela.ToString("N2", CultureInfo.CurrentCulture);
                        MessageBox.Show($"{ParcelasGeradas.Count} parcelas geradas com sucesso! Clique em 'Salvar' para persistir.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar parcelas: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumeroParcelas_Leave(object sender, EventArgs e)
        {
            CalcularValorParcela();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Utilitario.LimpaCampoKrypton(this);
            txtNumeroParcelas.Text = "1";
            int novoCodigo = Utilitario.GerarProximoCodigo(QueryDespesa);
            txtDespesaID.Text = Utilitario.AcrescentarZerosEsquerda(novoCodigo, 5);
        }

        private void Salvar()
        {
            try
            {
                if (StatusOperacao != "EXCLUSÃO" && StatusOperacao != "PAGAR")
                {
                    if (string.IsNullOrWhiteSpace(txtDescricao.Text))
                        throw new Exception("A descrição é obrigatória.");
                    if (!decimal.TryParse(txtValorTotal.Text, out decimal valorTotal))
                        throw new Exception("O valor total deve ser um número válido.");
                    if (string.IsNullOrWhiteSpace(txtMetodoPgto.Text))
                        throw new Exception("Selecione um método de pagamento.");
                    if (string.IsNullOrWhiteSpace(txtCategoria.Text))
                        throw new Exception("Selecione uma categoria.");
                    if (CategoriaID <= 0)
                        throw new Exception("O Código CategoriaID está vazio ou não é válido.");
                    if (MetodoPgtoID <= 0)
                        throw new Exception("O Código MetodoPgtoID está vazio ou não é válido.");
                }

                if (ParcelasGeradas.Count > 0)
                {
                    var despesa = new DespesasModel
                    {
                        DespesaID = int.Parse(txtDespesaID.Text),
                        Descricao = txtDescricao.Text,
                        ValorDaCompra = decimal.Parse(txtValorTotal.Text),
                        CategoriaID = CategoriaID,
                        MetodoPgtoID = MetodoPgtoID,
                        DataCriacao = dtpDataCadastro.Value
                    };
                    objetoBll.Salvar(despesa);

                    foreach (var parcela in ParcelasGeradas)
                    {
                        parcela.DespesaID = despesa.DespesaID;
                        parcelasBll.Salvar(parcela);
                    }

                    MessageBox.Show($"{ParcelasGeradas.Count} parcelas salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Salvou = true;
                    _formPai.AtualizarDataGrid();
                    Utilitario.LimpaCampoKrypton(this);
                    int codigo = Utilitario.GerarProximoCodigo(QueryDespesa);
                    txtDespesaID.Text = Utilitario.AcrescentarZerosEsquerda(codigo, 5);
                    txtNumeroParcelas.Text = "1";
                    ParcelasGeradas.Clear();
                }
                else
                {
                    switch (StatusOperacao)
                    {
                        case "NOVO":
                            var despesaNovo = new DespesasModel
                            {
                                DespesaID = int.Parse(txtDespesaID.Text),
                                Descricao = txtDescricao.Text,
                                ValorDaCompra = decimal.Parse(txtValorTotal.Text),
                                CategoriaID = CategoriaID,
                                MetodoPgtoID = MetodoPgtoID,
                                DataCriacao = dtpDataCadastro.Value
                            };
                            objetoBll.Salvar(despesaNovo);

                            var parcelaUnica = new ParcelasModel
                            {
                                DespesaID = despesaNovo.DespesaID,
                                NumeroParcela = 1,
                                ValorParcela = despesaNovo.ValorDaCompra,
                                DataVencimento = dtpDataVencimento.Value,
                                Pago = radiobtnPago.Checked,
                                DataPagamento = radiobtnPago.Checked ? dtpDataCadastro.Value : (DateTime?)null
                            };
                            parcelasBll.Salvar(parcelaUnica);

                            MessageBox.Show("Despesa salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Salvou = true;
                            _formPai.AtualizarDataGrid();
                            Utilitario.LimpaCampoKrypton(this);
                            txtNumeroParcelas.Text = "1";
                            int codigoNovo = Utilitario.GerarProximoCodigo(QueryDespesa);
                            txtDespesaID.Text = Utilitario.AcrescentarZerosEsquerda(codigoNovo, 5);
                            break;

                        case "ALTERAR":
                            var despesaAlterar = new DespesasModel
                            {
                                DespesaID = int.Parse(txtDespesaID.Text),
                                Descricao = txtDescricao.Text,
                                ValorDaCompra = decimal.Parse(txtValorTotal.Text),
                                CategoriaID = CategoriaID,
                                MetodoPgtoID = MetodoPgtoID,
                                DataCriacao = dtpDataCadastro.Value
                            };
                            objetoBll.Alterar(despesaAlterar);
                            MessageBox.Show("Despesa alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Salvou = true;
                            _formPai.AtualizarDataGrid();
                            this.Close();
                            break;

                        case "PAGAR":
                            if (MessageBox.Show("Deseja realmente pagar esta conta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                var parcelaPagar = parcelasBll.Pesquisar(int.Parse(txtDespesaID.Text)).FirstOrDefault();
                                if (parcelaPagar != null)
                                {
                                    parcelaPagar.Pago = true;
                                    parcelaPagar.DataPagamento = dtpDataCadastro.Value;
                                    parcelasBll.Alterar(parcelaPagar);
                                    MessageBox.Show("Conta paga com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Salvou = true;
                                    _formPai.AtualizarDataGrid();
                                    this.Close();
                                }
                            }
                            break;

                        case "EXCLUSÃO":
                            if (MessageBox.Show("Deseja realmente excluir esta despesa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                int despesaId = int.Parse(txtDespesaID.Text);
                                objetoBll.Excluir(despesaId);
                                MessageBox.Show("Despesa excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Salvou = true;
                                _formPai.AtualizarDataGrid();
                                this.Close();
                            }
                            break;

                        default:
                            throw new Exception("Operação inválida.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnLocalizarCategoria_Click(object sender, EventArgs e)
        {
            using (FormLocalizarCategoria pesquisaCategoria = new FormLocalizarCategoria(this, txtCategoria.Text))
            {
                pesquisaCategoria.Owner = this;
                if (pesquisaCategoria.ShowDialog() == DialogResult.OK)
                {
                    txtCategoria.Text = pesquisaCategoria.categoriaSelecionado;
                }
            }
            Task.Delay(100).ContinueWith(t => Invoke(new Action(() => bloqueiaPesquisa = false)));
        }

        private void btnLocalizarMetodoPagamento_Click(object sender, EventArgs e)
        {
            using (FormLocalizarMetodoPagamento pesquisaMetodoPgto = new FormLocalizarMetodoPagamento(this, txtMetodoPgto.Text))
            {
                pesquisaMetodoPgto.Owner = this;
                if (pesquisaMetodoPgto.ShowDialog() == DialogResult.OK)
                {
                    txtMetodoPgto.Text = pesquisaMetodoPgto.MetodoPgtoSelecionado;
                }
            }
            Task.Delay(100).ContinueWith(t => Invoke(new Action(() => bloqueiaPesquisa = false)));
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            if (bloqueiaPesquisa || bloqueiaEventosTextChanged || string.IsNullOrEmpty(txtCategoria.Text))
                return;

            bloqueiaPesquisa = true;
            using (FormLocalizarCategoria pesquisaCategoria = new FormLocalizarCategoria(this, txtCategoria.Text))
            {
                pesquisaCategoria.Owner = this;
                if (pesquisaCategoria.ShowDialog() == DialogResult.OK)
                {
                    txtCategoria.Text = pesquisaCategoria.categoriaSelecionado;
                }
            }
            Task.Delay(100).ContinueWith(t => Invoke(new Action(() => bloqueiaPesquisa = false)));
        }

        private void txtMetodoPgto_TextChanged(object sender, EventArgs e)
        {
            if (bloqueiaPesquisa || bloqueiaEventosTextChanged || string.IsNullOrEmpty(txtMetodoPgto.Text))
                return;

            bloqueiaPesquisa = true;
            using (FormLocalizarMetodoPagamento pesquisaMetodoPgto = new FormLocalizarMetodoPagamento(this, txtMetodoPgto.Text))
            {
                pesquisaMetodoPgto.Owner = this;
                if (pesquisaMetodoPgto.ShowDialog() == DialogResult.OK)
                {
                    txtMetodoPgto.Text = pesquisaMetodoPgto.MetodoPgtoSelecionado;
                }
            }
            Task.Delay(100).ContinueWith(t => Invoke(new Action(() => bloqueiaPesquisa = false)));
        }

        private void btnParcelar_Click(object sender, EventArgs e)
        {
            Parcelamento();
        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {
            CalcularValorParcela();
        }

        private void txtNumeroParcelas_TextChanged(object sender, EventArgs e)
        {
            CalcularValorParcela();
        }

        private void radiobtnSim_CheckedChanged(object sender, EventArgs e)
        {
            btnParcelar.Enabled = true;
        }

        private void radiobtnNao_CheckedChanged(object sender, EventArgs e)
        {
            btnParcelar.Enabled = false;
        }
    }
}
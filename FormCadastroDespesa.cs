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
        public string StatusOperacao { get; set; }
        private string QueryDespesa = "SELECT MAX(DespesaID) FROM Despesas";
        public bool Salvou { get; private set; } = false;
        private readonly FormManutencaoDespesas _formPai;
        public int DespesaID { get; set; }
        // Propriedade para armazenar as parcelas geradas
        public List<DespesasModel> ParcelasGeradas { get; set; } = new List<DespesasModel>();

        public int CategoriaID { get; set; } // Propriedade para armazenar o ID da categoria
        public int MetodoPgtoID { get; set; } // Propriedade para armazenar o ID do método de pagamento

        private bool bloqueiaPesquisa = false;
        public bool bloqueiaEventosTextChanged = false;
        private DateTime DataPgto { get; set; }
        public FormCadastroDespesa(string statusOperacao, FormManutencaoDespesas formPai)
        {
            InitializeComponent();

            StatusOperacao = statusOperacao;
            Utilitario.AdicionarEfeitoFocoEmTodos(this);
            _formPai = formPai;

            // Desabilitar eventos TextChanged nos modos ALTERAR, EXCLUSÃO e PAGAR
            if (StatusOperacao == "ALTERAR" || StatusOperacao == "EXCLUSÃO" || StatusOperacao == "PAGAR")
            {
                txtCategoria.TextChanged -= txtCategoria_TextChanged;
                txtMetodoPgto.TextChanged -= txtMetodoPgto_TextChanged;
            }

            ConfigurarFormularioInicial();
        }
        // Re-adicionar os eventos ao fechar o formulário, se necessário
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (StatusOperacao == "ALTERAR" || StatusOperacao == "EXCLUSÃO" || StatusOperacao == "PAGAR")
            {
                txtCategoria.TextChanged += txtCategoria_TextChanged;
                txtMetodoPgto.TextChanged += txtMetodoPgto_TextChanged;
            }
            base.OnFormClosing(e);
        }
        private void CalcularValorParcela()
        {
            if (decimal.TryParse(txtValorTotal.Text, out decimal valorTotal) &&
                int.TryParse(txtNumeroParcelas.Text, out int numeroParcelas) &&
                numeroParcelas > 0)
            {
                decimal valorParcela = valorTotal / numeroParcelas;
                txtValorParcela.Text = valorParcela.ToString("F2"); // Formato com 2 casas decimais
            }
            else
            {
                txtValorParcela.Text = txtValorTotal.Text; // Se falhar, assume o valor total (compra à vista)
            }
        }
        private void ConfigurarFormularioInicial()
        {
            if (StatusOperacao == "NOVO")
            {
                int codigo = Utilitario.GerarProximoCodigo(QueryDespesa);
                txtDespesaID.Text = Utilitario.AcrescentarZerosEsquerda(codigo, 5);
                bloqueiaEventosTextChanged = false; // Eventos habilitados no modo NOVO
            }
            else if (StatusOperacao == "ALTERAR" || StatusOperacao == "EXCLUSÃO" || StatusOperacao == "PAGAR")
            {
                bloqueiaEventosTextChanged = true; // Desabilita eventos nos modos ALTERAR, EXCLUSÃO e PAGAR
            }
            btnParcelar.Visible = false;
        }
        private void FormCadastroTipoReceita_Load(object sender, EventArgs e)
        {
            if (StatusOperacao == "NOVO")
            {
                int codigo = Utilitario.GerarProximoCodigo(QueryDespesa);
                txtDespesaID.Text = Utilitario.AcrescentarZerosEsquerda(codigo, 5);
                btnLocalizarCategoria.Enabled = false;
                btnLocalizarMetodoPagamento.Enabled = false;
            }           
        }

        private void FormCadastroCategorias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Suprima o som de "beep"
                e.Handled = true;
                // Envia a tecla Tab
                SendKeys.Send("{TAB}");
            }
        }
        

        private void txtValor_Leave(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(txtValorTotal.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal valorTotal))
                {
                    txtValorTotal.Text = valorTotal.ToString("N2", CultureInfo.CurrentCulture);

                    // Validar txtNumeroParcelas antes de calcular o valor da parcela
                    if (int.TryParse(txtNumeroParcelas.Text, out int numeroParcelas) && numeroParcelas > 0)
                    {
                        decimal valorParcela = valorTotal / numeroParcelas;
                        txtValorParcela.Text = valorParcela.ToString("N2", CultureInfo.CurrentCulture);
                    }
                    else if (!string.IsNullOrWhiteSpace(txtNumeroParcelas.Text))
                    {
                        MessageBox.Show("Número de parcelas inválido! Digite um número inteiro maior que zero.",
                                        "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNumeroParcelas.Focus(); // Volta o foco para corrigir
                    }
                }
                else if (!string.IsNullOrWhiteSpace(txtValorTotal.Text))
                {
                    MessageBox.Show("Valor total inválido! Digite um número válido.",
                                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValorTotal.Focus(); // Volta o foco para corrigir
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar o valor: {ex.Message}",
                                "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                decimal valorTotal = decimal.Parse(txtValorTotal.Text, CultureInfo.CurrentCulture);
                var frmGerarParcelas = new FormGerarParcelas(
                    txtDescricao.Text.Trim(),
                    valorTotal,
                    dtpDataVencimento.Value,
                    txtCategoria.Text.ToString() ?? "",
                    cmbStatus.SelectedItem?.ToString() ?? "",
                    txtNumeroParcelas.Text.Trim() == "0" ? 1 : int.Parse(txtNumeroParcelas.Text.Trim())
                );

                if (frmGerarParcelas.ShowDialog() == DialogResult.OK)
                {
                    ParcelasGeradas = frmGerarParcelas.Parcelas;
                    if (ParcelasGeradas.Count > 0)
                    {
                        MessageBox.Show($"{ParcelasGeradas.Count} parcelas geradas com sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtNumeroParcelas.Text = ParcelasGeradas.Count.ToString();
                        txtValorParcela.Text = ParcelasGeradas.First().ValorParcela?.ToString("N2") ?? "0,00";
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("O valor informado é inválido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar parcelas: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGerarParcelas_Click(object sender, EventArgs e)
        {            
        }

        private void txtValorParcela_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtValorTotal.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal valorParcela))
            {
                txtValorParcela.Text = valorParcela.ToString("N2", CultureInfo.CurrentCulture);
            }
            else if (!string.IsNullOrWhiteSpace(txtValorParcela.Text))
            {
                MessageBox.Show("Valor inválido! Digite um número válido.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumeroParcelas_Leave(object sender, EventArgs e)
        {
            if (txtValorTotal.Text != string.Empty)
            {
                decimal valorarcela = decimal.Parse(txtValorTotal.Text) / int.Parse(txtNumeroParcelas.Text);
                txtValorParcela.Text = valorarcela.ToString("N2");
            }
        }

        private void radiobtnSim_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radiobtnNao_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Utilitario.LimpaCampoKrypton(this);
            txtNumeroParcelas.Text = "1";
            int NovoCodigo = Utilitario.GerarProximoCodigo(QueryDespesa);
            txtDespesaID.Text = Utilitario.AcrescentarZerosEsquerda(NovoCodigo, 5);
        }
        private void Salvar()
        {
            string[] metodosPagos = new string[]
                        {
                    "Dinheiro",
                    "Cartão de Débito",
                    "PIX",
                    "Transferência Bancária",
                    "Vale-Alimentação",
                    "Débito Automático"
            };

            bool pago = metodosPagos.Contains(txtMetodoPgto.Text?.Trim(), StringComparer.OrdinalIgnoreCase);
            DateTime? dataPgto = pago ? (DateTime?)dtpDataVencimento.Value : null;

            try
            {
                // Validações
                if (string.IsNullOrWhiteSpace(txtDescricao.Text))
                    throw new Exception("A descrição é obrigatória.");
                if (!decimal.TryParse(txtValorTotal.Text, out decimal valorTotal))
                    throw new Exception("O valor total deve ser um número válido.");
                if (!int.TryParse(txtNumeroParcelas.Text, out int numeroParcelas))
                    throw new Exception("O número de parcelas deve ser um número inteiro.");
                if (!decimal.TryParse(txtValorParcela.Text, out decimal valorParcela))
                    throw new Exception("O valor da parcela deve ser um número válido."); // Sempre validar txtValorParcela
                if (cmbStatus.SelectedIndex == -1)
                    throw new Exception("Selecione um status.");
                if (string.IsNullOrWhiteSpace(txtMetodoPgto.Text))
                    throw new Exception("Selecione um método de pagamento.");
                if (string.IsNullOrWhiteSpace(txtCategoria.Text))
                    throw new Exception("Selecione uma categoria.");
                if (CategoriaID <= 0)
                    throw new Exception("O Código CategoriaID está vazio ou não é válido.");
                if (MetodoPgtoID <= 0)
                    throw new Exception("O Código MetodoPgtoID está vazio ou não é válido.");

                if (ParcelasGeradas.Count > 0)
                {
                    // Lógica para parcelas geradas
                    foreach (var parcela in ParcelasGeradas)
                    {
                        parcela.DespesaID = Utilitario.GerarProximoCodigo(QueryDespesa);
                        parcela.Descricao = txtDescricao.Text;
                        parcela.Valor = valorTotal; // Valor total da compra
                        parcela.DataVencimento = parcela.DataVencimento; // Já definido na geração
                        parcela.Status = "Pendente";
                        parcela.NumeroParcelas = numeroParcelas;
                        parcela.ValorParcela = valorParcela; // Sempre usa o valor calculado de txtValorParcela
                        parcela.CategoriaID = CategoriaID;
                        parcela.MetodoPgtoID = MetodoPgtoID;
                        parcela.Pago = false;
                        parcela.DataCriacao = dtpDataCadastro.Value;
                        parcela.DataPgto = null;

                        objetoBll.Salvar(parcela);
                        QueryDespesa = "SELECT MAX(DespesaID) FROM Despesas";
                    }
                    MessageBox.Show($"{ParcelasGeradas.Count} parcelas salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Salvou = true;
                    _formPai.AtualizarDataGrid();
                    Utilitario.LimpaCampoKrypton(this);
                    int codigo = Utilitario.GerarProximoCodigo(QueryDespesa);
                    txtDespesaID.Text = Utilitario.AcrescentarZerosEsquerda(codigo, 5);
                    cmbStatus.Focus();
                    cmbStatus.SelectedItem = "Pendente";
                    txtNumeroParcelas.Text = "1";
                    ParcelasGeradas.Clear();
                }
                else
                {
                    switch (StatusOperacao)
                    {
                        case "NOVO":
                            var novoTipo = new DespesasModel
                            {
                                DespesaID = int.Parse(txtDespesaID.Text),
                                Descricao = txtDescricao.Text,
                                Valor = valorTotal, // Valor total da compra
                                DataVencimento = dtpDataVencimento.Value,
                                Status = cmbStatus.SelectedItem.ToString(),
                                NumeroParcelas = numeroParcelas,
                                ValorParcela = valorParcela, // Sempre grava o valor de txtValorParcela
                                CategoriaID = CategoriaID,
                                MetodoPgtoID = MetodoPgtoID,
                                Pago = pago,
                                DataCriacao = dtpDataCadastro.Value,
                                DataPgto = dataPgto
                            };

                            objetoBll.Salvar(novoTipo);
                            MessageBox.Show("Despesa salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Salvou = true;
                            _formPai.AtualizarDataGrid();
                            Utilitario.LimpaCampoKrypton(this);
                            txtNumeroParcelas.Text = "1";
                            int codigoNovo = Utilitario.GerarProximoCodigo(QueryDespesa);
                            txtDespesaID.Text = Utilitario.AcrescentarZerosEsquerda(codigoNovo, 5);
                           cmbStatus.Focus();
                            break;

                        case "ALTERAR":
                            var alterarTipo = new DespesasModel
                            {
                                DespesaID = int.Parse(txtDespesaID.Text),
                                Descricao = txtDescricao.Text,
                                Valor = valorTotal, // Valor total da compra
                                DataVencimento = dtpDataVencimento.Value,
                                Status = cmbStatus.SelectedItem.ToString(),
                                NumeroParcelas = numeroParcelas,
                                ValorParcela = valorParcela, // Sempre grava o valor de txtValorParcela
                                CategoriaID = CategoriaID,
                                MetodoPgtoID = MetodoPgtoID,
                                Pago = pago,
                                DataCriacao = dtpDataCadastro.Value,
                                DataPgto = dataPgto
                            };
                            objetoBll.Alterar(alterarTipo);
                            MessageBox.Show("Despesa alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Salvou = true;
                            _formPai.AtualizarDataGrid();
                            this.Close();
                            break;

                        case "PAGAR":
                            if (MessageBox.Show("Deseja realmente pagar esta conta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                var pagarTipo = new DespesasModel
                                {
                                    DespesaID = int.Parse(txtDespesaID.Text),
                                    Status = "Pago",
                                    Pago = true,
                                    DataPgto = dtpDataCadastro.Value
                                };
                                objetoBll.AlterarStatus(pagarTipo);
                                MessageBox.Show("Conta paga com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Salvou = true;
                                _formPai.AtualizarDataGrid();
                                this.Close();
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

            Task.Delay(100).ContinueWith(t =>
            {
                Invoke(new Action(() => bloqueiaPesquisa = false));
            });
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

            Task.Delay(100).ContinueWith(t =>
            {
                Invoke(new Action(() => bloqueiaPesquisa = false));
            });
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

            Task.Delay(100).ContinueWith(t =>
            {
                Invoke(new Action(() => bloqueiaPesquisa = false));
            });
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

            Task.Delay(100).ContinueWith(t =>
            {
                Invoke(new Action(() => bloqueiaPesquisa = false));
            });
        }

        private void radiobtnParcelar_CheckedChanged(object sender, EventArgs e)
        {
            btnParcelar.Visible = true;
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
    }
}

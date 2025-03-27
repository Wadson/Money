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

            radiobtnNao.CheckedChanged += radiobtnNao_CheckedChanged;
            radiobtnSim.CheckedChanged += radiobtnSim_CheckedChanged;
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
                !string.IsNullOrWhiteSpace(txtNumeroParcelas.Text))
            {
                string numeroParcelasText = txtNumeroParcelas.Text.Trim();
                int totalParcelas;

                // Verifica se está no formato "X/Y" ou é apenas um número
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
                        txtValorParcela.Text = valorTotal.ToString("F2", CultureInfo.CurrentCulture); // Assume compra à vista se inválido
                    }
                }
                else if (int.TryParse(numeroParcelasText, out totalParcelas) && totalParcelas > 0)
                {
                    decimal valorParcela = valorTotal / totalParcelas;
                    txtValorParcela.Text = valorParcela.ToString("F2", CultureInfo.CurrentCulture);
                }
                else
                {
                    txtValorParcela.Text = valorTotal.ToString("F2", CultureInfo.CurrentCulture); // Assume compra à vista se inválido
                }
            }
            else
            {
                txtValorParcela.Text = txtValorTotal.Text; // Se falhar, usa o valor total
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
            btnParcelar.Enabled = false;
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

                    // Validar e processar txtNumeroParcelas
                    if (!string.IsNullOrWhiteSpace(txtNumeroParcelas.Text))
                    {
                        string numeroParcelasText = txtNumeroParcelas.Text;
                        int totalParcelas;

                        if (numeroParcelasText.Contains("/"))
                        {
                            // Formato "X/Y" (ex.: "1/2")
                            string[] partes = numeroParcelasText.Split('/');
                            if (partes.Length != 2 || !int.TryParse(partes[1], out totalParcelas) || totalParcelas <= 0)
                            {
                                MessageBox.Show("Número de parcelas inválido! O total de parcelas deve ser um número inteiro maior que zero no formato 'X/Y'.",
                                                "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtNumeroParcelas.Focus();
                                return;
                            }
                        }
                        else
                        {
                            // Formato simples (ex.: "2")
                            if (!int.TryParse(numeroParcelasText, out totalParcelas) || totalParcelas <= 0)
                            {
                                MessageBox.Show("Número de parcelas inválido! Digite um número inteiro maior que zero.",
                                                "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtNumeroParcelas.Focus();
                                return;
                            }
                        }

                        // Calcular o valor da parcela com base no total de parcelas
                        decimal valorParcela = valorTotal / totalParcelas;
                        txtValorParcela.Text = valorParcela.ToString("N2", CultureInfo.CurrentCulture);
                    }
                }
                else if (!string.IsNullOrWhiteSpace(txtValorTotal.Text))
                {
                    MessageBox.Show("Valor total inválido! Digite um número válido.",
                                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValorTotal.Focus();
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

                // Pegar o texto do número de parcelas
                string numeroParcelasTexto = txtNumeroParcelas.Text.Trim();
                int numeroParcelas;

                // Verificar se está no formato "X/Y" ou é apenas um número
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

                // Passar o texto original como string para FormGerarParcelas
                var frmGerarParcelas = new FormGerarParcelas(
                    txtDescricao.Text.Trim(),
                    valorTotal,
                    dtpDataVencimento.Value,
                    numeroParcelasTexto // Passa a string original, como "1/7" ou "5"
                );

                if (frmGerarParcelas.ShowDialog() == DialogResult.OK)
                {
                    ParcelasGeradas = frmGerarParcelas.Parcelas;
                    if (ParcelasGeradas.Count > 0)
                    {
                        // Mantém o formato "X/Y" da última parcela para refletir o total
                        txtNumeroParcelas.Text = ParcelasGeradas.Last().NumeroParcelas; // Ex.: "2/2" ou "8/8"
                        txtValorParcela.Text = ParcelasGeradas.First().ValorParcela.HasValue
                            ? ParcelasGeradas.First().ValorParcela.Value.ToString("N2", CultureInfo.CurrentCulture)
                            : "0.00";
                        MessageBox.Show($"{ParcelasGeradas.Count} parcelas geradas com sucesso! Clique em 'Salvar' para persistir.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!string.IsNullOrWhiteSpace(txtValorTotal.Text) && !string.IsNullOrWhiteSpace(txtNumeroParcelas.Text))
            {
                try
                {
                    decimal valorTotal = decimal.Parse(txtValorTotal.Text);
                    string numeroParcelasText = txtNumeroParcelas.Text.Trim();

                    int totalParcelas;

                    // Verifica se está no formato "X/Y" ou é apenas um número
                    if (numeroParcelasText.Contains("/"))
                    {
                        string[] partes = numeroParcelasText.Split('/');
                        if (partes.Length != 2 || !int.TryParse(partes[1], out totalParcelas) || totalParcelas <= 0)
                        {
                            throw new FormatException("O número de parcelas no formato 'X/Y' deve ter o total (à direita do '/') maior que zero.");
                        }
                    }
                    else if (!int.TryParse(numeroParcelasText, out totalParcelas) || totalParcelas <= 0)
                    {
                        throw new FormatException("O número de parcelas deve ser um inteiro maior que zero.");
                    }

                    decimal valorParcela = valorTotal / totalParcelas;
                    txtValorParcela.Text = valorParcela.ToString("N2", CultureInfo.CurrentCulture);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao calcular o valor da parcela: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValorParcela.Text = "0,00"; // Valor padrão em caso de erro
                }
            }
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
                // Validações comuns (aplicáveis a NOVO e ALTERAR, mas não a EXCLUSÃO)
                if (StatusOperacao != "EXCLUSÃO" && StatusOperacao != "PAGAR") // Exclui validações desnecessárias para EXCLUSÃO e PAGAR
                {
                    if (string.IsNullOrWhiteSpace(txtDescricao.Text))
                        throw new Exception("A descrição é obrigatória.");
                    if (!decimal.TryParse(txtValorTotal.Text, out decimal valorTotal))
                        throw new Exception("O valor total deve ser um número válido.");
                    if (string.IsNullOrWhiteSpace(txtNumeroParcelas.Text))
                        throw new Exception("O número de parcelas não pode estar vazio.");
                    if (!decimal.TryParse(txtValorParcela.Text, out decimal valorParcela))
                        throw new Exception("O valor da parcela deve ser um número válido.");
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
                }

                if (ParcelasGeradas.Count > 0)
                {
                    // Lógica para parcelas geradas (apenas para NOVO)
                    foreach (var parcela in ParcelasGeradas)
                    {
                        parcela.DespesaID = Utilitario.GerarProximoCodigo(QueryDespesa);
                        parcela.Descricao = parcela.Descricao;
                        parcela.ValorDaCompra = decimal.Parse(txtValorTotal.Text);
                        parcela.DataVencimento = parcela.DataVencimento;
                        parcela.Status = "Pendente";
                        parcela.NumeroParcelas = parcela.NumeroParcelas;
                        parcela.ValorParcela = parcela.ValorParcela;
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
                                ValorDaCompra = decimal.Parse(txtValorTotal.Text),
                                DataVencimento = dtpDataVencimento.Value,
                                Status = cmbStatus.SelectedItem.ToString(),
                                NumeroParcelas = "1/1",
                                ValorParcela = decimal.Parse(txtValorParcela.Text),
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
                                ValorDaCompra = decimal.Parse(txtValorTotal.Text),
                                DataVencimento = dtpDataVencimento.Value,
                                Status = cmbStatus.SelectedItem.ToString(),
                                NumeroParcelas = "1/1",
                                ValorParcela = decimal.Parse(txtValorParcela.Text),
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

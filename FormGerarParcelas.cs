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
using Money.MODEL;
namespace Money
{
    public partial class FormGerarParcelas : KryptonForm
    {
        // Lista para armazenar as parcelas geradas
        private List<DespesasModel> parcelasGeradas = new List<DespesasModel>();
        // Propriedade pública para retornar as parcelas
        internal List<DespesasModel> Parcelas
        {
            get { return parcelasGeradas; }
        }
        public FormGerarParcelas(string descricao, decimal valorTotal, DateTime dataVencimentoInicial, string NumParcela)
        {
            InitializeComponent();
            ConfigurarControles(descricao, valorTotal, dataVencimentoInicial, NumParcela);
            ConfigurarListView();
        }
        private void ConfigurarControles(string descricao, decimal valorTotal, DateTime dataVencimentoInicial, string numParcela)
        {
            lblDescricao.Text = descricao;
            lblValorTotal.Text = valorTotal.ToString("N2");
            dtpPrimeiraParcela.Value = dataVencimentoInicial;

            // Definir o número total de parcelas
            int totalParcelas = 1; // Valor padrão caso não seja válido

            if (!string.IsNullOrEmpty(numParcela))
            {
                // Verificar se é um número inteiro simples (ex.: "2", "5", "8")
                if (int.TryParse(numParcela, out int numeroInteiro))
                {
                    totalParcelas = numeroInteiro;
                }
                // Verificar se está no formato "X/Y" (ex.: "1/3")
                else if (numParcela.Contains("/"))
                {
                    string[] partes = numParcela.Split('/');
                    if (partes.Length == 2 && int.TryParse(partes[1], out int valorDireita))
                    {
                        totalParcelas = valorDireita;
                    }
                }
            }

            nudParcelas.Value = totalParcelas;

            // Desabilitar edição de campos que vêm do FrmDespesas
            lblDescricao.Enabled = false;
            lblValorTotal.Enabled = false;
        }      

        private void ConfigurarListView()
        {
            lvParcelas.View = View.Details;
            lvParcelas.FullRowSelect = true;
            lvParcelas.GridLines = true;
            lvParcelas.Columns.Add("Parcela", 80);
            lvParcelas.Columns.Add("Descrição", 250);
            lvParcelas.Columns.Add("Valor (R$)", 100);
            lvParcelas.Columns.Add("Vencimento", 100);
        }
        private void GerarParcelas()
        {
            try
            {
                lvParcelas.Items.Clear();
                parcelasGeradas.Clear();

                if (!decimal.TryParse(lblValorTotal.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal valorTotal) || valorTotal < 0)
                {
                    MessageBox.Show("Valor total inválido! Digite um número válido.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblValorTotal.Text = "0,00";
                    return;
                }

                int numeroParcelas = (int)nudParcelas.Value; // Usar .Value em vez de .Text
                if (numeroParcelas <= 0)
                {
                    MessageBox.Show("Número de parcelas inválido! Deve ser maior que zero.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nudParcelas.Value = 1; // Ajustar o valor diretamente
                    return;
                }

                decimal valorParcela = valorTotal / numeroParcelas;
                lblValorTotal.Text = valorParcela.ToString("N2", CultureInfo.CurrentCulture);

                DateTime dataVencimento = dtpPrimeiraParcela.Value;

                for (int i = 0; i < numeroParcelas; i++)
                {
                    string parcelaFormatada = $"{i + 1}/{numeroParcelas}";
                    var despesa = new DespesasModel
                    {
                        Descricao = $"{lblDescricao.Text} - Parcela {parcelaFormatada}",
                        ValorDaCompra = valorParcela,
                        DataVencimento = dataVencimento.AddMonths(i),
                        NumeroParcelas = i + 1, // Ajuste aqui: usar apenas o número da parcela atual
                        ValorParcela = valorParcela,
                        MetodoPgtoID = null,
                        Pago = false,
                        DataDaCompra = DateTime.Now
                    };
                    parcelasGeradas.Add(despesa);

                    lvParcelas.Items.Add(new ListViewItem(new[]
                    {
                parcelaFormatada,
                despesa.Descricao,
                despesa.ValorDaCompra.ToString("N2"),
                despesa.DataVencimento?.ToString("dd/MM/yyyy")
            }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar parcelas: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGerarParcelas_Click(object sender, EventArgs e)
        {
            GerarParcelas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (parcelasGeradas.Count == 0)
            {
                MessageBox.Show("Gere as parcelas antes de confirmar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void nudParcelas_ValueChanged(object sender, EventArgs e)
        {
            GerarParcelas();
        }
    }
}


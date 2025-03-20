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
using Money.MODEL;
namespace Money
{
    public partial class FormGerarParcelas : KryptonForm
    {
        // Lista para armazenar as parcelas geradas
        private List<DespesasModel> parcelasGeradas = new List<DespesasModel>();
        // Propriedade pública para retornar as parcelas
        public List<DespesasModel> Parcelas
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

            // Extrair o número total de parcelas (valor à direita do "/")
            int totalParcelas = 1; // Valor padrão caso não seja no formato "X/Y"
            if (!string.IsNullOrEmpty(numParcela) && numParcela.Contains("/"))
            {
                string[] partes = numParcela.Split('/');
                if (partes.Length == 2 && int.TryParse(partes[1], out int valorDireita))
                {
                    totalParcelas = valorDireita;
                }
            }
            nudParcelas.Value = totalParcelas;

            // Desabilitar edição de campos que vêm do FrmDespesas
            lblDescricao.Enabled = false;
            lblValorTotal.Enabled = false;
        }
        //private void ConfigurarControles(string descricao, decimal valorTotal, DateTime dataVencimentoInicial, int NumParcela)
        //{
        //    lblDescricao.Text = descricao;
        //    lblValorTotal.Text = valorTotal.ToString("N2");
        //    dtpPrimeiraParcela.Value = dataVencimentoInicial;
        //    nudParcelas.Value = 1;            
        //    nudParcelas.Value = NumParcela;

        //    // Desabilitar edição de campos que vêm do FrmDespesas
        //    lblDescricao.Enabled = false;
        //    lblValorTotal.Enabled = false;            
        //}

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

                decimal valorTotal = decimal.Parse(lblValorTotal.Text);
                int numeroParcelas = (int)nudParcelas.Value;
                decimal valorParcela = valorTotal / numeroParcelas;
                DateTime dataVencimento = dtpPrimeiraParcela.Value;

                for (int i = 0; i < numeroParcelas; i++)
                {
                    string parcelaFormatada = $"{i + 1}/{numeroParcelas}"; // Formato "1/4", "2/4", etc.
                    var despesa = new DespesasModel
                    {
                        Descricao = $"{lblDescricao.Text} - Parcela {parcelaFormatada}",
                        Valor = valorParcela,
                        DataVencimento = dataVencimento.AddMonths(i),
                        NumeroParcelas = parcelaFormatada, // "1/4", "2/4", etc.
                        ValorParcela = valorParcela,
                        MetodoPgtoID = null,
                        Pago = false,
                        DataCriacao = DateTime.Now
                    };
                    parcelasGeradas.Add(despesa);

                    lvParcelas.Items.Add(new ListViewItem(new[] {
                parcelaFormatada,
                despesa.Descricao,
                despesa.Valor.ToString("N2"),
                despesa.DataVencimento.ToString("dd/MM/yyyy")
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


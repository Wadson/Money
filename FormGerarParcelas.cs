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
        public FormGerarParcelas(string descricao, decimal valorTotal, DateTime dataVencimentoInicial, string categoria, string status, int NumParcela)
        {
            InitializeComponent();
            ConfigurarControles(descricao, valorTotal, dataVencimentoInicial, categoria, status, NumParcela);
            ConfigurarListView();
        }

        private void ConfigurarControles(string descricao, decimal valorTotal, DateTime dataVencimentoInicial, string categoria, string status, int NumParcela)
        {
            txtDescricao.Text = descricao;
            txtValorTotal.Text = valorTotal.ToString("N2");
            dtpPrimeiraParcela.Value = dataVencimentoInicial;
            nudParcelas.Value = 1;
            cmbCategoria.Text = categoria;
            cmbStatus.Text = status;
            nudParcelas.Value = NumParcela;

            // Desabilitar edição de campos que vêm do FrmDespesas
            txtDescricao.Enabled = false;
            txtValorTotal.Enabled = false;
            cmbCategoria.Enabled = false;
            cmbStatus.Enabled = false;
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

                decimal valorTotal = decimal.Parse(txtValorTotal.Text);
                int numeroParcelas = (int)nudParcelas.Value;
                decimal valorParcela = valorTotal / numeroParcelas;
                DateTime dataVencimento = dtpPrimeiraParcela.Value;

                for (int i = 0; i < numeroParcelas; i++)
                {
                    var despesa = new DespesasModel
                    {
                        Descricao = $"{txtDescricao.Text} - Parcela {i + 1}/{numeroParcelas}",
                        Valor = valorParcela,
                        DataVencimento = dataVencimento.AddMonths(i),
                        Status = cmbStatus.Text,
                        NumeroParcelas = numeroParcelas, // Total de parcelas
                        ValorParcela = valorParcela,
                        CategoriaID = null, // Será preenchido no FormCadastroDespesa
                        MetodoPgtoID = null, // Será preenchido no FormCadastroDespesa                        
                        Pago = false,
                        DataCriacao = DateTime.Now // Será ajustado no FormCadastroDespesa
                    };
                    parcelasGeradas.Add(despesa);
                    lvParcelas.Items.Add(new ListViewItem(new[] {
                    $"{i + 1}/{numeroParcelas}", despesa.Descricao, despesa.Valor.ToString("N2"), despesa.DataVencimento.ToString("dd/MM/yyyy")
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

        private void FormGerarParcelas_Load(object sender, EventArgs e)
        {
        }
    }
}



/*
 * 
 * public partial class FormGerarParcelas : KryptonForm
{
    private List<DespesasModel> parcelasGeradas = new List<DespesasModel>();

    public List<DespesasModel> Parcelas
    {
        get { return parcelasGeradas; }
    }

    public FormGerarParcelas(string descricao, decimal valorTotal, DateTime dataVencimentoInicial, string categoria, string status)
    {
        InitializeComponent();
        ConfigurarControles(descricao, valorTotal, dataVencimentoInicial, categoria, status);
        ConfigurarListView();
    }

    private void ConfigurarControles(string descricao, decimal valorTotal, DateTime dataVencimentoInicial, string categoria, string status)
    {
        txtDescricao.Text = descricao;
        txtValorTotal.Text = valorTotal.ToString("N2");
        dtpPrimeiraParcela.Value = dataVencimentoInicial;
        nudParcelas.Value = 1;
        cmbCategoria.Text = categoria;
        cmbStatus.Text = status;

        txtDescricao.Enabled = false;
        txtValorTotal.Enabled = false;
        cmbCategoria.Enabled = false;
        cmbStatus.Enabled = false;
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

    private void btnGerarParcelas_Click(object sender, EventArgs e)
    {
        try
        {
            lvParcelas.Items.Clear();
            parcelasGeradas.Clear();

            decimal valorTotal = decimal.Parse(txtValorTotal.Text);
            int numeroParcelas = (int)nudParcelas.Value;
            decimal valorParcela = valorTotal / numeroParcelas;
            DateTime dataVencimento = dtpPrimeiraParcela.Value;

            for (int i = 0; i < numeroParcelas; i++)
            {
                var despesa = new DespesasModel
                {
                    Descricao = $"{txtDescricao.Text} - Parcela {i + 1}/{numeroParcelas}",
                    Valor = valorParcela,
                    DataVencimento = dataVencimento.AddMonths(i),
                    Status = cmbStatus.Text,
                    NumeroParcelas = numeroParcelas,
                    ValorParcela = valorParcela,
                    CategoriaID = null, // Será preenchido no FormCadastroDespesa
                    MetodoPgtoID = null, // Será preenchido no FormCadastroDespesa
                    Pago = false,
                    DataCriacao = DateTime.Now
                };
                parcelasGeradas.Add(despesa);
                lvParcelas.Items.Add(new ListViewItem(new[] {
                    $"{i + 1}/{numeroParcelas}", despesa.Descricao, despesa.Valor.ToString("N2"), despesa.DataVencimento.ToString("dd/MM/yyyy")
                }));
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao gerar parcelas: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
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

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}
 * */
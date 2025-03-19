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
    public partial class FormFluxoFinanceiro : KryptonForm
    {
        private readonly ReceitasBLL receitasBLL = new ReceitasBLL();
        private readonly DespesasBLL despesasBLL = new DespesasBLL();

        public FormFluxoFinanceiro()
        {
            InitializeComponent();
           
            InicializarControles();
            dtpMesAno.ValueChanged += dtpMesAno_ValueChanged;
            dgvReceitas.CellFormatting += dgvReceitas_CellFormatting;
            dgvDespesas.CellFormatting += dgvDespesas_CellFormatting;
            dgvDespesas.CellValueChanged += dgvDespesas_CellValueChanged;
            dgvDespesas.DataError += dgvDespesas_DataError;
        }
        private void InicializarControles()
        {
            dtpMesAno.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            AtualizarFluxoFinanceiro();
        }
        private void AtualizarFluxoFinanceiro()
        {
            try
            {
                DateTime mesAno = dtpMesAno.Value;

                // Filtrar e adicionar linha de totais para receitas
                var receitas = receitasBLL.Pesquisar()
                    .Where(r => r.Data.Month == mesAno.Month && r.Data.Year == mesAno.Year)
                    .ToList();
                decimal totalReceitas = receitas.Sum(r => r.Valor);
                if (receitas.Count > 0)
                {
                    receitas.Add(new ReceitasModel
                    {
                        Descricao = "Total",
                        Valor = totalReceitas,
                        Data = DateTime.MinValue
                    });
                }
                dgvReceitas.DataSource = null;
                dgvReceitas.DataSource = receitas;
                PersonalizarDgvReceitas();

                // Filtrar e adicionar linha de totais para despesas
                var despesas = despesasBLL.PesquisarRelatorio()
                    .Where(d => d.DataVencimento.Month == mesAno.Month && d.DataVencimento.Year == mesAno.Year)
                    .Select(d => new DespesaViewModel
                    {
                        Descricao = d.Descricao,
                        Valor = d.Valor,
                        DataVencimento = d.DataVencimento,
                        Pago = d.Pago,
                        NumeroParcelas = d.NumeroParcelas,
                        ValorParcela = d.ValorParcela,
                        NomeCategoria = d.NomeCategoria,
                        Selecionado = false // Inicialmente não selecionado
                    }).ToList();
                decimal totalDespesas = despesas.Sum(d => d.Valor);
                if (despesas.Count > 0)
                {
                    despesas.Add(new DespesaViewModel
                    {
                        Descricao = "Total",
                        Valor = totalDespesas,
                        DataVencimento = DateTime.MinValue,
                        Pago = false,
                        NumeroParcelas = null,
                        ValorParcela = null,
                        NomeCategoria = null,
                        Selecionado = false // Não selecionável na linha de totais
                    });
                }
                dgvDespesas.DataSource = null;
                dgvDespesas.DataSource = despesas;
                PersonalizarDgvDespesas();

                // Calcular saldo e atualizar TextBox
                decimal saldo = totalReceitas - totalDespesas;
                txtTotalReceitas.Text = $" {totalReceitas:C2}";
                txtTotalDespesas.Text = $"{totalDespesas:C2}";
                txtSaldo.Text = $"{saldo:C2}";
                txtSaldo.ForeColor = saldo >= 0 ? Color.Green : Color.Red;

                // Atualizar o total selecionado inicialmente
                AtualizarTotalSelecionado();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o fluxo financeiro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PersonalizarDgvReceitas()
        {
            dgvReceitas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(70, 130, 180);
            dgvReceitas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReceitas.ColumnHeadersDefaultCellStyle.Font = new Font(dgvReceitas.Font, FontStyle.Bold);
            dgvReceitas.EnableHeadersVisualStyles = false;

            if (dgvReceitas.Columns.Contains("Data"))
            {
                dgvReceitas.Columns["Data"].HeaderText = "Data";
                dgvReceitas.Columns["Data"].Width = 90;
                dgvReceitas.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvReceitas.Columns.Contains("Valor"))
            {
                dgvReceitas.Columns["Valor"].HeaderText = "Valor";
                dgvReceitas.Columns["Valor"].Width = 90;
                dgvReceitas.Columns["Valor"].DefaultCellStyle.Format = "C2";
                dgvReceitas.Columns["Valor"].DefaultCellStyle.ForeColor = Color.DarkGreen;
            }

            if (dgvReceitas.Columns.Contains("Descricao"))
            {
                dgvReceitas.Columns["Descricao"].HeaderText = "Descrição";
                dgvReceitas.Columns["Descricao"].Width = 200;
            }

            foreach (DataGridViewColumn col in dgvReceitas.Columns)
            {
                if (!new[] { "Data", "Valor", "Descricao" }.Contains(col.Name))
                    col.Visible = false;
            }
        }

        private void PersonalizarDgvDespesas()
        {
            dgvDespesas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(70, 130, 180);
            dgvDespesas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDespesas.ColumnHeadersDefaultCellStyle.Font = new Font(dgvDespesas.Font, FontStyle.Bold);
            dgvDespesas.EnableHeadersVisualStyles = false;

            // Adicionar coluna de checkbox
            if (!dgvDespesas.Columns.Contains("Selecionado"))
            {
                var checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "Selecionado",
                    HeaderText = "Selecionar",
                    Width = 70,
                    ReadOnly = false
                };
                dgvDespesas.Columns.Insert(0, checkBoxColumn); // Inserir como primeira coluna
            }

            if (dgvDespesas.Columns.Contains("Descricao"))
            {
                dgvDespesas.Columns["Descricao"].HeaderText = "Descrição";
                dgvDespesas.Columns["Descricao"].Width = 180;
                dgvDespesas.Columns["Descricao"].ReadOnly = true;
            }

            if (dgvDespesas.Columns.Contains("Valor"))
            {
                dgvDespesas.Columns["Valor"].HeaderText = "Valor";
                dgvDespesas.Columns["Valor"].Width = 90;
                dgvDespesas.Columns["Valor"].DefaultCellStyle.Format = "C2";
                dgvDespesas.Columns["Valor"].DefaultCellStyle.ForeColor = Color.DarkRed;
                dgvDespesas.Columns["Valor"].ReadOnly = true;
            }

            if (dgvDespesas.Columns.Contains("DataVencimento"))
            {
                dgvDespesas.Columns["DataVencimento"].HeaderText = "Vencimento";
                dgvDespesas.Columns["DataVencimento"].Width = 90;
                dgvDespesas.Columns["DataVencimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvDespesas.Columns["DataVencimento"].ReadOnly = true;
            }

            if (dgvDespesas.Columns.Contains("Pago"))
            {
                dgvDespesas.Columns["Pago"].HeaderText = "Pago";
                dgvDespesas.Columns["Pago"].Width = 50;
                dgvDespesas.Columns["Pago"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDespesas.Columns["Pago"].ReadOnly = true;
            }

            foreach (DataGridViewColumn col in dgvDespesas.Columns)
            {
                if (!new[] { "Selecionado", "Descricao", "Valor", "DataVencimento", "Pago" }.Contains(col.Name))
                    col.Visible = false;
            }
        }

        private void AtualizarTotalSelecionado()
        {
            decimal totalSelecionado = 0m;

            // Iterar pelas linhas do DataGridView diretamente
            foreach (DataGridViewRow row in dgvDespesas.Rows)
            {
                // Verificar se a linha não é "Total" e se o checkbox está marcado
                if (row.Cells["Descricao"].Value?.ToString() != "Total" &&
                    row.Cells["Selecionado"].Value != null &&
                    Convert.ToBoolean(row.Cells["Selecionado"].Value))
                {
                    decimal valor = Convert.ToDecimal(row.Cells["Valor"].Value);
                    totalSelecionado += valor;
                    // Depuração: exibir os valores sendo somados
                    Console.WriteLine($"Somando: {valor:C2}, Total até agora: {totalSelecionado:C2}");
                }
            }

            txtTotalSelecionado.Text = $"{totalSelecionado:C2}";
        }

        private void dtpMesAno_ValueChanged(object sender, EventArgs e)
        {
            AtualizarFluxoFinanceiro();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDespesas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDespesas.Rows[e.RowIndex].Cells["Descricao"].Value?.ToString() == "Total")
            {
                e.CellStyle.Font = new Font(dgvDespesas.Font, FontStyle.Bold);
                e.CellStyle.BackColor = Color.LightGray;
                e.CellStyle.ForeColor = Color.Black;

                if (dgvDespesas.Columns[e.ColumnIndex].Name == "Selecionado" ||
                    dgvDespesas.Columns[e.ColumnIndex].Name == "DataVencimento" ||
                    dgvDespesas.Columns[e.ColumnIndex].Name == "Pago" ||
                    dgvDespesas.Columns[e.ColumnIndex].Name == "NumeroParcelas" ||
                    dgvDespesas.Columns[e.ColumnIndex].Name == "ValorParcela" ||
                    dgvDespesas.Columns[e.ColumnIndex].Name == "NomeCategoria")
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvReceitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvReceitas.Rows[e.RowIndex].Cells["Descricao"].Value?.ToString() == "Total")
            {
                e.CellStyle.Font = new Font(dgvReceitas.Font, FontStyle.Bold);
                e.CellStyle.BackColor = Color.LightGray;
                e.CellStyle.ForeColor = Color.Black;

                if (dgvReceitas.Columns[e.ColumnIndex].Name == "Data")
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvDespesas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.WriteLine($"Erro no DataGridView Despesas: {e.Exception.Message} na coluna {e.ColumnIndex}, linha {e.RowIndex}");
            e.ThrowException = false;
        }

        private void dgvDespesas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {           
        }

        private void dgvDespesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDespesas.Columns["Selecionado"].Index && e.RowIndex >= 0)
            {
                // Forçar o commit da edição da célula
                dgvDespesas.EndEdit();
                AtualizarTotalSelecionado();
            }
        }
    }
    // Classe temporária para adicionar a propriedade Selecionado
    public class DespesaViewModel
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool Pago { get; set; }
        public int? NumeroParcelas { get; set; }
        public decimal? ValorParcela { get; set; }
        public string NomeCategoria { get; set; }
        public bool Selecionado { get; set; }
    }
}

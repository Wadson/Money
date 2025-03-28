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

            listViewDespesas.ItemCheck += listViewDespesas_ItemCheck; // Evento para atualizar total selecionado
            AtualizarFluxoFinanceiro(); // Certifique-se de que isso é chamado após InitializeComponent
        }
        private void InicializarControles()
        {
            dtpMesAno.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            PersonalizarListViewReceitas();
            PersonalizarListViewDespesas();           
        }
        private void AtualizarFluxoFinanceiro()
        {
            try
            {
                DateTime mesAno = dtpMesAno.Value;
                Console.WriteLine($"Mês/Ano selecionado: {mesAno:MM/yyyy}");

                // Filtrar e adicionar linha de totais para receitas
                var receitas = receitasBLL.Pesquisar()
                    .Where(r => r.DataRecebimento.Month == mesAno.Month && r.DataRecebimento.Year == mesAno.Year)
                    .ToList();
                Console.WriteLine($"Receitas encontradas: {receitas.Count}");
                decimal totalReceitas = receitas.Sum(r => r.ValorDaReceita);
                if (receitas.Count > 0)
                {
                    receitas.Add(new ReceitasModel
                    {
                        Descricao = "Total",
                        ValorDaReceita = totalReceitas,
                        DataRecebimento = DateTime.MinValue
                    });
                }
                listViewReceitas.Items.Clear();
                foreach (var receita in receitas)
                {
                    var item = new ListViewItem(receita.DataRecebimento == DateTime.MinValue ? "" : receita.DataRecebimento.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(receita.ValorDaReceita.ToString("C2"));
                    item.SubItems.Add(receita.Descricao);
                    if (receita.Descricao == "Total")
                    {
                        item.Font = new Font(listViewReceitas.Font, FontStyle.Bold);
                        item.BackColor = Color.LightGray;
                    }
                    listViewReceitas.Items.Add(item);
                }

                // Filtrar e adicionar linha de totais para despesas
                var todasDespesas = despesasBLL.PesquisarRelatorioComVencimento();
                Console.WriteLine($"Total de despesas retornadas: {todasDespesas.Count}");

                var despesas = todasDespesas
                    .SelectMany(d => d.Parcelas.Select(p => new DespesaViewModel
                    {
                        Descricao = $"{d.Descricao} (Parcela {p.NumeroParcela})",
                        ValorDaCompra = d.ValorDaCompra,
                        DataVencimento = p.DataVencimento,
                        Pago = (bool)p.Pago,
                        NumeroParcelas = p.NumeroParcela.ToString(),
                        ValorParcela = p.ValorParcela,
                        NomeCategoria = d.NomeCategoria,
                        Selecionado = false
                    }))
                    .Where(d => d.DataVencimento.Month == mesAno.Month && d.DataVencimento.Year == mesAno.Year)
                    .ToList();
                Console.WriteLine($"Despesas filtradas por vencimento para {mesAno:MM/yyyy}: {despesas.Count}");

                decimal totalDespesas = despesas.Sum(d => d.ValorParcela ?? 0);
                Console.WriteLine($"Total Despesas Calculado: {totalDespesas:C2}");

                if (despesas.Any())
                {
                    despesas.Add(new DespesaViewModel
                    {
                        Descricao = "Total",
                        ValorParcela = totalDespesas,
                        DataVencimento = DateTime.MinValue,
                        Pago = false,
                        NumeroParcelas = null,
                        ValorDaCompra = 0m,
                        NomeCategoria = null,
                        Selecionado = false
                    });
                }

                listViewDespesas.Items.Clear();
                foreach (var despesa in despesas)
                {
                    var item = new ListViewItem
                    {
                        Checked = despesa.Selecionado,
                        Text = despesa.Descricao
                    };
                    item.SubItems.Add((despesa.ValorParcela ?? 0).ToString("C2"));
                    item.SubItems.Add(despesa.DataVencimento == DateTime.MinValue ? "" : despesa.DataVencimento.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(despesa.Pago.ToString());

                    if (despesa.Descricao == "Total")
                    {
                        item.Font = new Font(listViewDespesas.Font, FontStyle.Bold);
                        item.BackColor = Color.LightGray;
                        item.Checked = false; // Total não deve ser selecionável
                    }
                    listViewDespesas.Items.Add(item);
                }

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
                Console.WriteLine($"Exceção: {ex}");
            }
        }
        private void PersonalizarListViewReceitas()
        {
            listViewReceitas.View = View.Details;
            listViewReceitas.FullRowSelect = true;
            listViewReceitas.GridLines = true;
            listViewReceitas.Columns.Clear();
            listViewReceitas.Columns.Add("DataRecebimento", 90);
            var valorReceitaColumn = listViewReceitas.Columns.Add("Valor da Receita", 90);
            valorReceitaColumn.TextAlign = HorizontalAlignment.Right; // Alinhar texto à direita
            listViewReceitas.Columns.Add("Descrição", 200);
            listViewReceitas.HeaderStyle = ColumnHeaderStyle.Clickable;
            listViewReceitas.BackColor = Color.White;
        }

        private void PersonalizarListViewDespesas()
        {
            listViewDespesas.View = View.Details;
            listViewDespesas.FullRowSelect = true;
            listViewDespesas.GridLines = true;
            listViewDespesas.CheckBoxes = true; // Habilitar checkboxes
            listViewDespesas.Columns.Clear();
            listViewDespesas.Columns.Add("Descrição", 180); // Checkbox será exibido aqui
            var valorParcelaColumn = listViewDespesas.Columns.Add("Valor da Parcela", 90);
            valorParcelaColumn.TextAlign = HorizontalAlignment.Right; // Alinhar texto à direita
            listViewDespesas.Columns.Add("Vencimento", 90);
            listViewDespesas.Columns.Add("Pago", 50);
            listViewDespesas.HeaderStyle = ColumnHeaderStyle.Clickable;
            listViewDespesas.BackColor = Color.White;
        }

        private void AtualizarTotalSelecionado()
        {
            decimal totalSelecionado = 0m;

            foreach (ListViewItem item in listViewDespesas.Items)
            {
                if (item.Text != "Total" && item.Checked)
                {
                    decimal valor = decimal.Parse(item.SubItems[1].Text, System.Globalization.NumberStyles.Currency);
                    totalSelecionado += valor;
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

        private void listViewDespesas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Impedir que a linha "Total" seja marcada
            if (listViewDespesas.Items[e.Index].Text == "Total")
            {
                e.NewValue = CheckState.Unchecked;
            }
            else
            {
                // Atualizar o total selecionado após a mudança
                BeginInvoke((MethodInvoker)delegate { AtualizarTotalSelecionado(); });
            }
        }
    }
    // Classe temporária para adicionar a propriedade Selecionado
    public class DespesaViewModel
    {
        public string Descricao { get; set; }
        public decimal ValorDaCompra { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool Pago { get; set; }
        public string NumeroParcelas { get; set; }
        public decimal? ValorParcela { get; set; }
        public string NomeCategoria { get; set; }
        public bool Selecionado { get; set; }
    }
}

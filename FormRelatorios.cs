﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using ComponentFactory.Krypton.Toolkit;
using Money.BLL;
using Money.DAL;
using Money.MODEL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Money
{
    public partial class FormRelatorios : KryptonForm
    {
        private readonly DespesasBLL despesasBLL = new DespesasBLL();
        private readonly ParcelasBLL parcelasBLL = new ParcelasBLL(); // Adicionado para acessar parcelas
        private readonly ReceitasBLL receitasBLL = new ReceitasBLL(); // Mantido para receitas

        public FormRelatorios()
        {
            InitializeComponent();            
            InicializarControles();
            dgvRelatorio.DataError += dgvRelatorio_DataError;
        }

        private void InicializarControles()
        {
            cmbStatus.SelectedIndex = 0;

            var categorias = new List<string> { "Todos" };
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "SELECT NomeCategoria FROM Categorias ORDER BY NomeCategoria";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categorias.Add(reader.GetString(0));
                        }
                    }
                }
            }
            cmbCategoria.DataSource = categorias;
            cmbCategoria.SelectedIndex = 0;

            var metodosPagamento = new List<string> { "Todos" };
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sqlMetodos = "SELECT NomeMetodoPagamento FROM MetodosPagamento ORDER BY NomeMetodoPagamento";
                using (var cmd = new SqlCeCommand(sqlMetodos, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            metodosPagamento.Add(reader.GetString(0));
                        }
                    }
                }
            }
            cmbMetodoPgto.DataSource = metodosPagamento;
            cmbMetodoPgto.SelectedIndex = 0;
        }

        private void PersonalizarDataGridView(KryptonDataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            if (dgv.Columns.Contains("DespesaID")) dgv.Columns["DespesaID"].Visible = false;
            if (dgv.Columns.Contains("ParcelaID")) dgv.Columns["ParcelaID"].Visible = false;
            if (dgv.Columns.Contains("CategoriaID")) dgv.Columns["CategoriaID"].Visible = false;
            if (dgv.Columns.Contains("MetodoPgtoID")) dgv.Columns["MetodoPgtoID"].Visible = false;

            if (dgv.Columns.Contains("Descricao"))
            {
                dgv.Columns["Descricao"].HeaderText = "Descrição";
                dgv.Columns["Descricao"].Width = 350;
            }

            if (dgv.Columns.Contains("ValorDaCompra"))
            {
                dgv.Columns["ValorDaCompra"].HeaderText = "Valor da Compra";
                dgv.Columns["ValorDaCompra"].Width = 100;
                dgv.Columns["ValorDaCompra"].DefaultCellStyle.Format = "C2";
                dgv.Columns["ValorDaCompra"].DefaultCellStyle.ForeColor = Color.DarkRed;
                dgv.Columns["ValorDaCompra"].DefaultCellStyle.BackColor = Color.LightYellow;
            }

            if (dgv.Columns.Contains("DataDaCompra"))
            {
                dgv.Columns["DataDaCompra"].HeaderText = "Data da Compra";
                dgv.Columns["DataDaCompra"].Width = 120;
                dgv.Columns["DataDaCompra"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgv.Columns.Contains("DataVencimento"))
            {
                dgv.Columns["DataVencimento"].HeaderText = "Data Vencimento";
                dgv.Columns["DataVencimento"].Width = 120;
                dgv.Columns["DataVencimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgv.Columns.Contains("NumeroParcela"))
            {
                dgv.Columns["NumeroParcela"].HeaderText = "Nº Parcela";
                dgv.Columns["NumeroParcela"].Width = 60;
                dgv.Columns["NumeroParcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgv.Columns.Contains("ValorParcela"))
            {
                dgv.Columns["ValorParcela"].HeaderText = "Valor Parcela";
                dgv.Columns["ValorParcela"].Width = 120;
                dgv.Columns["ValorParcela"].DefaultCellStyle.Format = "C2";
                dgv.Columns["ValorParcela"].DefaultCellStyle.ForeColor = Color.DarkGreen;
                dgv.Columns["ValorParcela"].DefaultCellStyle.BackColor = Color.LightCyan;
            }

            if (dgv.Columns.Contains("NomeCategoria"))
            {
                dgv.Columns["NomeCategoria"].HeaderText = "Categoria";
                dgv.Columns["NomeCategoria"].Width = 150;
                dgv.Columns["NomeCategoria"].DefaultCellStyle.NullValue = "";
            }

            if (dgv.Columns.Contains("Pago"))
            {
                dgv.Columns["Pago"].HeaderText = "Pago";
                dgv.Columns["Pago"].Width = 60;
                dgv.Columns["Pago"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgv.Columns.Contains("DataPgto"))
            {
                dgv.Columns["DataPgto"].HeaderText = "Data Pgto";
                dgv.Columns["DataPgto"].Width = 120;
                dgv.Columns["DataPgto"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgv.Columns["DataPgto"].DefaultCellStyle.NullValue = "";
                dgv.Columns["DataPgto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgv.ReadOnly = true;
        }


        private void FormRelatorios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private int GetCategoriaId()
        {
            string nomeCategoria = cmbCategoria.Text.Trim();
            if (nomeCategoria == "Todos") return 0;
            string query = "SELECT CategoriaID FROM Categorias WHERE NomeCategoria = @NomeCategoria";
            int categoriaID = Utilitario.ObterCodigoComboBox(query, "@NomeCategoria", nomeCategoria);
            if (categoriaID == -1)
                MessageBox.Show($"Nenhum CategoriaID encontrado para '{nomeCategoria}'", "Debug");
            return categoriaID;
        }

        private int GetMetodoPgtoId()
        {
            string nomeMetodoPgto = cmbMetodoPgto.Text.Trim();
            if (nomeMetodoPgto == "Todos") return 0;
            string queryMetodo = "SELECT MetodoPgtoID FROM MetodosPagamento WHERE NomeMetodoPagamento = @NomeMetodoPagamento";
            int metodoPgtoID = Utilitario.ObterCodigoComboBox(queryMetodo, "@NomeMetodoPagamento", nomeMetodoPgto);
            if (metodoPgtoID == -1)
                MessageBox.Show($"Nenhum MetodoPgtoID encontrado para '{nomeMetodoPgto}'", "Debug");
            return metodoPgtoID;
        }
        private void GerarRelatorio()
        {
            try
            {
                string categoria = cmbCategoria.Text.Trim();
                string metodoPagamento = cmbMetodoPgto.Text.Trim();
                DateTime mesAno = dtpMesAno.Value;
                string status = cmbStatus.SelectedItem?.ToString() ?? "Todos";

                DateTime inicioMesAtual = new DateTime(mesAno.Year, mesAno.Month, 1);
                DateTime fimMesAnterior = inicioMesAtual.AddDays(-1);

                var receitasTotais = receitasBLL.Pesquisar();
                var parcelasTotais = parcelasBLL.Pesquisar();

                var despesasTotais = despesasBLL.PesquisarRelatorio();

                // Log das datas distintas em Parcelas
                var datasDistintas = parcelasTotais.Select(p => new { Mes = p.DataVencimento.Month, Ano = p.DataVencimento.Year })
                                                  .Distinct()
                                                  .OrderBy(d => d.Ano).ThenBy(d => d.Mes);
                Console.WriteLine("Datas distintas em Parcelas:");
                foreach (var data in datasDistintas)
                {
                    Console.WriteLine($"Mês: {data.Mes}, Ano: {data.Ano}");
                }

                decimal totalReceitasAnteriores = receitasTotais
                    .Where(r => r.DataRecebimento <= fimMesAnterior)
                    .Sum(r => r.ValorDaReceita);

                decimal totalDespesasAnteriores = parcelasTotais
                    .Where(p => p.DataVencimento <= fimMesAnterior)
                    .Sum(p => p.ValorParcela);

                decimal saldoAcumulado = totalReceitasAnteriores - totalDespesasAnteriores;

                var relatorio = from p in parcelasTotais
                                join d in despesasTotais on p.DespesaID equals d.DespesaID into despesaJoin
                                from d in despesaJoin.DefaultIfEmpty()
                                select new
                                {
                                    p.ParcelaID,
                                    p.DespesaID,
                                    Descricao = d?.Descricao ?? "Sem descrição",
                                    ValorDaCompra = d?.ValorDaCompra ?? 0m,
                                    DataDaCompra = d?.DataDaCompra ?? DateTime.MinValue,
                                    p.NumeroParcela,
                                    p.ValorParcela,
                                    p.DataVencimento,
                                    p.Pago,
                                    p.DataPgto,
                                    NomeCategoria = d?.NomeCategoria ?? "Sem categoria",
                                    CategoriaID = d?.CategoriaID,
                                    MetodoPgtoID = d?.MetodoPgtoID
                                };

                int totalAntesFiltros = relatorio.Count();
                Console.WriteLine($"Parcelas: {parcelasTotais.Count}, Despesas: {despesasTotais.Count}, Total antes filtros: {totalAntesFiltros}");

                var relatorioFiltrado = relatorio.AsEnumerable();
                Console.WriteLine($"Após conversão para Enumerable: {relatorioFiltrado.Count()}");

                if (categoria != "Todos")
                {
                    int categoriaId = GetCategoriaId();
                    if (categoriaId > 0)
                        relatorioFiltrado = relatorioFiltrado.Where(r => r.CategoriaID == categoriaId);
                    Console.WriteLine($"Após filtro de categoria ({categoria}): {relatorioFiltrado.Count()}");
                }

                if (metodoPagamento != "Todos")
                {
                    int metodoPgtoId = GetMetodoPgtoId();
                    if (metodoPgtoId > 0)
                        relatorioFiltrado = relatorioFiltrado.Where(r => r.MetodoPgtoID == metodoPgtoId);
                    Console.WriteLine($"Após filtro de método de pagamento ({metodoPagamento}): {relatorioFiltrado.Count()}");
                }

                relatorioFiltrado = relatorioFiltrado.Where(r => r.DataVencimento.Month == mesAno.Month && r.DataVencimento.Year == mesAno.Year);
                Console.WriteLine($"Após filtro de mês/ano ({mesAno:MM/yyyy}): {relatorioFiltrado.Count()}");

                if (status != "Todos")
                {
                    if (status == "Pago")
                        relatorioFiltrado = relatorioFiltrado.Where(r => r.Pago == true);
                    else if (status == "Pendente")
                        relatorioFiltrado = relatorioFiltrado.Where(r => r.Pago == false);
                    Console.WriteLine($"Após filtro de status ({status}): {relatorioFiltrado.Count()}");
                }

                var listaFiltrada = relatorioFiltrado.Select(r => new
                {
                    r.DespesaID,
                    r.ParcelaID,
                    r.Descricao,
                    r.ValorDaCompra,
                    r.DataDaCompra,
                    r.NumeroParcela,
                    r.ValorParcela,
                    r.DataVencimento,
                    r.Pago,
                    r.DataPgto,
                    r.NomeCategoria,
                    r.CategoriaID,
                    r.MetodoPgtoID
                }).ToList();

                if (listaFiltrada.Count == 0)
                {
                    string debugInfo = $"Filtros aplicados: Categoria={categoria}, MetodoPgto={metodoPagamento}, Mes/Ano={mesAno:MM/yyyy}, Status={status}\n" +
                                       $"Parcelas: {parcelasTotais.Count}, Despesas: {despesasTotais.Count}, Total antes filtros: {totalAntesFiltros}";
                    MessageBox.Show("Nenhum registro encontrado com os filtros aplicados.\n" + debugInfo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvRelatorio.DataSource = null;
                    lblTotalAberto.Text = "Total Aberto: R$ 0,00";
                    lblTotalPago.Text = "Total Pago: R$ 0,00";
                }
                else
                {
                    decimal totalValorCompra = listaFiltrada.Sum(d => d.ValorDaCompra);
                    decimal totalValorParcela = listaFiltrada.Sum(d => d.ValorParcela);

                    var linhaTotal = new
                    {
                        DespesaID = 0,
                        ParcelaID = 0,
                        Descricao = "Total",
                        ValorDaCompra = totalValorCompra,
                        DataDaCompra = DateTime.MinValue,
                        NumeroParcela = 0,
                        ValorParcela = totalValorParcela,
                        DataVencimento = DateTime.MinValue,
                        Pago = (bool?)null,
                        DataPgto = (DateTime?)null,
                        NomeCategoria = "",
                        CategoriaID = (int?)null,
                        MetodoPgtoID = (int?)null
                    };
                    listaFiltrada.Add(linhaTotal);

                    dgvRelatorio.DataSource = null;
                    dgvRelatorio.DataSource = listaFiltrada;
                    PersonalizarDataGridView(dgvRelatorio);

                    decimal totalAberto = listaFiltrada.Where(d => d.Pago == false && d.Descricao != "Total").Sum(d => d.ValorParcela);
                    decimal totalPago = listaFiltrada.Where(d => d.Pago == true && d.Descricao != "Total").Sum(d => d.ValorParcela);
                    lblTotalAberto.Text = $"Total Aberto: {totalAberto:C2}";
                    lblTotalPago.Text = $"Total Pago: {totalPago:C2}";
                }

                var receitasMes = receitasTotais.Where(r => r.DataRecebimento.Month == mesAno.Month && r.DataRecebimento.Year == mesAno.Year);
                decimal totalReceitasMes = receitasMes.Sum(r => r.ValorDaReceita);

                decimal totalDespesasAcumuladas = parcelasTotais.Where(p => p.Pago == false && p.DataVencimento <= fimMesAnterior).Sum(p => p.ValorParcela);

                decimal totalDespesasMes = listaFiltrada.Where(d => d.Descricao != "Total").Sum(d => d.ValorParcela);

                decimal saldoFinal = saldoAcumulado + totalReceitasMes - (totalDespesasAcumuladas + totalDespesasMes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar relatório: {ex.Message}\nStackTrace: {ex.StackTrace}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            GerarRelatorio();
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            var data = dgvRelatorio.DataSource as List<dynamic>;
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("Não há dados para exportar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Arquivos Excel (*.xlsx)|*.xlsx";
                sfd.FileName = "RelatorioDespesas.xlsx";
                sfd.Title = "Salvar Relatório como Excel";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Relatório Despesas");
                            var dadosExportacao = data.Select(d => new
                            {
                                Descricao = d.Descricao,
                                ValorDaCompra = d.ValorDaCompra,
                                DataCriacao = d.DataCriacao.ToString("dd/MM/yyyy"),
                                NumeroParcela = d.NumeroParcela,
                                ValorParcela = d.ValorParcela,
                                DataVencimento = d.DataVencimento.ToString("dd/MM/yyyy"),
                                NomeCategoria = d.NomeCategoria,
                                Pago = d.Pago ? "Sim" : "Não",
                                DataPagamento = d.DataPagamento?.ToString("dd/MM/yyyy") ?? ""
                            }).ToList();

                            worksheet.Cell(1, 1).InsertTable(dadosExportacao);
                            worksheet.Columns().AdjustToContents();
                            workbook.SaveAs(sfd.FileName);
                        }

                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = sfd.FileName,
                            UseShellExecute = true
                        });

                        MessageBox.Show("Relatório exportado para Excel e aberto com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao exportar o relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvRelatorio_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.WriteLine($"DataGridView DataError: {e.Exception.Message} na coluna {e.ColumnIndex}, linha {e.RowIndex}");
            e.ThrowException = false;
        }

        private void dgvRelatorio_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvRelatorio.Rows[e.RowIndex].Cells["Descricao"].Value?.ToString() == "Total")
            {
                e.CellStyle.Font = new Font(dgvRelatorio.Font, FontStyle.Bold);
                e.CellStyle.BackColor = Color.LightGray;
                e.CellStyle.ForeColor = Color.Black;

                if (dgvRelatorio.Columns[e.ColumnIndex].Name == "DataDaCompra" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "DataVencimento" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "DataPgto" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "NumeroParcela" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "NomeCategoria" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "Pago")
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}

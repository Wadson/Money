







using System;
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
using Money.MODEL;

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
            dgvRelatorio.CellFormatting += DgvRelatorio_CellFormatting;
            InicializarControles();
            dgvRelatorio.DataError += dgvRelatorio_DataError;
        }

        private void InicializarControles()
        {
            cmbStatus.SelectedIndex = 0;

            var categorias = new List<string> { "Todos" }; // Adiciona "Todos" como primeira opção
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
            cmbCategoria.SelectedIndex = 0; // "Todos" por padrão

            var metodosPagamento = new List<string> { "Todos" }; // Adiciona "Todos" como primeira opção
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
            cmbMetodoPgto.SelectedIndex = 0; // "Todos" por padrão
        }

        private void PersonalizarDataGridView(KryptonDataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Ocultar colunas de ID
            if (dgv.Columns.Contains("DespesaID")) dgv.Columns["DespesaID"].Visible = false;
            if (dgv.Columns.Contains("ParcelaID")) dgv.Columns["ParcelaID"].Visible = false;
            if (dgv.Columns.Contains("CategoriaID")) dgv.Columns["CategoriaID"].Visible = false;
            if (dgv.Columns.Contains("MetodoPgtoID")) dgv.Columns["MetodoPgtoID"].Visible = false;

            // Configurar colunas visíveis
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

            if (dgv.Columns.Contains("DataCriacao"))
            {
                dgv.Columns["DataCriacao"].HeaderText = "Data da Compra";
                dgv.Columns["DataCriacao"].Width = 120;
                dgv.Columns["DataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
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

            if (dgv.Columns.Contains("DataPagamento"))
            {
                dgv.Columns["DataPagamento"].HeaderText = "Data Pgto";
                dgv.Columns["DataPagamento"].Width = 120;
                dgv.Columns["DataPagamento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgv.Columns["DataPagamento"].DefaultCellStyle.NullValue = "";
                dgv.Columns["DataPagamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgv.ReadOnly = true;
        }

        private void DgvRelatorio_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvRelatorio.Rows[e.RowIndex].Cells["Descricao"].Value?.ToString() == "Total")
            {
                e.CellStyle.Font = new Font(dgvRelatorio.Font, FontStyle.Bold);
                e.CellStyle.BackColor = Color.LightGray;
                e.CellStyle.ForeColor = Color.Black;

                if (dgvRelatorio.Columns[e.ColumnIndex].Name == "DataCriacao" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "DataVencimento" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "DataPagamento" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "NumeroParcela" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "NomeCategoria" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "Pago")
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
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
                string status = cmbStatus.SelectedItem.ToString();

                DateTime inicioMesAtual = new DateTime(mesAno.Year, mesAno.Month, 1);
                DateTime fimMesAnterior = inicioMesAtual.AddDays(-1);

                // Calcular saldo acumulado até o mês anterior
                var receitasTotais = receitasBLL.Pesquisar();
                var parcelasTotais = parcelasBLL.Pesquisar();
                var despesasTotais = despesasBLL.PesquisarRelatorio();

                decimal totalReceitasAnteriores = receitasTotais
                    .Where(r => r.DataRecebimento <= fimMesAnterior)
                    .Sum(r => r.ValorDaReceita);

                decimal totalDespesasAnteriores = parcelasTotais
                    .Where(p => p.DataVencimento <= fimMesAnterior)
                    .Sum(p => p.ValorParcela);

                decimal saldoAcumulado = totalReceitasAnteriores - totalDespesasAnteriores;

                // Buscar e filtrar parcelas do mês atual
                var parcelas = parcelasBLL.Pesquisar();
                var despesas = despesasBLL.PesquisarRelatorio();
                var relatorio = from p in parcelas
                                join d in despesas on p.DespesaID equals d.DespesaID
                                select new
                                {
                                    p.ParcelaID,
                                    p.DespesaID,
                                    d.Descricao,
                                    d.ValorDaCompra,
                                    d.DataCriacao,
                                    p.NumeroParcela,
                                    p.ValorParcela,
                                    p.DataVencimento,
                                    p.Pago,
                                    p.DataPagamento,
                                    d.NomeCategoria,
                                    d.CategoriaID,
                                    d.MetodoPgtoID
                                };

                var relatorioFiltrado = relatorio.AsEnumerable();

                if (categoria != "Todos")
                {
                    int categoriaId = GetCategoriaId();
                    if (categoriaId > 0)
                        relatorioFiltrado = relatorioFiltrado.Where(r => r.CategoriaID == categoriaId);
                }

                if (metodoPagamento != "Todos")
                {
                    int metodoPgtoId = GetMetodoPgtoId();
                    if (metodoPgtoId > 0)
                        relatorioFiltrado = relatorioFiltrado.Where(r => r.MetodoPgtoID == metodoPgtoId);
                }

                relatorioFiltrado = relatorioFiltrado.Where(r => r.DataVencimento.Month == mesAno.Month && r.DataVencimento.Year == mesAno.Year);

                if (status != "Todos")
                {
                    if (status == "Atrasado")
                        relatorioFiltrado = relatorioFiltrado.Where(r => !r.Pago && r.DataVencimento < DateTime.Now);
                    else if (status == "Pago")
                        relatorioFiltrado = relatorioFiltrado.Where(r => r.Pago);
                    else if (status == "Pendente")
                        relatorioFiltrado = relatorioFiltrado.Where(r => !r.Pago && r.DataVencimento >= DateTime.Now);
                }

                var listaFiltrada = relatorioFiltrado.Select(r => new
                {
                    r.DespesaID,
                    r.ParcelaID,
                    r.Descricao,
                    r.ValorDaCompra,
                    r.DataCriacao,
                    r.NumeroParcela,
                    r.ValorParcela,
                    r.DataVencimento,
                    r.Pago,
                    r.DataPagamento,
                    r.NomeCategoria,
                    r.CategoriaID,
                    r.MetodoPgtoID
                }).ToList();

                if (listaFiltrada.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado com os filtros aplicados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        DataCriacao = DateTime.MinValue,
                        NumeroParcela = 0,
                        ValorParcela = totalValorParcela,
                        DataVencimento = DateTime.MinValue,
                        Pago = false,
                        DataPagamento = (DateTime?)null,
                        NomeCategoria = "",
                        CategoriaID = 0,
                        MetodoPgtoID = 0
                    };
                    listaFiltrada.Add(linhaTotal);

                    dgvRelatorio.DataSource = null;
                    dgvRelatorio.DataSource = listaFiltrada;
                    PersonalizarDataGridView(dgvRelatorio);

                    decimal totalAberto = listaFiltrada.Where(d => !d.Pago && d.Descricao != "Total").Sum(d => d.ValorParcela);
                    decimal totalPago = listaFiltrada.Where(d => d.Pago && d.Descricao != "Total").Sum(d => d.ValorParcela);
                    lblTotalAberto.Text = $"Total Aberto: {totalAberto:C2}";
                    lblTotalPago.Text = $"Total Pago: {totalPago:C2}";
                }

                var receitasMes = receitasTotais.Where(r => r.DataRecebimento.Month == mesAno.Month && r.DataRecebimento.Year == mesAno.Year);
                decimal totalReceitasMes = receitasMes.Sum(r => r.ValorDaReceita);

                decimal totalDespesasAcumuladas = parcelasTotais
                    .Where(p => !p.Pago && p.DataVencimento <= fimMesAnterior)
                    .Sum(p => p.ValorParcela);

                decimal totalDespesasMes = listaFiltrada.Where(d => d.Descricao != "Total").Sum(d => d.ValorParcela);

                decimal saldoFinal = saldoAcumulado + totalReceitasMes - (totalDespesasAcumuladas + totalDespesasMes);
                // Aqui você pode exibir o saldoFinal em algum controle, se desejar
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
    }
}
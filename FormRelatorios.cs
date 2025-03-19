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
using Money.DAL;
using Money.MODEL;


namespace Money
{
    public partial class FormRelatorios : KryptonForm
    {
        private readonly DespesasBLL despesasBLL = new DespesasBLL();
        private readonly ReceitasBLL receitasBLL = new ReceitasBLL(); // Adicione isso se existir
        public FormRelatorios()
        {
            InitializeComponent();
            dgvRelatorio.CellFormatting += dgvRelatorio_CellFormatting;
            InicializarControles();

            dgvRelatorio.DataError += dgvRelatorio_DataError; // Adicione este manipulador
                                                              // Adicionar o evento ValueChanged ao dtpMesAno
            
        }
        private void InicializarControles()
        {           
            cmbStatus.SelectedIndex = 0;

            // Preencher ComboBox de Categoria diretamente do banco
            var categorias = new List<string>();
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "SELECT NomeCategoria FROM Categorias ORDER BY NomeCategoria"; // Ordem alfabética para "Todos" aparecer no topo ou conforme desejado
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
            cmbCategoria.SelectedIndex = categorias.IndexOf("Todos"); // Seleciona "Todos" por padrão     


            // Preencher ComboBox de Métodos de Pagamento diretamente do banco
            var metodosPagamento = new List<string>();
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sqlMetodos = "SELECT NomeMetodoPagamento FROM MetodosPagamento ORDER BY NomeMetodoPagamento"; // Ordem alfabética para "Todos" aparecer no topo ou conforme desejado
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
            cmbMetodoPgto.SelectedIndex = metodosPagamento.IndexOf("Todos"); // Seleciona "Todos" por padrão  
        }
        private void PersonalizarDataGridView(KryptonDataGridView dgv)
        {
            // Desativar ajuste automático para garantir larguras fixas
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Ocultar colunas de ID
            if (dgv.Columns.Contains("DespesaID")) dgv.Columns["DespesaID"].Visible = false;
            if (dgv.Columns.Contains("CategoriaID")) dgv.Columns["CategoriaID"].Visible = false;
            if (dgv.Columns.Contains("MetodoPgtoID")) dgv.Columns["MetodoPgtoID"].Visible = false;

            // Configurar colunas visíveis
            if (dgv.Columns.Contains("Descricao"))
            {
                dgv.Columns["Descricao"].HeaderText = "Descrição";
                dgv.Columns["Descricao"].Width = 350;
            }

            if (dgv.Columns.Contains("Valor"))
            {
                dgv.Columns["Valor"].HeaderText = "Valor";
                dgv.Columns["Valor"].Width = 100;
                dgv.Columns["Valor"].DefaultCellStyle.Format = "C2";
                dgv.Columns["Valor"].DefaultCellStyle.ForeColor = Color.DarkRed;
                dgv.Columns["Valor"].DefaultCellStyle.BackColor = Color.LightYellow;
            }

            if (dgv.Columns.Contains("DataVencimento"))
            {
                dgv.Columns["DataVencimento"].HeaderText = "   Data\nVencimento";
                dgv.Columns["DataVencimento"].Width = 120;
                dgv.Columns["DataVencimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgv.Columns["DataVencimento"].DefaultCellStyle.NullValue = ""; // Garante que null aparece como vazio
            }

            if (dgv.Columns.Contains("Status"))
            {
                dgv.Columns["Status"].HeaderText = "Status";
                dgv.Columns["Status"].Width = 70;
            }

            if (dgv.Columns.Contains("NumeroParcelas"))
            {
                dgv.Columns["NumeroParcelas"].HeaderText = "    Nº\nParcelas";
                dgv.Columns["NumeroParcelas"].Width = 60;
                dgv.Columns["NumeroParcelas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["NumeroParcelas"].DefaultCellStyle.NullValue = ""; // Garante que null aparece como vazio
            }

            if (dgv.Columns.Contains("ValorParcela"))
            {
                dgv.Columns["ValorParcela"].HeaderText = "Valor Parcela";
                dgv.Columns["ValorParcela"].Width = 120;
                dgv.Columns["ValorParcela"].DefaultCellStyle.Format = "C2";
                dgv.Columns["ValorParcela"].DefaultCellStyle.ForeColor = Color.DarkGreen;
                dgv.Columns["ValorParcela"].DefaultCellStyle.BackColor = Color.LightCyan;
                dgv.Columns["ValorParcela"].DefaultCellStyle.NullValue = ""; // Garante que null aparece como vazio
            }

            if (dgv.Columns.Contains("NomeCategoria"))
            {
                dgv.Columns["NomeCategoria"].HeaderText = "Categoria";
                dgv.Columns["NomeCategoria"].Width = 150;
                dgv.Columns["NomeCategoria"].DefaultCellStyle.NullValue = ""; // Garante que null aparece como vazio
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
                dgv.Columns["DataPgto"].DefaultCellStyle.NullValue = ""; // Garante que null aparece como vazio
                dgv.Columns["DataPgto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Tornar o grid somente leitura
            dgv.ReadOnly = true;

            // Adicionar evento CellFormatting para destacar a linha de totais
            dgv.CellFormatting -= DgvRelatorio_CellFormatting;
            dgv.CellFormatting += DgvRelatorio_CellFormatting;
        }



        private void DgvRelatorio_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvRelatorio.Rows[e.RowIndex].Cells["Descricao"].Value?.ToString() == "Total")
            {
                e.CellStyle.Font = new Font(dgvRelatorio.Font, FontStyle.Bold); // Negrito
                e.CellStyle.BackColor = Color.LightGray; // Fundo cinza
                e.CellStyle.ForeColor = Color.Black; // Texto preto

                // Limpar valores de colunas não monetárias na linha de total
                if (dgvRelatorio.Columns[e.ColumnIndex].Name == "DataVencimento" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "DataPgto" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "Status" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "NumeroParcelas" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "NomeCategoria" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "Pago")
                {
                    e.Value = ""; // Define como vazio
                    e.FormattingApplied = true; // Indica que o valor foi formatado manualmente
                }
            }
        }
       
        private void FormRelatorios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Suprima o som de "beep"
                e.Handled = true;
                // Envia a tecla Tab
                SendKeys.Send("{TAB}");
            }
        }
        private int GetCategoriaId()
        {
            if (cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Erro: categoria está nula!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            string nomeCategoria = cmbCategoria.Text.Trim();            
            string query = "SELECT CategoriaID FROM Categorias WHERE NomeCategoria = @NomeCategoria";
            int categoriaID = Utilitario.ObterCodigoComboBox(query, "@NomeCategoria", nomeCategoria);
            if (categoriaID == -1)
                MessageBox.Show($"Nenhum CategoriaID encontrado para '{nomeCategoria}'", "Debug");
            return categoriaID;
        }
        private int GetMetodoPgtoId()
        {
            if (cmbMetodoPgto.SelectedItem == null)
            {
                MessageBox.Show("Erro: Métodos pagamento está nula!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            string nomeMetodoPgto = cmbMetodoPgto.Text.Trim();
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

                // Definir o último dia do mês anterior
                DateTime inicioMesAtual = new DateTime(mesAno.Year, mesAno.Month, 1);
                DateTime fimMesAnterior = inicioMesAtual.AddDays(-1);

                // Passo 1: Calcular o saldo acumulado até o mês anterior
                var receitasTotais = receitasBLL.Pesquisar();
                var despesasTotais = despesasBLL.PesquisarRelatorio();

                decimal totalReceitasAnteriores = receitasTotais
                    .Where(r => r.Data <= fimMesAnterior)
                    .Sum(r => r.Valor);

                decimal totalDespesasAnteriores = despesasTotais
                    .Where(d => d.DataVencimento <= fimMesAnterior)
                    .Sum(d => d.Valor);

                decimal saldoAcumulado = totalReceitasAnteriores - totalDespesasAnteriores;

                // Passo 2: Buscar e filtrar despesas do mês atual
                var despesas = despesasBLL.PesquisarRelatorio();
                var despesasFiltradas = despesas.AsEnumerable();

                if (categoria != "Todos")
                {
                    int categoriaId = GetCategoriaId();
                    if (categoriaId != -1 && categoriaId != 0)
                    {
                        despesasFiltradas = despesasFiltradas.Where(d => d.CategoriaID.HasValue && d.CategoriaID.Value == categoriaId);
                    }
                }

                if (metodoPagamento != "Todos")
                {
                    int metodoPgtoId = GetMetodoPgtoId();
                    if (metodoPgtoId != -1 && metodoPgtoId != 0)
                    {
                        despesasFiltradas = despesasFiltradas.Where(d => d.MetodoPgtoID.HasValue && d.MetodoPgtoID.Value == metodoPgtoId);
                    }
                }

                despesasFiltradas = despesasFiltradas.Where(d => d.DataVencimento.Month == mesAno.Month && d.DataVencimento.Year == mesAno.Year);

                if (status != "Todos")
                {
                    if (status == "Atrasado")
                        despesasFiltradas = despesasFiltradas.Where(d => !d.Pago && d.DataVencimento < DateTime.Now);
                    else if (status == "Pago")
                        despesasFiltradas = despesasFiltradas.Where(d => d.Pago);
                    else if (status == "Pendente")
                        despesasFiltradas = despesasFiltradas.Where(d => !d.Pago && d.DataVencimento >= DateTime.Now);
                }

                var listaFiltrada = despesasFiltradas.ToList();
                decimal totalAberto = 0m;
                decimal totalPago = 0m;

                if (listaFiltrada.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado com os filtros aplicados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvRelatorio.DataSource = null;
                    lblTotalAberto.Text = "Total Aberto: R$ 0,00";
                    lblTotalPago.Text = "Total Pago: R$ 0,00";
                }
                else
                {
                    decimal totalValor = listaFiltrada.Sum(d => d.Valor);
                    decimal? totalValorParcela = listaFiltrada.Where(d => d.ValorParcela.HasValue).Sum(d => d.ValorParcela);

                    var linhaTotal = new DespesasModel
                    {
                        Descricao = "Total",
                        Valor = totalValor,
                        ValorParcela = totalValorParcela,
                        DataVencimento = DateTime.MinValue,
                        DataPgto = null,
                        Status = "",
                        NumeroParcelas = null,
                        NomeCategoria = null,
                        Pago = false
                    };
                    listaFiltrada.Add(linhaTotal);

                    dgvRelatorio.DataSource = null;
                    dgvRelatorio.DataSource = listaFiltrada;
                    PersonalizarDataGridView(dgvRelatorio);

                    totalAberto = listaFiltrada.Where(d => !d.Pago && d.Descricao != "Total").Sum(d => d.Valor);
                    totalPago = listaFiltrada.Where(d => d.Pago && d.Descricao != "Total").Sum(d => d.Valor);
                    lblTotalAberto.Text = $"Total Aberto: {totalAberto:C2}";
                    lblTotalPago.Text = $"Total Pago: {totalPago:C2}";
                }

                // Passo 3: Calcular receitas e despesas do mês atual
                var receitasMes = receitasTotais.Where(r => r.Data.Month == mesAno.Month && r.Data.Year == mesAno.Year);
                decimal totalReceitasMes = receitasMes.Sum(r => r.Valor);

                // Incluir despesas acumuladas não pagas de meses anteriores + despesas do mês atual
                decimal totalDespesasAcumuladas = despesasTotais
                    .Where(d => !d.Pago && d.DataVencimento <= fimMesAnterior)
                    .Sum(d => d.Valor);

                decimal totalDespesasMes = listaFiltrada.Where(d => d.Descricao != "Total").Sum(d => d.Valor);

                // Passo 4: Calcular o saldo final
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

        private void FormRelatorios_Load(object sender, EventArgs e)
        {           
        }

        private void dgvRelatorio_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvRelatorio.Rows[e.RowIndex].Cells["Descricao"].Value?.ToString() == "Total")
            {
                e.CellStyle.Font = new Font(dgvRelatorio.Font, FontStyle.Bold); // Negrito
                e.CellStyle.BackColor = Color.LightGray; // Fundo cinza
                e.CellStyle.ForeColor = Color.Black; // Texto preto

                // Limpar valores de colunas não monetárias na linha de total
                if (dgvRelatorio.Columns[e.ColumnIndex].Name == "DataVencimento" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "DataPgto" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "Status" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "NumeroParcelas" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "NomeCategoria" ||
                    dgvRelatorio.Columns[e.ColumnIndex].Name == "Pago")
                {
                    e.Value = ""; // Define como vazio
                    e.FormattingApplied = true; // Indica que o valor foi formatado manualmente
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            var data = dgvRelatorio.DataSource as List<DespesasModel>;
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
                                Valor = d.Valor,
                                DataVencimento = d.DataVencimento.ToString("dd/MM/yyyy"),
                                Status = d.Status,
                                NomeCategoria = d.NomeCategoria,
                                Pago = d.Pago ? "Sim" : "Não"
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
            // Logar o erro para depuração (opcional)
            Console.WriteLine($"DataGridView DataError: {e.Exception.Message} na coluna {e.ColumnIndex}, linha {e.RowIndex}");
            e.ThrowException = false; // Impede que o erro seja lançado como exceção visível
        }
    }
}

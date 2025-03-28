﻿using System;
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
using DocumentFormat.OpenXml.Wordprocessing;
using Money.BLL;
using Money.DAL;
using Money.MODEL;
using Color = System.Drawing.Color;
using View = System.Windows.Forms.View;
using System.Runtime.InteropServices; // Para P/Invoke



namespace Money
{
    public partial class FormManutencaoDespesas : KryptonForm   
    {
        private DespesasModel TipoAtual { get; set; }
        private readonly DespesasBLL despesasBLL = new DespesasBLL();
        private readonly ParcelasBLL parcelasBLL = new ParcelasBLL(); // Adicionado para acessar parcelas
        private string StatusOperacao;

        public FormManutencaoDespesas(string statusOperacao = "CONSULTA")
        {
            InitializeComponent();
            StatusOperacao = statusOperacao;

            radioPagas.CheckedChanged += radioPagas_CheckedChanged;
            radioPendentes.CheckedChanged += radioPendentes_CheckedChanged;
            Utilitario.AdicionarEfeitoFocoEmTodos(this);

            AtualizarListView();
            lstvDespesas.SelectedIndexChanged += lstvDespesas_SelectedIndexChanged;
        }
        private void PersonalizarListView(ListView lstvDespesas)
        {
            lstvDespesas.View = View.Details;
            lstvDespesas.FullRowSelect = true;
            lstvDespesas.GridLines = true;

            lstvDespesas.BackColor = Color.FromArgb(0, 33, 71);
            lstvDespesas.ForeColor = Color.White;

            lstvDespesas.HeaderStyle = ColumnHeaderStyle.Clickable;
            lstvDespesas.OwnerDraw = false;

            lstvDespesas.Columns.Clear();
            lstvDespesas.Columns.Add("DespesaID", 0); // Oculta
            lstvDespesas.Columns.Add("Descrição", 400);
            lstvDespesas.Columns.Add("Valor Total", 100, HorizontalAlignment.Right);
            lstvDespesas.Columns.Add("DataDaCompra", 100, HorizontalAlignment.Center);
            lstvDespesas.Columns.Add("Categoria", 100);
            lstvDespesas.Columns.Add("Método Pgto", 100);
            lstvDespesas.Columns.Add("Nº Parcelas", 80, HorizontalAlignment.Center);
            lstvDespesas.Columns.Add("Data Vencto", 100, HorizontalAlignment.Center);
            lstvDespesas.Columns.Add("Valor Parcela", 100, HorizontalAlignment.Right);
            lstvDespesas.Columns.Add("Pago", 50, HorizontalAlignment.Center);
            lstvDespesas.Columns.Add("DataPgto", 100, HorizontalAlignment.Center);

            ApplyHeaderBackgroundColor(lstvDespesas, Color.FromArgb(0, 120, 215));
        }

        private void CarregarDados(string nomeTipo = null, bool? pago = null)
        {
            try
            {
                lstvDespesas.BeginUpdate();
                lstvDespesas.Items.Clear();
                PersonalizarListView(lstvDespesas);

                var despesas = despesasBLL.Pesquisar(nomeTipo);
                var parcelas = parcelasBLL.Pesquisar();
                DateTime hoje = DateTime.Today;

                foreach (var despesa in despesas)
                {
                    var parcelasDespesa = parcelas.Where(p => p.DespesaID == despesa.DespesaID).ToList();
                    foreach (var parcela in parcelasDespesa)
                    {
                        if (pago.HasValue && parcela.Pago != pago.Value) continue;

                        var item = new ListViewItem(new[] {
                    despesa.DespesaID.ToString(),
                    despesa.Descricao,
                    despesa.ValorDaCompra.ToString("C2", CultureInfo.CurrentCulture),
                    despesa.DataDaCompra.ToString("dd/MM/yyyy"),
                    despesa.NomeCategoria ?? "",
                    Utilitario.PesquisarPorCodigoExibirEmTexbox("MetodosPagamento", "MetodoPgtoID", "NomeMetodoPagamento", despesa.MetodoPgtoID ?? 0),
                    $"{parcela.NumeroParcela}/{parcelasDespesa.Count}",
                    parcela.DataVencimento.ToString("dd/MM/yyyy"),
                    parcela.ValorParcela.ToString("C2", CultureInfo.CurrentCulture),
                    parcela.Pago.HasValue && parcela.Pago.Value ? "Sim" : "Não",
                    parcela.DataPgto?.ToString("dd/MM/yyyy") ?? ""
                });

                        // Use DespesaParcelaTag em vez de objeto anônimo
                        item.Tag = new DespesaParcelaTag
                        {
                            Despesa = despesa,
                            Parcela = parcela
                        };

                        item.UseItemStyleForSubItems = false;
                        item.BackColor = lstvDespesas.Items.Count % 2 == 0 ? Color.FromArgb(0, 33, 71) : Color.FromArgb(70, 70, 70);
                        item.ForeColor = Color.White;

                        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                        {
                            subItem.BackColor = item.BackColor;
                            subItem.ForeColor = Color.White;
                        }

                        if (parcela.DataVencimento < hoje && parcela.Pago.HasValue && !parcela.Pago.Value)
                            item.SubItems[7].BackColor = Color.Red;
                        else if (parcela.DataVencimento.Date == hoje && !(bool)parcela.Pago)
                            item.SubItems[7].BackColor = Color.Orange;
                        else if ((bool)!parcela.Pago)
                            item.SubItems[7].BackColor = Color.Green;

                        item.SubItems[8].BackColor = Color.FromArgb(255, 245, 220);
                        item.SubItems[8].ForeColor = Color.DarkRed;

                        lstvDespesas.Items.Add(item);
                    }
                }

                lstvDespesas.EndUpdate();
                AtualizarTotais(parcelas.Where(p => despesas.Any(d => d.DespesaID == p.DespesaID)).ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private const int LVM_SETBKCOLOR = 0x1001;
        private const int HDM_SETBKCOLOR = 0x1204;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        private void ApplyHeaderBackgroundColor(ListView listView, Color color)
        {
            IntPtr header = SendMessage(listView.Handle, 0x1200, IntPtr.Zero, IntPtr.Zero);
            if (header != IntPtr.Zero)
            {
                int colorRef = ColorTranslator.ToWin32(color);
                SendMessage(header, HDM_SETBKCOLOR, IntPtr.Zero, (IntPtr)colorRef);
                listView.Refresh();
            }
        }

        private void AtualizarTotais(List<ParcelasModel> parcelas)
        {
            try
            {
                if (parcelas != null)
                {
                    var parcelasAbertas = parcelas.Where(p => p.Pago.HasValue && !p.Pago.Value);
                    decimal valorTotalAberto = parcelasAbertas.Sum(p => p.ValorParcela);
                    int qtdItensPendentes = parcelasAbertas.Count();

                    txtValorTotalAberto.Text = valorTotalAberto.ToString("N2", CultureInfo.CurrentCulture);
                    txtQtdItens.Text = qtdItensPendentes.ToString();
                }
                else
                {
                    txtValorTotalAberto.Text = "R$ 0,00";
                    txtQtdItens.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao calcular totais: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AtualizarListView()
        {
            lstvDespesas.Items.Clear();

            // Buscar todas as despesas (substitua por sua lógica real)
            var despesas = despesasBLL.Pesquisar(); // Exemplo: sua lógica para buscar despesas
            foreach (var despesa in despesas)
            {
                // Buscar a parcela associada à despesa (substitua por sua lógica real)
                var parcela = parcelasBLL.Pesquisar(despesa.DespesaID).FirstOrDefault(); // Exemplo: buscar a primeira parcela

                // Criar o item do ListView com os dados da despesa
                var item = new ListViewItem(new[]
                {
                    despesa.DespesaID.ToString(),
                    despesa.Descricao,
                    despesa.ValorDaCompra.ToString("N2", CultureInfo.CurrentCulture),
                    // Adicione outros campos conforme necessário, por exemplo:
                    parcela?.DataVencimento.ToString("dd/MM/yyyy") ?? "N/A",
                    parcela?.Pago.ToString() ?? "N/A"
                    });

                // Atribuir o Tag com a classe DespesaParcelaTag
                item.Tag = new DespesaParcelaTag
                {
                    Despesa = despesa,
                    Parcela = parcela ?? new ParcelasModel() // Use uma parcela vazia se não houver
                };

                // Adicionar o item ao ListView
                lstvDespesas.Items.Add(item);
            }

            // Chamar CarregarDados (se necessário, verifique o propósito deste método)
            CarregarDados();
        }

        private void LimparCampos()
        {
            txtPesquisa.Clear();
            TipoAtual = null;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        //private void AbrirFormularioCadastro()
        //{
        //    var selectedItem = lstvDespesas.SelectedItems.Count > 0 ? lstvDespesas.SelectedItems[0] : null;
        //    var data = selectedItem?.Tag as DespesaParcelaTag;
        //    int parcelaID = data?.Parcela?.ParcelaID ?? 0;

        //    FormCadastroDespesa form = new FormCadastroDespesa(StatusOperacao, this, parcelaID);

        //    try
        //    {
        //        switch (StatusOperacao)
        //        {
        //            // Outros casos...
        //            case "PAGAR":
        //                PreencherCampos(form);
        //                ConfigurarFormulario(form, "PAGAR", true, "Confirmar Pgto", true);
        //                DesabilitarCampos(form);
        //                form.btnSalvar.BackColor = Color.RoyalBlue;
        //                form.panelTitulo.BackColor = Color.RoyalBlue;
        //                form.btnSalvar.ForeColor = Color.White;
        //                form.lblDataCadastro_e_Pagamento.Text = "Data Pagamento";
        //                form.lblTitulo.Text = "Pagar Despesa";
        //                form.ShowDialog();
        //                break;
        //                // Outros casos...
        //        }
        //        if (form.Salvou)
        //        {
        //            AtualizarListView();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        form.Dispose();
        //    }
        //}
        private void AbrirFormularioCadastro()
        {
            FormCadastroDespesa form = new FormCadastroDespesa(StatusOperacao, this);

            try
            {
                switch (StatusOperacao)
                {
                    case "NOVO":
                        ConfigurarFormulario(form, "NOVO", true, "Salvar", true);
                        form.btnSalvar.BackColor = Color.FromArgb(1, 128, 255);
                        form.panelTitulo.BackColor = Color.FromArgb(1, 128, 255);
                        form.btnSalvar.ForeColor = Color.White;
                        form.lblTitulo.Text = "Nova Despesa";
                        form.ShowDialog();
                        break;

                    case "ALTERAR":
                        PreencherCampos(form);
                        ConfigurarFormulario(form, "ALTERAR", true, "Alterar", true);
                        form.btnSalvar.BackColor = Color.OrangeRed;
                        form.btnSalvar.ForeColor = Color.White;
                        form.lblTitulo.Text = "Alterar Despesa";
                        form.panelTitulo.BackColor = Color.OrangeRed;
                        form.btnNovo.Visible = false;
                        form.dtpDataCadastro.Enabled = false;
                        form.ShowDialog();
                        break;

                    case "PAGAR":
                        PreencherCampos(form);
                        ConfigurarFormulario(form, "PAGAR", true, "Confirmar Pgto", true);
                        DesabilitarCampos(form);
                        form.btnSalvar.BackColor = Color.RoyalBlue;
                        form.panelTitulo.BackColor = Color.RoyalBlue;
                        form.btnSalvar.ForeColor = Color.White;
                        form.lblDataCadastro_e_Pagamento.Text = "Data Pagamento";
                        form.lblTitulo.Text = "Pagar Despesa";
                        form.ShowDialog();
                        break;

                    case "EXCLUSÃO":
                        PreencherCampos(form);
                        ConfigurarFormulario(form, "EXCLUSÃO", true, "Excluir", true);
                        DesabilitarCampos(form);
                        form.btnSalvar.BackColor = Color.Red;
                        form.panelTitulo.BackColor = Color.Red;
                        form.btnSalvar.ForeColor = Color.White;
                        form.lblTitulo.Text = "Excluir Despesa";
                        form.ShowDialog();
                        break;
                }
                if (form.Salvou)
                {
                    AtualizarListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                form.Dispose();
            }
        }

        private void PreencherCampos(FormCadastroDespesa form)
        {
            if (TipoAtual != null)
            {
                var data = lstvDespesas.SelectedItems[0].Tag as DespesaParcelaTag;
                var parcelaAtual = data?.Parcela; // Pega a parcela do Tag
                form.DespesaID = TipoAtual.DespesaID;
                form.txtDespesaID.Text = TipoAtual.DespesaID.ToString();
                form.txtDescricao.Text = TipoAtual.Descricao;
                form.txtValorTotal.Text = TipoAtual.ValorDaCompra.ToString("N2", CultureInfo.CurrentCulture);
                form.dtpDataCadastro.Value = TipoAtual.DataDaCompra;
                form.CategoriaID = TipoAtual.CategoriaID ?? 0;
                form.MetodoPgtoID = TipoAtual.MetodoPgtoID ?? 0;

                if (parcelaAtual != null)
                {
                    form.txtNumeroParcelas.Text = $"{parcelaAtual.NumeroParcela}/{parcelasBLL.Pesquisar(TipoAtual.DespesaID).Count}";
                    form.txtValorParcela.Text = parcelaAtual.ValorParcela.ToString("N2", CultureInfo.CurrentCulture);
                    form.dtpDataVencimento.Value = parcelaAtual.DataVencimento;                    
                    form.radiobtnPago.Checked = parcelaAtual.Pago ?? false; // Pago já é bool?, precisa de conversão
                    form.radiobtnPendente.Checked = !parcelaAtual.Pago ?? true;                    
                }

                form.txtCategoria.Text = Utilitario.PesquisarPorCodigoExibirEmTexbox("Categorias", "CategoriaID", "NomeCategoria", form.CategoriaID);
                form.txtMetodoPgto.Text = Utilitario.PesquisarPorCodigoExibirEmTexbox("MetodosPagamento", "MetodoPgtoID", "NomeMetodoPagamento", form.MetodoPgtoID);
            }
        }
        public class DespesaParcelaTag
        {
            public DespesasModel Despesa { get; set; }
            public ParcelasModel Parcela { get; set; }
        }
        private void lstvDespesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvDespesas.SelectedItems.Count > 0)
            {
                var selectedItem = lstvDespesas.SelectedItems[0];
                var data = selectedItem.Tag as DespesaParcelaTag;

                if (data == null || data.Despesa == null)
                {
                    MessageBox.Show("Erro: Dados da despesa não encontrados no item selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TipoAtual = null;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnExcel.Enabled = false;
                    btnPagarConta.Enabled = false;
                    return;
                }

                TipoAtual = data.Despesa;

                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnExcel.Enabled = true;
                btnPagarConta.Enabled = data.Parcela != null && data.Parcela.Pago.HasValue ? !data.Parcela.Pago.Value : true;
            }
            else
            {
                TipoAtual = null;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnExcel.Enabled = false;
                btnPagarConta.Enabled = false;
            }
        }





        private void lstvDespesas_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 120, 215))) // Azul escuro (RoyalBlue)
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }
            using (SolidBrush textBrush = new SolidBrush(Color.White))
            {
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                e.Graphics.DrawString(e.Header.Text, lstvDespesas.Font, textBrush, e.Bounds, sf);
            }
            e.DrawDefault = false;
        }

        private void lstvDespesas_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawBackground();
            e.Item.BackColor = e.Item.Index % 2 == 0 ?
                Color.FromArgb(0, 33, 71) : // Cinza escuro
                Color.FromArgb(70, 70, 70); // Cinza um pouco mais claro
            e.Item.ForeColor = Color.White;
        }

        private void lstvDespesas_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            // Aplica a cor de fundo padrão do item
            e.DrawBackground();

            // Colorir "Data Vencto" (índice 3)
            if (e.ColumnIndex == 3 && DateTime.TryParseExact(e.SubItem.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataVencimento))
            {
                DateTime hoje = DateTime.Today;
                Color dataColor = dataVencimento < hoje ? Color.Red :
                                 dataVencimento.Date == hoje ? Color.Orange :
                                 Color.LightGreen;

                using (SolidBrush brush = new SolidBrush(dataColor))
                {
                    e.Graphics.FillRectangle(brush, e.Bounds);
                }
            }
            // Destacar "Valor Parcela" (índice 6)
            else if (e.ColumnIndex == 6)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 245, 220))) // Amarelo claro
                {
                    e.Graphics.FillRectangle(brush, e.Bounds);
                }
                e.SubItem.ForeColor = Color.DarkRed;
            }

            // Desenhar o texto
            using (SolidBrush textBrush = new SolidBrush(e.SubItem.ForeColor))
            {
                StringFormat sf = new StringFormat
                {
                    Alignment = e.Header.TextAlign == HorizontalAlignment.Right ? StringAlignment.Far :
                                e.Header.TextAlign == HorizontalAlignment.Center ? StringAlignment.Center :
                                StringAlignment.Near
                };
                e.Graphics.DrawString(e.SubItem.Text, e.SubItem.Font ?? lstvDespesas.Font, textBrush, e.Bounds, sf);
            }
        }
        public void ConfigurarFormulario(FormCadastroDespesa form, string operacao, bool camposHabilitados, string textoBotao, bool botaoHabilitado)
        {
            form.StatusOperacao = operacao;
            form.btnSalvar.Text = textoBotao;
            form.btnSalvar.Enabled = botaoHabilitado;
        }
        private void FormCadastroTiposReceita_Load(object sender, EventArgs e)
        {
            radioPendentes.Checked = true;
            CarregarDados();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            StatusOperacao = "NOVO";
            AbrirFormularioCadastro();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (TipoAtual == null)
            {
                MessageBox.Show("Selecione uma despesa para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StatusOperacao = "ALTERAR";
            AbrirFormularioCadastro();
        }

        private void DesabilitarCampos(FormCadastroDespesa form)
        {
            form.txtDespesaID.Enabled = false;
            form.txtDescricao.Enabled = false;
            form.txtValorTotal.Enabled = false;
            form.dtpDataVencimento.Enabled = false;
            form.txtNumeroParcelas.Enabled = false;
            form.txtValorParcela.Enabled = false;
            form.txtCategoria.Enabled = false;
            form.txtMetodoPgto.Enabled = false;
            form.btnNovo.Visible = false;
            form.btnLocalizarCategoria.Enabled = false;
            form.btnLocalizarMetodoPagamento.Enabled = false;
            form.groupBoxParcelar.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //using (var workbook = new ClosedXML.Excel.XLWorkbook())
            //{
            //    var worksheet = workbook.Worksheets.Add("Relatório Despesas");
            //    var data = dgvDespesa.DataSource as List<DespesasModel>;
            //    if (data != null)
            //    {
            //        worksheet.Cell(1, 1).InsertTable(data);
            //        worksheet.Columns().AdjustToContents();
            //    }
            //    workbook.SaveAs("RelatorioDespesas.xlsx");
            //}
            //MessageBox.Show("Relatório exportado para Excel!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lstvDespesas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um registro para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lstvDespesas.SelectedItems.Count == 1 ||
                MessageBox.Show("Deseja excluir apenas o registro atual?", "Excluir Despesas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (TipoAtual == null)
                {
                    MessageBox.Show("Selecione uma despesa para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                StatusOperacao = "EXCLUSÃO";
                AbrirFormularioCadastro();
            }
            else
            {
                int numeroSelecionados = lstvDespesas.SelectedItems.Count;
                if (MessageBox.Show($"Deseja realmente excluir todos os {numeroSelecionados} registros selecionados?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        foreach (ListViewItem item in lstvDespesas.SelectedItems)
                        {
                            int despesaId = Convert.ToInt32(item.SubItems[0].Text);
                            despesasBLL.Excluir(despesaId);
                        }
                        MessageBox.Show($"{numeroSelecionados} despesas excluídas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarListView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir os registros: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            bool? pago = null;
            if (radioPagas.Checked)
                pago = true;
            else if (radioPendentes.Checked)
                pago = false;
            CarregarDados(txtPesquisa.Text, pago);
        }

        private void btnPagarConta_Click(object sender, EventArgs e)
        {
            if (TipoAtual == null)
            {
                MessageBox.Show("Selecione uma despesa para pagar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StatusOperacao = "PAGAR";
            AbrirFormularioCadastro();
        }

        private void radioPagas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPagas.Checked)
                CarregarDados(txtPesquisa.Text, true);
        }

        private void radioPendentes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPendentes.Checked)
                CarregarDados(txtPesquisa.Text, false);
        }    
       
    }
}

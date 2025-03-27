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
        private DespesasModel TipoAtual { get; set; } // Armazena o tipo selecionado        
        private readonly DespesasBLL despesasBLL = new DespesasBLL();
        private string StatusOperacao;

        public FormManutencaoDespesas(string statusOperacao = "CONSULTA")
        {
            InitializeComponent();
            StatusOperacao = statusOperacao;           
           
            radioPagas.CheckedChanged += radioPagas_CheckedChanged;
            radioPendentes.CheckedChanged += radioPendentes_CheckedChanged;
            Utilitario.AdicionarEfeitoFocoEmTodos(this);

            AtualizarListView(); // Substitui AtualizarDataGrid
            lstvDespesas.SelectedIndexChanged += lstvDespesas_SelectedIndexChanged; // Novo evento
        }

        private void PersonalizarListView(ListView lstvDespesas)
        {
            lstvDespesas.View = View.Details;
            lstvDespesas.FullRowSelect = true;
            lstvDespesas.GridLines = true;

            // Configuração visual
            lstvDespesas.BackColor = Color.FromArgb(0, 33, 71); // Cinza escuro para o fundo
            lstvDespesas.ForeColor = Color.White; // Letras brancas

            // Configuração do cabeçalho
            lstvDespesas.HeaderStyle = ColumnHeaderStyle.Clickable;
            lstvDespesas.OwnerDraw = false; // Desativado para melhorar desempenho e evitar flickering

            // Adicionar colunas
            lstvDespesas.Columns.Clear();
            lstvDespesas.Columns.Add("DespesaID", 0); // Oculta
            lstvDespesas.Columns.Add("Descrição", 400);
            lstvDespesas.Columns.Add("Valor da Compra", 100, HorizontalAlignment.Right);
            lstvDespesas.Columns.Add("Data Vencto", 80, HorizontalAlignment.Center);
            lstvDespesas.Columns.Add("Status", 60, HorizontalAlignment.Center);
            lstvDespesas.Columns.Add("Nº Parc.", 60, HorizontalAlignment.Center);
            lstvDespesas.Columns.Add("Valor Parcela", 80, HorizontalAlignment.Right);
            lstvDespesas.Columns.Add("Categoria", 100);
            lstvDespesas.Columns.Add("Data Pagamento", 100, HorizontalAlignment.Center);

            // Aplicar cor ao cabeçalho via P/Invoke
            ApplyHeaderBackgroundColor(lstvDespesas, Color.FromArgb(0, 120, 215)); // RoyalBlue
        }

        private void CarregarDados(string nomeTipo = null, bool? pago = null)
        {
            try
            {
                lstvDespesas.BeginUpdate();
                lstvDespesas.Items.Clear();
                PersonalizarListView(lstvDespesas);

                var tipos = despesasBLL.Pesquisar(nomeTipo, pago);
                DateTime hoje = DateTime.Today;

                foreach (var despesa in tipos)
                {
                    var item = new ListViewItem(new[] {
                despesa.DespesaID.ToString(),                              // 0: DespesaID (oculta)
                despesa.Descricao,                                        // 1: Descrição
                despesa.ValorDaCompra.ToString("C2", CultureInfo.CurrentCulture), // 2: Valor da Compra
                despesa.DataVencimento.ToString("dd/MM/yyyy"),            // 3: Data Vencto
                despesa.Status,                                           // 4: Status
                despesa.NumeroParcelas.ToString(),                        // 5: Nº Parc.
                despesa.ValorParcela?.ToString("C2", CultureInfo.CurrentCulture) ?? string.Empty, // 6: Valor Parcela
                despesa.NomeCategoria,                                    // 7: Categoria
                despesa.DataPgto?.ToString("dd/MM/yyyy") ?? ""            // 8: Data Pagamento
            });

                    // Armazenar o objeto DespesasModel completo no Tag
                    item.Tag = despesa;

                    // Alternância de cores nas linhas
                    item.UseItemStyleForSubItems = false;
                    item.BackColor = lstvDespesas.Items.Count % 2 == 0 ?
                        Color.FromArgb(0, 33, 71) : // Cor ajustada para combinar com o fundo
                        Color.FromArgb(70, 70, 70);
                    item.ForeColor = Color.White;

                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        subItem.BackColor = item.BackColor;
                        subItem.ForeColor = Color.White;
                    }

                    if (despesa.DataVencimento < hoje)
                        item.SubItems[3].BackColor = Color.Red;
                    else if (despesa.DataVencimento.Date == hoje)
                        item.SubItems[3].BackColor = Color.Orange;
                    else
                        item.SubItems[3].BackColor = Color.Green;

                    item.SubItems[6].BackColor = Color.FromArgb(255, 245, 220); // Valor Parcela
                    item.SubItems[6].ForeColor = Color.DarkRed;

                    lstvDespesas.Items.Add(item);
                }

                lstvDespesas.EndUpdate();
                AtualizarTotais(tipos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos para colorir o cabeçalho via P/Invoke
        private const int LVM_SETBKCOLOR = 0x1001;
        private const int HDM_SETBKCOLOR = 0x1204;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        private void ApplyHeaderBackgroundColor(ListView listView, Color color)
        {
            IntPtr header = SendMessage(listView.Handle, 0x1200, IntPtr.Zero, IntPtr.Zero); // LVM_GETHEADER
            if (header != IntPtr.Zero)
            {
                int colorRef = ColorTranslator.ToWin32(color);
                SendMessage(header, HDM_SETBKCOLOR, IntPtr.Zero, (IntPtr)colorRef);
                listView.Refresh(); // Força a atualização
            }
        }

        private void AtualizarTotais(List<DespesasModel> despesas)
        {
            try
            {
                if (despesas != null)
                {
                    var despesasAbertas = despesas.Where(d => !d.Pago);
                    decimal valorTotalAberto = despesasAbertas.Sum(d => d.ValorParcela ?? 0);
                    int qtdItensPendentes = despesasAbertas.Count();

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

        public void AtualizarListView() // Substitui AtualizarDataGrid
        {
            CarregarDados();
        }


        private void LimparCampos()
        {
            txtPesquisa.Clear();
            TipoAtual = null;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        public void AtualizarDataGrid()
        {
            CarregarDados(); // Chama o método de carregamento de dados
        }

        private void AbrirFormularioCadastro()
        {
            FormCadastroDespesa form = new FormCadastroDespesa(StatusOperacao, this);

            try
            {
                switch (StatusOperacao)
                {
                    case "NOVO":
                        ConfigurarFormulario(form, "NOVO", true, "Salvar", true);
                        form.btnSalvar.BackColor = System.Drawing.Color.FromArgb(1, 128, 255);
                        form.panelTitulo.BackColor = System.Drawing.Color.FromArgb(1, 128, 255);                        
                        form.btnSalvar.ForeColor = System.Drawing.Color.White;
                        form.lblTitulo.Text = "Nova Despesa";
                        form.ShowDialog();
                        break;

                    case "ALTERAR":
                        PreencherCampos(form);
                        ConfigurarFormulario(form, "ALTERAR", true, "Alterar", true);
                        form.btnSalvar.BackColor = System.Drawing.Color.OrangeRed;
                        form.btnSalvar.ForeColor = System.Drawing.Color.White;
                        form.lblTitulo.Text = "Alterar Despesa";
                        form.panelTitulo.BackColor = System.Drawing.Color.OrangeRed;
                        form.btnNovo.Visible = false;                                                
                        form.dtpDataCadastro.Enabled = false;
                        form.ShowDialog();
                        break;

                    case "PAGAR":
                        PreencherCampos(form);
                        ConfigurarFormulario(form, "PAGAR", true, "Confirmar Pgto", true);
                        DesabilitarCampos(form);
                        form.btnSalvar.BackColor = System.Drawing.Color.RoyalBlue;
                        form.panelTitulo.BackColor = System.Drawing.Color.RoyalBlue;
                        form.btnSalvar.ForeColor = System.Drawing.Color.White;
                        form.lblDataCadastro_e_Pagamento.Text = "Data Pagamento";
                        form.lblTitulo.Text = "Pagar Despesa";
                        form.ShowDialog();
                        break;

                    case "EXCLUSÃO":
                        PreencherCampos(form);
                        ConfigurarFormulario(form, "EXCLUSÃO", true, "Excluir", true);
                        DesabilitarCampos(form);
                        form.btnSalvar.BackColor = System.Drawing.Color.Red;
                        form.panelTitulo.BackColor = System.Drawing.Color.Red;
                        form.btnSalvar.ForeColor = System.Drawing.Color.White;
                        form.lblTitulo.Text = "Excluir Despesa";
                        form.ShowDialog();
                        break;
                }
                if (form.Salvou)
                {
                    AtualizarDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Preenche os campos de texto e data
                form.txtDespesaID.Text = TipoAtual.DespesaID.ToString();
                form.txtDescricao.Text = TipoAtual.Descricao;
                form.txtValorTotal.Text = TipoAtual.ValorDaCompra.ToString();
                form.dtpDataVencimento.Value = TipoAtual.DataVencimento;
                form.cmbStatus.SelectedItem = TipoAtual.Status;
                form.txtNumeroParcelas.Text = TipoAtual.NumeroParcelas.ToString();
                form.txtValorParcela.Text = TipoAtual.ValorParcela.ToString();

                form.CategoriaID = Convert.ToInt32(TipoAtual.CategoriaID);
                form.MetodoPgtoID = Convert.ToInt32(TipoAtual.MetodoPgtoID);

                int _categoriaID = Convert.ToInt32(TipoAtual.CategoriaID);
                form.txtCategoria.Text = Utilitario.PesquisarPorCodigoExibirEmTexbox("Categorias", "CategoriaID", "NomeCategoria", _categoriaID);

                int _metodoPgtoID = Convert.ToInt32(TipoAtual.MetodoPgtoID);
                form.txtMetodoPgto.Text = Utilitario.PesquisarPorCodigoExibirEmTexbox("MetodosPagamento", "MetodoPgtoID", "NomeMetodoPagamento", _metodoPgtoID);
            }
        }

        private void lstvDespesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvDespesas.SelectedItems.Count > 0)
            {
                var selectedItem = lstvDespesas.SelectedItems[0];
                TipoAtual = selectedItem.Tag as DespesasModel; // Recupera o objeto completo do Tag

                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnExcel.Enabled = true;
                btnPagarConta.Enabled = true;
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

        private void DesabilitarCampos(FormCadastroDespesa form)
        {
            form.txtDespesaID.Enabled = false;
            form.txtDescricao.Enabled = false;
            form.txtValorTotal.Enabled = false;
            form.dtpDataVencimento.Enabled = false;
            form.cmbStatus.Enabled = false;
            form.txtNumeroParcelas.Enabled = false;
            form.txtValorParcela.Enabled = false;
            form.txtCategoria.Enabled = false;
            form.txtMetodoPgto.Enabled = false;            
            form.btnNovo.Visible = false;
            form.btnLocalizarCategoria.Enabled = false;
            form.btnLocalizarMetodoPagamento.Enabled = false;
            form.groupBoxParcelar.Enabled = false;
        }


        private void FormCadastroTiposReceita_Load(object sender, EventArgs e)
        {
            radioPendentes.Checked = true; // Define Pendentes como padrão
            CarregarDados(); // Carrega os dados iniciais
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            StatusOperacao = "NOVO";
            CarregarDados();
            AbrirFormularioCadastro(); // Chama diretamente o formulário sem recarregar dados
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (TipoAtual == null)
            {
                MessageBox.Show("Selecione um tipo para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StatusOperacao = "ALTERAR";
            AbrirFormularioCadastro(); // Chama diretamente o formulário sem recarregar dados
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
                MessageBox.Show("Deseja excluir apenas o registro atual?",
                                "Excluir Despesas",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (TipoAtual == null)
                {
                    MessageBox.Show("Selecione um tipo para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                StatusOperacao = "EXCLUSÃO";
                AbrirFormularioCadastro();
            }
            else
            {
                int numeroSelecionados = lstvDespesas.SelectedItems.Count;
                if (MessageBox.Show($"Deseja realmente excluir todos os {numeroSelecionados} registros selecionados?",
                                    "Confirmação de Exclusão",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        DespesasBLL objetoBll = new DespesasBLL();
                        foreach (ListViewItem item in lstvDespesas.SelectedItems)
                        {
                            int despesaId = Convert.ToInt32(item.SubItems[0].Text);
                            objetoBll.Excluir(despesaId);
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
            bool? pago = null; // null significa "sem filtro" por padrão
            if (radioPagas.Checked)
            {
                pago = true; // Filtrar por despesas pagas
            }
            else if (radioPendentes.Checked)
            {
                pago = false; // Filtrar por despesas pendentes
            }
            CarregarDados(txtPesquisa.Text, pago); // Passa o texto da pesquisa e o filtro de pago
        }

        private void btnPagarConta_Click(object sender, EventArgs e)
        {
            if (TipoAtual == null)
            {
                MessageBox.Show("Selecione um tipo para Pagar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StatusOperacao = "PAGAR";
            AbrirFormularioCadastro(); // Chama diretamente o formulário sem recarregar dados
        }

        private void radioPagas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPagas.Checked)
            {
                CarregarDados(txtPesquisa.Text, true); // Exibir apenas pagas
            }
        }


        private void radioPendentes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPendentes.Checked)
            {
                CarregarDados(txtPesquisa.Text, false); // Exibir apenas pendentes
            }
        }
       
       
    }
}

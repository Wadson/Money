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
    public partial class FormCadastroReceita : KryptonForm
    {
        private readonly ReceitasBLL objetoBll = new ReceitasBLL();
        public string StatusOperacao { get; set; }
        private string QueryCategoria = "SELECT MAX(ReceitaID) FROM Receitas";
        private int TipoID;

        public bool Salvou { get; private set; } = false;

        private readonly FormManutencaoReceitas _formPai; // Campo para armazenar a referência
        public FormCadastroReceita(string statusOperacao, FormManutencaoReceitas formPai)
        {
            InitializeComponent();
            StatusOperacao = statusOperacao;
            Utilitario.AdicionarEfeitoFocoEmTodos(this);
            _formPai = formPai;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validações básicas
                if (string.IsNullOrWhiteSpace(txtDescricao.Text))
                    throw new Exception("A descrição é obrigatória.");
                if (string.IsNullOrWhiteSpace(txtValor.Text) || !decimal.TryParse(txtValor.Text, out decimal valor))
                    throw new Exception("O valor deve ser um número válido.");

                switch (StatusOperacao)
                {
                    case "NOVO":
                        var novoTipo = new ReceitasModel
                        {
                            Descricao = txtDescricao.Text,
                            ValorDaReceita = valor,
                            DataRecebimento = dtpDataRecebimento.Value,
                            TipoID = cmbTipoReceita.SelectedValue != null ? (int?)Convert.ToInt32(cmbTipoReceita.SelectedValue) : null,
                            DataCadastro = dtpDataCadastro.Value
                        };
                        objetoBll.Salvar(novoTipo);
                        MessageBox.Show("Categoria salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Salvou = true;
                        _formPai.AtualizarDataGrid();
                        Utilitario.LimpaCampoKrypton(this);
                        int codigo = Utilitario.GerarProximoCodigo(QueryCategoria);
                        txtReceitaID.Text = Utilitario.AcrescentarZerosEsquerda(codigo, 5);
                        txtDescricao.Focus();
                        break;

                    case "ALTERAR":
                        if (string.IsNullOrWhiteSpace(txtReceitaID.Text) || !int.TryParse(txtReceitaID.Text, out int receitaId))
                            throw new Exception("ID da receita inválido.");
                        var tipo = new ReceitasModel
                        {
                            ReceitaID = receitaId,
                            Descricao = txtDescricao.Text,
                            ValorDaReceita = valor,
                            DataRecebimento = dtpDataRecebimento.Value,
                            TipoID = cmbTipoReceita.SelectedValue != null ? (int?)Convert.ToInt32(cmbTipoReceita.SelectedValue) : null,
                            DataCadastro = dtpDataCadastro.Value
                        };
                        objetoBll.Alterar(tipo);
                        MessageBox.Show("Categoria alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Salvou = true;
                        _formPai.AtualizarDataGrid();
                        this.Close();
                        break;

                    case "EXCLUSÃO":
                        if (string.IsNullOrWhiteSpace(txtReceitaID.Text) || !int.TryParse(txtReceitaID.Text, out receitaId))
                            throw new Exception("ID da receita inválido.");
                        if (MessageBox.Show("Confirma a exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            objetoBll.Excluir(receitaId);
                            MessageBox.Show("Categoria excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Salvou = true;
                            _formPai.AtualizarDataGrid();
                            this.Close();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnNovo_Click(object sender, EventArgs e)
        {
            int NovoCodigo = Utilitario.GerarProximoCodigo(QueryCategoria);
            TipoID = NovoCodigo;
            txtReceitaID.Text = Utilitario.AcrescentarZerosEsquerda(NovoCodigo, 5);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastroTipoReceita_Load(object sender, EventArgs e)
        {
            string query = "SELECT TipoID, NomeTipo FROM TiposReceita";
            Utilitario.PreencherComboBoxKrypton(cmbTipoReceita, query, "NomeTipo", "TipoID");
            if (StatusOperacao == "NOVO")
            {
                int codigo = Utilitario.GerarProximoCodigo(QueryCategoria);
                txtReceitaID.Text = Utilitario.AcrescentarZerosEsquerda(codigo, 5);
            }                       
        }

        private void FormCadastroCategorias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Suprima o som de "beep"
                e.Handled = true;
                // Envia a tecla Tab
                SendKeys.Send("{TAB}");
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtValor.Text, out decimal valor))
            {
                // Formata o valor como moeda com duas casas decimais
                txtValor.Text = valor.ToString("N2");
            }
            else
            {
                // Mostra uma mensagem de erro ou limpa o texto se não for um número válido
                txtValor.Text = string.Empty;
                MessageBox.Show("Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}

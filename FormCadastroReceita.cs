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
                            Valor = valor,
                            Data = dtpDataRecebimento.Value,
                            TipoID = cmbTipoReceita.SelectedValue != null ? (int?)Convert.ToInt32(cmbTipoReceita.SelectedValue) : null,
                            DataCriacao = dtpDataCadastro.Value
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
                            Valor = valor,
                            Data = dtpDataRecebimento.Value,
                            TipoID = cmbTipoReceita.SelectedValue != null ? (int?)Convert.ToInt32(cmbTipoReceita.SelectedValue) : null,
                            DataCriacao = dtpDataCadastro.Value
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
        //private void SalvarRegistro()
        //{
        //    try
        //    {
        //        var tipo = new CategoriasModel
        //        {
        //            NomeCategoria = txtDescricao.Text
        //        };
        //        objetoBll.Salvar(tipo);
        //        MessageBox.Show("Categoria salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        Utilitario.LimpaCampoKrypton(this);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //public void AlterarRegistro()
        //{
        //    try
        //    {
        //        CategoriasModel objetoModel = new CategoriasModel
        //        {
        //            CategoriaID = Convert.ToInt32(txtReceitaID.Text),
        //            NomeCategoria = txtDescricao.Text
        //        };

        //        CategoriasBLL objetoBll = new CategoriasBLL();
        //        objetoBll.Alterar(objetoModel);

        //        MessageBox.Show("Registro alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                
        //        Utilitario.LimpaCampoKrypton(this);
        //        this.Close();
        //    }
        //    catch (Exception erro)
        //    {
        //        MessageBox.Show("Erro ao alterar o registro: " + erro.Message);
        //    }
        //}
        //public void ExcluirRegistro()
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(txtReceitaID.Text))
        //        {
        //            MessageBox.Show("Selecione um Tipo de receita para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        int tipoReceitaID = Convert.ToInt32(txtReceitaID.Text);

        //        CategoriasModel objetoModel = new CategoriasModel
        //        {
        //            CategoriaID = tipoReceitaID,
        //        };

        //        CategoriasBLL objetoBll = new CategoriasBLL();
        //        objetoBll.Excluir(tipoReceitaID);

        //        MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        //        Utilitario.LimpaCampoKrypton(this);// Limpa os campos e fecha o formulário
        //        this.Close();
        //    }
        //    catch (Exception erro)
        //    {
        //        MessageBox.Show("Erro ao excluir o registro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
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
    }
}

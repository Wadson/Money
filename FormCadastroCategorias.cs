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
    public partial class FormCadastroCategorias : KryptonForm
    {
        private readonly CategoriasBLL categoria_bll = new CategoriasBLL();
        public string StatusOperacao { get; set; }
        private string QueryCategoria = "SELECT MAX(CategoriaID) FROM Categorias";
        private int TipoID;

        private readonly CategoriasBLL _bll = new CategoriasBLL();        
        public bool Salvou { get; private set; } = false;

        private readonly FormManutencaoCategorias _formPai; // Campo para armazenar a referência
        public FormCadastroCategorias(string statusOperacao, FormManutencaoCategorias formPai)
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
                switch (StatusOperacao)
                {
                    case "NOVO":
                        var novoTipo = new CategoriasModel { NomeCategoria = txtNomeCategoria.Text };
                        _bll.Salvar(novoTipo);
                        MessageBox.Show("Categoria salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Salvou = true;
                        _formPai.AtualizarDataGrid();
                        Utilitario.LimpaCampoKrypton(this);
                        int codigo = Utilitario.GerarProximoCodigo(QueryCategoria);
                        txtCategoriaID.Text = Utilitario.AcrescentarZerosEsquerda(codigo, 5);
                        txtNomeCategoria.Focus();
                        break;

                    case "ALTERAR":
                        var tipo = new CategoriasModel
                        {
                            CategoriaID = int.Parse(txtCategoriaID.Text),
                            NomeCategoria = txtNomeCategoria.Text
                        };
                        _bll.Alterar(tipo);
                        MessageBox.Show("Categoria alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Salvou = true;
                        _formPai.AtualizarDataGrid();
                        this.Close();
                        break;

                    case "EXCLUSÃO":
                        if (MessageBox.Show("Confirma a exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _bll.Excluir(int.Parse(txtCategoriaID.Text));
                            MessageBox.Show("Categoria excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void SalvarRegistro()
        {
            try
            {
                var tipo = new CategoriasModel
                {
                    NomeCategoria = txtNomeCategoria.Text
                };
                categoria_bll.Salvar(tipo);
                MessageBox.Show("Categoria salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Utilitario.LimpaCampoKrypton(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AlterarRegistro()
        {
            try
            {
                CategoriasModel objetoModel = new CategoriasModel
                {
                    CategoriaID = Convert.ToInt32(txtCategoriaID.Text),
                    NomeCategoria = txtNomeCategoria.Text
                };

                CategoriasBLL objetoBll = new CategoriasBLL();
                objetoBll.Alterar(objetoModel);

                MessageBox.Show("Registro alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                
                Utilitario.LimpaCampoKrypton(this);
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar o registro: " + erro.Message);
            }
        }
        public void ExcluirRegistro()
        {
            try
            {
                if (string.IsNullOrEmpty(txtCategoriaID.Text))
                {
                    MessageBox.Show("Selecione um Tipo de receita para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int tipoReceitaID = Convert.ToInt32(txtCategoriaID.Text);

                CategoriasModel objetoModel = new CategoriasModel
                {
                    CategoriaID = tipoReceitaID,
                };

                CategoriasBLL objetoBll = new CategoriasBLL();
                objetoBll.Excluir(tipoReceitaID);

                MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Utilitario.LimpaCampoKrypton(this);// Limpa os campos e fecha o formulário
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir o registro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            int NovoCodigo = Utilitario.GerarProximoCodigo(QueryCategoria);
            TipoID = NovoCodigo;
            txtCategoriaID.Text = Utilitario.AcrescentarZerosEsquerda(NovoCodigo, 5);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastroTipoReceita_Load(object sender, EventArgs e)
        {
            if (StatusOperacao == "NOVO")
            {
                int codigo = Utilitario.GerarProximoCodigo(QueryCategoria);
                txtCategoriaID.Text = Utilitario.AcrescentarZerosEsquerda(codigo, 5);
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

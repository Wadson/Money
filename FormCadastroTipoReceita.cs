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
    public partial class FormCadastroTipoReceita : KryptonForm
    {
        private readonly TiposReceitaBLL tiposReceita_bll = new TiposReceitaBLL();
        public string StatusOperacao { get; set; }
        private string QueryTiposReceita = "SELECT MAX(TipoID) FROM TiposReceita";
        private int TipoID;
        private readonly TiposReceitaBLL _bll = new TiposReceitaBLL();        
        public bool Salvou { get; private set; } = false;        
        private readonly FormManutencaoTiposReceita _formPai; // Campo para armazenar a referência

        public FormCadastroTipoReceita(string statusOperacao, FormManutencaoTiposReceita formPai)
        {
            InitializeComponent();
            StatusOperacao = statusOperacao;
            Utilitario.AdicionarEfeitoFocoEmTodos(this);

            _formPai = formPai; // Armazena a referência ao formulário pai
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (StatusOperacao)
                {
                    case "NOVO":
                        var novoTipo = new TiposReceitaModel { NomeTipoReceita = txtNomeTipo.Text };
                        _bll.Salvar(novoTipo);
                        MessageBox.Show("Tipo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Salvou = true;
                        _formPai.AtualizarDataGrid(); // Atualiza o DataGridView no formulário pai
                        Utilitario.LimpaCampoKrypton(this);
                        int codigo = Utilitario.GerarProximoCodigo(QueryTiposReceita);
                        txtTipoReceitaID.Text = Utilitario.AcrescentarZerosEsquerda(codigo, 5);
                        txtNomeTipo.Focus();
                        break;

                    case "ALTERAR":
                        var tipo = new TiposReceitaModel
                        {
                            TipoReceitaID = int.Parse(txtTipoReceitaID.Text),
                            NomeTipoReceita = txtNomeTipo.Text
                        };
                        _bll.Alterar(tipo);
                        MessageBox.Show("Tipo alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Salvou = true;
                        _formPai.AtualizarDataGrid(); // Atualiza o DataGridView no formulário pai
                        this.Close();
                        break;

                    case "EXCLUSÃO":
                        if (MessageBox.Show("Confirma a exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _bll.Excluir(int.Parse(txtTipoReceitaID.Text));
                            MessageBox.Show("Tipo excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Salvou = true;
                            _formPai.AtualizarDataGrid(); // Atualiza o DataGridView no formulário pai
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
                var tipo = new TiposReceitaModel
                {
                    NomeTipoReceita = txtNomeTipo.Text
                };
                tiposReceita_bll.Salvar(tipo);
                MessageBox.Show("Tipo de receita salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                TiposReceitaModel objetoModel = new TiposReceitaModel
                {
                    TipoReceitaID = Convert.ToInt32(txtTipoReceitaID.Text),
                    NomeTipoReceita = txtNomeTipo.Text

                };

                TiposReceitaBLL objetoBll = new TiposReceitaBLL();
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
                if (string.IsNullOrEmpty(txtTipoReceitaID.Text))
                {
                    MessageBox.Show("Selecione um Tipo de receita para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int tipoReceitaID = Convert.ToInt32(txtTipoReceitaID.Text);

                TiposReceitaModel objetoModel = new TiposReceitaModel
                {
                    TipoReceitaID = tipoReceitaID,
                };

                TiposReceitaBLL objetoBll = new TiposReceitaBLL();
                objetoBll.Excluir(tipoReceitaID);

                MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza a tela de manutenção de usuários              

                // Limpa os campos e fecha o formulário
                Utilitario.LimpaCampoKrypton(this);
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir o registro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            int NovoCodigo = Utilitario.GerarProximoCodigo(QueryTiposReceita);
            TipoID = NovoCodigo;
            txtTipoReceitaID.Text = Utilitario.AcrescentarZerosEsquerda(NovoCodigo, 5);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastroTipoReceita_Load(object sender, EventArgs e)
        {
            if (StatusOperacao == "NOVO")
            {
                int codigo = Utilitario.GerarProximoCodigo(QueryTiposReceita);
                txtTipoReceitaID.Text = Utilitario.AcrescentarZerosEsquerda(codigo, 5);
            }

                       
        }

        private void FormCadastroTipoReceita_KeyDown(object sender, KeyEventArgs e)
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

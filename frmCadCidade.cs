using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Money
{
    public partial class frmCadCidade : Money.frmBase
    {
        string Query = "SELECT MAX(idcidade) FROM cidade";

        public frmCadCidade()
        {
            InitializeComponent();
        }

        public override int CodigoMaisUm(string query)
        {
            return base.CodigoMaisUm(Query);
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodig.Text = CodigoMaisUm(Query).ToString();

                cidadeModel objetocidade = new cidadeModel();

                objetocidade.Idcidade = Convert.ToInt32(txtCodig.Text);
                objetocidade.Cidade = txtCidade.Text;
                objetocidade.Uf = txtUf.Text;

                cidadeBLL cidadebll = new cidadeBLL();

                if (txtCidade.Text == string.Empty)
                {
                    MessageBox.Show("Digite um nome de fornecedor.", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtCidade.Focus();
                }
                else
                {
                    cidadebll.gravaCidade(objetocidade);
                    MessageBox.Show("REGISTRO gravado com sucesso! ", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LimpaCampo();
                    txtCodig.Text = CodigoMaisUm(Query).ToString();
                    txtCidade.Focus();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao gravar O REGISTRO!!! " + erro);
            }            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            cidadeModel objetocidade = new cidadeModel();
            try
            {
                if (txtCidade.Text != string.Empty)
                {
                    objetocidade.Cidade = txtCidade.Text;
                    objetocidade.Uf = txtUf.Text;     
                    objetocidade.Idcidade = Convert.ToInt32(txtCodig.Text);
                    

                    cidadeBLL cidadebll = new cidadeBLL();
                    cidadebll.atualizaCidade(objetocidade);
                    MessageBox.Show("Registro alterado ! ", "Informação !)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Selecione um registro ! ", "Informação !)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (OleDbException)
            {
                MessageBox.Show("Não há dados para alterar. Localize um registro primeiro.", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cidadeModel objetocidade = new cidadeModel();

            if (MessageBox.Show("Excluir Registro ?", "Pergunta ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    objetocidade.Cidade = txtCidade.Text;
                    objetocidade.Uf = txtUf.Text;
                    objetocidade.Idcidade = Convert.ToInt32(txtCodig.Text);

                    cidadeBLL cidadebll = new cidadeBLL();
                    cidadebll.excluiCidade(objetocidade);

                    MessageBox.Show("Fornecedor Excluído com Sucesso ! ", "Informação !)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                catch (OleDbException)
                {
                    MessageBox.Show("Não há dados para deletar. Localize um registro primeiro.", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

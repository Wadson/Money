using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace Money
{
    public partial class frmCadReceita : Money.frmBase
    {

        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string DataRecebimento { get; set; }
        
        string Query = "SELECT MAX(Codigo) FROM receita";

        public frmCadReceita()
        {
            InitializeComponent();
        }
        public override void LimpaCampo()
        {
            base.LimpaCampo();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            LimpaCampo();
            txtCodigo.Text = CodigoMaisUm(Query).ToString();
        }
        public override int CodigoMaisUm(string query)
        {
            return base.CodigoMaisUm(Query);
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            frmManutReceita manutenção = new frmManutReceita();

            if (txtCodigo.Text != string.Empty & txtCodFonte.Text != string.Empty)
            {
                string valorsemformato;
                valorsemformato = txtValor.Text;
                valorsemformato = valorsemformato.Replace("R$", "").Replace(".", "");
                try
                {
                    ReceitaMODEL objetoreceita = new ReceitaMODEL();

                    objetoreceita.Codigoreceita = Convert.ToInt32(txtCodigo.Text);
                    objetoreceita.Codigofonte = Convert.ToInt32(txtCodFonte.Text);
                    objetoreceita.Valor = Convert.ToDouble(valorsemformato);
                    objetoreceita.Datarecebimento = Convert.ToDateTime(dtPickDataReceb.Text);                    

                    ReceitaBLL receitabll = new ReceitaBLL();
                    receitabll.Salvar(objetoreceita);

                    MessageBox.Show("Registro gravado ", "Informe !)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LimpaCampo();
                    txtCodFonte.Focus();
                    txtCodigo.Text = CodigoMaisUm(Query).ToString();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Verifique os erros", ex.Message);
                }
            }
            else
                MessageBox.Show("Localize um contato primeiro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ReceitaMODEL objetoreceita = new ReceitaMODEL();
            //try
            //{
            //    objetoreceita.Codigofonte = Convert.ToInt32(txtCodFonte.Text);
            //    objetoreceita.Valor = Convert.ToDouble(txtValor.Text);
            //    objetoreceita.Datarecebimento = Convert.ToDateTime(dtPickDataReceb.Text);
            //    objetoreceita.Codigoreceita = Convert.ToInt32(txtCodigo.Text);

            //    ReceitaBLL receitabll = new ReceitaBLL();
            //    receitabll.atualizaReceita(objetoreceita);

            //    MessageBox.Show("Registro alterado com sucesso ! ", "Informação !)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    this.Close();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Não há dados para alterar. Localize um registro primeiro.", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}             
            objetoreceita.Codigofonte = Convert.ToInt32(txtCodFonte.Text);
            objetoreceita.Valor = Convert.ToDouble(txtValor.Text);
            objetoreceita.Datarecebimento = Convert.ToDateTime(dtPickDataReceb.Text);
            objetoreceita.Codigoreceita = Convert.ToInt32(txtCodigo.Text);

            ReceitaBLL receitabll = new ReceitaBLL();
            receitabll.atualizaReceita(objetoreceita);

            MessageBox.Show("Registro alterado com sucesso ! ", "Informação !)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este contato ?", "Perqunta !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ReceitaMODEL objetoreceita = new ReceitaMODEL();
                try
                {
                    if (txtCodigo.Text != string.Empty)
                    {
                        objetoreceita.Codigofonte = Convert.ToInt32(txtCodFonte);
                        objetoreceita.Valor = Convert.ToDouble(txtValor.Text);
                        objetoreceita.Datarecebimento = Convert.ToDateTime(dtPickDataReceb.Text);
                        objetoreceita.Codigoreceita = Convert.ToInt32(txtCodigo.Text);

                        ReceitaBLL receitabll = new ReceitaBLL();
                        receitabll.excluiReceita(objetoreceita);

                        MessageBox.Show("Registro EXCLUÍDO com sucesso ! ", "Informação !)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Selecione um registro ! ", "Informação !)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (OleDbException)
                {
                    MessageBox.Show("Não há dados para alterar. Localize um registro primeiro.", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtCodFonte_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"^\d+$");

            Match verifica = Regex.Match(txtCodFonte.Text, rx.ToString());

            if (verifica.Success == true)
            {

            }
            else
            {
                if (txtCodFonte.Text != string.Empty)
                {
                    frmPesquisaContatosLista frmpesquisa = new frmPesquisaContatosLista();
                    frmpesquisa.Capturavalor = txtCodFonte.Text;
                    frmpesquisa.ShowDialog();

                    txtCodFonte.Text = frmpesquisa.Codigo;
                    txtNome.Text = frmpesquisa.Nome;
                }
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            try
            {
                txtValor.Text = String.Format("{0:C}", Convert.ToDouble(txtValor.Text));
            }
            catch
            {
                MessageBox.Show("Este campo só aceita valores numericos", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtValor.Text = string.Empty;
                txtValor.Focus();
            }
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            string valorsemformato;
            valorsemformato = txtValor.Text;
            valorsemformato = valorsemformato.Replace("R$", "").Replace(" ", "");
            txtValor.Text = valorsemformato;
        }

        private void txtValor_Click(object sender, EventArgs e)
        {
            string valorsemformato;
            valorsemformato = txtValor.Text;
            valorsemformato = valorsemformato.Replace("R$", "").Replace(" ", "");
            txtValor.Text = valorsemformato;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty)
            {
                string pesquisa = txtNome.Text;
                AgendaModel obj_cidade = new AgendaModel();
                try
                {
                    AgendaBLL cidadebll = new AgendaBLL();
                    obj_cidade = cidadebll.pesquisaAgenda22(pesquisa);

                    txtCodFonte.Text = obj_cidade.Idagenda.ToString();                   
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Nenhum Registro Encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro Geral" + erro);
                }                
            }            
        }
    }
}

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
    public partial class frmCadLista : Money.frmBase
    {
        public string Codigo { get; set; }
        public string CodigoCidade { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Fone { get; set; }
        public string Celular { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Email { get; set; }
        string Query = "SELECT MAX(idagenda) FROM agenda";

        public frmCadLista()
        {
            InitializeComponent();
        }
        public override void LimpaCampo()
        {
            base.LimpaCampo();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {           
            frmManutLista manutenção = new frmManutLista();

            if (txtCodigo.Text != string.Empty & txtCodCidade.Text != string.Empty)
            {
                try
                {
                    AgendaModel objetoagenda = new AgendaModel();
                    objetoagenda.Idagenda = Convert.ToInt32(txtCodigo.Text);

                    objetoagenda.Nome = txtNome.Text;
                    objetoagenda.Endereco = txtEndereco.Text;
                    objetoagenda.Fone = txtFonee.Text;
                    objetoagenda.Email = txtEmail.Text;
                    objetoagenda.Idagenda = Convert.ToInt32(txtCodigo.Text);
                    objetoagenda.Idcidade = Convert.ToInt32(txtCodCidade.Text);
                    objetoagenda.Celular = txtCelular.Text;

                    AgendaBLL agendabll = new AgendaBLL();
                    agendabll.gravaAgendaDal(objetoagenda);

                    MessageBox.Show("Registro gravado ", "Informe !)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LimpaCampo();
                    txtNome.Focus();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AgendaModel objetoagenda = new AgendaModel();
            try
            {
                objetoagenda.Nome = txtNome.Text;
                objetoagenda.Fone = txtFonee.Text;
                objetoagenda.Celular = txtCelular.Text;
                objetoagenda.Endereco = txtEndereco.Text;
                objetoagenda.Idcidade = Convert.ToInt32(txtCodCidade.Text);
                objetoagenda.Email = txtEmail.Text;
                objetoagenda.Idagenda = Convert.ToInt32(txtCodigo.Text);

                AgendaBLL agendabll = new AgendaBLL();
                agendabll.atualizaAgendaDAL(objetoagenda);

                MessageBox.Show("Registro alterado com sucesso ! ", "Informação !)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Não há dados para alterar. Localize um registro primeiro.", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                                  
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este contato ?", "Perqunta !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AgendaModel obj_agenda = new AgendaModel();
                try
                {
                    if (txtCodigo.Text != string.Empty)
                    {
                        obj_agenda.Nome = txtNome.Text;                        
                        obj_agenda.Fone = txtFonee.Text;
                        obj_agenda.Celular = txtCelular.Text;                        
                        obj_agenda.Endereco = txtEndereco.Text;
                        obj_agenda.Email = txtEmail.Text;
                        obj_agenda.Idagenda = Convert.ToInt32(txtCodigo.Text);


                        AgendaBLL agenda_bll = new AgendaBLL();
                        agenda_bll.excluiAgendaDAL(obj_agenda);
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

        private void txtCodCidade_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"^\d+$");

            Match verifica = Regex.Match(txtCodCidade.Text, rx.ToString());

            if (verifica.Success == true)
            {

            }
            else
            {
                if (txtCodCidade.Text != string.Empty)
                {
                    frmPesquisaCidade frmpesquisa = new frmPesquisaCidade();
                    frmpesquisa.Capturavalor = txtCodCidade.Text;
                    frmpesquisa.ShowDialog();

                    txtCodCidade.Text = frmpesquisa.IdCidade;
                    txtCidade.Text = frmpesquisa.Cidade;
                    txtUf.Text = frmpesquisa.Uf;
                }
            }
        }

        private void txtFonee_Click(object sender, EventArgs e)
        {
            string fone;
            fone = txtFonee.Text;
            fone = fone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            txtFonee.Text = fone;
        }

        private void txtCelular_Click(object sender, EventArgs e)
        {
            string celular;
            celular = txtCelular.Text;
            celular = celular.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            txtCelular.Text = celular;
        }

        private void txtFonee_Leave(object sender, EventArgs e)
        {
            try
            {
                long Fone = Convert.ToInt64(txtFonee.Text);
                string FoneFormato = String.Format(@"{0:(0)0000\-0000}", Fone);
                txtFonee.Text = FoneFormato;

                Regex rx = new Regex(@"^\(\d{2}\)\d{4}-\d{4}$");
                Match verifica = Regex.Match(txtFonee.Text, rx.ToString());

                if (verifica.Success == true)
                {

                }
                else
                {
                    MessageBox.Show("Telefone inválido \n\n Digite nesse formato: 9911112222", "Atenção !)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtFonee.Text = string.Empty;
                    txtFonee.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            try
            {
                long celular = Convert.ToInt64(txtCelular.Text);
                string CelularFormato = String.Format(@"{0:(0)0000\-0000}", celular);
                txtCelular.Text = CelularFormato;

                Regex rx = new Regex(@"^\(\d{2}\)\d{4}-\d{4}$");
                Match verifica = Regex.Match(txtCelular.Text, rx.ToString());

                if (verifica.Success == true)
                {

                }
                else
                {
                    MessageBox.Show("Telefone inválido \n\n Digite nesse formato: 9911112222", "Atenção !)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtCelular.Text = string.Empty;
                    txtCelular.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCidade_Leave(object sender, EventArgs e)
        {
            string pesquisa = txtCidade.Text;
            cidadeModel obj_cidade = new cidadeModel();
            try
            {
                cidadeBLL cidadebll = new cidadeBLL();
                obj_cidade = cidadebll.pesquisaCidade(pesquisa);

                txtCodCidade.Text = obj_cidade.Idcidade.ToString();
                txtUf.Text = obj_cidade.Uf.ToString();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Nenhum Registro Encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCidade.Text = string.Empty;
                txtCidade.Focus();
                txtCodCidade.Text = string.Empty;
                txtUf.Text = string.Empty;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Geral" + erro);
            }
        }

        private void txtFonee_Enter(object sender, EventArgs e)
        {
            string valorsemformato;
            valorsemformato = txtFonee.Text;
            valorsemformato = valorsemformato.Replace("(", "").Replace(")","").Replace("-","").Replace(" ", "");
            txtFonee.Text = valorsemformato;
        }

        private void txtCelular_Enter(object sender, EventArgs e)
        {
            string valorsemformato;
            valorsemformato = txtCelular.Text;
            valorsemformato = valorsemformato.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            txtCelular.Text = valorsemformato;
        }
    }
}

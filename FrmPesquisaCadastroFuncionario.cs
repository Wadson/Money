using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Money
{
    public partial class FrmPesquisaCadastroFuncionario : BasePesquisa
    {
        public FrmPesquisaCadastroFuncionario()
        {
            InitializeComponent();
        }
        public void ListaFuncionario()
        {
            FuncionarioBLL funcionariobll = new FuncionarioBLL();
            dataGridPesquisa.DataSource = funcionariobll.ListaFuncionario();
        }
        private void FrmPesquisaCadastroFuncionario_Load(object sender, EventArgs e)
        {
            ListaFuncionario();
            DataGridViewRow row = this.dataGridPesquisa.RowTemplate;
            //row.DefaultCellStyle.BackColor = Color.Bisque;
            row.Height = 17;
            row.MinimumHeight = 17;
        }
      
        private void CarregaDados()
        {
            FrmCadastroFuncionario f3 = new FrmCadastroFuncionario();
            try
            {
                if (linhaAtual >= 0)
                {

                    f3.txtCodigo.Text = dataGridPesquisa[0, linhaAtual].Value.ToString(); f3.Codigo = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
                    f3.txtCadastro.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                    f3.txtFuncionario.Text = dataGridPesquisa[2, linhaAtual].Value.ToString(); Nome = dataGridPesquisa[2, linhaAtual].Value.ToString();
                    f3.txtEndereco.Text = dataGridPesquisa[3, linhaAtual].Value.ToString();
                    f3.txtCep.Text = dataGridPesquisa[4, linhaAtual].Value.ToString();
                    f3.txtBairro.Text = dataGridPesquisa[5, linhaAtual].Value.ToString();
                    f3.txtCidade.Text = dataGridPesquisa[6, linhaAtual].Value.ToString();
                    f3.txtUf.Text = dataGridPesquisa[7, linhaAtual].Value.ToString();
                    f3.txtFone1.Text = dataGridPesquisa[8, linhaAtual].Value.ToString();
                    f3.txtFone2.Text = dataGridPesquisa[9, linhaAtual].Value.ToString();
                    f3.txtCelular.Text = dataGridPesquisa[10, linhaAtual].Value.ToString();
                    f3.txtWhats.Text = dataGridPesquisa[11, linhaAtual].Value.ToString();
                    f3.txtEmail.Text = dataGridPesquisa[12, linhaAtual].Value.ToString();
                    f3.txtCpf.Text = dataGridPesquisa[13, linhaAtual].Value.ToString();
                    f3.txtRg.Text = dataGridPesquisa[14, linhaAtual].Value.ToString();
                    f3.txtEmissor.Text = dataGridPesquisa[15, linhaAtual].Value.ToString();
                    f3.txtRgEmissao.Text = dataGridPesquisa[16, linhaAtual].Value.ToString();
                    f3.txtPai.Text = dataGridPesquisa[17, linhaAtual].Value.ToString();
                    f3.txtMae.Text = dataGridPesquisa[18, linhaAtual].Value.ToString();
                    f3.txtEstadoCivil.Text = dataGridPesquisa[19, linhaAtual].Value.ToString();
                    f3.txtConjuge.Text = dataGridPesquisa[20, linhaAtual].Value.ToString();
                    f3.txtNascimento.Text = dataGridPesquisa[21, linhaAtual].Value.ToString();
                    f3.txtNaturalidade.Text = dataGridPesquisa[22, linhaAtual].Value.ToString();
                    f3.txtGrauInstrucao.Text = dataGridPesquisa[23, linhaAtual].Value.ToString();
                    f3.txtCtps.Text = dataGridPesquisa[24, linhaAtual].Value.ToString();
                    f3.txtCtpsSerie.Text = dataGridPesquisa[25, linhaAtual].Value.ToString();
                    f3.txtCtpsEmissao.Text = dataGridPesquisa[26, linhaAtual].Value.ToString();
                    f3.txtTituloEle.Text = dataGridPesquisa[27, linhaAtual].Value.ToString();
                    f3.txtTituloZona.Text = dataGridPesquisa[28, linhaAtual].Value.ToString();
                    f3.txtTituloSecao.Text = dataGridPesquisa[29, linhaAtual].Value.ToString();
                    f3.txtReservista.Text = dataGridPesquisa[30, linhaAtual].Value.ToString();
                    f3.txtReservistaCategoria.Text = dataGridPesquisa[31, linhaAtual].Value.ToString();
                    f3.txtPis.Text = dataGridPesquisa[32, linhaAtual].Value.ToString();
                    f3.txtAdmissao.Text = dataGridPesquisa[33, linhaAtual].Value.ToString();
                    f3.txtFuncao.Text = dataGridPesquisa[34, linhaAtual].Value.ToString();
                    f3.txtDepto.Text = dataGridPesquisa[35, linhaAtual].Value.ToString();
                    f3.txtSalario.Text = dataGridPesquisa[36, linhaAtual].Value.ToString();
                    f3.txtComissao.Text = dataGridPesquisa[37, linhaAtual].Value.ToString();
                    f3.txtObs.Text = dataGridPesquisa[38, linhaAtual].Value.ToString();

                    f3.StatusOperacao = "ALTERAR";
                    f3.Text = "Alterar Funcionário : > " + Nome;

                    f3.ShowDialog();
                    ListaFuncionario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
        }
        public override void carregaGrid2Localizar(SqlCeCommand criterioSQL, DataGridView DatagridParametro)
        {
            base.carregaGrid2Localizar(criterioSQL, DatagridParametro);
        }
        public void Pesquisar22()
        {
            Frm_Base_Pesquisa pesquisa = new Frm_Base_Pesquisa();
            var conn = Conexao.Conex();


            if (rbtDescricao.Checked == true)
            {
                SqlCeCommand sqlStringNome = new SqlCeCommand("SELECT idfuncionario, dtcadastro, funcionario, endereco,cep, bairro, cidade, uf, fone, fone1, celular, "
         + " whatsapp, email, cpf, rg, rgorgaoemissor, rgemissao, pai, mae, estadocivil, conjuge, dtnascimento, naturalidade, grauinstrucao, ctps, ctpsserieuf, ctpsemissao, "
         + " tituloeleitor, titulozona, titulosecao, reservista, reservistacategoria, pis, admissao, funcao, depto, salario,  comissao, obs FROM funcionarios  WHERE funcionario LIKE @pesquisa", conn);
                sqlStringNome.Parameters.AddWithValue("@pesquisa", txtPesquisa.Text + "%");
                carregaGrid2Localizar(sqlStringNome, dataGridPesquisa);
            }
            if (rbtCodigo.Checked == true)
            {
                SqlCeCommand sqlStringCodigo = new SqlCeCommand("SELECT idfuncionario, dtcadastro, funcionario, endereco,cep, bairro, cidade, uf, fone, fone1, celular, "
         + " whatsapp, email, cpf, rg, rgorgaoemissor, rgemissao, pai, mae, estadocivil, conjuge, dtnascimento, naturalidade, grauinstrucao, ctps, ctpsserieuf, ctpsemissao, "
         + " tituloeleitor, titulozona, titulosecao, reservista, reservistacategoria, pis, admissao, funcao, depto, salario,  comissao, obs FROM funcionarios  WHERE idfuncionario LIKE @pesquisa", conn);
                sqlStringCodigo.Parameters.AddWithValue("@pesquisa", txtPesquisa.Text + "%");
                carregaGrid2Localizar(sqlStringCodigo, dataGridPesquisa);
            }
        }       
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Pesquisar22();
        }
        public void ExcluirCliente()
        {
            try
            {
                Codigo = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
                Nome = dataGridPesquisa[2, linhaAtual].Value.ToString();
                string CPF = dataGridPesquisa[13, linhaAtual].Value.ToString();

                if (MessageBox.Show("Deseja Excluir? \n\nNº  '" + Codigo + "    CPF: " + CPF + " ", "Funcionário : " + Nome + "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funcionarioMODEL funcionariomoel = new funcionarioMODEL();
                    funcionariomoel.Idfuncionario = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);

                    FuncionarioBLL funcionariobll = new FuncionarioBLL();
                    funcionariobll.Excluir(funcionariomoel);
                    MessageBox.Show("REGISTRO EXCLUÍDO!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ListaFuncionario();
                }
            }
            catch
            { 
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastroFuncionario cadfunci = new FrmCadastroFuncionario();
            cadfunci.StatusOperacao = "NOVO";
            cadfunci.ShowDialog();
            ListaFuncionario();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCliente();
        }

        private void txtPesquisa_TextChanged_1(object sender, EventArgs e)
        {
            Pesquisar22();
        }

        private void dataGridPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaDados();
        }

        private void dataGridPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

        private void dataGridPesquisa_SelectionChanged(object sender, EventArgs e)
        {
            linhaAtual = dataGridPesquisa.CurrentRow.Index;
        }
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ListaFuncionario();
            timer1.Enabled = false;
        }    
    }
}

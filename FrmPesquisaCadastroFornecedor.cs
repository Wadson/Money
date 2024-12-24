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
    public partial class FrmPesquisaCadastroFornecedor : BasePesquisa
    {
        public FrmPesquisaCadastroFornecedor()
        {
            InitializeComponent();
        }

       
        public void ListaFornecedor()
        {
            FornecedorBLL fornecedorbll = new FornecedorBLL();
            dataGridPesquisa.DataSource = fornecedorbll.lista_Fornecedor_dal();
        }
        public void ExcluirFornecedor()
        {
            Codigo = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
            Nome = dataGridPesquisa[2, linhaAtual].Value.ToString();
            string Endereco = dataGridPesquisa[10, linhaAtual].Value.ToString();

            if(MessageBox.Show("Excluir? Código:"+ Codigo +" : "+ Nome +"  "+Endereco+" ","Excluir!!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                FornecedorMODEL fornecedorMODEL = new FornecedorMODEL();
                fornecedorMODEL.IDFornecedor = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);

                FornecedorBLL fornecedorbll = new FornecedorBLL();
                fornecedorbll.excluiFornecedorDal(fornecedorMODEL);
                MessageBox.Show("REGISTRO EXCLUÍDO!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ListaFornecedor();
            }
            
        }
        private void FrmPesquisaCadastroFornecedor_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridPesquisa.RowTemplate;
            //row.DefaultCellStyle.BackColor = Color.Bisque;
            row.Height = 17;
            row.MinimumHeight = 17;
            ListaFornecedor();
        }

     
        private void CarregaDados()
        {
            FrmCadastroFornecedor f3 = new FrmCadastroFornecedor();
            try
            {
                if (linhaAtual >= 0)
                {
                    //idfornecedor, dtcadastro, fornecedor, endereco, bairro, cidade, uf, cep, rg, emissor, cpf, cnpj, ie, fone, fone1, celular, contato, email, obs 
                    //idfornecedor, dtcadastro, fornecedor, endereco, bairro, cidade, uf, cep, rg, emissor, cpf, cnpj, ie, fone, fone1, celular, contato, email, obs

                    f3.txtCodigo.Text = dataGridPesquisa[0, linhaAtual].Value.ToString(); 
                    f3.Codigo = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
                    
                    f3.txtCadastro.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                    
                    f3.txtFornecedor.Text = dataGridPesquisa[2, linhaAtual].Value.ToString();
                    Nome = dataGridPesquisa[2, linhaAtual].Value.ToString();
                    
                    f3.txtEndereco.Text = dataGridPesquisa[3, linhaAtual].Value.ToString();
                    f3.txtBairro.Text = dataGridPesquisa[4, linhaAtual].Value.ToString();
                    f3.txtCidade.Text = dataGridPesquisa[5, linhaAtual].Value.ToString();
                    f3.txtUf.Text = dataGridPesquisa[6, linhaAtual].Value.ToString();
                    f3.txtCep.Text = dataGridPesquisa[7, linhaAtual].Value.ToString();
                    f3.txtIdentidade.Text = dataGridPesquisa[8, linhaAtual].Value.ToString();
                    f3.txtEmissor.Text = dataGridPesquisa[9, linhaAtual].Value.ToString();
                    f3.txtCpf.Text = dataGridPesquisa[10, linhaAtual].Value.ToString();
                    f3.txtCnpj.Text = dataGridPesquisa[11, linhaAtual].Value.ToString();
                    f3.txtInscricaoEstadual.Text = dataGridPesquisa[12, linhaAtual].Value.ToString();
                    f3.txtFone1.Text = dataGridPesquisa[13, linhaAtual].Value.ToString();
                    f3.txtFone2.Text = dataGridPesquisa[14, linhaAtual].Value.ToString();                   
                    f3.txtCelular.Text = dataGridPesquisa[15, linhaAtual].Value.ToString();
                    f3.txtContato.Text = dataGridPesquisa[16, linhaAtual].Value.ToString();
                    f3.txtEmail.Text = dataGridPesquisa[17, linhaAtual].Value.ToString();                   
                    f3.txtObs.Text = dataGridPesquisa[18, linhaAtual].Value.ToString();
                    f3.StatusOperacao = "ALTERAR";
                    f3.Text = "Alterar Fornecedor : > " + Nome;

                    f3.ShowDialog();
                    ListaFornecedor();
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
            var conn = Conexao.Conex();

            if (rbtDescricao.Checked == true)
            {
                SqlCeCommand sqlStringNome = new SqlCeCommand("SELECT  idfornecedor, dtcadastro, fornecedor, endereco, bairro, cidade, uf, cep, rg, emissor, cpf, cnpj, ie, fone, fone1, celular, contato, email, obs FROM fornecedor  WHERE fornecedor LIKE @pesquisa", conn);
                sqlStringNome.Parameters.AddWithValue("@pesquisa", txtPesquisa.Text + "%");
                carregaGrid2Localizar(sqlStringNome, dataGridPesquisa);
            }
            if (rbtCodigo.Checked == true)
            {
                SqlCeCommand sqlStringCodigo = new SqlCeCommand("SELECT  idfornecedor, dtcadastro, fornecedor, endereco, bairro, cidade, uf, cep, rg, emissor, cpf, cnpj, ie, fone, fone1, celular, contato, email, obs FROM fornecedor  WHERE idcliente LIKE @pesquisa", conn);
                sqlStringCodigo.Parameters.AddWithValue("@pesquisa", txtPesquisa.Text + "%");
                carregaGrid2Localizar(sqlStringCodigo, dataGridPesquisa);
            }
        }

        private void rbtDescricao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void dataGridPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaDados();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Pesquisar22();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastroFornecedor cadcli = new FrmCadastroFornecedor();
            cadcli.StatusOperacao = "NOVO";
            cadcli.ShowDialog();
            ListaFornecedor();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CarregaDados();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirFornecedor();
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
            ListaFornecedor();
            timer1.Enabled = false;
        }

        private void FrmPesquisaCadastroFornecedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmCadastroContasPagar cadcontas = new FrmCadastroContasPagar();

            if (dataGridPesquisa.DataSource != null)
            {
                try
                {
                    IdFornecedor = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value.ToString());
                    Fornecedor = dataGridPesquisa[2, linhaAtual].Value.ToString();  
                }
                catch
                {
                }
                if (linhaAtual >= 1)
                {
                    cadcontas.IdFornecedor = IdFornecedor;
                    cadcontas.txtFavorecido.Text = Fornecedor;
                }
            }
        }       
    }
}

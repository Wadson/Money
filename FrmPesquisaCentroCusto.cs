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
    public partial class FrmPesquisaCentroCusto : Money.BasePesquisa
    {
        public FrmPesquisaCentroCusto()
        {
            InitializeComponent();
        }
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastroCentroCusto cadcentrocusto = new FrmCadastroCentroCusto();
            cadcentrocusto.StatusOperacao = "NOVO";
            cadcentrocusto.ShowDialog();
            //ListaCentroCusto();
        }
        public void AcrescenteZero_a_Esquerda()
        {
            dataGridPesquisa.Columns[0].DefaultCellStyle.Format = "000000";
            //string texto;
            //string textofinal;
            //int tamanho;
            //textofinal = "";
            //texto = dataGridPesquisa[0, linhaAtual].Value.ToString();
            
            //if ((texto.Length < 4))
            //{
            //    tamanho = texto.Length;
            //    for (int t = 0; (t <= (4 - tamanho)); t++)
            //    {
            //        textofinal = (textofinal + "0");
            //    }
            //    dataGridPesquisa.Columns[0].DefaultCellStyle.Format = (textofinal + texto);
            //    //txtCodigo.Text = (textofinal + texto);
            //}
        }
            
        public override void carregaGrid2Localizar(SqlCeCommand criterioSQL, DataGridView DatagridParametro)
        {
            base.carregaGrid2Localizar(criterioSQL, DatagridParametro);
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var conn = Conexao.Conex();
                if (rbtDescricao.Checked == true)
                {
                    SqlCeCommand sqlStringDesc = new SqlCeCommand("SELECT idcentrocusto, centrocusto FROM centrocusto WHERE centrocusto  LIKE @criterio", conn);
                    sqlStringDesc.Parameters.AddWithValue("@criterio", txtPesquisa.Text + "%");

                    carregaGrid2Localizar(sqlStringDesc,dataGridPesquisa);
                    
                }
                if (rbtCodigo.Checked == true)
                {
                    SqlCeCommand sqlStringCod = new SqlCeCommand("SELECT idcentrocusto, centrocusto FROM centrocusto  WHERE idcentrocusto LIKE @Criterio", conn);
                    sqlStringCod.Parameters.AddWithValue("@Criterio", txtPesquisa.Text + "%");
                    carregaGrid2Localizar(sqlStringCod,dataGridPesquisa);
                }
                AcrescenteZero_a_Esquerda();
            }
            catch
            {
            }
        }
        private void CarregaDados()
        {
            FrmCadastroCentroCusto f3 = new FrmCadastroCentroCusto();

            try
            {
                if (linhaAtual >= 0)
                {
                    //f3.txtCodigo.Text = dataGridPesquisa[0, linhaAtual].Value.ToString();
                    f3.IdCentroCusto = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
                    f3.txtNome.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                    Nome = dataGridPesquisa[1, linhaAtual].Value.ToString();


                    f3.StatusOperacao = "ALTERAR";
                    f3.Text = "Alterar Centro de Custo : > " + Nome;

                    f3.ShowDialog();
                    //ListaUsuario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
        }
       
        public void ListaCentroCusto()
        {
            CentroCustoBLL cenrtrobll = new CentroCustoBLL();
            dataGridPesquisa.DataSource = cenrtrobll.lista_Centro_Custo();
            AcrescenteZero_a_Esquerda();
        }
        public void ExcluirCentroCusto()
        {
            Codigo = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
            Nome = dataGridPesquisa[1, linhaAtual].Value.ToString();
          

            if (MessageBox.Show("Excluir? Código:  " + Codigo + " : " + Nome + " ", "Excluir!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CentroCustoModel centromodel = new CentroCustoModel();
                centromodel.Id_centro = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);

                CentroCustoBLL centrobll = new CentroCustoBLL();
                centrobll.Excluir(centromodel);
                MessageBox.Show("REGISTRO EXCLUÍDO!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ListaCentroCusto();
            }
            
        }      
        private void btnAlterar_Click(object sender, EventArgs e)
        {           
            CarregaDados();
        }

        private void dataGridPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

        private void dataGridPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaDados();
        }

        private void dataGridPesquisa_SelectionChanged(object sender, EventArgs e)
        {
            linhaAtual = dataGridPesquisa.CurrentRow.Index;
        }

        private void FrmPesquisaCentroCusto_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridPesquisa.RowTemplate;
            //row.DefaultCellStyle.BackColor = Color.Bisque;
            row.Height = 17;
            row.MinimumHeight = 17;
           
            ListaCentroCusto();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCentroCusto();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListaCentroCusto();
            timer1.Enabled = false;
        }

        private void FrmPesquisaCentroCusto_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmCadastroContasPagar cadcontas = new FrmCadastroContasPagar();

            if (dataGridPesquisa.DataSource != null)
            {
                try
                {
                    IdCentroCusto = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value.ToString());
                    CentroCusto = dataGridPesquisa[1, linhaAtual].Value.ToString();
                }
                catch
                {
                }
                if (linhaAtual >= 1)
                {
                    cadcontas.IdCentroCusto = IdCentroCusto;
                    cadcontas.txtCentroCusto.Text = CentroCusto;
                    cadcontas.txtCodigoCentroCusto.Text = IdCentroCusto.ToString();
                }
            }
        }

    }
}

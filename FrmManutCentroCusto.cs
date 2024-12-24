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
    public partial class FrmManutCentroCusto : Money.BasePesquisa
    {
        public FrmManutCentroCusto()
        {
            InitializeComponent();
        }
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastro_CentroCusto childForm = new FrmCadastro_CentroCusto();
            childForm.MdiParent = this.ParentForm;
            childForm.StatusOperacao = "NOVO";
            childForm.Show();
        }
        public void AcrescenteZero_a_Esquerda()
        {
            dataGridPesquisa.Columns[0].DefaultCellStyle.Format = "000000";   
        }

        public override void carregaGrid2Localizar(SqlCeCommand criterioSQL, DataGridView DatagridParametro)
        {
            base.carregaGrid2Localizar(criterioSQL, DatagridParametro);
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string criterio = txtPesquisa.Text + "%";
            try
            {
                if (rbtDescricao.Checked == true)
                {
                    SqlCeCommand sqlStringDesc = new SqlCeCommand("SELECT idcentrocusto, centrocusto FROM centrocusto WHERE centrocusto  LIKE @Criterio");
                    sqlStringDesc.Parameters.AddWithValue("@Criterio", criterio);
                    carregaGrid2Localizar(sqlStringDesc,dataGridPesquisa);
                    
                }
                if (rbtCodigo.Checked == true)
                {
                    SqlCeCommand sqlStringDesc = new SqlCeCommand( "SELECT idcentrocusto, centrocusto FROM centrocusto WHERE idcentrocusto  LIKE @Crite");
                    sqlStringDesc.Parameters.AddWithValue("@Crite",criterio);
                    carregaGrid2Localizar(sqlStringDesc, dataGridPesquisa);
                }
                AcrescenteZero_a_Esquerda();
            }
            catch
            {
            }
        }
        private void CarregaDados()
        {
            FrmCadastro_CentroCusto f3 = new FrmCadastro_CentroCusto();
            f3.MdiParent = this.MdiParent;
            try
            {
                if (linhaAtual >= 0)
                {
                    f3.txtCodigo.Text = dataGridPesquisa[0, linhaAtual].Value.ToString();
                    f3.txtNome.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                    Nome = dataGridPesquisa[1, linhaAtual].Value.ToString();
                    f3.StatusOperacao = "ALTERAR";
                    f3.lblTituloCadCentro.Text = "Alterar Centro de Custo";
                    f3.Text = "Alterar Centro de Custo : > " + Nome;

                    f3.Show();                   
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
                ((FrmManutCentroCusto)Application.OpenForms["FrmManutCentroCusto"]).HabilitarTimer(true);
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
            try
            {
                linhaAtual = dataGridPesquisa.CurrentRow.Index;
            }
            catch
            { 
            }
        }

        private void FrmPesquisaCentroCusto_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridPesquisa.RowTemplate;
            //row.DefaultCellStyle.BackColor = Color.Bisque;
            row.Height = 17;
            row.MinimumHeight = 17;
           
            ListaCentroCusto();
            this.WindowState = FormWindowState.Maximized;
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
            FrmCadastroContas cadcontas = new FrmCadastroContas();

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
                    cadcontas.lblIdCentroCusto.Text = IdCentroCusto.ToString();
                }
            }
        }

    }
}

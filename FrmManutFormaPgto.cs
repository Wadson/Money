using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace Money
{
    public partial class FrmManutFormaPgto : BasePesquisa
    {
        public FrmManutFormaPgto()
        {
            InitializeComponent();
        }
     

        public void ListaformaPgto()
        {
            FormaPgtoBLL  formapgtobll = new FormaPgtoBLL();
            dataGridPesquisa2.DataSource = formapgtobll.ListaFormaPgto();            
        }

        private void FrmManutFormaPgto_Load(object sender, EventArgs e)
        {
            ListaformaPgto();            
        }
        private void CarregaDados()
        {
            FrmCadFormaPgto f3 = new FrmCadFormaPgto();
           
            try
            {
             
                    f3.IdFormaPgto = Convert.ToInt32(dataGridPesquisa2.CurrentRow.Cells[0].Value);
                    f3.txtCodigo.Text = dataGridPesquisa2.CurrentRow.Cells[0].Value.ToString();
                    FormadePgto = dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString();
                    f3.txtNome.Text = dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString();
                    f3.StatusOperacao = "ALTERAR";
                f3.lblTitulo.Text = "ALTERAR" + " " +FormadePgto;
                    f3.Text = "Money - Alterar registro" + " | " + dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString();

                    f3.ShowDialog();
                    ListaformaPgto();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
        }
        public void ExcluirFormaPgto()
        {

            IdFormaPgto = Convert.ToInt32(dataGridPesquisa2.CurrentRow.Cells[0].Value);
            FormadePgto = dataGridPesquisa2.CurrentRow.Cells[1].Value.ToString();

            if (MessageBox.Show("Excluir? Código:" + IdFormaPgto + " : " + FormaPgto + " ", "Excluir!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormaPgtoMODEL formapgtoModel = new FormaPgtoMODEL();
                formapgtoModel.Id_formapgto = Convert.ToInt32(IdFormaPgto);

                FormaPgtoBLL formapgtobll = new FormaPgtoBLL();
                formapgtobll.Excluir(formapgtoModel);
                ((FrmManutFormaPgto)Application.OpenForms["FrmManutFormaPgto"]).HabilitarTimer(true);
                MessageBox.Show("REGISTRO EXCLUÍDO!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ListaformaPgto();
            }

        }

        public override void carregaGrid2Localizar(System.Data.SqlClient.SqlCommand criterioSQL, DataGridView DatagridParametro)
        {
            base.carregaGrid2Localizar(criterioSQL, DatagridParametro);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text + "%";

            SqlCommand sqlStringNome = new SqlCommand("SELECT * FROM formapgto  WHERE formapgto LIKE @Pesquisa");
            sqlStringNome.Parameters.AddWithValue("@Pesquisa", pesquisa);
            dataGridPesquisa2.DataSource = LocalizarGeral(sqlStringNome);
        }
      

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadFormaPgto formaPgto = new FrmCadFormaPgto();

            formaPgto.StatusOperacao = "NOVO";
            formaPgto.lblTitulo.Text = "NOVO CADASTRO";
            formaPgto.ShowDialog();

            ListaformaPgto();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirFormaPgto();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridPesquisa2_SelectionChanged(object sender, EventArgs e)
        {            
        }
        public void HabilitarTimer(bool habilitar)
        {
            timerAtualizaMedoto.Enabled = habilitar;
        }
        private void timerAtualizaMedoto_Tick(object sender, EventArgs e)
        {
            ListaformaPgto();
            timerAtualizaMedoto.Enabled = false;
        }

        private void dataGridPesquisa2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridPesquisa2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaDados();
        }
       
    }
}

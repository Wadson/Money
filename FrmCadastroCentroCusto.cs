using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmCadastroCentroCusto : FrmBaseGeral
    {
        public FrmCadastroCentroCusto()
        {
            InitializeComponent();
        }
        //public void AcrescenteZero_a_Esquerda()
        //{
        //    string texto;
        //    string textofinal;
        //    int tamanho;
        //    textofinal = "";
        //    texto = txtCodigo.Text.ToString();
        //    if ((txtCodigo.Text.Length < 6))
        //    {
        //        tamanho = txtCodigo.Text.Length;
        //        for (int t = 1; (t <= (6 - tamanho)); t++)
        //        {
        //            textofinal = (textofinal + "0");
        //        }

        //        txtCodigo.Text = (textofinal + txtCodigo.Text);
        //    }
          
        //}
        private void Frm_Cad_CentroCusto_Load(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                //AcrescenteZero_a_Esquerda();
                return;
            }
            if (StatusOperacao == "NOVO")
            {
                IdCentroCusto = RetornaCodigoContaMaisUm(QueryCentro);
                //txtCodigo.Text = RetornaCodigoContaMaisUm(QueryCentro).ToString();
                txtNome.Focus();
                
                //AcrescenteZero_a_Esquerda();
            }  
           
        }
        public void GravarRegistro()
        {
            try
            {
                CentroCustoModel objcentro = new CentroCustoModel();
                objcentro.Id_centro = Convert.ToInt32(IdCentroCusto);
                objcentro.Centrocusto = txtNome.Text;
                CentroCustoBLL centrobll = new CentroCustoBLL();

                centrobll.Salvar(objcentro);

                MessageBox.Show("REGISTRO gravado com sucesso!", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LimpaCampo();
                IdCentroCusto = RetornaCodigoContaMaisUm(QueryCentro);
                //txtCodigo.Text = RetornaCodigoContaMaisUm(QueryCentro).ToString();
                txtNome.Focus();
                //AcrescenteZero_a_Esquerda();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao gravar O REGISTRO!!! " + erro);
            }
        }
        public override string EvitarDuplicado(string Tabela, string Campo, string CampoParametro)
        {
            return base.EvitarDuplicado(Tabela, Campo, CampoParametro);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void AlgerarRegistro()
        {

            try
            {

                CentroCustoModel centrocustoMODEL = new CentroCustoModel();

                centrocustoMODEL.Centrocusto = txtNome.Text;
                centrocustoMODEL.Id_centro = Convert.ToInt32(IdCentroCusto);

                CentroCustoBLL centroBLL = new CentroCustoBLL();

                centroBLL.Alterar(centrocustoMODEL);
                MessageBox.Show("Registro Alterado com sucesso!", "Alteração!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterar O REGISTRO!!! " + erro);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                AlgerarRegistro();
            }
            if (StatusOperacao == "NOVO")
            {
                EvitarDuplicado("centrocusto", "centrocusto", txtNome.Text);
                if (RetornoEvitaDuplicado == "0")
                {

                    GravarRegistro();
                    LimpaCampo();
                    txtNome.Focus();                    
                    //txtCodigo.Text = RetornaCodigoContaMaisUm(QueryFornecedor).ToString();
                    IdCentroCusto = RetornaCodigoContaMaisUm(QueryFornecedor);
                    //AcrescenteZero_a_Esquerda();
                }
            }
            try
            {
                ((FrmPesquisaCentroCusto)Application.OpenForms["FrmPesquisaCentroCusto"]).HabilitarTimer(true);// Habilita Timer do outro form Obs: O timer no outro form executa um Método.        
            }
            catch
            { 
            }
        }

      
        //private void bt_Click(object sender, EventArgs e)
        //{          IdCentroCusto = RetornaCodigoContaMaisUm(QueryCentroCusto);
        //    txtNome.Focus();
        //}

        //private void btnLocaClick(object sender, EventArgs e)
        //{
        //    ////Frm_Pesquisa_Centro pesqforn = new Frm_Pesquisa_Centro();
        //    //pesqforn.ShowDialog();
        //    //IdCentroCusto = pesqforn.IdCentro;
        //    //txtNome.Text = pesqforn.CentroCusto;                 
        //}

        //private void txtNoLeave(object sender, EventArgs e)
        //{
        //    txtNome.BackColor = Color.White;
        //}

        //private void txtNer(object sender, EventArgs e)
        //{
        //    txtNome.BackColor = Color.Yellow;
        //}
    }
}

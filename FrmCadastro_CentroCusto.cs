using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmCadastro_CentroCusto : FrmBaseGeral
    {
        public FrmCadastro_CentroCusto()
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
                AcrescenteZero_a_Esquerda2(txtCodigo);
                return;
            }
            if (StatusOperacao == "NOVO")
            {
                IdCentroCusto = RetornaCodigoContaMaisUm(QueryCentro);
                txtCodigo.Text = RetornaCodigoContaMaisUm(QueryCentro).ToString();
                txtNome.Focus();
                AcrescenteZero_a_Esquerda2(txtCodigo);
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
                var frmmenu = Application.OpenForms["FrmManutCentroCusto"];
                if (frmmenu != null)
                {
                    ((FrmManutCentroCusto)Application.OpenForms["FrmManutCentroCusto"]).HabilitarTimer(true);
                }
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
        }
        public void AlgerarRegistro()
        {
            try
            {
                CentroCustoModel centrocustoMODEL = new CentroCustoModel();

                centrocustoMODEL.Centrocusto = txtNome.Text;
                centrocustoMODEL.Id_centro = Convert.ToInt32(txtCodigo.Text);

                CentroCustoBLL centroBLL = new CentroCustoBLL();

                centroBLL.Alterar(centrocustoMODEL);
                MessageBox.Show("Registro Alterado com sucesso!", "Alteração!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ((FrmManutCentroCusto)Application.OpenForms["FrmManutCentroCusto"]).HabilitarTimer(true);
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterar O REGISTRO!!! " + erro);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {

            FrmManutCentroCusto manucentro = new FrmManutCentroCusto();
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
                    IdCentroCusto = RetornaCodigoContaMaisUm(QueryCentro);
                    txtCodigo.Text = RetornaCodigoContaMaisUm(QueryCentro).ToString();
                    AcrescenteZero_a_Esquerda2(txtCodigo);

                    var frmmenu = Application.OpenForms["FrmManutCentroCusto"];
                    if (frmmenu != null)
                    {
                        ((FrmManutCentroCusto)Application.OpenForms["FrmManutCentroCusto"]).HabilitarTimer(true);
                    }
                }
                try
                {
                    // Habilita Timer do outro form Obs: O timer no outro form executa um Método.        
                }
                catch
                {
                }
            }
        }      
    }
}

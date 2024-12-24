using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmCadastroMarcas : Money.FrmBaseGeral
    {
        public FrmCadastroMarcas()
        {
            InitializeComponent();
        }
        public void Salvar()
        {

            MarcaMODEL marcasmodel = new MarcaMODEL();
            //marcasmodel.Idmarca = Convert.ToInt32(txtCodigo.Text);
            marcasmodel.Marca = txtMarca.Text;

            MarcaBLL marcabll = new MarcaBLL();
            marcabll.Salvar(marcasmodel);
            MessageBox.Show("Registro Gravado com sucesso!!!","Informe", MessageBoxButtons.OK,MessageBoxIcon.Information);
            LimpaCampo();           
           Codigo = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryMarca));
            txtMarca.Focus();
        }
        public void Alterar()
        {
            MarcaMODEL marcasmodel = new MarcaMODEL();            
            marcasmodel.Marca = txtMarca.Text;
            marcasmodel.Idmarca = Convert.ToInt32(Codigo);

            MarcaBLL marcabll = new MarcaBLL();
            marcabll.Alterar(marcasmodel);
            MessageBox.Show("Registro Alterado com sucesso!!!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
       
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                Alterar();
            }
            if (StatusOperacao == "NOVO")
            {
                Salvar();
            }
            ((FrmPesquisaMarcacs)Application.OpenForms["FrmPesquisaMarcacs"]).HabilitarTimer(true);// Habilita Timer do outro form Obs: O timer no outro form executa um Método.
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadastroMarcas_Load(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                return;
            }
            if (StatusOperacao == "NOVO")
            {
                Codigo = RetornaCodigoContaMaisUm(QueryMarca);              
                txtMarca.Focus();                
            }  
        }
    }
}

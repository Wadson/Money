using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmCadastroGrupo : Money.FrmBaseGeral
    {
       
        public FrmCadastroGrupo()
        {
            InitializeComponent();
        }
        public void Salvar()
        {

            GrupoMODEL grupomodel = new GrupoMODEL();
            //marcasmodel.Idmarca = Convert.ToInt32(txtCodigo.Text);
            grupomodel.Grupo = txtGrupo.Text;

            GrupoBLL grupobll = new GrupoBLL();
            grupobll.Salvar(grupomodel);
            MessageBox.Show("Registro Gravado com sucesso!!!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpaCampo();
            Codigo = RetornaCodigoContaMaisUm(QueryGrupo);
            Codigo = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryGrupo));
            txtGrupo.Focus();
        }
        public void Alterar()
        {
            GrupoMODEL grupomodel = new GrupoMODEL();
            grupomodel.Grupo = txtGrupo.Text;
            grupomodel.Idgrupo = Convert.ToInt32(Codigo);

            GrupoBLL grupobll = new GrupoBLL();
            grupobll.Alterar(grupomodel);
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
            ((FrmPesquisaGrupo)Application.OpenForms["FrmPesquisaGrupo"]).HabilitarTimer(true);// Habilita Timer do outro form Obs: O timer no outro form executa um Método.
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadastroGrupo_Load(object sender, EventArgs e)
        {

            if (StatusOperacao == "ALTERAR")
            {
                return;
            }
            if (StatusOperacao == "NOVO")
            {
                Codigo = RetornaCodigoContaMaisUm(QueryGrupo);                
                txtGrupo.Focus();
            }  
        }
    }
}

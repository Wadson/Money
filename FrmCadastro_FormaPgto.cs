using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmCadastro_FormaPgto : Money.FrmBaseGeral
    {
        public FrmCadastro_FormaPgto()
        {
            InitializeComponent();
        }
        public void GravarRegistro()
        {
            try
            {
                FormaPgtoMODEL objcentro = new FormaPgtoMODEL();
                objcentro.Idformapgto = Convert.ToInt32(IdFormaPgto);
                objcentro.Formapgto = txtNome.Text;
                FormaPgtoBLL centrobll = new FormaPgtoBLL();

                centrobll.Salvar(objcentro);

                MessageBox.Show("REGISTRO gravado com sucesso!", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ((FrmManutFormaPgto)Application.OpenForms["FrmManutFormaPgto"]).HabilitarTimer(true);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao gravar O REGISTRO!!! " + erro);
            }
        }
        public void AlgerarRegistro()
        {
            try
            {
                FormaPgtoMODEL formapgto = new FormaPgtoMODEL();

                formapgto.Formapgto = txtNome.Text;
                formapgto.Idformapgto = Convert.ToInt32(IdFormaPgto);

                FormaPgtoBLL centroBLL = new FormaPgtoBLL();

                centroBLL.Alterar(formapgto);

                MessageBox.Show("Registro Alterado com sucesso!", "Alteração!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ((FrmManutFormaPgto)Application.OpenForms["FrmManutFormaPgto"]).HabilitarTimer(true);               
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

        private void FrmCadastro_FormaPgto_Load(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                AcrescenteZero_a_Esquerda2(txtCodigo);
                return;
            }
            if (StatusOperacao == "NOVO")
            {
                IdFormaPgto = RetornaCodigoContaMaisUm(QueryFormaPag);
                txtCodigo.Text = RetornaCodigoContaMaisUm(QueryCentro).ToString();
                txtNome.Focus();

                AcrescenteZero_a_Esquerda2(txtCodigo);
            }  
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {          
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                AlgerarRegistro();
            }
            if (StatusOperacao == "NOVO")
            {
                EvitarDuplicado("formapgto", "formapgto", txtNome.Text);
                if (RetornoEvitaDuplicado == "0")
                {
                    GravarRegistro();
                    LimpaCampo();
                    txtNome.Focus();
                    IdFormaPgto = RetornaCodigoContaMaisUm(QueryFormaPag);
                    txtCodigo.Text = RetornaCodigoContaMaisUm(QueryFormaPag).ToString();
                    AcrescenteZero_a_Esquerda2(txtCodigo);                    
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

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }
    }
}

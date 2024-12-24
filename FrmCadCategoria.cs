using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmCadastro_categoria : FrmBaseGeral
    {
        public FrmCadastro_categoria()
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
        private void Frm_Cad_categoria_Load(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {                
                AcrescenteZero_a_Esquerda2(txtCodigo);
                return;
            }
            if (StatusOperacao == "NOVO")
            {                
                Idcategoria = RetornaCodigoContaMaisUm(QueryCentro);
                txtCodigo.Text = RetornaCodigoContaMaisUm(QueryCentro).ToString();
                txtNome.Focus();
                AcrescenteZero_a_Esquerda2(txtCodigo);
            }  
           
        }
        public void GravarRegistro()
        {
            try
            {
                categoriaModel objcentro = new categoriaModel();
                objcentro.Idcategoria = Convert.ToInt32(Idcategoria);
                objcentro.Categoria = txtNome.Text;
                categoriaBLL centrobll = new categoriaBLL();

                centrobll.Salvar(objcentro);

                MessageBox.Show("REGISTRO gravado com sucesso!", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                var frmmenu = Application.OpenForms["FrmManutcategoria"];
                if (frmmenu != null)
                {
                    ((FrmManutcategoria)Application.OpenForms["FrmManutcategoria"]).HabilitarTimer(true);
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
                categoriaModel categoriaMODEL = new categoriaModel();

                categoriaMODEL.Categoria = txtNome.Text;
                categoriaMODEL.Idcategoria = Convert.ToInt32(txtCodigo.Text);

                categoriaBLL centroBLL = new categoriaBLL();

                centroBLL.Alterar(categoriaMODEL);
                MessageBox.Show("Registro Alterado com sucesso!", "Alteração!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ((FrmManutcategoria)Application.OpenForms["FrmManutcategoria"]).HabilitarTimer(true);
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterar O REGISTRO!!! " + erro);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FrmManutcategoria manucentro = new FrmManutcategoria();
            if (StatusOperacao == "ALTERAR")
            {
                AlgerarRegistro();
            }
            if (StatusOperacao == "NOVO")
            {
                EvitarDuplicado("categoria", "nome_categoria", txtNome.Text);
                if (RetornoEvitaDuplicado == "0")
                {
                    GravarRegistro();
                    LimpaCampo();
                    txtNome.Focus();
                    Idcategoria = RetornaCodigoContaMaisUm(QueryCentro);
                    txtCodigo.Text = RetornaCodigoContaMaisUm(QueryCentro).ToString();
                    AcrescenteZero_a_Esquerda2(txtCodigo);

                    var frmmenu = Application.OpenForms["FrmManutcategoria"];
                    if (frmmenu != null)
                    {
                        ((FrmManutcategoria)Application.OpenForms["FrmManutcategoria"]).HabilitarTimer(true);
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampo();
            txtNome.Focus();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.Yellow;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.White;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

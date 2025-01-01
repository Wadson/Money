using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmCadSubCategoria : Money.FrmBaseGeral
    {
        public FrmCadSubCategoria()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
             FrmManutSubCategoria manusubcat = new FrmManutSubCategoria();
            if (StatusOperacao == "ALTERAR")
            {
                AlgerarRegistro();
            }
            if (StatusOperacao == "NOVO")
            {
                EvitarDuplicado("subcategoria", "nome_subcategoria", txtNome.Text);
                if (RetornoEvitaDuplicado == "0")
                {
                    GravarRegistro();

                    txtNome.Text = "";
                    txtNome.Focus();

                    Idsubcategoria = RetornaCodigoContaMaisUm(QuerySubCat);
                    txtCodigo.Text = RetornaCodigoContaMaisUm(QuerySubCat).ToString();
                    AcrescenteZero_a_Esquerda2(txtCodigo);

                    var frmmenu = Application.OpenForms["FrmManutSubCategoria"];
                    if (frmmenu != null)
                    {
                        ((FrmManutSubCategoria)Application.OpenForms["FrmManutSubCategoria"]).HabilitarTimer(true);
                    }
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampo();
            preencherComboBoxT(cmbCategoria, "SELECT id_categoria, nome_categoria FROM categoria", "id_categoria", "nome_categoria");
            txtidCategoria.Text = cmbCategoria.SelectedValue.ToString();

            AcrescenteZero_a_Esquerda2(txtCodigo);
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

        public void GravarRegistro()
        {
            SubCategoriaMODEL objesub = new SubCategoriaMODEL();

            objesub.Idsubcategoria = Idsubcategoria;
            objesub.Idcategoria = Convert.ToInt32(txtidCategoria.Text);
            objesub.Subcategoria = txtNome.Text;

            SubsubCategoriaBLL subbll = new SubsubCategoriaBLL();

            subbll.Salvar(objesub);

            MessageBox.Show("REGISTRO gravado com sucesso!", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            var frmmenu = Application.OpenForms["FrmManutSubCategoria"];
            if (frmmenu != null)
            {
                ((FrmManutSubCategoria)Application.OpenForms["FrmManutSubCategoria"]).HabilitarTimer(true);
            }
            //try
            //{
               
            //}
            //catch (Exception erro)
            //{
            //    MessageBox.Show("Erro ao gravar O REGISTRO!!! " + erro);
            //}
        }
        public void AlgerarRegistro()
        {
            try
            {
                SubCategoriaMODEL SubcategoriaMODEL = new SubCategoriaMODEL();

                SubcategoriaMODEL.Subcategoria = txtNome.Text;
                SubcategoriaMODEL.Idcategoria = Convert.ToInt32(txtidCategoria.Text);
                SubcategoriaMODEL.Idsubcategoria = Convert.ToInt32(txtCodigo.Text);

                SubsubCategoriaBLL subcatBLL = new SubsubCategoriaBLL();
                
                subcatBLL.Alterar(SubcategoriaMODEL);
                MessageBox.Show("Registro Alterado com sucesso!", "Alteração!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ((FrmManutSubCategoria)Application.OpenForms["FrmManutSubCategoria"]).HabilitarTimer(true);
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterar O REGISTRO!!! " + erro);
            }
        }

        private void FrmCadSubCategoria_Load(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                preencherComboBoxT(cmbCategoria, "SELECT id_categoria, nome_categoria FROM categoria", "id_categoria", "nome_categoria");
                
                txtidCategoria.Text = cmbCategoria.SelectedValue.ToString();

                AcrescenteZero_a_Esquerda2(txtCodigo);
                return;
            }
            if (StatusOperacao == "NOVO")
            {
                preencherComboBoxT(cmbCategoria,"SELECT id_categoria, nome_categoria FROM categoria","id_categoria","nome_categoria");

                if (cmbCategoria.SelectedValue == null)
                {
                    return;
                }
                else
                {
                    txtidCategoria.Text = cmbCategoria.SelectedValue.ToString();
                }
                


                AcrescenteZero_a_Esquerda2(txtidCategoria);
                
                Idsubcategoria = RetornaCodigoContaMaisUm(QuerySubCat);
                txtCodigo.Text = RetornaCodigoContaMaisUm(QuerySubCat).ToString();
                txtNome.Focus();
                AcrescenteZero_a_Esquerda2(txtCodigo);
            }  
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedValue == null)
            {
                return;
            }
            txtidCategoria.Text = cmbCategoria.SelectedValue.ToString();
            
            //var nome = cmbCategoria.Text;
            //txtidCategoria.Text = nome;

            AcrescenteZero_a_Esquerda2(txtidCategoria);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaiusculaUpper(txtNome);
        }
    }
}

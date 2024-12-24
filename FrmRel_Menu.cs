using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Money
{
    public partial class FrmRel_Menu : FrmBaseGeral
    {
        public FrmRel_Menu()
        {
            InitializeComponent();
        }


        private void btn_emitir_Click(object sender, EventArgs e)
        {
            if (rbFornecedor.Checked == true)
            {                
            }
            else if (rb_Periodo_e_Situacao.Checked == true)
            {               
            }
            else if (rbFornAgrupado.Checked == true)
            {
            }
            else if (rb_Fornecedor_Situacao.Checked == true)
            {               
            }
            else if (rbAgrupadocategoria.Checked == true)
            {                
            }
            else if (rbSubCategoria.Checked == true)
            {               
            }
            else if (rbAgrupadoPerSit.Checked == true)
            {                
            }
            else if (rbAgrupadoFormaPgtoSit.Checked == true)
            {                
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRel_Menu_Load(object sender, EventArgs e)
        {
        }
    }
}

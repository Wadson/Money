using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class TexBoxMoeda : UserControl
    {
        public TexBoxMoeda()
        {
            InitializeComponent();
        }
        Double valor;
        private void txtValorMoeda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valor = Double.Parse(txtValorMoeda.Text);
                txtValorMoeda.Text = valor.ToString("N");
            }
            catch(Exception)
            { 
            }
        }

        private void txtValorMoeda_Leave(object sender, EventArgs e)
        {
            txtValorMoeda.BackColor = Color.White;
        }

        private void txtValorMoeda_Enter(object sender, EventArgs e)
        {
            txtValorMoeda.BackColor = Color.Yellow;
        }
    }
}

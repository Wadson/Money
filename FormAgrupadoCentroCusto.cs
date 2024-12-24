using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FormAgrupadoCentroCusto : FrmBaseGeral
    {
        public FormAgrupadoCentroCusto()
        {
            InitializeComponent();
        }
        private string comandoAgrupado;
        private void FormAgrupadoCentroCusto_Load(object sender, EventArgs e)
        {
            carregaGrid2Localizar(comandoAgrupado, datagridAgrupadoCentroCusto);
        }
    }
}

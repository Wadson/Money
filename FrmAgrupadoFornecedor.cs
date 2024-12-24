using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Drawing.Drawing2D;

namespace Money
{
    public partial class FrmAgrupadoFornecedor : Money.FrmBaseGeral
    {

        public FrmAgrupadoFornecedor()
        {
            InitializeComponent();      
        }
        public string comando;

      
        private void FrmPesquisaContasAgrupado_Load(object sender, EventArgs e)
        {
            carregaGrid2Localizar(comando, datagridPesquisaAgrupado);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
        }      
    }
}

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
    public partial class FrmRel_AgrupadoFornecedor : Form
    {
        public FrmRel_AgrupadoFornecedor()
        {
            InitializeComponent();
        }

        private void FrmRel_AgrupadoFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdfinancaDataSet.Fornecedor_Agrupado' table. You can move, or remove it, as needed.
            this.Fornecedor_AgrupadoTableAdapter.Fill_Agrupado(this.bdfinancaDataSet.Fornecedor_Agrupado);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}

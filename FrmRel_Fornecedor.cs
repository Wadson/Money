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
    public partial class FrmRel_Fornecedor : Form
    {
        public FrmRel_Fornecedor()
        {
            InitializeComponent();
        }

        private void Frm_Rel_Fornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdfinancaDataSet.Fornecedor' table. You can move, or remove it, as needed.
            this.FornecedorTableAdapter.Fill_Fornecedor(this.bdfinancaDataSet.fornecedor);

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter());


            this.reportViewer1.RefreshReport();
        }

        private void Frm_Rel_Fornecedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.Dispose();
        }
    }
}

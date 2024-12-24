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
    public partial class Rel_Agrupado_categoria : Form
    {
        public Rel_Agrupado_categoria()
        {
            InitializeComponent();
        }

        private void Rel_Agrupado_categoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdfinancaDataSet.categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill_Agrupado_categoria(this.bdfinancaDataSet.categoria);

            this.reportViewer1.RefreshReport();
        }

        private void Rel_Agrupado_categoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.Dispose();
        }
    }
}

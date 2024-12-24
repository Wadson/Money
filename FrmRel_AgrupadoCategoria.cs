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
    public partial class FrmRel_AgrupadoCategoria : Form
    {
        public FrmRel_AgrupadoCategoria()
        {
            InitializeComponent();
        }

        private void FrmRel_AgrupadoCategoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdfinancaDataSet.categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill_Agrupado_categoria(this.bdfinancaDataSet.categoria);
            // TODO: This line of code loads data into the 'bdfinancaDataSet.subcategoria' table. You can move, or remove it, as needed.
            this.subcategoriaTableAdapter.Fill_AgrupadoSubCategoria(this.bdfinancaDataSet.subcategoria);

            this.reportViewer1.RefreshReport();
        }
    }
}

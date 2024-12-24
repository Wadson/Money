using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmPesquisaCadastroProdutos : BasePesquisa
    {
        public FrmPesquisaCadastroProdutos()
        {
            InitializeComponent();
        }

        private void dataGridPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }

        private void dataGridPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = dataGridPesquisa.CurrentRow.Index;
        }

        private void dataGridPesquisa_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmPesquisaCadastroProdutos_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridPesquisa.RowTemplate;
            //row.DefaultCellStyle.BackColor = Color.Bisque;
            row.Height = 17;
            row.MinimumHeight = 17;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ListaProdutoa();
            timer1.Enabled = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Money.DAL;
using Money.MODEL;
namespace Money
{
    public partial class FormBaixaDeDespesa : KryptonForm
    {
        private PagamentosDAL pagamentoDAL = new PagamentosDAL();
        public FormBaixaDeDespesa()
        {
            InitializeComponent();            
        }
       
        private void btnConfirmarPagamento_Click(object sender, EventArgs e)
        {           
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDespesasPendentes_SelectionChanged(object sender, EventArgs e)
        {           
        }
    }
}

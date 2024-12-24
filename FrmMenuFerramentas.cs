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
    public partial class FrmMenuFerramentas : FrmBaseGeral
    {
        public FrmMenuFerramentas()
        {
            InitializeComponent();            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {            
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {
            FrmFerramentas ferramentas = new FrmFerramentas();          
            ferramentas.Show();
        }

        private void btnEstorno_Click(object sender, EventArgs e)
        {
            FrmEstorno_Baixa estbaixa = new FrmEstorno_Baixa();           
            estbaixa.Show();
        }
      
        private void btnPesquisaDinami_Click(object sender, EventArgs e)
        {
            frmPesquiaDinamica pesq = new frmPesquiaDinamica();
           
            pesq.Show();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            FrmBackup gerarbackup = new FrmBackup();           
            gerarbackup.Show();
        }

        private void btnRestaurarBackup_Click(object sender, EventArgs e)
        {
            FrmRestaura_Banco restaurarBackup = new FrmRestaura_Banco();            
            restaurarBackup.Show();
        }
    }
}

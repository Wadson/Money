using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmLocalizaGrupo : Money.FrmBaseGeral
    {
        //public int Qtd_caractere { get; set; }

        public FrmLocalizaGrupo()
        {
            InitializeComponent();
        }

        private void FrmLocalizaGrupo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Nome = txtGrupo.Text;
        }

        private void FrmLocalizaGrupo_Load(object sender, EventArgs e)
        {
            FrmPesquisaGrupo cad = new FrmPesquisaGrupo();            
            txtGrupo.Text = Capturavalor;
            txtGrupo.SelectionStart = Capturavalor.Length;
            txtGrupo.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLocalizaGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.Close();
            }
        }

        private void txtGrupo_TextChanged(object sender, EventArgs e)
        {            
        }
    }
}

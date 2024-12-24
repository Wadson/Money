using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Money
{
    public partial class FrmRestaura_Banco : FrmBaseGeral
    {
        public FrmRestaura_Banco()
        {
            InitializeComponent();
        }

        private void btn_caminho_origem_Click(object sender, EventArgs e)
        {
            DialogResult ofd = folderBrowserDialog1.ShowDialog();
          if (ofd == DialogResult.OK)
          {

              string backupPath = folderBrowserDialog1.SelectedPath;
              txt_origem.Text = backupPath;
           }
        }

        private void btn_caminho_destino_Click(object sender, EventArgs e)
        {             
        }

        private void btnSair_Click(object sender, EventArgs e)
        {           
        }

        private void btn_inicia_copia_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = "bdfinanca.sdf";
                string sourcePath = txt_origem.Text;

                string restorePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                //string restorePath = @"";
                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(restorePath, fileName);
                System.IO.File.Copy(sourceFile, destFile, true);
                MessageBox.Show("Banco de dados restaurado com sucesso","Informe.",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_Restaura_Banco_Load(object sender, EventArgs e)
        {
            string currentPath = Path.GetDirectoryName(Application.ExecutablePath);            
            txt_origem.Text = currentPath + @"\Data";
        }
    }
}

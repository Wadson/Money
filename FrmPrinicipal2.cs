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
    public partial class FrmPrinicipal2 : Form
    {
        private int childFormNumber = 0;

        public FrmPrinicipal2()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {

        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnContasPagar_Click(object sender, EventArgs e)
        {
            fechaFormMDI();
            if (Application.OpenForms["FrmManutContasPagar"] == null)
            {

                Form childForm = new FrmManutContasPagar();
                childForm.MdiParent = this;
                childForm.MaximizeBox = true;               
                childForm.Show();
            }            
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            fechaFormMDI();
            Form childForm = new FrmManutFornecedor();

            if (Application.OpenForms[childForm.Name] == null) // Verifica se "Form2" não possui uma instância aberta.                
            {
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                Application.OpenForms[childForm.Name].Focus();
            }          

        }
        private void fechaFormMDI()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void btnFormaPgto_Click(object sender, EventArgs e)
        {
            fechaFormMDI();
            Form childForm = new FrmManutFormaPgto();

            if (Application.OpenForms[childForm.Name] == null) // Verifica se "Form2" não possui uma instância aberta.                
            {
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                Application.OpenForms[childForm.Name].Focus();
            }            
        }

        private void btnCentroCusto_Click(object sender, EventArgs e)
        {
            fechaFormMDI();
            Form childForm = new FrmManutCentroCusto();

            if (Application.OpenForms[childForm.Name] == null) // Verifica se "Form2" não possui uma instância aberta.                
            {
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                Application.OpenForms[childForm.Name].Focus();
            }           
        }

        private void btnContasReceber_Click(object sender, EventArgs e)
        {
            fechaFormMDI();
            Form childForm = new frmManutReceitas();
            if (Application.OpenForms[childForm.Name] == null)          
            {
                childForm.MdiParent = this;               
                childForm.Show();
            }
            else
            {
                Application.OpenForms[childForm.Name].Focus();
            }           
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            fechaFormMDI();
            Form childForm = new FrmRecibo();
            if (Application.OpenForms[childForm.Name] == null) // Verifica se "Form2" não possui uma instância aberta.                
            {
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                Application.OpenForms[childForm.Name].Focus();
            }  
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            fechaFormMDI();
            Form childForm = new FrmRel_Menu();
            if (Application.OpenForms[childForm.Name] == null) // Verifica se "Form2" não possui uma instância aberta.                
            {
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                Application.OpenForms[childForm.Name].Focus();
            }  
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {
            fechaFormMDI();
            Form childForm = new FrmMenuFerramentas();
            if (Application.OpenForms[childForm.Name] == null) // Verifica se "Form2" não possui uma instância aberta.                
            {
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                Application.OpenForms[childForm.Name].Focus();
            }  
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {           
        }
        private void UpdateTexPosition()
        {
            string productVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductVersion;
            string assemblyVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string fileversion = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion;

            lblVersao.Text = string.Format("Assembly Version: {0}", assemblyVersion);

            var grap = CreateGraphics();

            var pontoInicio = grap.MeasureString(" ", Font).Width;
            var larguraEspaco = grap.MeasureString(" ", Font).Width;


            var tituloTemp = "Money - Controle Financeiro Pessoal " + " | " + string.Format("Product Version: {0}", productVersion + " | FileVersion :" + fileversion);
            double larguraTemp = 0;

            while ((larguraTemp + larguraEspaco) < pontoInicio)
            {
                tituloTemp += " ";
                larguraTemp += larguraEspaco;
            }
            Text = tituloTemp + Text.Trim();
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            fechaFormMDI();
            FrmManutUsuario childForm = new FrmManutUsuario();
           
            if (Application.OpenForms[childForm.Name] == null) // Verifica se "Form2" não possui uma instância aberta.                
            {
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                Application.OpenForms[childForm.Name].Focus();
            }
        }

        private void FrmPrinicipal2_Load(object sender, EventArgs e)
        {
            UpdateTexPosition();
            lblUsuarioLogado.Text = FrmLogin.usuarioConectado;
            lblNivelAcess.Text = FrmLogin.NivelAcesso;

            if (lblNivelAcess.Text == "Operador")
            {

            }
            string currentPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            toolStripStatusPatch.Text = currentPath + @"\Money.exe";  
        }
              
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void closeAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
    }
}

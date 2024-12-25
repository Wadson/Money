using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;


namespace Money
{
    public partial class FrmPrincip : Form
    {
        public FrmPrincip()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void AbrirFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void mostrarlogo()
        {
            AbrirFormInPanel(new FormLogo());
        }
        private void mostrarlogoAlCerrarForm(object sender, FormClosedEventArgs e)
        {
            mostrarlogo();
        }
        private void btnFUNCIONARIOS_Click(object sender, EventArgs e)
        {
            FrmManutUsuario frm = new FrmManutUsuario();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnFORNECEDORES_Click(object sender, EventArgs e)
        {
            FrmManutFornecedor frm = new FrmManutFornecedor();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnRELATORIOS_Click(object sender, EventArgs e)
        {
            FrmRel_Menu frm = new FrmRel_Menu();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnFerramenta_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmManutcategoria frm = new FrmManutcategoria();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnSubCateg_Click(object sender, EventArgs e)
        {
            FrmManutSubCategoria frm = new FrmManutSubCategoria();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnFormapgto_Click(object sender, EventArgs e)
        {
            FrmManutFormaPgto frm = new FrmManutFormaPgto();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnEstorno_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            FrmEstorno_Baixa formp = new FrmEstorno_Baixa();
            formp.ShowDialog();
        }

        private void brnPesquisadinamica_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            frmPesquiaDinamica pesq = new frmPesquiaDinamica();
            pesq.ShowDialog();
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            FrmFerramentas ferramtt = new FrmFerramentas();
            ferramtt.ShowDialog();
        }

        private void btnGerarBackup_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            FrmBackup backupg = new FrmBackup();
            backupg.ShowDialog();
        }

        private void btnRestauraBackup_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            FrmRestaura_Banco backupr = new FrmRestaura_Banco();
            backupr.ShowDialog();
        }

        private void FrmPrincip_Load(object sender, EventArgs e)
        { 
            string currentPath = Path.GetDirectoryName(Application.ExecutablePath);           

            lblUsuarioLogado.Text = FrmLogin.usuarioConectado +"  |  Previlégio:"+ FrmLogin.NivelAcesso +"  |  Diretório:"+ currentPath + @"\Money.exe";  
        
        }
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            FrmManutCliente frm = new FrmManutCliente();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmManutProduto frm = new frmManutProduto();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);            
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            //FrmManutContasaReceber frm = new FrmManutContasaReceber();
            //frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);            
            //AbrirFormInPanel(frm);
            //FrmVendas frm = new FrmVendas();
            //frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            //AbrirFormInPanel(frm);

        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendas vendasc = new FrmVendas();
            vendasc.ShowDialog();
        }

        private void btnContasReceber_Click(object sender, EventArgs e)
        {
            frmManutContasReceber frm = new frmManutContasReceber();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void pesquisaDinâmicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquiaDinamicaVendas pesquivendas = new frmPesquiaDinamicaVendas();
            pesquivendas.ShowDialog();  
        }
    }
}

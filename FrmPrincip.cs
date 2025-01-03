﻿using System;
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
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
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
       
      
        private void btnFUNCIONARIOS_Click(object sender, EventArgs e)
        {
            FrmManutUsuario frm = new FrmManutUsuario();
            
            AbrirFormInPanel(frm);
        }

        private void btnFORNECEDORES_Click(object sender, EventArgs e)
        {
            FrmManutFornecedor frm = new FrmManutFornecedor();
            //frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnRELATORIOS_Click(object sender, EventArgs e)
        {
            FrmRel_Menu frm = new FrmRel_Menu();
            //frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnFerramenta_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmManutcategoria frm = new FrmManutcategoria();
            //frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnSubCateg_Click(object sender, EventArgs e)
        {
            FrmManutSubCategoria frm = new FrmManutSubCategoria();
            //frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
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

            string data = DateTime.Now.ToLongDateString();
            data = data.Substring(0, 1).ToUpper() + data.Substring(1, data.Length - 1);
            toolStripStatusData.Text = data;

            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            //string path2 = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            //string path3 = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //string path4 = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            //string path5 = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath);
            //string path6 = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.LocalUserAppDataPath);
            //string path7 = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.CommonAppDataPath);
            //string path8 = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.UserAppDataPath);
                        
            var informacao = Environment.UserName;
            var nomeComputador = Environment.MachineName;

            toolStripStatusExecutablePath.Text = path;
            //toolStripStatusLocation.Text = path6;
            toolStripStatusCommonAppDataPath.Text = nomeComputador + " | " + informacao;
            
            lblEstação.Text = nomeComputador;
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
            //lblHoraAtual.Text = DateTime.UtcNow.ToString("HH:mm:ss");


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
            //frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmManutProduto frm = new frmManutProduto();
            //frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);            
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FrmVendas frm = new FrmVendas();  
            frm.lblTitulo.Text = "PEDIDO DE VENDAS";
            AbrirFormInPanel(frm);                    
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendas vendasc = new FrmVendas();
            vendasc.ShowDialog();
        }

        private void btnContasReceber_Click(object sender, EventArgs e)
        {
            frmManutContasReceber frm = new frmManutContasReceber();
           // frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }

        private void pesquisaDinâmicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquiaDinamicaVendas pesquivendas = new frmPesquiaDinamicaVendas();
            pesquivendas.ShowDialog();  
        }

        private void btnContasPagar_Click(object sender, EventArgs e)
        {
            FrmManutContasPagar frm = new FrmManutContasPagar();
            frm.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatusHora.Text = DateTime.Now.ToLongTimeString();
            lblHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManutCidade frm = new FrmManutCidade();
            //frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frm);
        }
    }
}

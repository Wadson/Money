using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Timers;
using System.IO;

namespace Money
{
    public partial class FormPrincipal : MetroFramework.Forms.MetroForm
    {
        private Form currentForm = null;
        //private FinanceiroBLL financeiroBLL = new FinanceiroBLL();
        public FormPrincipal()
        {
            InitializeComponent();            
        }
        private void OpenFormInContainer(Form formToOpen)
        {
            // Fecha e remove o formulário atual, se houver
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
                pnlContainer.Controls.Clear(); // Remove qualquer controle dentro do painel
            }

            // Remove qualquer propriedade que possa causar conflito
            formToOpen.Owner = null;
            formToOpen.Parent = null; // <<==== Adicione esta linha

            // Configura o formulário para abrir dentro do painel
            formToOpen.TopLevel = false;
            formToOpen.FormBorderStyle = FormBorderStyle.None;
            formToOpen.Dock = DockStyle.Fill;

            // Adiciona ao painel
            pnlContainer.Controls.Add(formToOpen);
            pnlContainer.Tag = formToOpen;
            currentForm = formToOpen;

            formToOpen.Show();
        }
        private void AtualizaBarraStatus()
        {
            // Obtém o caminho do diretório de execução
            string currentPath = Path.GetDirectoryName(Application.ExecutablePath);


            // Verifica se a aplicação foi publicada via ClickOnce
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                // Obtém a versão da publicação
                Version version = ApplicationDeployment.CurrentDeployment.CurrentVersion;

                // Exibe a versão na barra de status ou onde preferir
                lblVersaoSistema.Text = $"Versão da Publicação: {version}";
            }
            else
            {
                lblVersaoSistema.Text = "Aplicação não publicada.";
            }

            //// Atualiza a label de usuário na barra de status
            //string usuarioLogado = FrmLogin.UsuarioConectado;
            //string nivelAcesso = FrmLogin.NivelAcesso;
            //lblUsuarioLogadoo.Text = $"{usuarioLogado}";
            //lblTipoUsuarioo.Text = $"{nivelAcesso}";

            // Atualiza a data
            string data = DateTime.Now.ToLongDateString();
            data = data.Substring(0, 1).ToUpper() + data.Substring(1);
            lblDat.Text = data;

            // Exibe informações do computador
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            var informacao = Environment.UserName;
            var nomeComputador = Environment.MachineName;

            lblEstac.Text = nomeComputador;
            lblDat.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHoraAt.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            // Atualiza a data e hora
            this.Invoke(new Action(() =>
            {
                lblDat.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lblHoraAt.Text = DateTime.Now.ToString("HH:mm:ss");
            }));
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            AtualizaBarraStatus();
        }

        private void btnReceitas_Click(object sender, EventArgs e)
        {
            OpenFormInContainer(new FormManutencaoReceitas());           
        }

        private void btnDespesas_Click(object sender, EventArgs e)
        {
            OpenFormInContainer(new FormManutencaoDespesas());            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tiposDeReceitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInContainer(new FormManutencaoTiposReceita(null));
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            OpenFormInContainer(new FormManutencaoCategorias());
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            OpenFormInContainer(new FormRelatorios());
        }

        private void gerarCópiaDeSegurançaBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerarBackup form = new FormGerarBackup();
            form.ShowDialog();
        }

        private void restaurarCópiaDeSegurançaBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRestaurarBackup form = new FormRestaurarBackup();
            form.ShowDialog();
        }

        private void abrirFuxoFinanceiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFluxoFinanceiro formFluxo = new FormFluxoFinanceiro();
            formFluxo.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblHoraAt.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}

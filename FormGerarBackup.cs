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
using System.IO;
namespace Money
{
    public partial class FormGerarBackup : KryptonForm
    {
        private string origem;
        private string destino;
        public FormGerarBackup()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerarBackup_Click(object sender, EventArgs e)
        {
            GerarBackup();
        }
        private void GerarBackup()
        {
            destino = txtDestino.Text + "Money.sdf"; // Substitua "BancoDeDados.sdf" pelo nome do seu arquivo de banco de dados
            try
            {    
                // Validar se o caminho de destino foi preenchido
                if (string.IsNullOrEmpty(destino))
                {
                    MessageBox.Show("Por favor, informe o caminho de destino.");
                    return;
                }

                // Verificar se o arquivo de origem existe
                if (!File.Exists(origem))
                {
                    MessageBox.Show("O arquivo do banco de dados não foi encontrado no diretório da aplicação.");
                    return;
                }

                // Copiar o arquivo para o destino
                File.Copy(origem, destino, true);

                MessageBox.Show("Backup gerado com sucesso!","Informação!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar backup: {ex.Message}");
            }
        }
        private void FormGerarBackup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Suprima o som de "beep"
                e.Handled = true;
                // Envia a tecla Tab
                SendKeys.Send("{TAB}");
            }
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    // Define o nome pré-definido para o backup
                    string nomeArquivoBackup = "Moneybkp";

                    // Combina o caminho selecionado com o nome do arquivo
                    string caminhoCompleto = Path.Combine(fbd.SelectedPath, nomeArquivoBackup);

                    // Exibe o caminho completo no TextBox de destino
                    txtDestino.Text = caminhoCompleto;
                }
            }
        }

        private void FormGerarBackup_Load(object sender, EventArgs e)
        {
            // Obter o caminho do diretório da aplicação
            origem = AppDomain.CurrentDomain.BaseDirectory + "Money.sdf"; // Substitua "BancoDeDados.sdf" pelo nome do seu arquivo de banco de dados
           txtOrigem.Text = origem;
            txtDestino.Focus();
        }
    }
}

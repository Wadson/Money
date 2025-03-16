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
    public partial class FormRestaurarBackup : KryptonForm
    {
        public FormRestaurarBackup()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnDestino_Click(object sender, EventArgs e)
        {            
        }

        private void btnRestaurarBackup_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter o caminho do diretório da aplicação
                string destino = AppDomain.CurrentDomain.BaseDirectory + "Money.sdf"; // Substitua "BancoDeDados.sdf" pelo nome do seu banco de dados
                string origem = txtOrigem.Text; // Caminho do arquivo de backup

                // Validar se o caminho de origem foi preenchido
                if (string.IsNullOrEmpty(origem))
                {
                    MessageBox.Show("Por favor, informe o caminho de origem do backup.");
                    return;
                }

                // Verificar se o arquivo de origem existe
                if (!File.Exists(origem))
                {
                    MessageBox.Show("O arquivo de backup não foi encontrado.");
                    return;
                }

                // Copiar o arquivo de backup para o diretório da aplicação
                File.Copy(origem, destino, true);

                MessageBox.Show("Backup restaurado com sucesso!","Informação",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao restaurar backup: {ex.Message}");
            }
        }

        private void FormRestaurarBackup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Suprima o som de "beep"
                e.Handled = true;
                // Envia a tecla Tab
                SendKeys.Send("{TAB}");
            }
        }

        private void FormRestaurarBackup_Load(object sender, EventArgs e)
        {
            txtOrigem.Focus();
            // Obter o caminho do diretório da aplicação
            string destino = AppDomain.CurrentDomain.BaseDirectory + "Money.sdf"; // Substitua "BancoDeDados.sdf" pelo nome do seu banco de dados
            txtDestino.Text = destino;
        }

        private void btnOrigem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Define configurações iniciais do diálogo de arquivo
                ofd.Title = "Selecione o arquivo de backup do banco de dados";
                ofd.Filter = "Arquivos de banco de dados (*.sdf)|*.sdf|Todos os arquivos (*.*)|*.*";

                // Exibe o diálogo e verifica se o usuário selecionou um arquivo
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Obtém o caminho completo do arquivo selecionado
                    string caminhoArquivo = ofd.FileName;

                    // Exibe o caminho completo no TextBox de origem
                    txtOrigem.Text = caminhoArquivo;
                }
            }
        }
    }
}

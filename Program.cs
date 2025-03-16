using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Money
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());



            try
            {
                // Caminho para o banco de dados SQL Compact 3.5 com senha
                string connectionString = "Data Source=bdfinanca.sdf;Password=10;Persist Security Info=True";

                // Cria uma instância de SqlCeEngine
                using (SqlCeEngine engine = new SqlCeEngine(connectionString))
                {
                    // Atualiza o banco de dados para a versão 4.0
                    engine.Upgrade();
                    Console.WriteLine("Banco de dados atualizado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                // Captura e exibe qualquer erro
                Console.WriteLine($"Erro ao atualizar o banco de dados: {ex.Message}");
            }
        }
    }
}

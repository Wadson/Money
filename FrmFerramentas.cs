using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Money
{
    public partial class FrmFerramentas : FrmBaseGeral
    {
        public FrmFerramentas()
        {
            InitializeComponent();
        }
        //private void VerificaBanco()
        //{
        //    string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        //    path = path + @"\bdMoney.db";
        //    try
        //    {
        //        string connectionString;

        //        if (File.Exists(path))
        //        {
        //            return;
        //        }
        //        else
        //        {
        //            if (MessageBox.Show("Não há banco de dados! \n Deseja criar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //            {
        //                connectionString = string.Format("Data Source=bdfinanca.sdf;Password=10;Persist Security Info=True");
        //                if (MessageBox.Show("Será criado arquivo " + connectionString + " Confirma ? ", "Criar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
        //                {
        //                    SqlEngine SqlEng = new SqlEngine(connectionString);
        //                    SQLiteDateFormats sqliii = new SQLiteDateFormats(connectionString);
        //                    SqlEng.CreateDatabase();
        //                }
        //                else
        //                {
        //                    return;
        //                }

        //                //*******************criando banco sqlite
        //                SqlConnection.CreateFile("bdMoney");
        //                SqlConnection conn = new SqlConnection(string.Format("Data Source={0}","bdMoney"));
        //                //conn.SetPassword(Resources.DBPassword);



        //                using (SQLiteTransaction transaction = conn.BeginTransaction())
        //                {
        //                    using (SqlCommand cmd = new SqlCommand())
        //                    {
        //                        cmd.Connection = conn;

        //                        //while (!sr.EndoStream)
        //                        //{
        //                        //    cmd.CommandText = sr.ReadLine();
        //                        //    cmd.ExecuteNonQuery();
        //                        //}
        //                    }
        //                    transaction.Commit();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void CriarBanco()
        {
            /* define os parâmetros para o inputbox */
            string Prompt = "Informe o nome do Banco de Dados a ser criado.Ex: Teste.sdf";
            string Titulo = "WR Services";
            string Resultado = Interaction.InputBox(Prompt, Titulo, @"C:\Money\bdfinanca.sdf", 650, 350);

            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            path = path + @"\bdfinanca.sdf";
            /* verifica se o resultado é uma string vazia o que indica que foi cancelado. */
            if (path != "")
            {
                //'verifica se o nome informado contém  o texto ".sdf"
                if (!path.Contains(".sdf"))
                {
                    MessageBox.Show("Informe a extensão .db no arquivo...");
                    return;
                }
                try
                {
                    string connectionString;
                    string nomeArquivoBD = path;
                    //'verifica se o arquivo com o nome informado já existe
                    if (File.Exists(nomeArquivoBD))
                    {
                        if (MessageBox.Show("O arquivo já existe !. Deseja excluir e criar novamente ? ", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            File.Delete(nomeArquivoBD);
                        }
                        else
                        {
                            return;
                        }
                    }
                    //'monta a string de conexão com o banco de dados
                    //Data Source=bdfinanca.sdf;Password=10;Persist Security Info=True
                    connectionString = string.Format("Data Source=bdfinanca.sdf;Password=10;Persist Security Info=True");
                    if (MessageBox.Show("Será criado arquivo " + connectionString + " Confirma ? ", "Criar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        /*SqlEngine SqlEng = new SqlEngine(connectionString);
                        SqlEng.CreateDatabase();
                        lblResultado.Text = "Banco de dados " + nomeArquivoBD + " com sucesso !";*/
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("A operação foi cancelada...");
            }

        }
        private void CriarTabelas()
        {

            var cn = Conexao.Conex();
            //verifica se a conexão esta fechada e abre a conexão
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            //definimos um objeto command
            SqlCommand cmd;
            //montamos uma instrução SQL usando Create Table definindo a estrutura da tabela a ser criada
            string sql = "create table Contatos ("
                              + "Nome nvarchar (60) not null, "
                              + "Sobrenome nvarchar (80), "
                              + "URL nvarchar (150) )";
            cmd = new SqlCommand(sql, cn);
            if (MessageBox.Show("Confirma a criação da tabela ? ", "Criar Tabela", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    //cria a tabela no banco de dados
                    cmd.ExecuteNonQuery();
                    lblResultado.Text = "Tabela criada com sucesso ";
                }
                catch (SqlException sqlexception)
                {
                    MessageBox.Show(sqlexception.Message, "Caramba.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Caramba.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cn.Close();
                }
            }
            else
            {
                return;
            }
        }
       
        private void Frm_Ferramentas_Load(object sender, EventArgs e)
        {
            CarregaTabelas_BD();
        }
        
        private void btnCriarBanco_Click(object sender, EventArgs e)
        {

        }
        private void VerificaBanco()
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            path = path + @"\bdfinanca.sdf";
            try
            {
                string connectionString;

                if (File.Exists(path))
                {
                    return;
                }
                else
                {
                    if (MessageBox.Show("Banco de dados não localizado! \n Deseja criar um novo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        /*connectionString = string.Format("Data Source=bdfinanca.sdf;Password=10;Persist Security Info=True");
                        SqlEngine SqlEng = new SqlEngine(connectionString);
                        SqlEng.CreateDatabase();*/
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCriarBD_Click(object sender, EventArgs e)
        {
            VerificaBanco();
            Verifica_Existe_Tabela();         
           
        }
        private void Verifica_Existe_Tabela()
        {
            var conn = Conexao.Conex();
            try
            {
                conn.Open();
                string Query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";

                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dtResultado = new DataTable();

                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    CreateDatabase_Tabela();
                    //CRIAR_TabelasNew();                   
                }              
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Erro de acesso ao SqlCe : " + sqle.Message, "Erro");
            }
            finally
            {
                conn.Close();
            }
        }
        public static void CreateDatabase_Tabela()
        {
            var Connection = Conexao.Conex();
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            path = path + @"\ScriptCriaBanco.sqlce";

            string script = File.ReadAllText(path);

            IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
                                     RegexOptions.Multiline | RegexOptions.IgnoreCase);

            Connection.Open();

            foreach (string commandString in commandStrings)
            {
                if (commandString.Trim() != "")
                {
                    using (var command = new SqlCommand(commandString, Connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            Connection.Close();
        }
        private void CarregaTabelas_BD()
        {
            var conn = Conexao.Conex();
            try
            {
                conn.Open();
                string Query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";

                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dtResultado = new DataTable();
                da.Fill(dtResultado);
                dgvDados.DataSource = dtResultado;               
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Não Existe banco de dados!!!  \n\n\n\n" + sqle.Message, "Erro",MessageBoxButtons.OK,MessageBoxIcon.Information);               
            }
            finally
            {
                conn.Close();
            }
        }
       
        public void APAGAR()
        {
            if (MessageBox.Show("Quer realmente excluir todas as tabelas ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                path = path + @"\bdfinanca.sdf";

                File.Delete(path);
                MessageBox.Show("Banco de Dados excluídos com Sucesso!!");
                dgvDados.DataSource = null;
                CarregaTabelas_BD();
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {            
        }
      
        private void btnApagarBanco_Click(object sender, EventArgs e)
        {
            APAGAR();
        }

        private void btnCarregarTabelas_Click(object sender, EventArgs e)
        {
            CarregaTabelas_BD();
        }
    }
}

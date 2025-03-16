using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Drawing;
using ComponentFactory.Krypton.Toolkit;
using Guna.UI2.WinForms;

namespace Money
{
    public static class Utilitario
    {
        private static readonly SqlCeConnection conn = Conexao.Conex();
        public static string RemoverZerosAEsquerda(string valor)
        {
            if (string.IsNullOrEmpty(valor))
                return valor;

            return valor.TrimStart('0');

        }
        public static string PesquisarPorCodigoExibirEmTexbox(string tabela, string campoCodigo, string campoNome, int codigo)
        {
            string resultado = string.Empty;
            string query = $"SELECT {campoNome} FROM {tabela} WHERE {campoCodigo} = @Codigo";

            try
            {
                using (SqlCeConnection conn = Conexao.Conex())
                {
                    using (SqlCeCommand cmd = new SqlCeCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", codigo);
                        conn.Open();

                        object retorno = cmd.ExecuteScalar(); // Obtém o primeiro valor retornado

                        if (retorno != null)
                        {
                            resultado = retorno.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar {campoNome}: {ex.Message}");
            }

            return resultado;

            // exemplo  de uso 
            //txtCategoria.Text = Utilitario.PesquisarPorCodigo("Categorias", "CategoriaID", "NomeCategoria", codigo);             
        }



        public static DataTable ObterDataTableComboBox(string query)
        {
            DataTable dt = new DataTable();
            using (SqlCeCommand cmd = new SqlCeCommand(query, conn))
            {
                conn.Open();
                using (SqlCeDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                conn.Close();
            }
            return dt;
        }

        public static void PreencherComboBoxKrypton(KryptonComboBox comboBox, string query, string nome, string Id)
        {
            using (SqlCeCommand cmd = new SqlCeCommand(query, conn))
            {
                conn.Open();
                using (SqlCeDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    comboBox.DisplayMember = nome;  // Substitua "Nome" pela coluna que deseja exibir
                    comboBox.ValueMember = Id;      // Substitua "ID" pela coluna de valor
                    comboBox.DataSource = dt;
                    conn.Close();
                }
            }
        }
        public static void PreencherComboBoxKryptonN(KryptonComboBox comboBox, string query, string nome, string Id)
        {
            using (SqlCeCommand cmd = new SqlCeCommand(query, conn))
            {
                conn.Open();
                using (SqlCeDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    comboBox.DisplayMember = nome;  // Substitua "Nome" pela coluna que deseja exibir
                    comboBox.ValueMember = Id;      // Substitua "ID" pela coluna de valor
                    comboBox.DataSource = dt;
                    conn.Close();
                }
            }
        }
        public static int ObterCodigoComboBox(string query, string NomeParametro, string nomePesquisar)
        {
            int codigoCategoria = -1; // Valor padrão caso não encontre

            using (var connection = Conexao.Conex())
            {
                SqlCeCommand command = new SqlCeCommand(query, connection);
                command.Parameters.AddWithValue(NomeParametro, nomePesquisar);

                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int codigo))
                    {
                        codigoCategoria = codigo;
                    }
                    else
                    {
                        MessageBox.Show($"Nenhum resultado encontrado para '{nomePesquisar}'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar categoria: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return codigoCategoria;
        }


        public static void AtualizarTotalRegistros(Label lblTotalRegistros, DataGridView dataGridView1)
        {
            int totalRegistros = dataGridView1.Rows.Count;
            lblTotalRegistros.Text = $"Total de Registros: {totalRegistros}";
        }
        public static void PreencherCamposEndereco(string enderecoCompleto, KryptonTextBox txtEndereco, KryptonTextBox txtNumero, KryptonTextBox txtBairro)
        {
            try
            {
                // Divide o endereço por vírgula (,) e hífen (-), removendo espaços extras
                string[] partesEndereco = Regex.Split(enderecoCompleto, @"\s*[,|-]\s*");

                // Garantir que há pelo menos 3 partes (Rua, Número, Bairro)
                if (partesEndereco.Length >= 3)
                {
                    txtEndereco.Text = partesEndereco[0].Trim();

                    string numero = partesEndereco[1].Trim();
                    if (numero.StartsWith("nº "))
                    {
                        numero = numero.Substring(3).Trim(); // Remover "nº " com segurança
                    }

                    txtNumero.Text = numero;
                    txtBairro.Text = partesEndereco[2].Trim();
                }
                else
                {
                    MessageBox.Show("Formato de endereço inválido. Certifique-se de que o endereço contém ao menos rua, número e bairro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar o endereço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Mudar a Cor dos Texbox inicio
        public static void AdicionarEfeitoFocoEmTodos(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is KryptonTextBox texbox)
                {
                    AdicionarEfeitoFoco(texbox);
                }

                // Verifica se o controle contém outros controles (como em um Panel ou GroupBox)
                if (control.HasChildren)
                {
                    AdicionarEfeitoFocoEmTodos(control);
                }
            }
        }

        private static void AdicionarEfeitoFoco(Guna2TextBox gunaTextBox)
        {
            // Adiciona um evento para quando o controle ganhar foco
            gunaTextBox.GotFocus += (sender, e) =>
            {
                gunaTextBox.BorderColor = Color.Blue; // Defina a cor da borda ao ganhar foco
            };

            // Adiciona um evento para quando o controle perder foco
            gunaTextBox.LostFocus += (sender, e) =>
            {
                gunaTextBox.BorderColor = Color.Gray; // Redefina a cor da borda ao perder foco
            };
        }


        private static void AdicionarEfeitoFoco(KryptonTextBox kryptonTextBox)
        {
            kryptonTextBox.Enter += (s, e) => kryptonTextBox.StateActive.Back.Color1 = System.Drawing.Color.PaleTurquoise;
            kryptonTextBox.Leave += (s, e) => kryptonTextBox.StateActive.Back.Color1 = kryptonTextBox.StateCommon.Back.Color1;
        }


        //FIM ACIMA
        public static string BuscarResultadoPorQuery(string query, int codigo)
        {
            string resultado = "Resultado não encontrado";

            using (var connection = Conexao.Conex())
            {
                SqlCeCommand command = new SqlCeCommand(query, connection);
                command.Parameters.AddWithValue("@Codigo", codigo);

                try
                {
                    connection.Open();
                    Console.WriteLine("Conexão aberta com sucesso.");
                    Console.WriteLine($"Executando a query: {query}");

                    SqlCeDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        resultado = reader[0].ToString(); // Acessando o primeiro resultado da consulta
                        Console.WriteLine($"Resultado encontrado: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Nenhum registro encontrado.");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Trate exceções conforme necessário
                    Console.WriteLine(ex.Message);
                }
            }

            return resultado;
        }






        // Método que gera o próximo código
        public static int GerarProximoCodigo(string query)
        {
            int proximoCodigo = 1; // Valor inicial padrão

            using (SqlCeConnection conn = Conexao.Conex()) // Inicializando a conexão aqui
            {
                try
                {
                    conn.Open();
                    using (SqlCeCommand cmd = new SqlCeCommand(query, conn))
                    {
                        var result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            proximoCodigo = Convert.ToInt32(result) + 1;
                        }
                    }
                }
                catch (SqlCeException sqlEx)
                {
                    // Tratar exceção de SQL
                    Console.WriteLine($"Erro de SQL: {sqlEx.Message}");
                }
                catch (InvalidOperationException invOpEx)
                {
                    // Tratar exceção de operação inválida
                    Console.WriteLine($"Erro de Operação Inválida: {invOpEx.Message}");
                }
                catch (Exception ex)
                {
                    // Tratar outras exceções
                    Console.WriteLine($"Erro: {ex.Message}");
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }

            return proximoCodigo;
        }
        //Novo Gerador de Código

        public static int GerarNovoCodigoID(string nomeCampo, string nomeDaTabela)
        {
            return GetNextId(nomeCampo, nomeDaTabela);
        }

        private static int GetNextId(string nomeCampo, string nomeDaTabela)
        {
            int nextId = 1;

            using (var connection = Conexao.Conex())
            {
                string query = $"SELECT MAX({nomeCampo}) FROM {nomeDaTabela}";

                SqlCeCommand command = new SqlCeCommand(query, connection);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    nextId = Convert.ToInt32(result) + 1;
                }
            }

            return nextId;
        }

        public static decimal RemoverFormatoMoeda(System.Windows.Forms.TextBox textBox)
        {
            // Obtém o texto do TextBox
            string valorMonetario = textBox.Text;

            // Remove símbolos de moeda e espaços, mantendo os pontos e vírgulas
            string valorSemFormato = valorMonetario.Replace("R$", "")  // Remover símbolo de moeda brasileiro
                                                   .Replace("$", "")   // Remover símbolo de dólar, se necessário
                                                   .Replace("€", "")   // Remover símbolo de euro, se necessário
                                                   .Replace("£", "")   // Remover símbolo de libra, se necessário
                                                   .Trim();            // Remover espaços adicionais

            // Converte a string para decimal considerando a cultura local
            if (decimal.TryParse(valorSemFormato, NumberStyles.Any, new CultureInfo("pt-BR"), out decimal valorDecimal))
            {
                return valorDecimal;
            }
            return 0;
        }



        // Método para validar CPF
        public static bool ValidarCPF(string cpf)
        {
            if (cpf.Length != 11 || cpf.All(c => c == cpf[0])) return false;

            int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicadores1[i];

            int resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            string digito = resto.ToString();
            tempCpf += digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicadores2[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }

      
        public static void PesquisarPorCodigoRetornarNomeTexBox(string query, string nomeParametro, string parametro, KryptonTextBox txtResultado)
        {
            using (var connection = Conexao.Conex())
            {
                SqlCeCommand command = new SqlCeCommand(query, connection);
                command.Parameters.AddWithValue(nomeParametro, parametro);

                try
                {
                    connection.Open();
                    SqlCeDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtResultado.Text = reader["Estado"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum resultado encontrado.", "Informe.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtResultado.Text = string.Empty; // Limpa o texbox
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar nome: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void PesquisarPorNomeMensagemSuprimida(string query, string nomeParametro, string valorParametro, KryptonDataGridView dgv)
        {
            try
            {
                using (SqlCeConnection conn = Conexao.Conex())
                {
                    conn.Open();
                    using (SqlCeCommand cmd = new SqlCeCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(nomeParametro, valorParametro);

                        using (SqlCeDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            if (dt.Rows.Count == 0)
                            {
                                // Limpar o DataGridView se não houver resultados
                                dgv.DataSource = null;
                                return;
                            }

                            dgv.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar categoria: " + ex.Message);
            }
        }


        public static void PesquisarPorPeriodo(string query, string nomeParametroInicio, DateTime dataVencimentoInicio, string nomeParametroFim, DateTime dataVencimentoFim, DataGridView dataGridView)
        {
            using (var connection = Conexao.Conex())
            {
                SqlCeCommand command = new SqlCeCommand(query, connection);
                command.Parameters.AddWithValue(nomeParametroInicio, dataVencimentoInicio);
                command.Parameters.AddWithValue(nomeParametroFim, dataVencimentoFim);

                try
                {
                    connection.Open();
                    SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum resultado encontrado.", "Informe.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        dataGridView.DataSource = null; // Limpa o DataGridView
                    }
                    else
                    {
                        dataGridView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar categoria: " + ex.Message);
                }
            }
        }
        public static int ContaRegistros(DataGridView dataGridView)
        {
            if (dataGridView.DataSource != null)
            {
                DataTable dataTable = dataGridView.DataSource as DataTable;
                return dataTable.Rows.Count;
            }
            else
            {
                return 0;
            }
        }


        private static bool isFormatting = false;

        public static void FormatTextBoxToCurrency(TextBox textBox)
        {
            if (!isFormatting)
            {
                isFormatting = true;
                if (decimal.TryParse(textBox.Text, out decimal value))
                {
                    textBox.Text = String.Format(CultureInfo.CurrentCulture, "{0:N2}", value);
                }
                else
                {
                    textBox.Text = "0.00";
                }
                textBox.SelectionStart = textBox.Text.Length;
                isFormatting = false;
            }
        }
        public static void FormatTextBoxToCurrencyKrypton(KryptonTextBox textBox)
        {
            if (!isFormatting)
            {
                isFormatting = true;
                if (decimal.TryParse(textBox.Text, out decimal value))
                {
                    textBox.Text = String.Format(CultureInfo.CurrentCulture, "{0:N2}", value);
                }
                else
                {
                    textBox.Text = "0.00";
                }
                textBox.SelectionStart = textBox.Text.Length;
                isFormatting = false;
            }
        }

        private static void FormatTextBoxToCurrencyHandler(object sender, EventArgs e)
        {
            FormatTextBoxToCurrency(sender as TextBox);
        }





        // Método para tornar todos os textos dos TextBox em maiúsculas
        public static void TornarTextosMaiusculas(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = textBox.Text.ToUpper();
                }

                // Se o controle possuir filhos, aplica recursivamente
                if (control.HasChildren)
                {
                    TornarTextosMaiusculas(control);
                }
            }
            /*
private void FrmMeuFormulario_Load(object sender, EventArgs e)
    {
        Utilitario.TornarTextosMaiusculas(this); // Converte textos já presentes para maiúsculas

        // Atribui o evento TextChanged para todos os TextBox
        foreach (Control control in this.Controls)
        {
            if (control is TextBox textBox)
            {
                textBox.TextChanged += textBox_TextChanged;
            }
        }
    }

    private void textBox_TextChanged(object sender, EventArgs e)
    {
        if (sender is TextBox textBox)
        {
            int posicaoCursor = textBox.SelectionStart;
            textBox.Text = textBox.Text.ToUpper();
            textBox.SelectionStart = posicaoCursor;
        }
    }
            */
        }
        // Método para 7 dados e preencher DataGridView
        public static void LocalizarGeral(DataGridView dataGridView, string query)
        {
            using (conn)
            {
                using (SqlCeCommand comando = new SqlCeCommand(query, conn))
                {
                    try
                    {
                        conn.Open();

                        // Verifica se a conexão está aberta
                        if (conn.State != ConnectionState.Open)
                        {
                            throw new Exception("Não foi possível abrir a conexão com o banco de dados.");
                        }

                        // Configuração do DataAdapter
                        SqlCeDataAdapter da = new SqlCeDataAdapter
                        {
                            SelectCommand = comando
                        };

                        // Preenchimento do DataTable
                        DataTable dtGeral = new DataTable();
                        da.Fill(dtGeral);

                        // Verifica se o DataTable tem dados
                        if (dtGeral.Rows.Count == 0)
                        {
                            throw new Exception("Nenhum dado foi encontrado.");
                        }

                        // Atribuição dos dados ao DataGridView
                        dataGridView.DataSource = dtGeral;
                    }
                    catch (SqlCeException sqlEx)
                    {
                        MessageBox.Show($"Erro de SQL: {sqlEx.Message}", "Erro de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (InvalidOperationException invOpEx)
                    {
                        MessageBox.Show($"Erro de Operação Inválida: {invOpEx.Message}", "Erro de Operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Verifica se a conexão está aberta antes de tentar fechá-la
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }

        // Método para limpar campos
        public static void LimpaCampo(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (c is MaskedTextBox maskedTextBox)
                {
                    maskedTextBox.Clear();
                }
                else if (c is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now;
                }
                else if (c is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (c is Panel panel)
                {
                    LimpaCampo(panel); // Recursivamente limpar os controles dentro do painel
                }
                else if (c is GroupBox groupBox)
                {
                    LimpaCampo(groupBox); // Recursivamente limpar os controles dentro do groupBox
                }
                else if (c is DataGridView dataGridView)
                {
                    dataGridView.Rows.Clear(); // Limpar todas as linhas do DataGridView
                }
            }
        }
        public static void LimpaCampoKrypton(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is KryptonTextBox textBox)
                {
                    textBox.Clear();
                }
                else if (c is KryptonMaskedTextBox maskedTextBox)
                {
                    maskedTextBox.Clear();
                }
                else if (c is KryptonDateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now;
                }
                else if (c is KryptonComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (c is KryptonPanel panel)
                {
                    LimpaCampo(panel); // Recursivamente limpar os controles dentro do painel
                }
                else if (c is KryptonGroupBox groupBox)
                {
                    LimpaCampo(groupBox); // Recursivamente limpar os controles dentro do groupBox
                }
            }
        }

        // Método para somar valores no DataGridView
        public static decimal SomarValoresDataGridView(KryptonDataGridView dataGridView, string columnName)
        {
            decimal soma = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[columnName].Value != null)
                {
                    soma += Convert.ToDecimal(row.Cells[columnName].Value);
                }
            }
            return soma;
        }
        //Versão melhorada do Método SOMARVALORESDATAGRIDVIEW

        public static decimal SomarValoresDataGrid(DataGridView dataGridView, string columnName)
        {
            decimal soma = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Verifica se a célula na coluna especificada contém um valor válido
                if (row.Cells[columnName].Value != null)
                {
                    decimal valor;
                    // Tenta converter o valor para decimal, se não conseguir, ignora essa célula
                    if (decimal.TryParse(row.Cells[columnName].Value.ToString(), out valor))
                    {
                        soma += valor;
                    }
                }
            }

            return soma;
        }

        // Método para somar valores do banco de dados
        public static decimal SomarValoresBancoDados(string query)
        {
            decimal soma = 0;
            using (conn)
            {
                using (SqlCeCommand comando = new SqlCeCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        soma = Convert.ToDecimal(comando.ExecuteScalar());
                    }
                    catch (SqlCeException sqlEx)
                    {
                        MessageBox.Show($"Erro de SQL: {sqlEx.Message}", "Erro de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (InvalidOperationException invOpEx)
                    {
                        MessageBox.Show($"Erro de Operação Inválida: {invOpEx.Message}", "Erro de Operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }
            return soma;
        }
        public static bool VerificarDuplicidade(string query, Dictionary<string, object> parametros)
        {
            using (conn)
            {
                using (SqlCeCommand comando = new SqlCeCommand(query, conn))
                {
                    foreach (var parametro in parametros)
                    {
                        comando.Parameters.AddWithValue(parametro.Key, parametro.Value);
                    }

                    try
                    {
                        conn.Open();
                        var result = comando.ExecuteScalar();
                        return result != null && result != DBNull.Value;
                    }
                    catch (SqlCeException sqlEx)
                    {
                        // Trate a exceção de SQL conforme necessário
                        Console.WriteLine($"Erro de SQL: {sqlEx.Message}");
                        return false;
                    }
                    catch (InvalidOperationException invOpEx)
                    {
                        // Trate a exceção de operação inválida conforme necessário
                        Console.WriteLine($"Erro de Operação Inválida: {invOpEx.Message}");
                        return false;
                    }
                    catch (Exception ex)
                    {
                        // Trate outras exceções conforme necessário
                        Console.WriteLine($"Erro: {ex.Message}");
                        return false;
                    }
                    finally
                    {
                        if (conn.State == System.Data.ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }

            /* COMO IMPLEMENTAR O MÉTODO EVIDA *** VerificarDuplicidade *****
             * 
             *  string query = "SELECT COUNT(*) FROM Usuarios WHERE Email = @Email";
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@Email", "teste@exemplo.com" }
                };

                bool duplicado = VerificadorDuplicidade.VerificarDuplicidade(query, parametros);
                if (duplicado)
                {
                    MessageBox.Show("Registro já existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Continuar com o cadastro
                }

             * */
        }

        public static string AcrescentarZerosEsquerda(int valor, int comprimentoTotal)
        {
            return valor.ToString().PadLeft(comprimentoTotal, '0');
        }
        /*
          EXEMPLO DE IMPLEMENTAÇÃO DO MÉTODO AcrescentarZerosEsquerda

            public class Programa
            {
                public static void Main()
                {
                    int numeroOriginal = 1;
                    int comprimentoTotal = 4;

                    // Chama o método global para acrescentar zeros à esquerda
                    string numeroComZeros = Utilitario.AcrescentarZerosEsquerda(numeroOriginal, comprimentoTotal);

                    Console.WriteLine($"Número com zeros à esquerda: {numeroComZeros}"); // Saída: 0001

                    numeroOriginal = 45;
                    numeroComZeros = Utilitario.AcrescentarZerosEsquerda(numeroOriginal, comprimentoTotal);

                    Console.WriteLine($"Número com zeros à esquerda: {numeroComZeros}"); // Saída: 0045
                }
            }

         * */
        public static void AcrescentarZerosEsquerda(TextBox txtResultado, int comprimentoTotal)
        {
            if (txtResultado == null)
            {
                throw new ArgumentNullException(nameof(txtResultado), "O parâmetro txtResultado não pode ser nulo.");
            }

            string texto = txtResultado.Text;
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("DEVE SER DIGITADO ALGUM VALOR NO CAMPO CÓDIGO.", "INFORMAÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtResultado.Text = new string('0', comprimentoTotal);
                return;
            }

            if (texto.Length < comprimentoTotal)
            {
                txtResultado.Text = texto.PadLeft(comprimentoTotal, '0');
            }
        }
        // Método para remover parênteses e traços de números
        public static string RemoverParentesesETraços(string numero)
        {
            if (string.IsNullOrWhiteSpace(numero))
            {
                return numero;
            }

            return numero.Replace("(", "").Replace(")", "").Replace("-", "").Trim();
        }

        public static bool EvitarDuplicado(string tabela, string campo, string valor)
        {
            string query = $"SELECT COUNT(*) FROM {tabela} WHERE {campo} = @valor";

            using (conn)
            {
                using (SqlCeCommand comando = new SqlCeCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@valor", valor);

                    try
                    {
                        conn.Open();
                        var result = comando.ExecuteScalar();
                        return result != null && Convert.ToInt32(result) > 0;
                    }
                    catch (SqlCeException sqlEx)
                    {
                        // Trate a exceção de SQL conforme necessário
                        Console.WriteLine($"Erro de SQL: {sqlEx.Message}");
                        return false;
                    }
                    catch (InvalidOperationException invOpEx)
                    {
                        // Trate a exceção de operação inválida conforme necessário
                        Console.WriteLine($"Erro de Operação Inválida: {invOpEx.Message}");
                        return false;
                    }
                    catch (Exception ex)
                    {
                        // Trate outras exceções conforme necessário
                        Console.WriteLine($"Erro: {ex.Message}");
                        return false;
                    }
                    finally
                    {
                        if (conn.State == System.Data.ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }
        // Método para concatenar textos dos TextBoxes e adicionar ao DataGridView
        public static void AddConcatenatedTextToDataGridView(TextBox textBox1, TextBox textBox2, TextBox textBox3, DataGridView dataGridView)
        {
            // Concatenar textos dos TextBoxes
            string concatenatedString = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;

            // Adicionar a string concatenada ao DataGridView em uma única coluna
            dataGridView.Rows.Add(concatenatedString);
        }

        // Método para restaurar textos aos TextBoxes a partir do DataGridView
        public static void RestoreTextBoxesFromDataGridView(TextBox textBox1, TextBox textBox2, TextBox textBox3, DataGridView dataGridView, int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
            {
                // Obter o valor da célula clicada
                string concatenatedString = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();

                // Dividir a string concatenada de volta aos valores originais
                string[] splitStrings = concatenatedString.Split(' ');

                // Restaurar os valores aos TextBoxes, considerando que existem três partes
                if (splitStrings.Length == 3)
                {
                    textBox1.Text = splitStrings[0];
                    textBox2.Text = splitStrings[1];
                    textBox3.Text = splitStrings[2];
                }
                else
                {
                    MessageBox.Show("O formato do texto concatenado está incorreto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Exemplo de uso
            /*
             *  private void btnSave_Click(object sender, EventArgs e)
                {
                    AddConcatenatedTextToDataGridView(textBox1, textBox2, textBox3, dataGridView1);
                }

                private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                    RestoreTextBoxesFromDataGridView(textBox1, textBox2, textBox3, dataGridView1, e.RowIndex);
                }

             * */
        }
        public static bool ValidarCampos(TextBox txtbox)
        {
            if (string.IsNullOrEmpty(txtbox.Text))
            {
                MessageBox.Show("O campo Produto é obrigatório.");
                return false;
            }

            // Outras validações...

            return true;
        }

        public static void ProcessarVenda(TextBox txtbox)
        {
            if (!ValidarCampos(txtbox)) return;

            var worker = new BackgroundWorker();
            worker.DoWork += (sender, e) =>
            {
                // Operações de banco de dados aqui
            };

            worker.RunWorkerCompleted += (sender, e) =>
            {
                MessageBox.Show("Venda processada com sucesso.");
            };

            worker.RunWorkerAsync();
        }
        //public static void FormataTelefone(object sender, KeyPressEventArgs e)
        //{
        //    TextBox textBoxTelefone = sender as TextBox;

        //    if (textBoxTelefone != null)
        //    {
        //        // Permite apenas dígitos e teclas de controle (como backspace)
        //        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        //        {
        //            e.Handled = true;
        //            return;
        //        }

        //        if (char.IsDigit(e.KeyChar))
        //        {
        //            // Prevê o novo valor que seria adicionado ao TextBox
        //            string novoTexto = textBoxTelefone.Text + e.KeyChar;

        //            // Remove todos os caracteres não numéricos para simplificar a formatação
        //            string numero = novoTexto.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

        //            // Formatação do número de telefone conforme o comprimento do texto
        //            if (numero.Length <= 2)
        //            {
        //                textBoxTelefone.Text = "(" + numero;
        //            }
        //            else if (numero.Length <= 6)
        //            {
        //                textBoxTelefone.Text = "(" + numero.Substring(0, 2) + ") " + numero.Substring(2);
        //            }
        //            else if (numero.Length <= 10)
        //            {
        //                textBoxTelefone.Text = "(" + numero.Substring(0, 2) + ") " + numero.Substring(2, 4) + "-" + numero.Substring(6);
        //            }

        //            // Define o cursor no final do texto
        //            textBoxTelefone.SelectionStart = textBoxTelefone.Text.Length;
        //            e.Handled = true;
        //        }
        //    }
        //}

        //// Exemplo de uso do método FormataTelefone
        //// Na classe construtor de inicialização adicione este código:
        public static void FormataTelefone(object sender, KeyPressEventArgs e)
        {
            KryptonTextBox textBoxTelefone = sender as KryptonTextBox;

            if (textBoxTelefone != null)
            {
                // Permite apenas dígitos e teclas de controle (como backspace)
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }

                // Permite apenas dígitos
                if (char.IsDigit(e.KeyChar))
                {
                    // Prever o novo texto que será inserido
                    string novoTexto = textBoxTelefone.Text + e.KeyChar;

                    // Remove caracteres não numéricos para simplificar a formatação
                    string numero = novoTexto.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

                    // Formatação conforme o comprimento do texto
                    if (numero.Length <= 2)
                    {
                        textBoxTelefone.Text = "(" + numero;
                    }
                    else if (numero.Length <= 7)
                    {
                        textBoxTelefone.Text = "(" + numero.Substring(0, 2) + ") " + numero.Substring(2);
                    }
                    else if (numero.Length <= 11)
                    {
                        textBoxTelefone.Text = "(" + numero.Substring(0, 2) + ") " + numero.Substring(2, 1) + " " + numero.Substring(3, 4) + "-" + numero.Substring(7);
                    }

                    // Define a posição do cursor no final do texto
                    textBoxTelefone.SelectionStart = textBoxTelefone.Text.Length;
                    e.Handled = true;
                }
            }
        }

        // Exemplo de uso do método FormataTelefone
        // Na classe construtor de inicialização adicione este código:
        //textBoxTelefone.KeyPress += new KeyPressEventHandler(FormataTelefone);



        public static string LimparNumeroTelefone(string numero) => Regex.Replace(numero, @"[\(\)\- ]", ""); //Exemplo de Uso LimparNumero// string numeroFormatado = txtTelefone.Text; // string numeroLimpo = UtilitarioTelefone.LimparNumero(numeroFormatado);
        public static string LimparNumeroGeral(string numero)
        {
            // Remove todos os caracteres que não são dígitos 
            return Regex.Replace(numero, @"\D", "");
            //Exemplo de Uso LimparNumero
            // string numeroFormatado = txtTelefone.Text; 
            // string numeroLimpo = UtilitarioTelefone.LimparNumero(numeroFormatado);
        }

        // método para PERSONALIZAR NUMEROS DE TELEFONE LIMPO PARA O FORMATO (99) 9 9999-4444
        // PARA EXIBIR EM TEXBOX
        public static string FormatPhoneNumber(string number)
        {
            if (number.Length == 11)
            {
                return string.Format("({0}) {1}-{2}",
                    number.Substring(0, 2),
                    number.Substring(2, 5),
                    number.Substring(7));
            }
            else if (number.Length == 10)
            {
                return string.Format("({0}) {1}-{2}",
                    number.Substring(0, 2),
                    number.Substring(2, 4),
                    number.Substring(6));
            }
            else
            {
                return number;
            }
        }

        public static void FormatarCpf(object sender, KeyPressEventArgs e)
        {
            TextBox textBoxCpf = sender as TextBox;

            if (textBoxCpf != null)
            {
                // Permite apenas dígitos e controle (backspace)
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }

                // Formata o texto após a entrada de um dígito
                if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    string numero = textBoxCpf.Text.Replace(".", "").Replace("-", "");
                    numero += e.KeyChar;

                    if (numero.Length <= 3)
                    {
                        textBoxCpf.Text = numero;
                    }
                    else if (numero.Length <= 6)
                    {
                        textBoxCpf.Text = numero.Substring(0, 3) + "." + numero.Substring(3);
                    }
                    else if (numero.Length <= 9)
                    {
                        textBoxCpf.Text = numero.Substring(0, 3) + "." + numero.Substring(3, 3) + "." + numero.Substring(6);
                    }
                    else if (numero.Length <= 11)
                    {
                        textBoxCpf.Text = numero.Substring(0, 3) + "." + numero.Substring(3, 3) + "." + numero.Substring(6, 3) + "-" + numero.Substring(9);
                    }

                    textBoxCpf.SelectionStart = textBoxCpf.Text.Length;

                    // Uso do Método FormataCpf

                    /*
                    // Construtor do formulário
                  //public Form1()
                  //{       
                  //Inicializacomponent;
                  // Adiciona o evento KeyPress ao campo de texto para chamar o método de formatação
                  //textBoxCpf.KeyPress += new KeyPressEventHandler(FormatadorCpfGlobal.FormatarCpf);        
                  //}
                    */
                }
            }
        }

        // Método para converter Guid em hash
        public static string ConvertGuidToHash(Guid guid)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(guid.ToString()));
                int hashInt = BitConverter.ToInt32(hashBytes, 0);
                return hashInt.ToString();
            }
        }

        // Método para converter hash de volta para Guid (precisa de um mapeamento)
        public static Guid ConvertHashToGuid(string hash)
        {
            // Simulação de conversão - em um cenário real, você precisará manter um mapeamento dos hashes para os GUIDs
            return Guid.NewGuid();
        }
        //Use o método global DE Conversão, Representação de Guid para Número Legivelno seu formulário:

        /*
         public Form1()
         {       
        // Simula a atribuição de um Guid
        VendaID = Guid.NewGuid();
        
        // Exibe um hash do Guid no TextBox
        textBoxVendaID.Text = UtilitarioGuid.ConvertGuidToHash(VendaID);
         }

        // Método para salvar no banco de dados (simulação)
         private void SalvarVenda()
        {
            string hash = textBoxVendaID.Text;
             Guid vendaIdParaSalvar = UtilitarioGuid.ConvertHashToGuid(hash);
        // Código para salvar vendaIdParaSalvar no banco de dados
        }
        */

       
        // Método para pesquisar com parâmetros
        public static void PesquisarComParametros(string query, Dictionary<string, object> parametros, DataGridView grid)
        {
            using (var connection = Conexao.Conex())
            {
                using (var command = new SqlCeCommand(query, connection))
                {
                    if (parametros != null)
                    {
                        foreach (var param in parametros)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    var adapter = new SqlCeDataAdapter(command);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    grid.DataSource = dataTable;
                }
            }
        }
        // Método para pesquisar com parâmetros FIM

        public static void PesquisarProdutoPorReferencia(string referencia, KryptonTextBox txtNomeProduto, KryptonTextBox txtPrecoProduto)
        {
            // Limpa os TextBox antes de realizar a pesquisa
            txtNomeProduto.Text = string.Empty;
            txtPrecoProduto.Text = string.Empty;

            using (var conn = Conexao.Conex())
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlCeCommand comando = new SqlCeCommand("SELECT NomeProduto, PrecoDeVenda FROM Produtos WHERE Referencia = @Referencia", conn);
                    comando.Parameters.AddWithValue("@Referencia", referencia);

                    conn.Open();

                    SqlCeDataAdapter da = new SqlCeDataAdapter(comando);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        txtNomeProduto.Text = dt.Rows[0]["NomeProduto"].ToString();
                        txtPrecoProduto.Text = dt.Rows[0]["PrecoDeVenda"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Referência não encontrada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao executar a pesquisa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }


        public static void PesquisarProdutoPorReferencia2(string referencia, KryptonTextBox texboxReferencia, KryptonTextBox texboxNome, KryptonTextBox texboxProdutoID)
        {
            // Evita a pesquisa vazia se o campo estiver em branco
            if (string.IsNullOrWhiteSpace(referencia))
            {
                texboxNome.Clear();
                texboxProdutoID.Clear();
                return;
            }

            // Query para buscar o ProdutoID e o NomeProduto pela referência
            string query = "SELECT ProdutoID, NomeProduto FROM Produtos WHERE Referencia = @Referencia";

            try
            {
                using (SqlCeConnection conexao = Conexao.Conex())
                {
                    conexao.Open();
                    SqlCeCommand comando = new SqlCeCommand(query, conexao);
                    comando.Parameters.AddWithValue("@Referencia", referencia);

                    // Executa a consulta e obtém o resultado
                    using (SqlCeDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Preenche os campos de NomeProduto e ProdutoID
                            texboxProdutoID.Text = reader["ProdutoID"].ToString();
                            texboxNome.Text = reader["NomeProduto"].ToString();
                        }
                        else
                        {
                            // Caso não encontre, limpar os campos
                            texboxNome.Clear();
                            texboxProdutoID.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar o produto: " + ex.Message);
            }
        }
    }
}

using System;
using System.Data;
using System.Data.SqlServerCe;
using System.IO;

namespace Money
{
    internal class Conexao
    {
        // String de conexão centralizada e flexível
        private static string GetConnectionString()
        {
            // Obtém o diretório onde o executável está rodando
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string dbPath = Path.Combine(appDirectory, "Money.sdf");
            return $"Data Source={dbPath};Persist Security Info=False;";
        }

        // Método para obter a conexão
        public static SqlCeConnection Conex()
        {
            try
            {
                string connString = GetConnectionString();
                SqlCeConnection connection = new SqlCeConnection(connString);
                return connection;
            }
            catch (SqlCeException ex)
            {
                throw new Exception($"Erro ao conectar ao banco de dados: {ex.Message} (SqlCe Error Code: {ex.NativeError})");
            }
        }

        // Método para executar consultas com SqlCeDataReader
        public static SqlCeDataReader Sql_DataReader(string queryString)
        {
            var conexao = Conex();
            conexao.Open();

            SqlCeCommand comando = new SqlCeCommand(queryString, conexao);
            SqlCeDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection); // Fecha a conexão ao fechar o reader
            return reader;
        }

        // Método para retornar um DataTable
        public static DataTable SQL_data_adapter(string queryString)
        {
            DataTable dataTable = new DataTable();
            using (var conexao = Conex())
            {
                try
                {
                    conexao.Open();
                    using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(queryString, conexao))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                catch (SqlCeException ex)
                {
                    throw new Exception($"Erro ao executar consulta: {ex.Message} (SqlCe Error Code: {ex.NativeError})");
                }
            }
            return dataTable;
        }

        // Método para executar comandos sem retorno (INSERT, UPDATE, DELETE)
        public static bool Execute_NON_query(string queryString, string parametroBase = null, string parametroReal = null)
        {
            try
            {
                using (var conexao = Conex())
                {
                    conexao.Open();
                    using (SqlCeCommand comando = new SqlCeCommand(queryString, conexao))
                    {
                        if (!string.IsNullOrEmpty(parametroBase) && parametroReal != null)
                        {
                            comando.Parameters.AddWithValue(parametroBase, parametroReal);
                        }
                        comando.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlCeException ex)
            {
                throw new Exception($"Erro ao executar comando SQL: {ex.Message} (SqlCe Error Code: {ex.NativeError})");
            }
        }
    }
}
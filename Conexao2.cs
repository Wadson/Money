using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Conexao2
    {
        SqlConnection conn = new SqlConnection();
        public Conexao2()
        {
            conn.ConnectionString = @"Data Source=DESKTOP-WR\SQLEXPRESS;Initial Catalog=bdmoney;Integrated Security=True;";
        }
        public SqlConnection Conectar()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
        public void Desconectar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        Conexao2 con = new Conexao2();


        public bool acessar(string login, string senha)
        {
            cmd.CommandText = "SELECT * FROM usuario WHERE usuario = @Usuario AND senha = @Senha";
            cmd.Parameters.AddWithValue("@Usuario", login);
            cmd.Parameters.AddWithValue("@Senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    tem = true;
                }

                Conexao.Conex().Open();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return tem;
        }
        public String cadastrar(String nome, String email, String login, String senha)
        {
            return "";
        }
    }
}

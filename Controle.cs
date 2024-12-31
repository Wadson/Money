using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class Controle
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public bool acessar(string login, string senha)
        {

            cmd.CommandText = "select * from usuario where user_usuario = @User_Usuario AND senha_usuario = @Senha_Usuario";
            cmd.Parameters.AddWithValue("@User_Usuario", login);
            cmd.Parameters.AddWithValue("@Senha_Usuario", senha);

            try
            {
                cmd.Connection = Conexao.Conex();
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
    }
}

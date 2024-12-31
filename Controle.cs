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
        public bool tem;
        public String mensagem = "";

        SqlCommand cmd = new SqlCommand();
//        SqlDataReader dr;

        public bool acessar(string login, string senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.acessar(login, senha);

            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
        public String cadastrar(String nome, String email, String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();

            this.mensagem = loginDao.cadastrar(nome, email, login, senha);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}

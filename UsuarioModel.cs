using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money
{
    class UsuarioModel
    {
        private int id_usuario;
        private string nome_usuario;
        private string senha_usuario;
        private string nivelacesso_usuario;
        private string user_usuario;
        private string email_usuario;
        private DateTime dt_nascimento;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nome_usuario { get => nome_usuario; set => nome_usuario = value; }
        public string Senha_usuario
        {
            get => senha_usuario; set => senha_usuario = value;
        }
        public string Nivelacesso_usuario { get => nivelacesso_usuario; set => nivelacesso_usuario = value; }
        public string User_usuario
        {
            get => user_usuario; set
            {
                user_usuario = value;
            }
        }
        public string Email_usuario { get => email_usuario; set => email_usuario = value; }
        public DateTime Dt_nascimento { get => dt_nascimento; set => dt_nascimento = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money
{
    class UsuarioModel
    {
        private int id_usuario;
        private string nome;
        private string senha;
        private string nivelacesso;
        private string usuario;
        private string email;
        private DateTime dt_nascimento;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Senha
        {
            get => senha; set => senha = value;
        }
        public string Nivelacesso_usuario { get => nivelacesso; set => nivelacesso = value; }
        public string Usuario
        {
            get => usuario; set
            {
                usuario = value;
            }
        }
        public string Email { get => email; set => email = value; }
        public DateTime Dt_nascimento { get => dt_nascimento; set => dt_nascimento = value; }
    }
}

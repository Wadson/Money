using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money
{
    class ClienteMODEL
    {
        private int id_cliente, id_cidade;
        private string nome_cliente, fone_cliente, endereco_cliente, bairro_cliente;
        private DateTime dt_cadastro_cliente;
        public int Id_cliente { get => Id_cliente1; set => Id_cliente1 = value; }
        public string Nome_cliente { get => nome_cliente; set => nome_cliente = value; }
        public string Fone_cliente { get => fone_cliente; set => fone_cliente = value; }
        public string Endereco_cliente { get => endereco_cliente; set => endereco_cliente = value; }
        public string Bairro_cliente { get => bairro_cliente; set => bairro_cliente = value; }
  
        public DateTime Dt_cadastro_cliente { get => dt_cadastro_cliente; set => dt_cadastro_cliente = value; }
        public int Id_cliente1 { get => id_cliente; set => id_cliente = value; }
        public int Id_cidade { get => id_cidade; set => id_cidade = value; }
    }
}

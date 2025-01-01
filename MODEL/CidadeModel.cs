using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class CidadeMODEL
    {
        private int id_cidade, ibge;
        private string nome_cidade, uf_cidade;
        public int Id_cidade { get => id_cidade; set => id_cidade = value; }
        public string Nome_cidade { get => nome_cidade; set => nome_cidade = value; }
        public string Uf_cidade { get => uf_cidade; set => uf_cidade = value; }
        public int Ibge { get => ibge; set => ibge = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money
{
    class cidadeModel
    {
        private int idcidade;
        private string cidade, uf;

        public int Idcidade
        {
            get { return idcidade; }
            set { idcidade = value; }
        }
        

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
    }
}

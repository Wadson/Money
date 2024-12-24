using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money
{
    class CentroCustoModel
    {
        private int id_centro;

        public int Id_centro
        {
            get { return id_centro; }
            set { id_centro = value; }
        }
        
        private string centrocusto;

        public string Centrocusto
        {
            get { return centrocusto; }
            set { centrocusto = value; }
        }

    }
}

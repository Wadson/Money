using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money
{
    class CentroCusto
    {
        private int id_centro_custo; private string centro_custo;

        public int Id_centro_custo
        {
            get { return id_centro_custo; }
            set { id_centro_custo = value; }
        }

        public string Centro_custo
        {
            get { return centro_custo; }
            set { centro_custo = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class RegistroPagamentoModel
    {
        private int id_pagamento, id_contasreceber, id_formapgto;

        private decimal valor_pgto;
        private DateTime dt_pgto;

        public decimal Valor_pgto
        {
            get { return valor_pgto; }
            set { valor_pgto = value; }
        }
        public int Id_pagamento
        {
            get { return id_pagamento; }
            set { id_pagamento = value; }
        }
        public int Id_contasreceber
        {
            get { return id_contasreceber; }
            set { id_contasreceber = value; }
        }

        public int Id_formapgto
        {
            get { return id_formapgto; }
            set { id_formapgto = value; }
        }
        public DateTime Dt_pgto
        {
            get { return dt_pgto; }
            set { dt_pgto = value; }
        }
    }
}

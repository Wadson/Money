using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class ContasReceberMODEL
    {
        private int id_contasreceber, id_parcela, id_formapgto;
        private decimal valor_parcela;
        private bool status_conta;

        public int Id_contasreceber { get => id_contasreceber; set => id_contasreceber = value; }
        public int Id_parcela { get => id_parcela; set => id_parcela = value; }
        public int Id_formapgto { get => id_formapgto; set => id_formapgto = value; }
        public decimal Valor_parcela { get => valor_parcela; set => valor_parcela = value; }
        public bool Status_conta { get => status_conta; set => status_conta = value; }
    }
}

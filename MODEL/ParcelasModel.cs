using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.MODEL
{
    public class ParcelasModel
    {
        public int ParcelaID { get; set; }
        public int DespesaID { get; set; }
        public int NumeroParcela { get; set; }
        public decimal ValorParcela { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPgto { get; set; }
        public bool? Pago { get; set; }
    }
}

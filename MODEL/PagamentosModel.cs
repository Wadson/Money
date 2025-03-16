using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.MODEL
{
    internal class PagamentosModel
    {
        public int PagamentoID { get; set; }
        public int DespesaID { get; set; }
        public int? GastoID { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal ValorPago { get; set; }
        public int? MetodoPgtoID { get; set; }
    }
}

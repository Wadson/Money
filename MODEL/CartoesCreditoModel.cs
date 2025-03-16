using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.MODEL
{
    internal class CartoesCreditoModel
    {
        public int CartaoID { get; set; }
        public string NomeCartao { get; set; }
        public decimal Limite { get; set; }
        public int Fechamento { get; set; }
        public int Vencimento { get; set; }
        public string Bandeira { get; set; }
    }
}

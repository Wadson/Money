using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.MODEL
{
    internal class GastosCombustivelModel
    {
        public int GastoID { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public decimal Litros { get; set; }
        public decimal PrecoPorLitro { get; set; }
        public string Veiculo { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}

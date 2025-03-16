using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.MODEL
{
    public class DespesasModel
    {
        public int DespesaID { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; } // Não nullable
        public string Status { get; set; }
        public int? NumeroParcelas { get; set; }
        public decimal? ValorParcela { get; set; }
        public int? CategoriaID { get; set; }
        public int? MetodoPgtoID { get; set; }
        public bool Pago { get; set; }
        public DateTime DataCriacao { get; set; }
        public string NomeCategoria { get; set; }
        public DateTime? DataPgto { get; set; }
    }
}

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
        public DateTime DataVencimento { get; set; }
        public string Status { get; set; }
        public string NumeroParcelas { get; set; } = null;
        public decimal? ValorParcela { get; set; }
        public int? CategoriaID { get; set; }
        public string NomeCategoria { get; set; } // Adicionada propriedade para o nome da categoria
        public int? MetodoPgtoID { get; set; }
        public bool Pago { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataPgto { get; set; }
    }
}

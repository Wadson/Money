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
        public decimal ValorDaCompra { get; set; }
        public DateTime DataDaCompra { get; set; }
        public string NomeCategoria { get; set; }
        public int? CategoriaID { get; set; }
        public int? MetodoPgtoID { get; set; }
        public List<ParcelasModel> Parcelas { get; set; } = new List<ParcelasModel>(); // Garantir inicialização aqui

        //public int DespesaID { get; set; }
        //public string Descricao { get; set; }
        //public int? CategoriaID { get; set; }
        //public int? MetodoPgtoID { get; set; }
        //public DateTime DataDaCompra { get; set; }
        //public decimal ValorDaCompra { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorParcela { get; set; }
        public bool? Pago { get; set; }
        //public DateTime? DataPgto { get; set; }
        public DateTime? DataVencimento { get; set; }
        //public List<ParcelasModel> Parcelas { get; set; }
        //public string NomeCategoria { get; set; }
        public int NumeroParcelas { get; set; }

    }
}

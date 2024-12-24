using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class ItensVendaMODEL
    {
        private int id_itensvenda, id_produto, qtd_produto, id_venda, num_parcela;
        private double valor_produto;

        public int Id_itensvenda { get => Id_itensvenda1; set => Id_itensvenda1 = value; }
        public int Id_produto { get => Id_produto1; set => Id_produto1 = value; }
        public int Qtd_produto { get => Qtd_produto1; set => Qtd_produto1 = value; }
        public double Valor_produto { get => valor_produto; set => valor_produto = value; }
        public int Id_produto1 { get => Id_produto2; set => Id_produto2 = value; }
        
        public int Id_venda { get => Id_venda1; set => Id_venda1 = value; }
        public int Id_itensvenda1 { get => id_itensvenda; set => id_itensvenda = value; }
        public int Id_produto2 { get => id_produto; set => id_produto = value; }
        public int Qtd_produto1 { get => qtd_produto; set => qtd_produto = value; }
        public int Id_venda1 { get => id_venda; set => id_venda = value; }
        public int Num_parcela { get => num_parcela; set => num_parcela = value; }
    }
}

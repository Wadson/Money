using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class ProdutosMODEL
    {
        private int id_produto;
        private string nome_produto, descricao_produto, marca_produto;
        private double precocusto_produto, precovenda_produto, lucro_produto;

        public int Id_produto { get => id_produto; set => id_produto = value; }
        public double Lucro_produto { get => lucro_produto; set => lucro_produto = value; }
        public string Nome_produto { get => nome_produto; set => nome_produto = value; }
        public string Descricao_produto { get => descricao_produto; set => descricao_produto = value; }
        public string Marca_produto { get => marca_produto; set => marca_produto = value; }
        public double Precocusto_produto { get => precocusto_produto; set => precocusto_produto = value; }
        public double Precovenda_produto { get => precovenda_produto; set => precovenda_produto = value; }
    }
}

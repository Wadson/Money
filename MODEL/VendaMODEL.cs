using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class VendaMODEL
    {
        private int id_venda, id_cliente;
        private DateTime dt_venda;
        

        public int Id_venda { get => id_venda; set => id_venda = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }       
        public DateTime Dt_venda { get => dt_venda; set => dt_venda = value; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money
{
    class FornecedorMODEL
    {

        private int id_fornecedor;
        private string nome_fornecedor, endere_fornecedor;
            
             

        public int ID_Fornecedor
        {
            get { return id_fornecedor; }
            set { id_fornecedor = value; }
        }

        public string Fornecedor
        {
            get { return nome_fornecedor; }
            set { nome_fornecedor = value; }
        }

        public string Endere_fornecedor { get => endere_fornecedor; set => endere_fornecedor = value; }
    }
}

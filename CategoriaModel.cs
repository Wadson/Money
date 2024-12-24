using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money
{
    class categoriaModel
    {
        private int idcategoria;

        public int Idcategoria
        {
            get { return idcategoria; }
            set { idcategoria = value; }
        }


        private string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money
{
    class SubCategoriaMODEL
    {
        int idsubcategoria, idcategoria;

        public int Idcategoria
        {
            get { return idcategoria; }
            set { idcategoria = value; }
        }

        public int Idsubcategoria
        {
            get { return idsubcategoria; }
            set { idsubcategoria = value; }
        } string subcategoria;

        public string Subcategoria
        {
            get { return subcategoria; }
            set { subcategoria = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money
{
    class ContasMODEL
    {
        private int idconta, idfornecedor, idcategoria, idsubcategoria, idformapgto;

        public int Idsubcategoria
        {
            get { return idsubcategoria; }
            set { idsubcategoria = value; }
        }

        public int Idformapgto
        {
            get { return idformapgto; }
            set { idformapgto = value; }
        }

      
        private DateTime datacadastro;

      
        private string descricao;

        public int Idcategoria
        {
            get { return idcategoria; }
            set { idcategoria = value; }
        }
        public DateTime Datacadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }
        public int IDConta
        {
            get { return idconta; }
            set { idconta = value; }
        }

        public int IDFornecedor
        {
            get { return idfornecedor; }
            set { idfornecedor = value; }
        }    

        public string Descricao
        {
            get { return this.descricao; }
            set { descricao = value; }
        }
    }
}

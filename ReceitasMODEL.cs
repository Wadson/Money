using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money
{
    class ReceitasMODEL
    {
        Int32 idfornecedor, idReceita;

        public Int32 Idfornecedor
        {
            get { return idfornecedor; }
            set { idfornecedor = value; }
        }
        DateTime dataCadastro;
        string descricao, competencia;

        public string Competencia
        {
            get { return competencia; }
            set { competencia = value; }
        }
        double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }

        public Int32 IdReceita
        {
            get { return idReceita; }
            set { idReceita = value; }
        }
    }
}

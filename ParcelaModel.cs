using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money
{
    class ParcelaModel
    {
        private int idparcela, idvenda;


        private int numparcela;
        private decimal valor_parc, valorpago;
       
       
        public decimal Valorpago
        {
            get { return valorpago; }
            set { valorpago = value; }
        }
          
        public int Numparcela
        {
            get { return numparcela; }
            set { numparcela = value; }
        }
        public int Idparcela
        {
            get { return idparcela; }
            set { idparcela = value; }
        }
        public int IdVenda
        {
            get { return idvenda; }
            set { idvenda = value; }
        }
       
        public decimal Valor_parc
        {
            get { return valor_parc; }
            set { valor_parc = value; }
        }
        private int pago;

        public int Pago
        {
            get { return pago; }
            set { pago = value; }
        }
        private DateTime datavenc, datapgto;

        public DateTime Datavenc
        {
            get { return datavenc; }
            set { datavenc = value; }
        }
        public DateTime Datapgto
        {
            get { return datapgto; }
            set { datapgto = value; }
        }

    }
}

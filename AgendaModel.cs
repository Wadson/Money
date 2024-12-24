using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money
{
    class AgendaModel
    {
        private string nome, endereco, email, fone, celular;
        private int idagenda, idcidade;

        public int Idcidade
        {
            get { return idcidade; }
            set { idcidade = value; }
        }  
        
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
              
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Fone
        {
            get { return fone; }
            set { fone = value; }
        }

        public int Idagenda
        {
            get { return idagenda; }
            set { idagenda = value; }
        }              

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }       

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
    }
}

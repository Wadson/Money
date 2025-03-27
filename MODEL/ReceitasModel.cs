using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class ReceitasModel
    {
        public int ReceitaID { get; set; }
        public string Descricao { get; set; }
        public decimal ValorDaReceita { get; set; }
        public DateTime DataRecebimento { get; set; }
        public int? TipoID { get; set; } // Agora aceita valores nulos       
        public string NomeTipoReceita { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}

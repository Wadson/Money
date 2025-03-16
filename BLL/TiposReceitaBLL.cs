using Money.DAL;
using Money.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.BLL
{
    internal class TiposReceitaBLL
    {
        private readonly TiposReceitaDAL _dal = new TiposReceitaDAL();

        public void Salvar(TiposReceitaModel tipo)
        {
            if (string.IsNullOrEmpty(tipo.NomeTipoReceita))
                throw new ArgumentException("O nome do tipo de receita é obrigatório.");

            _dal.Salvar(tipo);
        }

        public void Alterar(TiposReceitaModel tipo)
        {
            if (tipo.TipoReceitaID <= 0)
                throw new ArgumentException("ID inválido.");
            if (string.IsNullOrEmpty(tipo.NomeTipoReceita))
                throw new ArgumentException("O nome do tipo de receita é obrigatório.");

            _dal.Alterar(tipo);
        }

        public void Excluir(int tipoID)
        {
            if (tipoID <= 0)
                throw new ArgumentException("ID inválido.");

            _dal.Excluir(tipoID);
        }

        public List<TiposReceitaModel> Pesquisar(string nomeTipo = null)
        {
            return _dal.Pesquisar(nomeTipo);
        }
        public TiposReceitaModel Listar(string NomeTipoReceita)
        {
            if (NomeTipoReceita != null)
                throw new ArgumentException("ID inválido.");

            var tipo = _dal.Listar(NomeTipoReceita);
            if (tipo == null)
                throw new Exception($"Tipo de receita com ID {NomeTipoReceita} não encontrado.");

            return tipo;
        }

    }
}

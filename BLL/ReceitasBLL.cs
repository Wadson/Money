using Money.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Money.BLL
{
    internal class ReceitasBLL
    {
        private readonly ReceitasDAL _dal = new ReceitasDAL();

        public void Salvar(ReceitasModel receita)
        {
            if (string.IsNullOrEmpty(receita.Descricao))
                throw new ArgumentException("A descrição é obrigatória.");
            if (receita.ValorDaReceita <= 0)
                throw new ArgumentException("O valor deve ser maior que zero.");
            if (receita.TipoID <= 0)
                throw new ArgumentException("O tipo de receita é inválido.");
            if (receita.DataRecebimento == default)
                throw new ArgumentException("A data é obrigatória.");

            _dal.Salvar(receita);
        }

        public void Alterar(ReceitasModel receita)
        {
            if (receita.ReceitaID <= 0)
                throw new ArgumentException("ID inválido.");
            if (string.IsNullOrEmpty(receita.Descricao))
                throw new ArgumentException("A descrição é obrigatória.");
            if (receita.ValorDaReceita <= 0)
                throw new ArgumentException("O valor deve ser maior que zero.");
            if (receita.TipoID <= 0)
                throw new ArgumentException("O tipo de receita é inválido.");
            if (receita.DataRecebimento == default)
                throw new ArgumentException("A data é obrigatória.");

            _dal.Alterar(receita);
        }

        public void Excluir(int receitaID)
        {
            if (receitaID <= 0)
                throw new ArgumentException("ID inválido.");

            _dal.Excluir(receitaID);
        }

        public List<ReceitasModel> Pesquisar(string descricao = null)
        {
            return _dal.Pesquisar(descricao);
        }
    }
}

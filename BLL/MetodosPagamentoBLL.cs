using Money.DAL;
using Money.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.BLL
{
    internal class MetodosPagamentoBLL
    {
        private readonly MetodosPagamentoDAL _dal = new MetodosPagamentoDAL();

        public void Salvar(MetodosPagamentoModel metodo)
        {
            if (string.IsNullOrEmpty(metodo.NomeMetodoPagamento))
                throw new ArgumentException("O nome do método de pagamento é obrigatório.");

            _dal.Salvar(metodo);
        }

        public void Alterar(MetodosPagamentoModel metodo)
        {
            if (metodo.MetodoPgtoID <= 0)
                throw new ArgumentException("ID inválido.");
            if (string.IsNullOrEmpty(metodo.NomeMetodoPagamento))
                throw new ArgumentException("O nome do método de pagamento é obrigatório.");

            _dal.Alterar(metodo);
        }

        public void Excluir(int metodoPgtoID)
        {
            if (metodoPgtoID <= 0)
                throw new ArgumentException("ID inválido.");

            _dal.Excluir(metodoPgtoID);
        }

        public List<MetodosPagamentoModel> PesquisarMetodoPagamento(string nomeMetodo = null)
        {
            return _dal.PesquisarMetodoPagamento(nomeMetodo);
        }
    }
}

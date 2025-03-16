using Money.DAL;
using Money.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.BLL
{
    internal class PagamentosBLL
    {
        private readonly PagamentosDAL _dal = new PagamentosDAL();

        public void Salvar(PagamentosModel pagamento)
        {
            if (pagamento.DespesaID <= 0)
                throw new ArgumentException("O ID da despesa é inválido.");
            if (pagamento.ValorPago <= 0)
                throw new ArgumentException("O valor pago deve ser maior que zero.");
            if (pagamento.DataPagamento == default)
                throw new ArgumentException("A data de pagamento é obrigatória.");

            _dal.Salvar(pagamento);
        }

        public void Alterar(PagamentosModel pagamento)
        {
            if (pagamento.PagamentoID <= 0)
                throw new ArgumentException("ID inválido.");
            if (pagamento.DespesaID <= 0)
                throw new ArgumentException("O ID da despesa é inválido.");
            if (pagamento.ValorPago <= 0)
                throw new ArgumentException("O valor pago deve ser maior que zero.");
            if (pagamento.DataPagamento == default)
                throw new ArgumentException("A data de pagamento é obrigatória.");

            _dal.Alterar(pagamento);
        }

        public void Excluir(int pagamentoID)
        {
            if (pagamentoID <= 0)
                throw new ArgumentException("ID inválido.");

            _dal.Excluir(pagamentoID);
        }

        public List<PagamentosModel> Pesquisar(int? despesaID = null)
        {
            return _dal.Pesquisar(despesaID);
        }
    }
}

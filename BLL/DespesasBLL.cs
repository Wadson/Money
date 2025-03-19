using Money.DAL;
using Money.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Money.DAL.DespesasDAL;

namespace Money.BLL
{
    internal class DespesasBLL
    {
        private DespesasDAL _dal = new DespesasDAL();

        public void Salvar(DespesasModel despesa)
        {
            if (string.IsNullOrEmpty(despesa.Descricao))
                throw new ArgumentException("A descrição é obrigatória.");
            if (despesa.Valor <= 0)
                throw new ArgumentException("O valor deve ser maior que zero.");
            if (string.IsNullOrEmpty(despesa.Status))
                throw new ArgumentException("O status é obrigatório.");
            if (despesa.NumeroParcelas.HasValue && despesa.NumeroParcelas <= 0)
                throw new ArgumentException("O número de parcelas deve ser maior que zero.");
            if (despesa.ValorParcela.HasValue && despesa.ValorParcela <= 0)
                throw new ArgumentException("O valor da parcela deve ser maior que zero.");
            if (despesa.DataVencimento == default)
                throw new ArgumentException("A data de vencimento é obrigatória.");

            _dal.Salvar(despesa);
        }

        public void Alterar(DespesasModel despesa)
        {
            if (despesa.DespesaID <= 0)
                throw new ArgumentException("ID inválido.");
            if (string.IsNullOrEmpty(despesa.Descricao))
                throw new ArgumentException("A descrição é obrigatória.");
            if (despesa.Valor <= 0)
                throw new ArgumentException("O valor deve ser maior que zero.");
            if (string.IsNullOrEmpty(despesa.Status))
                throw new ArgumentException("O status é obrigatório.");
            if (despesa.NumeroParcelas.HasValue && despesa.NumeroParcelas <= 0)
                throw new ArgumentException("O número de parcelas deve ser maior que zero.");
            if (despesa.ValorParcela.HasValue && despesa.ValorParcela <= 0)
                throw new ArgumentException("O valor da parcela deve ser maior que zero.");
            if (despesa.DataVencimento == default)
                throw new ArgumentException("A data de vencimento é obrigatória.");

            _dal.Atualizar(despesa);
        }
        public void AlterarStatus(DespesasModel despesa)
        {
            if (despesa.DespesaID <= 0)
                throw new ArgumentException("ID inválido.");            
            if (string.IsNullOrEmpty(despesa.Status))
                throw new ArgumentException("O status é obrigatório.");
            if (despesa.Pago != true)
                throw new ArgumentException("Deve marcar como pago true");  

            _dal.AtualizarStatus(despesa);
        }
        public void Excluir(int despesaID)
        {
            if (despesaID <= 0)
                throw new ArgumentException("ID inválido.");

            _dal.Excluir(despesaID);
        }

        public List<DespesasModel> Pesquisar(string descricao = null, bool? pago = null)
        {
            return _dal.Pesquisar(descricao, pago);
        }

        public List<DespesasModel> PesquisarRelatorio(string descricao = null)
        {
            return _dal.PesquisarRelatorios(descricao);
        }


        //public void Salvar(DespesasModel despesa)
        //{
        //    _dal.Salvar(despesa);
        //}

        //public void Atualizar(DespesasModel despesa)
        //{
        //    _dal.Atualizar(despesa);
        //}

        //public void Excluir(int despesaId)
        //{
        //    _dal.Excluir(despesaId);
        //}

        //public List<DespesasModel> Pesquisar(string descricao = null)
        //{
        //    return _dal.Pesquisar(descricao);
        //}
    }
}

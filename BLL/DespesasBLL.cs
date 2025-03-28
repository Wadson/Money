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
            if (despesa.ValorDaCompra <= 0)
                throw new ArgumentException("O valor deve ser maior que zero.");

            _dal.Salvar(despesa);
        }

        public void Alterar(DespesasModel despesa)
        {
            if (despesa.DespesaID <= 0)
                throw new ArgumentException("ID inválido.");
            if (string.IsNullOrEmpty(despesa.Descricao))
                throw new ArgumentException("A descrição é obrigatória.");
            if (despesa.ValorDaCompra <= 0)
                throw new ArgumentException("O valor deve ser maior que zero.");

            _dal.Atualizar(despesa);
        }
        public void AlterarDespesasEParcelas(DespesasModel despesa)
        {
            if (despesa.DespesaID <= 0)
                throw new ArgumentException("ID inválido.");
            if (string.IsNullOrEmpty(despesa.Descricao))
                throw new ArgumentException("A descrição é obrigatória.");
            if (despesa.ValorDaCompra <= 0)
                throw new ArgumentException("O valor deve ser maior que zero.");

            _dal.AtualizarDespesasEParcelas(despesa);
        }

        public void AlterarStatus(DespesasModel despesa)
        {
            if (despesa.DespesaID <= 0)
                throw new ArgumentException("ID inválido.");
            // Aqui, podemos assumir que o status "Pago" será gerenciado em Parcelas, mas se for necessário na Despesa, precisamos adicionar um campo "Pago" à DespesasModel
            _dal.AtualizarStatus(despesa);
        }

        public void Excluir(int despesaID)
        {
            if (despesaID <= 0)
                throw new ArgumentException("ID inválido.");

            _dal.Excluir(despesaID);
        }
        public void ExcluirEmCascata(int despesaID)
        {
            if (despesaID <= 0)
                throw new ArgumentException("ID inválido.");

            _dal.Excluir(despesaID);
        }
        public List<DespesasModel> Pesquisar(string descricao = null, bool? pago = null)
        {
            return _dal.Pesquisar(descricao, pago); // Precisamos ajustar a DAL para suportar o parâmetro "pago"
        }

        public List<DespesasModel> PesquisarRelatorio(string descricao = null)
        {
            return _dal.PesquisarRelatorios(descricao);
        }
        public List<DespesasModel> PesquisarRelatorioComVencimento(string descricao = null)
        {
            return _dal.PesquisarRelatoriosComVencimento(descricao);
        }
    }
}

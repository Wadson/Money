using Money.DAL;
using Money.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.BLL
{
    internal class ParcelasBLL
    {
        private readonly ParcelasDAL _dal = new ParcelasDAL();

        public void Salvar(ParcelasModel parcela)
        {
            if (parcela.DespesaID <= 0)
                throw new ArgumentException("O ID da despesa é inválido.");
            if (parcela.ValorParcela <= 0)
                throw new ArgumentException("O valor da parcela deve ser maior que zero.");
            if (parcela.DataVencimento == default)
                throw new ArgumentException("A data de vencimento é obrigatória.");

            _dal.Salvar(parcela);
        }
        public void QuitarParcela(int parcelaID, DateTime? dataPgto = null)
        {
            _dal.QuitarParcela(parcelaID, dataPgto);
        }
        public void Alterar(ParcelasModel parcela)
        {
            if (parcela.ParcelaID <= 0)
                throw new ArgumentException("ID inválido.");
            if (parcela.DespesaID <= 0)
                throw new ArgumentException("O ID da despesa é inválido.");
            if (parcela.ValorParcela <= 0)
                throw new ArgumentException("O valor da parcela deve ser maior que zero.");
            if (parcela.DataVencimento == default)
                throw new ArgumentException("A data de vencimento é obrigatória.");

            _dal.Alterar(parcela);
        }

        public void Excluir(int parcelaID)
        {
            if (parcelaID <= 0)
                throw new ArgumentException("ID inválido.");

            _dal.Excluir(parcelaID);
        }

        public List<ParcelasModel> Pesquisar(int? despesaID = null)
        {
            return _dal.Pesquisar(despesaID);
        }
    }
}

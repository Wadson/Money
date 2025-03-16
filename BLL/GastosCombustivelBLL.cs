using Money.DAL;
using Money.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.BLL
{
    internal class GastosCombustivelBLL
    {
        private readonly GastosCombustivelDAL _dal = new GastosCombustivelDAL();

        public void Salvar(GastosCombustivelModel gasto)
        {
            if (gasto.Valor <= 0)
                throw new ArgumentException("O valor deve ser maior que zero.");
            if (gasto.Litros <= 0)
                throw new ArgumentException("A quantidade de litros deve ser maior que zero.");
            if (gasto.PrecoPorLitro <= 0)
                throw new ArgumentException("O preço por litro deve ser maior que zero.");
            if (string.IsNullOrEmpty(gasto.Veiculo))
                throw new ArgumentException("O veículo é obrigatório.");
            if (gasto.Data == default)
                throw new ArgumentException("A data é obrigatória.");

            _dal.Salvar(gasto);
        }

        public void Alterar(GastosCombustivelModel gasto)
        {
            if (gasto.GastoID <= 0)
                throw new ArgumentException("ID inválido.");
            if (gasto.Valor <= 0)
                throw new ArgumentException("O valor deve ser maior que zero.");
            if (gasto.Litros <= 0)
                throw new ArgumentException("A quantidade de litros deve ser maior que zero.");
            if (gasto.PrecoPorLitro <= 0)
                throw new ArgumentException("O preço por litro deve ser maior que zero.");
            if (string.IsNullOrEmpty(gasto.Veiculo))
                throw new ArgumentException("O veículo é obrigatório.");
            if (gasto.Data == default)
                throw new ArgumentException("A data é obrigatória.");

            _dal.Alterar(gasto);
        }

        public void Excluir(int gastoID)
        {
            if (gastoID <= 0)
                throw new ArgumentException("ID inválido.");

            _dal.Excluir(gastoID);
        }

        public List<GastosCombustivelModel> Pesquisar(string veiculo = null)
        {
            return _dal.Pesquisar(veiculo);
        }
    }
}

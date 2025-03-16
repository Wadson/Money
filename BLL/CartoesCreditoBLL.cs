using Money.DAL;
using Money.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.BLL
{
    internal class CartoesCreditoBLL
    {
        private readonly CartoesCreditoDAL _dal = new CartoesCreditoDAL();

        public void Salvar(CartoesCreditoModel cartao)
        {
            if (string.IsNullOrEmpty(cartao.NomeCartao))
                throw new ArgumentException("O nome do cartão é obrigatório.");
            if (cartao.Limite <= 0)
                throw new ArgumentException("O limite deve ser maior que zero.");
            if (cartao.Fechamento < 1 || cartao.Fechamento > 31)
                throw new ArgumentException("O dia de fechamento deve estar entre 1 e 31.");
            if (cartao.Vencimento < 1 || cartao.Vencimento > 31)
                throw new ArgumentException("O dia de vencimento deve estar entre 1 e 31.");

            _dal.Salvar(cartao);
        }

        public void Alterar(CartoesCreditoModel cartao)
        {
            if (cartao.CartaoID <= 0)
                throw new ArgumentException("ID inválido.");
            if (string.IsNullOrEmpty(cartao.NomeCartao))
                throw new ArgumentException("O nome do cartão é obrigatório.");
            if (cartao.Limite <= 0)
                throw new ArgumentException("O limite deve ser maior que zero.");
            if (cartao.Fechamento < 1 || cartao.Fechamento > 31)
                throw new ArgumentException("O dia de fechamento deve estar entre 1 e 31.");
            if (cartao.Vencimento < 1 || cartao.Vencimento > 31)
                throw new ArgumentException("O dia de vencimento deve estar entre 1 e 31.");

            _dal.Alterar(cartao);
        }

        public void Excluir(int cartaoID)
        {
            if (cartaoID <= 0)
                throw new ArgumentException("ID inválido.");

            _dal.Excluir(cartaoID);
        }

        public List<CartoesCreditoModel> Pesquisar(string nomeCartao = null)
        {
            return _dal.Pesquisar(nomeCartao);
        }
    }
}

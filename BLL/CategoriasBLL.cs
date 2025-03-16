using Money.DAL;
using Money.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.BLL
{
    internal class CategoriasBLL
    {
        private readonly CategoriasDAL _dal = new CategoriasDAL();

        public void Salvar(CategoriasModel categoria)
        {
            if (string.IsNullOrEmpty(categoria.NomeCategoria))
                throw new ArgumentException("O nome da categoria é obrigatório.");

            _dal.Salvar(categoria);
        }

        public void Alterar(CategoriasModel categoria)
        {
            if (categoria.CategoriaID <= 0)
                throw new ArgumentException("ID inválido.");
            if (string.IsNullOrEmpty(categoria.NomeCategoria))
                throw new ArgumentException("O nome da categoria é obrigatório.");

            _dal.Alterar(categoria);
        }

        public void Excluir(int categoriaID)
        {
            if (categoriaID <= 0)
                throw new ArgumentException("ID inválido.");

            _dal.Excluir(categoriaID);
        }

        public List<CategoriasModel> PesquisarCategoria(string nomeCategoria = null)
        {
            return _dal.PesquisarCategoria(nomeCategoria);
        }
    }
}

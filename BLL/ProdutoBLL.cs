using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Money
{
    internal class ProdutoBLL
    {
        ProdutoDAL produtodall = null;
       
        public DataTable Lista_Produto()
        {
            DataTable dtable = new DataTable();
            try
            {
                produtodall = new ProdutoDAL();
                dtable = produtodall.lista_Produto();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }

        public void Salvar(ProdutosMODEL produto)
        {
            try
            {
                produtodall = new ProdutoDAL();
                produtodall.salvaProduto(produto);
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }
        public void Alterar(ProdutosMODEL produto)
        {           
            try
            {
                produtodall = new ProdutoDAL();
                produtodall.atualizaProduto(produto);
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }
        public void ExcluirProduto(ProdutosMODEL produto)
        {
            try
            {
                produtodall = new ProdutoDAL();
                produtodall.excluiProduto(produto);
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }
        public ProdutosMODEL PesquisarCodigo(string pesquisa)
        {
            var conn = Conexao.Conex();
            try
            {

                SqlCommand sql = new SqlCommand("SELECT * FROM produto WHERE id_produto LIKE '" + pesquisa + "%' ", conn);
                conn.Open();
                SqlDataReader datareader;
                ProdutosMODEL obj_Produto = new ProdutosMODEL();

                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);
                while (datareader.Read())
                {
                    obj_Produto.Id_produto = Convert.ToInt32(datareader["id_produto"]);
                    obj_Produto.Nome_produto = datareader["nome_produto"].ToString();
                    obj_Produto.Descricao_produto = datareader["descricao_produto"].ToString();
                    obj_Produto.Marca_produto = datareader["marca_produto"].ToString();
                    obj_Produto.Precocusto_produto = Convert.ToDouble(datareader["precocusto_produto"]);
                    obj_Produto.Lucro_produto = Convert.ToInt32(datareader["lucro_produto"]);
                    obj_Produto.Precovenda_produto = Convert.ToDouble(datareader["precovenda_produto"]);                   

                }
                return obj_Produto;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}

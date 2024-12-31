using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Money
{
    internal class ContasReceberDAL
    {
        public DataTable lista_contas_receber()
        {
            var conn = Conexao.Conex();
            try
            {
                //SqlCommand sql = new SqlCommand("SELECT cliente.nome_cliente, cliente.id_cliente, venda.dt_venda, produto.id_produto, produto.nome_produto, parcelas.num_parcela, parcelas.dt_vcto_parcela, parcelas.id_venda AS Expr1, itensvenda.qtd_produto, contasreceber.valor_parcela, contasreceber.status_conta FROM produto INNER JOIN itensvenda ON produto.id_produto = itensvenda.id_produto INNER JOIN venda ON itensvenda.id_venda = venda.id_venda INNER JOIN cliente ON venda.id_cliente = cliente.id_cliente INNER JOIN contasreceber INNER JOIN parcelas ON contasreceber.id_parcela = parcelas.id_parcela ON venda.id_venda = parcelas.id_venda WHERE (contasreceber.status_conta = 0)", conn);

                SqlCommand sql = new SqlCommand("SELECT cliente.nome_cliente, cliente.id_cliente, venda.dt_venda, produto.id_produto, produto.nome_produto, parcelas.num_parcela, parcelas.dt_vcto_parcela, itensvenda.qtd_produto, contasreceber.valor_parcela, " +
"contasreceber.status_conta, venda.id_venda, parcelas.id_parcela, contasreceber.id_contasreceber, itensvenda.id_itensvenda " +
"FROM produto INNER JOIN " +
"itensvenda ON produto.id_produto = itensvenda.id_produto INNER JOIN " +
"venda ON itensvenda.id_venda = venda.id_venda INNER JOIN " +
"cliente ON venda.id_cliente = cliente.id_cliente INNER JOIN " +
"contasreceber INNER JOIN " +
"parcelas ON contasreceber.id_parcela = parcelas.id_parcela ON venda.id_venda = parcelas.id_venda " +
"WHERE (contasreceber.status_conta = 0)", conn);

                SqlDataAdapter daControle = new SqlDataAdapter();
                daControle.SelectCommand = sql;
                DataTable dtcontrole = new DataTable();
                daControle.Fill(dtcontrole);
                return dtcontrole;
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
        public void listarcontasreceber2(ContasReceberMODEL conta)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("SELECT cliente.nome_cliente, cliente.id_cliente, venda.dt_venda, produto.id_produto, produto.nome_produto, parcelas.num_parcela, parcelas.dt_vcto_parcela, parcelas.id_venda AS Expr1, itensvenda.qtd_produto, contasreceber.valor_parcela, contasreceber.status_conta FROM produto INNER JOIN itensvenda ON produto.id_produto = itensvenda.id_produto INNER JOIN venda ON itensvenda.id_venda = venda.id_venda INNER JOIN cliente ON venda.id_cliente = cliente.id_cliente INNER JOIN contasreceber INNER JOIN parcelas ON contasreceber.id_parcela = parcelas.id_parcela ON venda.id_venda = parcelas.id_venda WHERE (contasreceber.status_conta = @StatusConta)", conn);
                conta.Status_conta = false;
                sql.Parameters.AddWithValue("@StatusConta", conta.Status_conta);

                conn.Open();
                sql.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

        }
        public void salvarcontasreceber(ContasReceberMODEL conta)
        {
            var conn = Conexao.Conex();

            try
            {

                SqlCommand sql = new SqlCommand("INSERT INTO contasreceber (id_contasreceber, id_parcela, valor_parcela, status_conta ) " +
                       "VALUES (@id_Contasreceber, @id_Parcela, @valor_Parcela, @StatusConta)", conn);

                sql.Parameters.AddWithValue("@id_contasreceber", conta.Id_contasreceber);
                sql.Parameters.AddWithValue("@id_Parcela", conta.Id_parcela);
                sql.Parameters.AddWithValue("@valor_Parcela", conta.Valor_parcela);
                sql.Parameters.AddWithValue("@StatusConta", conta.Status_conta);

                conn.Open();
                sql.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

        }
        public void excluicontasreceber(ContasReceberMODEL contas)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("DELETE FROM contasreceber WHERE id_contasreceber = @IdContsReceber ", conn);

                sql.Parameters.AddWithValue("@IdContsReceber", contas.Id_contasreceber);
                conn.Open();
                sql.ExecuteNonQuery();
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
        public void Deletarcontaspagar(ContasReceberMODEL contas)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("DELETE FROM contas, parcelas USING contas, parcelas WHERE contas.idconta = @IdCont AND parcelas.idconta = @IdCont", conn);

                sql.Parameters.AddWithValue("@IdCont", contas.Id_contasreceber);
                conn.Open();
                sql.ExecuteNonQuery();
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

        public void atualiza_contasreceber(ContasReceberMODEL conta)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("UPDATE contasreceber SET id_parcela = @id_Parcela, valor_parcela = @valor_Parcela WHERE id_parcela = @id_Parcela", conn);

                sql.Parameters.AddWithValue("@id_contasreceber", conta.Id_contasreceber);
                sql.Parameters.AddWithValue("@id_Parcela", conta.Id_parcela);
                sql.Parameters.AddWithValue("@valor_Parcela", conta.Valor_parcela);
                

                conn.Open();
                sql.ExecuteNonQuery();
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


        //public void darBaixaConta(ContasMODEL contas)
        //{
        //    var conn = Conexao.Conex();
        //    try
        //    {
        //        SqlCommand sql = new SqlCommand("UPDATE controle SET datacadastro = @datacadastro, idfornecedor = @idfornecedor, descricao = @descricao WHERE idconta = @idconta", conn);
        //        sql.Parameters.AddWithValue("@datacadastro", contas.Datacadastro);
        //        sql.Parameters.AddWithValue("@idfornecedor", contas.IDFornecedor);
        //        sql.Parameters.AddWithValue("@descricao", contas.Descricao);
        //        sql.Parameters.AddWithValue("@idconta", contas.IDConta);

        //        conn.Open();
        //        sql.ExecuteNonQuery();
        //    }
        //    catch (Exception erro)
        //    {
        //        throw erro;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
    }
}

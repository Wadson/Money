using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class RegistroPagamentoBLL
    {
        RegistroPagamentoDAL registroPagamentodal = null;

        public void SalvarRegistroPagamento(RegistroPagamentoModel registroagamento)
        {
            try
            {
                registroPagamentodal = new RegistroPagamentoDAL();
                registroPagamentodal.SalvarRegistroPagamento(registroagamento);
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }
        public void excluir_RegistroPagamento(RegistroPagamentoModel registropagamento)
        {
            try
            {
                registroPagamentodal = new RegistroPagamentoDAL();
                registroPagamentodal.excluirTodosPagamentos(registropagamento);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public void excluir_Uma_Parcela(RegistroPagamentoModel excluirumaparcela)
        {
            try
            {
                registroPagamentodal = new RegistroPagamentoDAL();
                registroPagamentodal.excluiParcelaUnica(excluirumaparcela);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void atualiza_RegistroPagamento(RegistroPagamentoModel registropagamento)
        {
            try
            {
                registroPagamentodal = new RegistroPagamentoDAL();
                registroPagamentodal.atualizaRegistroPagamento(registropagamento);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
       
        public ParcelaModel pesquisaRegistroPagamento(string pesquisa)
        {
            var conexao = Conexao.Conex();

            try
            {
                SqlCommand sql = new SqlCommand("SELECT  SELECT  fornecedor.fornecedor, parcelas.valor_parc, parcelas.datavenc, parcelas.datapgto FROM   parcelas, fornecedor  WHERE idconta LIKE '" + pesquisa + "%' AND pago = false", conexao);
                conexao.Open();
                SqlDataReader datareader;
                ParcelaModel obj_parcela = new ParcelaModel();

                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);
                while (datareader.Read())
                {
                    obj_parcela.Idparcela = Convert.ToInt32(datareader["idparcela"]);
                    obj_parcela.IdVenda = Convert.ToInt32(datareader["idconta"]);
                    obj_parcela.Valor_parc = Convert.ToDecimal(datareader["valor_parc"]);
                    obj_parcela.Datavenc = Convert.ToDateTime(datareader["datavenc"]);
                }
                return obj_parcela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        public ParcelaModel pesquisaPrecosCodigo(string pesquisa)
        {
            var conexao = Conexao.Conex();

            try
            {
                SqlCommand sql = new SqlCommand("SELECT  fornecedor.fornecedor, parcelas.valor_parc, parcelas.datavenc, parcelas.datapgto FROM   parcelas WHERE fornecedor LIKE '" + pesquisa + "%' AND pago = false", conexao);
                conexao.Open();
                SqlDataReader datareader;
                ParcelaModel obj_parcela = new ParcelaModel();


                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);
                while (datareader.Read())
                {
                    obj_parcela.Idparcela = Convert.ToInt32(datareader["id_parcela"]);
                    obj_parcela.IdVenda = Convert.ToInt32(datareader["id_venda"]);
                    obj_parcela.Valor_parc = Convert.ToDecimal(datareader["valor_parcela"]);
                    obj_parcela.Datavenc = Convert.ToDateTime(datareader["dt_vcto_parcela"]);
                }
                return obj_parcela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

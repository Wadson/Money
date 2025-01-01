using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Money
{
    class ParcelaBLL
    {
        ParcelaDAL parceladal = null;

        public void Salvar_Parcelas(ParcelaModel parcela)
        {

            parceladal = new ParcelaDAL();
            parceladal.SalvarParcelas(parcela);

            try
            {
                
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }

        public void excluir_Todas_Parcelas(ParcelaModel parcela)
        {
            try
            {
                parceladal = new ParcelaDAL();
                parceladal.excluirTodasParcela(parcela);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
        //public void excluir_Uma_Parcela(ParcelaModel parcelas)
        //{
        //    try
        //    {
        //        parceladal = new ParcelaDAL();
        //        parceladal.excluirTodasParcela(parcelas);
        //    }
        //    catch (Exception erro)
        //    {
        //        throw erro;
        //    }
        //}
        public void atualiza_parcelas(ParcelaModel parcela)
        {
            try
            {
                parceladal = new ParcelaDAL();
                parceladal.atualizaParcela(parcela);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }       

        public void BaixarParcelas(ParcelaModel baixaconta)
        {
            try
            {
                parceladal = new ParcelaDAL();
                parceladal.baixarParcela(baixaconta);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void PagarParcelaDAL(ParcelaModel parcela)
        {
            try
            {
                parceladal = new ParcelaDAL();
                parceladal.baixarParcela(parcela);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ParcelaModel pesquisaParcela(string pesquisa)
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
                    obj_parcela.IdVenda = Convert.ToInt32(datareader["idvenda"]);
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

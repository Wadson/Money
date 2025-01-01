using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Money
{
    class ContasDAL
    {
        public DataTable lista_controle()
        {
            var conn = Conexao.Conex();
            try
            {   
                SqlCommand sql = new SqlCommand("SELECT contas.idconta, contas.datacadastro, fornecedor.fornecedor, contas.descricao, categoria.categoria, " +
                                   "parcelas.num_parcela, parcelas.valor_parc, parcelas.datavenc, parcelas.datapgto, parcelas.idparcela FROM categoria " +
                                   "INNER JOIN contas ON categoria.idcategoria = contas.idcategoria " +
                                   "INNER JOIN fornecedor ON contas.idfornecedor = fornecedor.idfornecedor INNER JOIN " +
                                   "parcelas ON contas.idconta = parcelas.idconta  WHERE pago = 0 ORDER BY datavenc", conn);


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
        public DataTable lista_controleOpcional()
        {
            var conn = Conexao.Conex();
            try
            {   
                SqlCommand sql = new SqlCommand("SELECT * FROM contas)", conn);

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
        public void SalvarConta(ContasMODEL conta)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("INSERT INTO contas (idconta, datacadastro, idfornecedor, descricao, idcategoria, idsubcategoria, idformapgto) VALUES (@idconta,@datacadastro, @idfornecedor, @descricao, @idcategoria, @IdSubcategoria, @IDFormapgto)", conn);

                sql.Parameters.AddWithValue("@idconta", conta.IDConta);
                sql.Parameters.AddWithValue("@datacadastro", conta.Datacadastro);                
                sql.Parameters.AddWithValue("@idfornecedor", conta.IDFornecedor);
                sql.Parameters.AddWithValue("@descricao", conta.Descricao);
                sql.Parameters.AddWithValue("@IdCategoria", conta.Idcategoria);
                sql.Parameters.AddWithValue("@IdSubcategoria", conta.Idsubcategoria);
                sql.Parameters.AddWithValue("@IDFormapgto",conta.Idformapgto);

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
        public void excluiConta(ContasMODEL contas)
        {
            var conn = Conexao.Conex();
            try
            {   
                SqlCommand sql = new SqlCommand("DELETE FROM contas WHERE idconta = @IdCont ", conn);              

                sql.Parameters.AddWithValue("@IdCont", contas.IDConta);
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
        public void DeletarConta(ContasMODEL contas)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("DELETE FROM contas, parcelas USING contas, parcelas WHERE contas.idconta = @IdCont AND parcelas.idconta = @IdCont", conn);

                sql.Parameters.AddWithValue("@IdCont", contas.IDConta);
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

        public void atualiza_contas(ContasMODEL contas)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("UPDATE contas SET descricao = @descricao, idcategoria = @IdCategoria, idsubcategoria = @Idsubcategoria, idformapgto = @Idformapgto WHERE idconta = @idconta", conn);
                                              
                sql.Parameters.AddWithValue("@descricao", contas.Descricao);
                sql.Parameters.AddWithValue("@IdCategoria", contas.Idcategoria);
                sql.Parameters.AddWithValue("@Idsubcategoria", contas.Idsubcategoria);
                sql.Parameters.AddWithValue("@Idformapgto", contas.Idformapgto);
                sql.Parameters.AddWithValue("@idconta", contas.IDConta);

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
        

        public void darBaixaConta(ContasMODEL contas)
        {
            var conn = Conexao.Conex();
            try
            {   
                SqlCommand sql = new SqlCommand("UPDATE controle SET datacadastro = @datacadastro, idfornecedor = @idfornecedor, descricao = @descricao WHERE idconta = @idconta", conn);
                sql.Parameters.AddWithValue("@datacadastro", contas.Datacadastro);
                sql.Parameters.AddWithValue("@idfornecedor", contas.IDFornecedor);
                sql.Parameters.AddWithValue("@descricao", contas.Descricao);
                sql.Parameters.AddWithValue("@idconta", contas.IDConta);

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
    }
}
    




           
       

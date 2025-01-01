using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Money
{
    class FornecedorBLL
    {
        FornecedorDAL fornecedordal = null;

        public DataTable lista_Fornecedor_dal()
        {
            DataTable dtable = new DataTable();
            try
            {
                fornecedordal = new FornecedorDAL();
                dtable = fornecedordal.lista_Fornecedor();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }

       
        public void Salvar(FornecedorMODEL fornecedor)
        {
            try
            {
                fornecedordal = new FornecedorDAL();
                fornecedordal.gravaFornecedor(fornecedor);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluiFornecedorDal(FornecedorMODEL fornecedor)
        {
            try
            {
                fornecedordal = new FornecedorDAL();
                fornecedordal.excluiFornecedor(fornecedor);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
       

        public void Alterar(FornecedorMODEL fornecedor)
        {
            try
            {
                fornecedordal = new FornecedorDAL();
                fornecedordal.atualizaFornecedor(fornecedor);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public FornecedorMODEL pesquisaFornecedor(string pesquisa)
        {
            var conn = Conexao.Conex();

            try
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM fornecedor WHERE fornecedo LIKE '" + pesquisa + "%'", conn);
                conn.Open();
                SqlDataReader datareader;
                FornecedorMODEL obj_fornecedor = new FornecedorMODEL();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);
                while (datareader.Read())
                {
                    if (datareader.IsDBNull(0))
                    {
                        string erro;
                        erro = "Nenhum registro encontrado";
                        Console.Write(erro);
                    }
                    else
                    {
                        obj_fornecedor.ID_Fornecedor = Convert.ToInt32(datareader["idfornecedor"]);                        
                        obj_fornecedor.Fornecedor = datareader["fornecedo"].ToString();
                    }
                        
                    
                }
                return obj_fornecedor;
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
        public FornecedorMODEL pesquisaFornecedorEspecial(string pesquisa)
        {
            var conn = Conexao.Conex();
            try
            {                
                SqlCommand sql = new SqlCommand("SELECT idfornecedor FROM fornecedor WHERE fornecedo LIKE '" + pesquisa + "%'", conn);
                conn.Open();
                SqlDataReader datareader;
                FornecedorMODEL obj_fornecedor = new FornecedorMODEL();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);
                while (datareader.Read())
                {
                    if (datareader.IsDBNull(0))
                    {
                        string erro;
                        erro = "Nenhum registro encontrado";
                        Console.Write(erro);
                    }
                    else
                    {
                        obj_fornecedor.ID_Fornecedor = Convert.ToInt32(datareader["id_fornecedor"]);                        
                    }


                }
                return obj_fornecedor;
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
        public FornecedorMODEL pesquisaFornecedorCod(string pesquisa)
        {
            var conn = Conexao.Conex();

            try
            {               
                SqlCommand sql = new SqlCommand("SELECT fornecedor FROM fornecedor  WHERE idfornecedor LIKE '" + pesquisa + "%' ", conn);//AND Pago = false
                conn.Open();
                SqlDataReader datareader;

                FornecedorMODEL obj_fornecedor = new FornecedorMODEL();


                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);
                while (datareader.Read())
                {
                    if (datareader.IsDBNull(0))
                    {
                        string erros = "Nenhum registro ENCONTRADO";
                        Console.WriteLine(erros);
                    }
                    else
                        obj_fornecedor.Fornecedor = datareader["fornecedo"].ToString();
                }
                return obj_fornecedor;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Money
{
    class ReceitasBLL
    {
        ReceitasDAL receitasdal = null;

        public DataTable listaReceitas()
        {
            DataTable dtable = new DataTable();
            try
            {
                receitasdal = new ReceitasDAL();
                dtable = receitasdal.lista_Receitas();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }


        public void Salvar(ReceitasMODEL receitas)
        {
            try
            {
                receitasdal = new ReceitasDAL();
                receitasdal.gravaReceitas(receitas);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluireceitasDal(ReceitasMODEL receitas)
        {
            try
            {
                receitasdal = new ReceitasDAL();
                receitasdal.excluiReceitas(receitas);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }


        public void Alterar(ReceitasMODEL receitas)
        {
            try
            {
                receitasdal = new ReceitasDAL();
                receitasdal.atualizaReceitas(receitas);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public ReceitasMODEL pesquisareceitas(string pesquisa)
        {
            var conn = Conexao.Conex();

            try
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM receitas WHERE idfornecedor LIKE '" + pesquisa + "%'", conn);
                conn.Open();
                SqlDataReader datareader;
                ReceitasMODEL obj_receitas = new ReceitasMODEL();
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
                        obj_receitas.IdReceita = Convert.ToInt32(datareader["idreceitas"]);
                        obj_receitas.Idfornecedor = Convert.ToInt32(datareader["idfornecedor"]);
                    }   
                }
                return obj_receitas;
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

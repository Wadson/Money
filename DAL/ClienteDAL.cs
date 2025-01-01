using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Money
{
    class ClienteDAL
    {
        public DataTable lista_clientes()
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("SELECT cliente.id_cliente, cliente.nome_cliente, cliente.dtcadastro_cliente, cliente.fone_cliente, cliente.endereco_cliente, cliente.bairro_cliente, cliente.id_cidade, cidade.nome, estado.nome AS Expr1 FROM cliente INNER JOIN cidade ON cliente.id_cidade = cidade.id INNER JOIN estado ON cidade.uf = estado.id", conn);


                SqlDataAdapter daCliente = new SqlDataAdapter();
                daCliente.SelectCommand = sql;
                DataTable dtcliente = new DataTable();
                daCliente.Fill(dtcliente);
                return dtcliente;
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
       
        public void salvaCliente(ClienteMODEL cliente)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("INSERT INTO cliente (id_cliente, nome_cliente, dtcadastro_cliente, fone_cliente, endereco_cliente, bairro_cliente, id_cidade) VALUES (@id_Cliente, @nome_Cliente, @dtCadastro_Cliente, @fone_Cliente, @endereco_Cliente, @bairro_Cliente, @Id_Cidade)", conn);

               
                sql.Parameters.AddWithValue("@id_Cliente", cliente.Id_cliente);
                sql.Parameters.AddWithValue("@nome_Cliente", cliente.Nome_cliente);
                sql.Parameters.AddWithValue("@dtCadastro_Cliente",  cliente.Dt_cadastro_cliente);
                sql.Parameters.AddWithValue("@fone_Cliente", cliente.Fone_cliente);
                sql.Parameters.AddWithValue("@endereco_Cliente",  cliente.Endereco_cliente);
                sql.Parameters.AddWithValue("@bairro_Cliente",  cliente.Bairro_cliente);
                sql.Parameters.AddWithValue("@Id_Cidade",   cliente.Id_cidade);                

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
        public void excluiCliente(ClienteMODEL cliente)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("DELETE FROM cliente WHERE id_cliente = @id_Cliente ", conn);                

                sql.Parameters.AddWithValue("@id_Cliente", cliente.Id_cliente);              

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

        public void atualiza_Cliente(ClienteMODEL cliente)
        {
            var conn = Conexao.Conex();
            try
            {
                //SqlCommand sql = new SqlCommand("UPDATE cliente SET nome_cliente = @nome_Cliente, dtcadastro_cliente = @dtCadastro_Cliente, fone_cliente = @fone_Cliente, endereco_cliente = @endereco_Cliente, bairro_cliente = @bairro_Cliente, cidade_cliente = @cidade_Cliente, estado_cliente = @estado_Cliente) WHERE id_cliente = @id_Cliente", conn);

                //sql.Parameters.AddWithValue("@nome_Cliente", cliente.Nome_cliente);
                //sql.Parameters.AddWithValue("@dtCadastro_Cliente", cliente.Dt_cadastro_cliente);
                //sql.Parameters.AddWithValue("@fone_Cliente", cliente.Fone_cliente);
                //sql.Parameters.AddWithValue("@endereco_Cliente", cliente.Endereco_cliente);
                //sql.Parameters.AddWithValue("@bairro_Cliente", cliente.Bairro_cliente);
                //sql.Parameters.AddWithValue("@cidade_Cliente", cliente.Cidade_cliente);
                //sql.Parameters.AddWithValue("@estado_Cliente", cliente.Estado_cliente);
                //sql.Parameters.AddWithValue("@id_Cliente", cliente.Id_cliente);
                //conn.Open();
                //sql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }

            SqlCommand sql = new SqlCommand    ("UPDATE cliente SET nome_cliente = @nome_Cliente, dtcadastro_cliente = @dtCadastro_Cliente, fone_cliente = @fone_Cliente, endereco_cliente = @endereco_Cliente, bairro_cliente = @bairro_Cliente, id_cidade = @id_cidade WHERE id_cliente = @id_Cliente", conn);
            
            sql.Parameters.AddWithValue("@nome_Cliente", cliente.Nome_cliente);
            sql.Parameters.AddWithValue("@dtCadastro_Cliente", cliente.Dt_cadastro_cliente);
            sql.Parameters.AddWithValue("@fone_Cliente", cliente.Fone_cliente);
            sql.Parameters.AddWithValue("@endereco_Cliente", cliente.Endereco_cliente);
            sql.Parameters.AddWithValue("@bairro_Cliente", cliente.Bairro_cliente);
            sql.Parameters.AddWithValue("@Id_Cidade", cliente.Id_cidade);            
            sql.Parameters.AddWithValue("@id_Cliente", cliente.Id_cliente);
            conn.Open();
            sql.ExecuteNonQuery();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Money
{
    class ClienteBLL
    {
        ClienteDAL clienteDAL = null;
       
        public DataTable Lista_Cliente()
        {
            DataTable dtable = new DataTable();
            try
            {
                clienteDAL = new ClienteDAL();
                dtable = clienteDAL.lista_clientes();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }

        public void Salvar(ClienteMODEL clienteS)
        {
            try
            {
                clienteDAL = new ClienteDAL();
                clienteDAL.salvaCliente(clienteS);
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }
        public void Alterar(ClienteMODEL clienteS)
        {
            clienteDAL = new ClienteDAL();
            clienteDAL.atualiza_Cliente(clienteS);
            try
            {
                //clienteDAL = new ClienteDAL();
                //clienteDAL.atualiza_Cliente(clienteS);
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }
        public void Excluir(ClienteMODEL clienteS)
        {
            try
            {
                clienteDAL = new ClienteDAL();
                clienteDAL.excluiCliente(clienteS);
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }
        public ClienteMODEL PesquisarCodigo(string pesquisa)
        {
            var conn = Conexao.Conex();
            try
            {

                SqlCommand sql = new SqlCommand("SELECT  * FROM cliente WHERE id_cliente LIKE '" + pesquisa + "%' ", conn);
                conn.Open();
                SqlDataReader datareader;
                ClienteMODEL obj_cliente = new ClienteMODEL();

                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);
                while (datareader.Read())
                {
                    obj_cliente.Id_cliente = Convert.ToInt32(datareader["id_cliente"]);
                    obj_cliente.Dt_cadastro_cliente = Convert.ToDateTime(datareader["dtcadastro_cliente"]);
                    obj_cliente.Nome_cliente = datareader["nome_cliente"].ToString();
                    obj_cliente.Fone_cliente = datareader["fone_cliente"].ToString();
                    obj_cliente.Endereco_cliente = datareader["endereco_cliente"].ToString();
                    obj_cliente.Bairro_cliente = datareader["bairro_cliente"].ToString();
                    obj_cliente.Id_cidade = Convert.ToInt32(datareader["id_cidade"]);
                }
                return obj_cliente;
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

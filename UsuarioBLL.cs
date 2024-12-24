using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Money
{
    class UsuarioBLL
    {
        UsuarioDAL usuariodal = null;
        // ************************LISTA USUARIO*********************************************
        public DataTable lista_Usuario_dal()
        {
            DataTable dtable = new DataTable();
            try
            {

                usuariodal = new UsuarioDAL();
                dtable = usuariodal.listaUsuario();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }
       
        public void gravaUsuarioDal(UsuarioModel usuarios)
        {
            try
            {
                usuariodal = new UsuarioDAL();
                usuariodal.gravaUsuario(usuarios);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
       
        public void excluiUsuarioDal(UsuarioModel usuarios)
        {
            try
            {
                usuariodal = new UsuarioDAL();
                usuariodal.excluiUsuario(usuarios);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void atualizaUsuarioDal(UsuarioModel usuarios)
        {
            try
            {
                usuariodal = new UsuarioDAL();
                usuariodal.atualizaUsuario(usuarios);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void atualizaUsuarioDalSenha(UsuarioModel usuarios)
        {
            try
            {
                usuariodal = new UsuarioDAL();
                usuariodal.atualizaUsuarioSenha(usuarios);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public UsuarioModel pesquisaUsuario(string pesquisa)
        {
            var conn = Conexao.Conex();
            try
            { 
                SqlCommand sql = new SqlCommand("SELECT * FROM usuario WHERE nome_usuario like '" + pesquisa + "%'", conn);
                conn.Open();
                SqlDataReader datareader;
                UsuarioModel obj_usuario = new UsuarioModel();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                while (datareader.Read())
                {

                    obj_usuario.Id_usuario = Convert.ToInt32(datareader["id_usuario"]);
                    obj_usuario.Nome_usuario = datareader["nome_usuario"].ToString();


                }
                return obj_usuario;
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

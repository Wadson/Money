using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Money
{
    class UsuarioDAL
    {       

        public DataTable listaUsuario()
        {

            //DataTable ListaUsuario = Conexao.SQL_data_adapter("SELECT idusuario,nome, usuario, dtnascimento, nivelacesso, senha FROM usuario");

            var conn = Conexao.Conex();
            try
            {
                SqlCommand comando = new SqlCommand("SELECT id_usuario, nome_usuario, user_usuario, dt_nascimento, nivelacesso_usuario, senha_usuario, email_usuario FROM usuario", conn);
                //id_usuario, nome_usuario, user_usuario, dt_nascimento, nivelacesso_usuario, senha_usuario, email_usuario, dt_nascimento

                SqlDataAdapter daUsuario = new SqlDataAdapter();
                daUsuario.SelectCommand = comando;





                DataTable dtUsuario = new DataTable();
                daUsuario.Fill(dtUsuario);
                return dtUsuario;
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
      
        public void gravaUsuario(UsuarioModel usuarios)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sqlcomm = new SqlCommand("INSERT INTO usuario (id_usuario, nome_usuario, senha_usuario, nivelacesso_usuario, user_usuario, email_usuario, dt_nascimento) VALUES " +
                    "(@idUsuario, @nomeUsuario, @senhaUsuario,@nivelAcessoUsuario,@userUsuario, @emailUsuario, @dtNascimento)", conn);
                sqlcomm.Parameters.AddWithValue("@nomeUsuario", usuarios.Nome_usuario);
                sqlcomm.Parameters.AddWithValue("@senhaUsuario", usuarios.Senha_usuario);
                sqlcomm.Parameters.AddWithValue("@nivelAcessoUsuario", usuarios.Nivelacesso_usuario);
                sqlcomm.Parameters.AddWithValue("@userUsuario", usuarios.User_usuario);
                sqlcomm.Parameters.AddWithValue("@emailUsuario", usuarios.Email_usuario);
                sqlcomm.Parameters.AddWithValue("@dtNascimento", usuarios.Dt_nascimento);
                sqlcomm.Parameters.AddWithValue("@idUsuario", usuarios.Id_usuario);

                conn.Open();
                sqlcomm.ExecuteNonQuery();
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
        // ***********E  X  C  L  U  I         U  S  U  A  R  I  O***********************************
        public void excluiUsuario(UsuarioModel usuarios)
        {
            var conn = Conexao.Conex();
            try
            {   
                SqlCommand sqlcomando = new SqlCommand("DELETE FROM usuario WHERE id_usuario = @idUsuario", conn);
                sqlcomando.Parameters.AddWithValue("@idUsuario", usuarios.Id_usuario);
                conn.Open();
                sqlcomando.ExecuteNonQuery();
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
        //********A  T  U  A  L  I  Z  A     U  S  U  A  R  I  O  *****************************************************
        public void atualizaUsuario(UsuarioModel usuarios)
        {
            var conn = Conexao.Conex();
            try
            {   
                SqlCommand sqlcomm = new SqlCommand("UPDATE usuario SET nome_usuario = @nome_Usuario, senha_usuario = @senha_Usuario, nivelacesso_usuario = @nivelAcesso_Usuario, user_usuario = @user_Usuario, email_usuario = @email_Usuario, dt_nascimento = @dtNascimento_Usuario WHERE id_usuario = @id_Usuario", conn);

                sqlcomm.Parameters.AddWithValue("@nome_Usuario", usuarios.Nome_usuario);
                sqlcomm.Parameters.AddWithValue("@senha_Usuario", usuarios.Senha_usuario);
                sqlcomm.Parameters.AddWithValue("@nivelAcesso_Usuario", usuarios.Nivelacesso_usuario);
                sqlcomm.Parameters.AddWithValue("@user_Usuario", usuarios.User_usuario);
                sqlcomm.Parameters.AddWithValue("@email_Usuario", usuarios.Email_usuario);
                sqlcomm.Parameters.AddWithValue("@dtNascimento_Usuario", usuarios.Dt_nascimento);
                sqlcomm.Parameters.AddWithValue("@id_Usuario", usuarios.Id_usuario);
                conn.Open();
                sqlcomm.ExecuteNonQuery();

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

        public void atualizaUsuarioSenha(UsuarioModel usuarios)
        {
            var conn = Conexao.Conex();
            try
            {   
                SqlCommand sqlcomm = new SqlCommand("UPDATE usuario SET senha_usuario = @senhaUsuario WHERE id_usuario = @idUsuario", conn);

                sqlcomm.Parameters.AddWithValue("@senhaUsuario", usuarios.Senha_usuario);
                sqlcomm.Parameters.AddWithValue("@idUsuario", usuarios.Id_usuario);

                conn.Open();
                sqlcomm.ExecuteNonQuery();

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

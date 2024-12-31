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
                SqlCommand comando = new SqlCommand("SELECT id_usuario, nome, usuario, dt_nascimento, nivelacesso, senha, email FROM usuario", conn);
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
                SqlCommand sqlcomm = new SqlCommand("INSERT INTO usuario (id_usuario, nome, senha, nivelacesso, usuario, email, dt_nascimento) VALUES " +
                    "(@idUsuario, @nomeUsuario, @senhaUsuario,@nivelAcessoUsuario,@userUsuario, @emailUsuario, @dtNascimento)", conn);
                sqlcomm.Parameters.AddWithValue("@nomeUsuario", usuarios.Nome);
                sqlcomm.Parameters.AddWithValue("@senhaUsuario", usuarios.Senha);
                sqlcomm.Parameters.AddWithValue("@nivelAcessoUsuario", usuarios.Nivelacesso_usuario);
                sqlcomm.Parameters.AddWithValue("@userUsuario", usuarios.Usuario);
                sqlcomm.Parameters.AddWithValue("@emailUsuario", usuarios.Email);
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
                SqlCommand sqlcomm = new SqlCommand("UPDATE usuario SET nome = @Nome, senha = @Senha, nivelacesso = @nivelAcesso, usuario = @Usuario, email = @Email, dt_nascimento = @dtNascimento WHERE id_usuario = @id_Usuario", conn);

                sqlcomm.Parameters.AddWithValue("@Nome", usuarios.Nome);
                sqlcomm.Parameters.AddWithValue("@Senha", usuarios.Senha);
                sqlcomm.Parameters.AddWithValue("@nivelAcesso", usuarios.Nivelacesso_usuario);
                sqlcomm.Parameters.AddWithValue("@Usuario", usuarios.Usuario);
                sqlcomm.Parameters.AddWithValue("@Email", usuarios.Email);
                sqlcomm.Parameters.AddWithValue("@dtNascimento", usuarios.Dt_nascimento);
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
                SqlCommand sqlcomm = new SqlCommand("UPDATE usuario SET senha = @Senha WHERE id_usuario = @idUsuario", conn);

                sqlcomm.Parameters.AddWithValue("@Senha", usuarios.Senha);
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

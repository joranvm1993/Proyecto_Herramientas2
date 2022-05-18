using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos
{
    public class PermisoDAL
    {
        public void CrearUsuario(Usuario usuario)
        {
            try
            {
                string conn = "Server=Localhost;Database=proyecto_herramientas2;Uid=root;Pwd=joran1020";

                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    string sql = @"INSERT INTO usuario(Id, Nombre, Contrasena, Usuario, Rol_Id) 
                            VALUES(@param1, @param2, @param3, @param4, @param5)";

                    using MySqlCommand command = new MySqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@param1", usuario.Id);

                    command.Parameters.AddWithValue("@param2", usuario.Nombre);

                    command.Parameters.AddWithValue("@param3", usuario.Contrasena);

                    command.Parameters.AddWithValue("@param4", usuario.User);

                    command.Parameters.AddWithValue("@param5", usuario.Rol_Id);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creando vendaDAL", ex);
            }
        }

        public List<Usuario> ObtnenerUsuario()
        {
            try
            {
                List<Usuario> ListUsuario = new List<Usuario>();

                Usuario usuarioEntity;
  
                string conn = "Server=Localhost;Database=proyecto_herramientas2;Uid=root;Pwd=joran1020";

                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    MySqlCommand comando = new MySqlCommand("select Usuario from usuario", connection);
                    connection.Open();

                    MySqlDataReader registro = comando.ExecuteReader();
                    while (registro.Read())
                    {
                        usuarioEntity = new Usuario();

                        usuarioEntity.User = registro["Usuario"].ToString();

                        ListUsuario.Add(usuarioEntity);
                    }
                    return ListUsuario;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error obteniendo PermisoDAL", ex);
            }
        }
    }
}

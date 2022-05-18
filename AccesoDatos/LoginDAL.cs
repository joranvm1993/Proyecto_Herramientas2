using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos
{
    public class LoginDAL
    {
        public Usuario ObtenerCredendiales(string usuario, string contrasena)
        {
            Usuario usuarioEntity = null;

            string conn = "Server=Localhost;Database=proyecto_herramientas2;Uid=root;Pwd=joran1020";
            
            try
            {
                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    string query = "select usuario.Usuario, usuario.Contrasena, rol.Nombre as 'Rol' " +
                                                            " from usuario " +
                                                            " inner join rol on usuario.Rol_Id = rol.Id " +
                                                            " where usuario.Usuario='" + usuario + "'and usuario.Contrasena='" + contrasena + "'";
                    MySqlCommand comando = new MySqlCommand(query, connection);
                    connection.Open();

                    MySqlDataReader registro = comando.ExecuteReader();
                    
                    while (registro.Read())
                    {
                        usuarioEntity = new Usuario();
                        
                        usuarioEntity.User = registro["Usuario"].ToString();
                        usuarioEntity.Contrasena = registro["Contrasena"].ToString();
                        usuarioEntity.Rol.Nombre = registro["Rol"].ToString();
                    }
                }
                return usuarioEntity;
            }
            catch (Exception ex)
            {
                throw new Exception("Error LoginDAL", ex);
            }
            
        }
    }
}

using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace AccesoDatos
{
    public class MaestroDAL
    {
        public List<Producto> ObtenerProducto()
        {
            try
            {
                string conn = "Server=Localhost;Database=proyecto_herramientas2;Uid=root;Pwd=joran1020";
                
                List<Producto> ListProductos = new List<Producto>();
                Producto productoEntity;

                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    MySqlCommand comando = new MySqlCommand("select Id, Nombre from producto", connection);

                    connection.Open();
          
                    MySqlDataReader registro = comando.ExecuteReader();

                    while (registro.Read())
                    {
                        productoEntity = new Producto();

                        productoEntity.Id = int.Parse(registro["Id"].ToString());

                        productoEntity.Nombre = registro["Nombre"].ToString();

                        ListProductos.Add(productoEntity);
                    }
                }
                return ListProductos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error obteniendo productos DAL ", ex);
            } 
        }
        public List<Transportadora> ObtenerTransportadora()
        {
            try
            {
                string conn = "Server=Localhost;Database=proyecto_herramientas2;Uid=root;Pwd=joran1020";

                List<Transportadora> ListTransportadora = new List<Transportadora>();
                
                Transportadora transportadorEntity;

                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    MySqlCommand comando = new MySqlCommand("select Id, Nombre from transportadora", connection);

                    connection.Open();

                    MySqlDataReader registro = comando.ExecuteReader();

                    while (registro.Read())
                    {
                        transportadorEntity = new Transportadora();

                        transportadorEntity.Id = int.Parse(registro["Id"].ToString());

                        transportadorEntity.Nombre = registro["Nombre"].ToString();

                        ListTransportadora.Add(transportadorEntity);
                    }
                }
                return ListTransportadora;
            }
            catch (Exception ex)
            {
                throw new Exception("Error obteniendo transportadora DAL ", ex);
            }
        }
        public List<Rol> ObtenerRol()
        {
            try
            {
                string conn = "Server=Localhost;Database=proyecto_herramientas2;Uid=root;Pwd=joran1020";

                List<Rol> ListRol = new List<Rol>();

                Rol rolEntity;

                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    MySqlCommand comando = new MySqlCommand("select Id, Nombre from rol", connection);

                    connection.Open();

                    MySqlDataReader registro = comando.ExecuteReader();

                    while (registro.Read())
                    {
                        rolEntity = new Rol();

                        rolEntity.Id = int.Parse(registro["Id"].ToString());

                        rolEntity.Nombre = registro["Nombre"].ToString();

                        ListRol.Add(rolEntity);
                    }
                }
                return ListRol;
            }
            catch (Exception ex)
            {
                throw new Exception("Error obteniendo Rol DAL ", ex);
            }
        }
    }
}

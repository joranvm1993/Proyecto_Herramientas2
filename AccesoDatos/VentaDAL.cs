using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos
{
    public class VentaDAL
    {
        string conn = "Server=Localhost;Database=proyecto_herramientas2;Uid=root;Pwd=joran1020";
        public void CrearVenta(Venta venta)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    string sql = @"INSERT INTO venta(Precio, NombreCliente, Direccion, CiudadDestino, UsuarioVendedor, ProductoId, TransportadoraId) 
                            VALUES(@param1, @param2, @param3, @param4, @param5, @param6, @param7)";

                    using MySqlCommand command = new MySqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@param1", venta.Precio);

                    command.Parameters.AddWithValue("@param2", venta.NombreCliente);

                    command.Parameters.AddWithValue("@param3", venta.Direccion);

                    command.Parameters.AddWithValue("@param4", venta.CiudadDestino);

                    command.Parameters.AddWithValue("@param5", venta.UsuarioVendedor);

                    command.Parameters.AddWithValue("@param6", venta.ProductoId);

                    command.Parameters.AddWithValue("@param7", venta.TransportadoraId);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creando vendaDAL", ex);
            }
        }
        public void ModificarVenta(Venta venta)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    MySqlCommand command;
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    string sql = "";
                    connection.Open();
                    sql = "Update venta set ProductoId='" + venta.ProductoId + "',Precio='" + venta.Precio + "',CiudadDestino='" + venta.CiudadDestino + "',TransportadoraId='" + venta.TransportadoraId + "',NombreCliente='" + venta.NombreCliente + "',Direccion='" + venta.Direccion + "', UsuarioVendedor='" + venta.UsuarioVendedor + "'  where Id=" + venta.Id;
                    command = new MySqlCommand(sql, connection);
                    adapter.InsertCommand = new MySqlCommand(sql, connection);
                    adapter.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error modificando venta DAL ", ex);
            }
        }
        public bool EliminarVenta(int ventaId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    MySqlCommand command;
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    string sql = "";
                    sql = "Delete from venta where Id=" + ventaId;
                    command = new MySqlCommand(sql, connection);
                    adapter.DeleteCommand = new MySqlCommand(sql, connection);
                    adapter.DeleteCommand.ExecuteNonQuery();
                    command.Dispose();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error eliminando venta DAL ", ex);
            }
        }
        public List<Venta> ObtenerVenta()
        {
            try
            {
                List<Venta> ListVenta = new List<Venta>();

                Venta venta;

                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    MySqlCommand comando = new MySqlCommand("SELECT venta.Id, venta.Precio, venta.NombreCliente, venta.Direccion, venta.CiudadDestino, venta.UsuarioVendedor, " +
                                                            "producto.Nombre as 'Nombre_Producto', producto.Id as 'Id_Producto', transportadora.Id as 'Id_Transportadora'," +
                                                            "transportadora.Nombre as 'Nombre_Transportadora'" +
                                                            " FROM venta " +
                                                            " INNER JOIN producto ON venta.ProductoId = producto.Id" +
                                                            " INNER JOIN transportadora ON venta.TransportadoraId  = transportadora.Id", connection);
                    connection.Open();

                    MySqlDataReader registro = comando.ExecuteReader();
                    
                    while (registro.Read())
                    {
                        venta = new Venta();

                        venta.Id = int.Parse(registro["Id"].ToString());

                        venta.Precio = float.Parse(registro["Precio"].ToString());

                        venta.NombreCliente = registro["NombreCliente"].ToString();

                        venta.Direccion = registro["Direccion"].ToString();

                        venta.CiudadDestino = registro["CiudadDestino"].ToString();

                        venta.UsuarioVendedor = registro["UsuarioVendedor"].ToString();

                        venta.Producto.Nombre = registro["Nombre_Producto"].ToString();

                        venta.Transportadora.Nombre = registro["Nombre_Transportadora"].ToString();

                        venta.Producto.Id = int.Parse(registro["Id_Producto"].ToString());

                        venta.Transportadora.Id = int.Parse(registro["Id_Transportadora"].ToString());

                        ListVenta.Add(venta);
                    }
                    return ListVenta;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error obteniendo VentaDAL", ex);
            }
        }
    }
}

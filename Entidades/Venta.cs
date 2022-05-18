using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Venta
    {
        public int Id { get; set; }
        public float Precio { get; set; }
        public string NombreCliente { get; set; }
        public string  Direccion { get; set; }
        public string  CiudadDestino { get; set; }
        public string UsuarioVendedor { get; set; }
        public int ProductoId { get; set; }
        public int TransportadoraId { get; set; }
        public Producto Producto { get; set; } = new Producto();
        public Transportadora Transportadora { get; set; } = new Transportadora();
    }
}

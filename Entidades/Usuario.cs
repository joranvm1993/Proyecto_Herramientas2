using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string User { get; set; }
        public string Contrasena { get; set; }
        public int Rol_Id { get; set; }
        public Rol Rol { get; set; } = new Rol();
    }
}

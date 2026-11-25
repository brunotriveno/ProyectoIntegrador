using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Modelos
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        public Usuario(string nombreUsuario, string contrasena)
        {
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
        }
    }
}
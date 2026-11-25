using System;
using System.Collections.Generic;
using System.Text;


using ProyectoIntegrador.Modelos;

namespace ProyectoIntegrador.Servicios
{
    public class Autenticacion
    {
        private List<Usuario> usuarios;

        public Autenticacion()
        {
            usuarios = new List<Usuario>();

            // Usuario de prueba
            usuarios.Add(new Usuario("admin", "1234"));
            usuarios.Add(new Usuario("bruno", "2026"));
        }

        public bool ValidarUsuario(string nombreUsuario, string contrasena)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.NombreUsuario == nombreUsuario &&
                    usuario.Contrasena == contrasena)
                {
                    return true;
                }
            }

            return false;
        }
    }
}


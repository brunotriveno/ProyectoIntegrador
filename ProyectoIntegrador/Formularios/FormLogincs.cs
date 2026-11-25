using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoIntegrador.Servicios;
namespace ProyectoIntegrador.Formularios
{
    public partial class FormLogincs : Form
    {
        public FormLogincs()
        {
            InitializeComponent();
        }

        private void FormLogincs_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Por favor, completa todos los campos.",
                    "Campos vacíos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Validar los datos del usuario
            Autenticacion autenticacion = new Autenticacion();

            if (autenticacion.ValidarUsuario(usuario, contrasena))
            {
                MessageBox.Show("¡Bienvenido al sistema!",
                    "Acceso correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.",
                    "Error de acceso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtContrasena.Clear();
                txtContrasena.Focus();
            }
        }

    }
}


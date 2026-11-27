using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al modulo de Solicitudes De Donaciones");
        }

        private void btnAdopcion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bienvenido al modulo de adopcion");
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bienvenido al modulo de almacen");
        }
    }
}

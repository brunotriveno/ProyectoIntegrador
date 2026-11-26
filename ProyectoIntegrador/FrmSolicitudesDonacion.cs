using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class FrmSolicitudes : Form
    {
        public FrmSolicitudes()
        {
            InitializeComponent();

            cmbTipoSolicitud.Items.Clear();

            cmbTipoSolicitud.Items.Add("Adopción");
            cmbTipoSolicitud.Items.Add("Donación");
            cmbTipoSolicitud.Items.Add("Voluntariado");

            cmbTipoSolicitud.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoSolicitud.SelectedIndex = -1;

            btnLimpiarSolicitud.Click += (sender, e) =>
            {
                LimpiarSolicitud();
            };

            // Centrar las tarjetas al iniciar.
            CentrarMenu();

            // Volver a centrarlas cuando cambie el tamaño.
            this.Resize += (sender, e) => CentrarMenu();

            btnSolicitudesNuevas.Click += (sender, e) =>
                MostrarNuevaSolicitud(true);

            btnVolverMenu.Click += (sender, e) =>
                MostrarNuevaSolicitud(false);

            MostrarNuevaSolicitud(false);
        }
        private void LimpiarSolicitud()
        {
            txtNombreSolicitante.Clear();
            txtTelefonoSolicitante.Clear();
            txtCorreoSolicitante.Clear();
            txtDescripcionSolicitud.Clear();

            cmbTipoSolicitud.SelectedIndex = -1;
            dtpFechaSolicitud.Value = DateTime.Now;

            txtNombreSolicitante.Focus();
        }

        private void picHistorial_Click(object sender, EventArgs e)
        {

        }

        private void picSolicitudesNuevas_Click(object sender, EventArgs e)
        {
            MostrarNuevaSolicitud(true);
        }
        private void MostrarNuevaSolicitud(bool mostrar)
        {
            // Ocultar o mostrar las tarjetas del menú
            pnlContenido.Visible = !mostrar;
            pnelSuperior.Visible = !mostrar;
            pnelMenu.Visible = !mostrar;
            pnlTarjetaDonantes.Visible = !mostrar;
            pnlTarjetaInicio.Visible = !mostrar;

            // Mostrar u ocultar el formulario de nueva solicitud
            pnlNuevaSolicitud.Visible = mostrar;

            if (mostrar)
            {
                pnlNuevaSolicitud.BringToFront();
            }
        }


        private void CentrarMenu()
        {
            int anchoTarjeta = 220;
            int altoTarjeta = 230;
            int separacion = 30;
            int margen = 30;
            int margenSuperior = 110;

            // Botón Inicio en la esquina superior izquierda
            pnlTarjetaInicio.Location = new Point(20, 20);

            // Comprobar si caben dos columnas
            bool dosColumnas =
                ClientSize.Width >= (anchoTarjeta * 2) +
                separacion + (margen * 2);

            int anchoTotal = dosColumnas
                ? (anchoTarjeta * 2) + separacion
                : anchoTarjeta;

            int altoTotal = dosColumnas
                ? (altoTarjeta * 2) + separacion
                : (altoTarjeta * 4) + (separacion * 3);

            // Centrar horizontalmente
            int x = Math.Max(
                margen,
                (ClientSize.Width - anchoTotal) / 2
            );

            // Centrar verticalmente reservando espacio para Inicio
            int y = Math.Max(
                margenSuperior,
                margenSuperior +
                (ClientSize.Height - margenSuperior - altoTotal) / 2
            );

            if (dosColumnas)
            {
                // Primera fila
                pnlContenido.Location = new Point(x, y);

                pnelSuperior.Location =
                    new Point(x + anchoTarjeta + separacion, y);

                // Segunda fila
                pnelMenu.Location =
                    new Point(x, y + altoTarjeta + separacion);

                pnlTarjetaDonantes.Location =
                    new Point(
                        x + anchoTarjeta + separacion,
                        y + altoTarjeta + separacion
                    );
            }
            else
            {
                // Una sola columna si la ventana es estrecha
                pnlContenido.Location = new Point(x, y);

                pnelSuperior.Location =
                    new Point(x, y + altoTarjeta + separacion);

                pnelMenu.Location =
                    new Point(x, y + (altoTarjeta + separacion) * 2);

                pnlTarjetaDonantes.Location =
                    new Point(x, y + (altoTarjeta + separacion) * 3);
            }
        }

        private void dtpFechaSolicitud_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

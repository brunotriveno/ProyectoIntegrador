using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using ProyectoIntegrador.Servicios;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class FrmSolicitudes : Form
    {
        public FrmSolicitudes()
        {
            InitializeComponent();


            btnAprobarSolicitud.Click += (sender, e) =>
    CambiarEstadoSolicitud("Aprobada");

            btnRechazarSolicitud.Click += (sender, e) =>
                CambiarEstadoSolicitud("Rechazada");

            txtBuscarSolicitud.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                }
            };

            txtBuscarSolicitud.TextChanged += (sender, e) =>
    FiltrarSolicitudes();

            cmbFiltroEstado.SelectedIndexChanged += (sender, e) =>
                FiltrarSolicitudes();

            btnActualizarHistorial.Click += (sender, e) =>
    CargarSolicitudes();

            btnHistorial.Click += (sender, e) => MostrarHistorial();

            btnVolverHistorial.Click += (sender, e) =>
                MostrarNuevaSolicitud(false);

            btnGuardarSolicitud.Click += (sender, e) => GuardarSolicitud();

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


        private void CambiarEstadoSolicitud(string nuevoEstado)
        {
            if (dgvHistorialSolicitudes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una solicitud.");
                return;
            }

            DataGridViewRow fila = dgvHistorialSolicitudes.SelectedRows[0];

            int idSolicitud = Convert.ToInt32(
                fila.Cells["id_solicitud"].Value
            );

            string estadoActual = Convert.ToString(
                fila.Cells["estado"].Value
            ) ?? "";

            if (estadoActual != "Pendiente")
            {
                MessageBox.Show(
                    "Solo se pueden aprobar o rechazar solicitudes pendientes."
                );
                return;
            }

            string observacion = txtObservacionAdmin.Text.Trim();

            if (observacion.Length > 250)
            {
                MessageBox.Show(
                    "La observación no puede superar los 250 caracteres."
                );
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Desea marcar la solicitud #{idSolicitud} como {nuevoEstado}?",
                "Confirmar decisión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string consulta = @"
                UPDATE SOLICITUD
                SET estado = @estado,
                    observacion_admin = @observacion,
                    fecha_respuesta = GETDATE()
                WHERE id_solicitud = @id
                  AND estado = 'Pendiente';";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.Add("@estado", SqlDbType.VarChar, 20)
                            .Value = nuevoEstado;

                        comando.Parameters.Add("@observacion", SqlDbType.VarChar, 250)
                            .Value = string.IsNullOrWhiteSpace(observacion)
                                ? DBNull.Value
                                : observacion;

                        comando.Parameters.Add("@id", SqlDbType.Int)
                            .Value = idSolicitud;

                        conexion.Open();

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            MessageBox.Show(
                                "La solicitud ya fue procesada o no existe."
                            );
                            CargarSolicitudes();
                            return;
                        }
                    }
                }

                MessageBox.Show(
                    $"Solicitud {nuevoEstado.ToLower()} correctamente.",
                    "Mishin Cine Café",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtObservacionAdmin.Clear();
                CargarSolicitudes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar la solicitud:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void FiltrarSolicitudes()
        {
            if (dgvHistorialSolicitudes.DataSource is not DataTable tabla)
                return;

            string nombre = txtBuscarSolicitud.Text.Trim();
            string estado = cmbFiltroEstado.SelectedItem?.ToString() ?? "Todos";

            string nombreSeguro = nombre
                .Replace("'", "''")
                .Replace("[", "[[]")
                .Replace("%", "[%]")
                .Replace("*", "[*]");

            string filtro = $"nombre_solicitante LIKE '%{nombreSeguro}%'";

            if (estado != "Todos")
            {
                string estadoSeguro = estado.Replace("'", "''");
                filtro += $" AND estado = '{estadoSeguro}'";
            }

            tabla.DefaultView.RowFilter = filtro;

            dgvHistorialSolicitudes.ClearSelection();
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
            // Mostrar u ocultar las tarjetas del menú
            pnlContenido.Visible = !mostrar;
            pnelSuperior.Visible = !mostrar;
            pnelMenu.Visible = !mostrar;
            pnlTarjetaDonantes.Visible = !mostrar;
            pnlTarjetaInicio.Visible = !mostrar;

            // Controlar las secciones
            pnlNuevaSolicitud.Visible = mostrar;
            pnlHistorialSolicitudes.Visible = false;

            if (mostrar)
            {
                pnlNuevaSolicitud.BringToFront();
            }
        }



        private void MostrarHistorial()
        {
            pnlContenido.Visible = false;
            pnelSuperior.Visible = false;
            pnelMenu.Visible = false;
            pnlTarjetaDonantes.Visible = false;
            pnlTarjetaInicio.Visible = false;
            pnlNuevaSolicitud.Visible = false;

            pnlHistorialSolicitudes.Visible = true;
            pnlHistorialSolicitudes.BringToFront();

            CargarSolicitudes();
        }




        private void CargarSolicitudes()
        {
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string consulta = @"
                SELECT
                    id_solicitud,
                    nombre_solicitante,
                    tipo_solicitud,
                    fecha_solicitud,
                    estado
                FROM SOLICITUD
                ORDER BY id_solicitud DESC";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(
                        consulta, conexion))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        dgvHistorialSolicitudes.AutoGenerateColumns = true;
                        dgvHistorialSolicitudes.DataSource = null;
                        dgvHistorialSolicitudes.Columns.Clear();
                        dgvHistorialSolicitudes.DataSource = tabla;
                        ConfigurarTablaSolicitudes();
                        FiltrarSolicitudes();
                        dgvHistorialSolicitudes.Refresh();
                        dgvHistorialSolicitudes.Invalidate();
                        dgvHistorialSolicitudes.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar solicitudes:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }




        private void ConfigurarTablaSolicitudes()
        {
            dgvHistorialSolicitudes.Columns["id_solicitud"].HeaderText = "ID";
            dgvHistorialSolicitudes.Columns["nombre_solicitante"].HeaderText = "Solicitante";
            dgvHistorialSolicitudes.Columns["tipo_solicitud"].HeaderText = "Tipo";
            dgvHistorialSolicitudes.Columns["fecha_solicitud"].HeaderText = "Fecha";
            dgvHistorialSolicitudes.Columns["estado"].HeaderText = "Estado";

            dgvHistorialSolicitudes.Columns["fecha_solicitud"]
                .DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            dgvHistorialSolicitudes.ClearSelection();


            dgvHistorialSolicitudes.BackgroundColor = Color.White;
            dgvHistorialSolicitudes.EnableHeadersVisualStyles = false;

            dgvHistorialSolicitudes.DefaultCellStyle.BackColor = Color.White;
            dgvHistorialSolicitudes.DefaultCellStyle.ForeColor = Color.Black;

            dgvHistorialSolicitudes.DefaultCellStyle.SelectionBackColor =
                Color.RoyalBlue;

            dgvHistorialSolicitudes.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgvHistorialSolicitudes.RowsDefaultCellStyle.BackColor =
                Color.White;

            dgvHistorialSolicitudes.RowsDefaultCellStyle.ForeColor =
                Color.Black;

            dgvHistorialSolicitudes.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(235, 240, 250);

            dgvHistorialSolicitudes.AlternatingRowsDefaultCellStyle.ForeColor =
                Color.Black;

            dgvHistorialSolicitudes.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(30, 45, 90);

            dgvHistorialSolicitudes.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

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


        private void ProbarConexion()
        {
            try
            {
                using (var conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();

                    MessageBox.Show(
                        "Conexión exitosa con SQL Server.",
                        "Mishin Cine Café",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo conectar a SQL Server:\n" + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void GuardarSolicitud()
        {
            // Validar los campos obligatorios
            if (cmbTipoSolicitud.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de solicitud.");
                cmbTipoSolicitud.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreSolicitante.Text))
            {
                MessageBox.Show("Ingrese el nombre del solicitante.");
                txtNombreSolicitante.Focus();
                return;
            }

            if (txtNombreSolicitante.Text.Trim().Length > 100 ||
                txtTelefonoSolicitante.Text.Trim().Length > 20 ||
                txtCorreoSolicitante.Text.Trim().Length > 100 ||
                txtDescripcionSolicitud.Text.Trim().Length > 250)
            {
                MessageBox.Show("Uno de los campos supera la longitud permitida.");
                return;
            }

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    string consulta = @"
                INSERT INTO SOLICITUD
                (
                    tipo_solicitud,
                    fecha_solicitud,
                    nombre_solicitante,
                    telefono,
                    correo,
                    descripcion
                )
                VALUES
                (
                    @tipo,
                    @fecha,
                    @nombre,
                    @telefono,
                    @correo,
                    @descripcion
                );";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.Add("@tipo", SqlDbType.VarChar, 50)
                            .Value = cmbTipoSolicitud.Text;

                        comando.Parameters.Add("@fecha", SqlDbType.DateTime)
                            .Value = dtpFechaSolicitud.Value;

                        comando.Parameters.Add("@nombre", SqlDbType.VarChar, 100)
                            .Value = txtNombreSolicitante.Text.Trim();

                        comando.Parameters.Add("@telefono", SqlDbType.VarChar, 20)
                            .Value = string.IsNullOrWhiteSpace(txtTelefonoSolicitante.Text)
                                ? DBNull.Value
                                : txtTelefonoSolicitante.Text.Trim();

                        comando.Parameters.Add("@correo", SqlDbType.VarChar, 100)
                            .Value = string.IsNullOrWhiteSpace(txtCorreoSolicitante.Text)
                                ? DBNull.Value
                                : txtCorreoSolicitante.Text.Trim();

                        comando.Parameters.Add("@descripcion", SqlDbType.VarChar, 250)
                            .Value = string.IsNullOrWhiteSpace(txtDescripcionSolicitud.Text)
                                ? DBNull.Value
                                : txtDescripcionSolicitud.Text.Trim();

                        conexion.Open();
                        int filas = comando.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show(
                                "Solicitud registrada correctamente.",
                                "Mishin Cine Café",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            LimpiarSolicitud();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Error al guardar la solicitud:\n" + ex.Message,
                    "Error de SQL Server",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void lblObservacionAdministrador_Click(object sender, EventArgs e)
        {

        }

        private void lblSolicitante_Click(object sender, EventArgs e)
        {

        }
    }

}

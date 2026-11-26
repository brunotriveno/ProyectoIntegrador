namespace ProyectoIntegrador
{
    partial class FrmSolicitudes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitudes));
            pnelSuperior = new Panel();
            picSolicitudesNuevas = new PictureBox();
            btnSolicitudesNuevas = new Button();
            pnelMenu = new Panel();
            btnGestionDonaciones = new Button();
            picGestionDonaciones = new PictureBox();
            pnlContenido = new Panel();
            picHistorial = new PictureBox();
            btnHistorial = new Button();
            btnListaDonantes = new Button();
            btnInicio = new Button();
            pnlTarjetaDonantes = new Panel();
            picListaDonantes = new PictureBox();
            pnlTarjetaInicio = new Panel();
            picInicio = new PictureBox();
            pnlNuevaSolicitud = new Panel();
            lblFechaSolicitud = new Label();
            lblSolicitud = new Label();
            lblDescripcionSolicitud = new Label();
            lblCorreo = new Label();
            lblTelefono = new Label();
            lblNombreSolicitante = new Label();
            btnLimpiarSolicitud = new Button();
            btnGuardarSolicitud = new Button();
            txtDescripcionSolicitud = new TextBox();
            txtCorreoSolicitante = new TextBox();
            txtTelefonoSolicitante = new TextBox();
            txtNombreSolicitante = new TextBox();
            dtpFechaSolicitud = new DateTimePicker();
            cmbTipoSolicitud = new ComboBox();
            btnVolverMenu = new Button();
            lblNuevaSolicitud = new Label();
            pnelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSolicitudesNuevas).BeginInit();
            pnelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGestionDonaciones).BeginInit();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHistorial).BeginInit();
            pnlTarjetaDonantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picListaDonantes).BeginInit();
            pnlTarjetaInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picInicio).BeginInit();
            pnlNuevaSolicitud.SuspendLayout();
            SuspendLayout();
            // 
            // pnelSuperior
            // 
            pnelSuperior.Controls.Add(picSolicitudesNuevas);
            pnelSuperior.Controls.Add(btnSolicitudesNuevas);
            pnelSuperior.Location = new Point(445, 30);
            pnelSuperior.Name = "pnelSuperior";
            pnelSuperior.Size = new Size(220, 230);
            pnelSuperior.TabIndex = 0;
            // 
            // picSolicitudesNuevas
            // 
            picSolicitudesNuevas.BackColor = Color.Transparent;
            picSolicitudesNuevas.Image = (Image)resources.GetObject("picSolicitudesNuevas.Image");
            picSolicitudesNuevas.Location = new Point(35, 20);
            picSolicitudesNuevas.Name = "picSolicitudesNuevas";
            picSolicitudesNuevas.Size = new Size(150, 120);
            picSolicitudesNuevas.SizeMode = PictureBoxSizeMode.Zoom;
            picSolicitudesNuevas.TabIndex = 2;
            picSolicitudesNuevas.TabStop = false;
            picSolicitudesNuevas.Click += picSolicitudesNuevas_Click;
            // 
            // btnSolicitudesNuevas
            // 
            btnSolicitudesNuevas.FlatStyle = FlatStyle.Flat;
            btnSolicitudesNuevas.Location = new Point(15, 170);
            btnSolicitudesNuevas.Name = "btnSolicitudesNuevas";
            btnSolicitudesNuevas.Size = new Size(190, 45);
            btnSolicitudesNuevas.TabIndex = 4;
            btnSolicitudesNuevas.Text = "Solicitudes Nuevas";
            btnSolicitudesNuevas.UseVisualStyleBackColor = true;
            // 
            // pnelMenu
            // 
            pnelMenu.Controls.Add(btnGestionDonaciones);
            pnelMenu.Controls.Add(picGestionDonaciones);
            pnelMenu.Location = new Point(195, 280);
            pnelMenu.Name = "pnelMenu";
            pnelMenu.Size = new Size(220, 230);
            pnelMenu.TabIndex = 1;
            // 
            // btnGestionDonaciones
            // 
            btnGestionDonaciones.FlatStyle = FlatStyle.Flat;
            btnGestionDonaciones.Location = new Point(15, 170);
            btnGestionDonaciones.Name = "btnGestionDonaciones";
            btnGestionDonaciones.Size = new Size(190, 45);
            btnGestionDonaciones.TabIndex = 9;
            btnGestionDonaciones.Text = "Gestión de Donaciones";
            btnGestionDonaciones.UseVisualStyleBackColor = true;
            // 
            // picGestionDonaciones
            // 
            picGestionDonaciones.BackColor = Color.Transparent;
            picGestionDonaciones.Image = (Image)resources.GetObject("picGestionDonaciones.Image");
            picGestionDonaciones.Location = new Point(35, 20);
            picGestionDonaciones.Name = "picGestionDonaciones";
            picGestionDonaciones.Size = new Size(150, 120);
            picGestionDonaciones.SizeMode = PictureBoxSizeMode.Zoom;
            picGestionDonaciones.TabIndex = 1;
            picGestionDonaciones.TabStop = false;
            // 
            // pnlContenido
            // 
            pnlContenido.Controls.Add(picHistorial);
            pnlContenido.Controls.Add(btnHistorial);
            pnlContenido.Location = new Point(195, 30);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(220, 230);
            pnlContenido.TabIndex = 2;
            // 
            // picHistorial
            // 
            picHistorial.BackColor = Color.Transparent;
            picHistorial.Image = (Image)resources.GetObject("picHistorial.Image");
            picHistorial.Location = new Point(35, 20);
            picHistorial.Name = "picHistorial";
            picHistorial.Size = new Size(150, 120);
            picHistorial.SizeMode = PictureBoxSizeMode.Zoom;
            picHistorial.TabIndex = 0;
            picHistorial.TabStop = false;
            picHistorial.Click += picHistorial_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Location = new Point(15, 170);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(190, 45);
            btnHistorial.TabIndex = 6;
            btnHistorial.Text = "Historial de Solicitudes";
            btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnListaDonantes
            // 
            btnListaDonantes.FlatStyle = FlatStyle.Flat;
            btnListaDonantes.Location = new Point(15, 170);
            btnListaDonantes.Name = "btnListaDonantes";
            btnListaDonantes.Size = new Size(190, 45);
            btnListaDonantes.TabIndex = 5;
            btnListaDonantes.Text = "Lista de Donantes";
            btnListaDonantes.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Location = new Point(52, 15);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(120, 40);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // pnlTarjetaDonantes
            // 
            pnlTarjetaDonantes.Controls.Add(picListaDonantes);
            pnlTarjetaDonantes.Controls.Add(btnListaDonantes);
            pnlTarjetaDonantes.Location = new Point(445, 280);
            pnlTarjetaDonantes.Name = "pnlTarjetaDonantes";
            pnlTarjetaDonantes.Size = new Size(220, 230);
            pnlTarjetaDonantes.TabIndex = 8;
            // 
            // picListaDonantes
            // 
            picListaDonantes.Image = (Image)resources.GetObject("picListaDonantes.Image");
            picListaDonantes.Location = new Point(35, 20);
            picListaDonantes.Name = "picListaDonantes";
            picListaDonantes.Size = new Size(150, 120);
            picListaDonantes.SizeMode = PictureBoxSizeMode.Zoom;
            picListaDonantes.TabIndex = 11;
            picListaDonantes.TabStop = false;
            // 
            // pnlTarjetaInicio
            // 
            pnlTarjetaInicio.AutoScroll = true;
            pnlTarjetaInicio.Controls.Add(picInicio);
            pnlTarjetaInicio.Controls.Add(btnInicio);
            pnlTarjetaInicio.Location = new Point(30, 540);
            pnlTarjetaInicio.Name = "pnlTarjetaInicio";
            pnlTarjetaInicio.Size = new Size(180, 70);
            pnlTarjetaInicio.TabIndex = 9;
            // 
            // picInicio
            // 
            picInicio.Image = (Image)resources.GetObject("picInicio.Image");
            picInicio.Location = new Point(12, 19);
            picInicio.Name = "picInicio";
            picInicio.Size = new Size(32, 32);
            picInicio.SizeMode = PictureBoxSizeMode.Zoom;
            picInicio.TabIndex = 10;
            picInicio.TabStop = false;
            // 
            // pnlNuevaSolicitud
            // 
            pnlNuevaSolicitud.AutoScroll = true;
            pnlNuevaSolicitud.Controls.Add(lblFechaSolicitud);
            pnlNuevaSolicitud.Controls.Add(lblSolicitud);
            pnlNuevaSolicitud.Controls.Add(lblDescripcionSolicitud);
            pnlNuevaSolicitud.Controls.Add(lblCorreo);
            pnlNuevaSolicitud.Controls.Add(lblTelefono);
            pnlNuevaSolicitud.Controls.Add(lblNombreSolicitante);
            pnlNuevaSolicitud.Controls.Add(btnLimpiarSolicitud);
            pnlNuevaSolicitud.Controls.Add(btnGuardarSolicitud);
            pnlNuevaSolicitud.Controls.Add(txtDescripcionSolicitud);
            pnlNuevaSolicitud.Controls.Add(txtCorreoSolicitante);
            pnlNuevaSolicitud.Controls.Add(txtTelefonoSolicitante);
            pnlNuevaSolicitud.Controls.Add(txtNombreSolicitante);
            pnlNuevaSolicitud.Controls.Add(dtpFechaSolicitud);
            pnlNuevaSolicitud.Controls.Add(cmbTipoSolicitud);
            pnlNuevaSolicitud.Controls.Add(btnVolverMenu);
            pnlNuevaSolicitud.Controls.Add(lblNuevaSolicitud);
            pnlNuevaSolicitud.Dock = DockStyle.Fill;
            pnlNuevaSolicitud.Location = new Point(0, 0);
            pnlNuevaSolicitud.Name = "pnlNuevaSolicitud";
            pnlNuevaSolicitud.Size = new Size(859, 641);
            pnlNuevaSolicitud.TabIndex = 10;
            // 
            // lblFechaSolicitud
            // 
            lblFechaSolicitud.AutoSize = true;
            lblFechaSolicitud.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            lblFechaSolicitud.Location = new Point(553, 176);
            lblFechaSolicitud.Name = "lblFechaSolicitud";
            lblFechaSolicitud.Size = new Size(153, 21);
            lblFechaSolicitud.TabIndex = 15;
            lblFechaSolicitud.Text = "Fecha de Solicitud";
            // 
            // lblSolicitud
            // 
            lblSolicitud.AutoSize = true;
            lblSolicitud.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            lblSolicitud.Location = new Point(553, 95);
            lblSolicitud.Name = "lblSolicitud";
            lblSolicitud.Size = new Size(142, 21);
            lblSolicitud.TabIndex = 14;
            lblSolicitud.Text = "Tipo de Solicitud";
            // 
            // lblDescripcionSolicitud
            // 
            lblDescripcionSolicitud.AutoSize = true;
            lblDescripcionSolicitud.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            lblDescripcionSolicitud.Location = new Point(12, 308);
            lblDescripcionSolicitud.Name = "lblDescripcionSolicitud";
            lblDescripcionSolicitud.Size = new Size(219, 21);
            lblDescripcionSolicitud.TabIndex = 13;
            lblDescripcionSolicitud.Text = "Descripcion de la Solicitud";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            lblCorreo.Location = new Point(12, 242);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(156, 21);
            lblCorreo.TabIndex = 12;
            lblCorreo.Text = "Correo Electrónico";
            lblCorreo.Click += label2_Click;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            lblTelefono.Location = new Point(12, 160);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(78, 21);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Teléfono";
            // 
            // lblNombreSolicitante
            // 
            lblNombreSolicitante.AutoSize = true;
            lblNombreSolicitante.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreSolicitante.Location = new Point(13, 95);
            lblNombreSolicitante.Name = "lblNombreSolicitante";
            lblNombreSolicitante.Size = new Size(155, 21);
            lblNombreSolicitante.TabIndex = 10;
            lblNombreSolicitante.Text = "Nombre Completo";
            // 
            // btnLimpiarSolicitud
            // 
            btnLimpiarSolicitud.FlatStyle = FlatStyle.Flat;
            btnLimpiarSolicitud.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarSolicitud.ForeColor = Color.White;
            btnLimpiarSolicitud.Location = new Point(553, 450);
            btnLimpiarSolicitud.Name = "btnLimpiarSolicitud";
            btnLimpiarSolicitud.Size = new Size(75, 45);
            btnLimpiarSolicitud.TabIndex = 9;
            btnLimpiarSolicitud.Text = "Limpiar";
            btnLimpiarSolicitud.UseVisualStyleBackColor = true;
            // 
            // btnGuardarSolicitud
            // 
            btnGuardarSolicitud.BackColor = Color.White;
            btnGuardarSolicitud.FlatStyle = FlatStyle.Flat;
            btnGuardarSolicitud.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarSolicitud.ForeColor = Color.MidnightBlue;
            btnGuardarSolicitud.Location = new Point(656, 450);
            btnGuardarSolicitud.Name = "btnGuardarSolicitud";
            btnGuardarSolicitud.Size = new Size(121, 45);
            btnGuardarSolicitud.TabIndex = 8;
            btnGuardarSolicitud.Text = "Guardar Solicitud";
            btnGuardarSolicitud.UseVisualStyleBackColor = false;
            // 
            // txtDescripcionSolicitud
            // 
            txtDescripcionSolicitud.Location = new Point(12, 332);
            txtDescripcionSolicitud.Multiline = true;
            txtDescripcionSolicitud.Name = "txtDescripcionSolicitud";
            txtDescripcionSolicitud.ScrollBars = ScrollBars.Vertical;
            txtDescripcionSolicitud.Size = new Size(765, 90);
            txtDescripcionSolicitud.TabIndex = 7;
            txtDescripcionSolicitud.Text = "Descripcion de la Solicitud";
            // 
            // txtCorreoSolicitante
            // 
            txtCorreoSolicitante.Location = new Point(12, 266);
            txtCorreoSolicitante.Multiline = true;
            txtCorreoSolicitante.Name = "txtCorreoSolicitante";
            txtCorreoSolicitante.Size = new Size(765, 39);
            txtCorreoSolicitante.TabIndex = 6;
            txtCorreoSolicitante.Text = "correo@ejemplo.com";
            // 
            // txtTelefonoSolicitante
            // 
            txtTelefonoSolicitante.Location = new Point(12, 184);
            txtTelefonoSolicitante.Multiline = true;
            txtTelefonoSolicitante.Name = "txtTelefonoSolicitante";
            txtTelefonoSolicitante.Size = new Size(516, 39);
            txtTelefonoSolicitante.TabIndex = 5;
            txtTelefonoSolicitante.Text = "Número de Contacto";
            // 
            // txtNombreSolicitante
            // 
            txtNombreSolicitante.Location = new Point(12, 120);
            txtNombreSolicitante.Multiline = true;
            txtNombreSolicitante.Name = "txtNombreSolicitante";
            txtNombreSolicitante.Size = new Size(516, 37);
            txtNombreSolicitante.TabIndex = 4;
            txtNombreSolicitante.Text = "Nombre del Solicitante";
            // 
            // dtpFechaSolicitud
            // 
            dtpFechaSolicitud.Location = new Point(553, 200);
            dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            dtpFechaSolicitud.Size = new Size(224, 23);
            dtpFechaSolicitud.TabIndex = 3;
            dtpFechaSolicitud.ValueChanged += dtpFechaSolicitud_ValueChanged;
            // 
            // cmbTipoSolicitud
            // 
            cmbTipoSolicitud.FormattingEnabled = true;
            cmbTipoSolicitud.Location = new Point(553, 120);
            cmbTipoSolicitud.Name = "cmbTipoSolicitud";
            cmbTipoSolicitud.Size = new Size(224, 23);
            cmbTipoSolicitud.TabIndex = 2;
            cmbTipoSolicitud.Text = "Seleccionar...";
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.FlatAppearance.BorderColor = Color.White;
            btnVolverMenu.FlatStyle = FlatStyle.Flat;
            btnVolverMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverMenu.ForeColor = Color.White;
            btnVolverMenu.Location = new Point(30, 550);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(160, 40);
            btnVolverMenu.TabIndex = 1;
            btnVolverMenu.Text = "Volver al Menú";
            btnVolverMenu.UseVisualStyleBackColor = false;
            // 
            // lblNuevaSolicitud
            // 
            lblNuevaSolicitud.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNuevaSolicitud.Location = new Point(30, 25);
            lblNuevaSolicitud.Name = "lblNuevaSolicitud";
            lblNuevaSolicitud.Size = new Size(320, 40);
            lblNuevaSolicitud.TabIndex = 0;
            lblNuevaSolicitud.Text = "Nueva Solicitud";
            lblNuevaSolicitud.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmSolicitudes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(859, 641);
            Controls.Add(pnlNuevaSolicitud);
            Controls.Add(pnlTarjetaInicio);
            Controls.Add(pnlTarjetaDonantes);
            Controls.Add(pnlContenido);
            Controls.Add(pnelMenu);
            Controls.Add(pnelSuperior);
            ForeColor = Color.White;
            Name = "FrmSolicitudes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Donaciones";
            WindowState = FormWindowState.Maximized;
            pnelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSolicitudesNuevas).EndInit();
            pnelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picGestionDonaciones).EndInit();
            pnlContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHistorial).EndInit();
            pnlTarjetaDonantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picListaDonantes).EndInit();
            pnlTarjetaInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picInicio).EndInit();
            pnlNuevaSolicitud.ResumeLayout(false);
            pnlNuevaSolicitud.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelSuperior;
        private Panel pnelMenu;
        private Panel pnlContenido;
        private Button btnListaDonantes;
        private Button btnHistorial;
        private Button btnInicio;
        private Button btnGestionDonaciones;
        private PictureBox picSolicitudesNuevas;
        private PictureBox picGestionDonaciones;
        private PictureBox picHistorial;
        private Button btnSolicitudesNuevas;
        private Panel pnlTarjetaDonantes;
        private Panel pnlTarjetaInicio;
        private PictureBox picInicio;
        private PictureBox picListaDonantes;
        private Panel pnlNuevaSolicitud;
        private Button btnVolverMenu;
        private Label lblNuevaSolicitud;
        private DateTimePicker dtpFechaSolicitud;
        private ComboBox cmbTipoSolicitud;
        private TextBox txtDescripcionSolicitud;
        private TextBox txtCorreoSolicitante;
        private TextBox txtTelefonoSolicitante;
        private TextBox txtNombreSolicitante;
        private Button btnLimpiarSolicitud;
        private Button btnGuardarSolicitud;
        private Label lblNombreSolicitante;
        private Label lblDescripcionSolicitud;
        private Label lblCorreo;
        private Label lblTelefono;
        private Label lblSolicitud;
        private Label lblFechaSolicitud;
    }
}
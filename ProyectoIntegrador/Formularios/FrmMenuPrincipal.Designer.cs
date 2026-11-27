namespace ProyectoIntegrador.Formularios
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            pnlEncabezado = new Panel();
            lblInicio = new Label();
            picAlmacen = new PictureBox();
            picAdopcion = new PictureBox();
            picDonaciones = new PictureBox();
            btnAlmacen = new Button();
            btnAdopcion = new Button();
            btnDonaciones = new Button();
            ((System.ComponentModel.ISupportInitialize)picAlmacen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAdopcion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDonaciones).BeginInit();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(12, 25, 58);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(800, 90);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInicio.ForeColor = Color.White;
            lblInicio.Location = new Point(386, 126);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(119, 45);
            lblInicio.TabIndex = 1;
            lblInicio.Text = "INICIO";
            // 
            // picAlmacen
            // 
            picAlmacen.Image = (Image)resources.GetObject("picAlmacen.Image");
            picAlmacen.Location = new Point(104, 199);
            picAlmacen.Name = "picAlmacen";
            picAlmacen.Size = new Size(180, 180);
            picAlmacen.SizeMode = PictureBoxSizeMode.StretchImage;
            picAlmacen.TabIndex = 2;
            picAlmacen.TabStop = false;
            // 
            // picAdopcion
            // 
            picAdopcion.Image = (Image)resources.GetObject("picAdopcion.Image");
            picAdopcion.Location = new Point(334, 199);
            picAdopcion.Name = "picAdopcion";
            picAdopcion.Size = new Size(180, 180);
            picAdopcion.SizeMode = PictureBoxSizeMode.StretchImage;
            picAdopcion.TabIndex = 3;
            picAdopcion.TabStop = false;
            // 
            // picDonaciones
            // 
            picDonaciones.Image = (Image)resources.GetObject("picDonaciones.Image");
            picDonaciones.Location = new Point(564, 199);
            picDonaciones.Name = "picDonaciones";
            picDonaciones.Size = new Size(180, 180);
            picDonaciones.SizeMode = PictureBoxSizeMode.StretchImage;
            picDonaciones.TabIndex = 4;
            picDonaciones.TabStop = false;
            // 
            // btnAlmacen
            // 
            btnAlmacen.Location = new Point(104, 397);
            btnAlmacen.Name = "btnAlmacen";
            btnAlmacen.Size = new Size(180, 28);
            btnAlmacen.TabIndex = 5;
            btnAlmacen.Text = "Almacen";
            btnAlmacen.UseVisualStyleBackColor = true;
            btnAlmacen.Click += btnAlmacen_Click;
            // 
            // btnAdopcion
            // 
            btnAdopcion.AutoSize = true;
            btnAdopcion.Location = new Point(334, 397);
            btnAdopcion.Name = "btnAdopcion";
            btnAdopcion.Size = new Size(180, 28);
            btnAdopcion.TabIndex = 6;
            btnAdopcion.Text = "Centro de adopcion";
            btnAdopcion.UseVisualStyleBackColor = true;
            btnAdopcion.Click += btnAdopcion_Click;
            // 
            // btnDonaciones
            // 
            btnDonaciones.Location = new Point(564, 397);
            btnDonaciones.Name = "btnDonaciones";
            btnDonaciones.Size = new Size(180, 28);
            btnDonaciones.TabIndex = 7;
            btnDonaciones.Text = "Solicitudes de donaciones";
            btnDonaciones.UseVisualStyleBackColor = true;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 35, 82);
            ClientSize = new Size(800, 450);
            Controls.Add(btnDonaciones);
            Controls.Add(btnAdopcion);
            Controls.Add(btnAlmacen);
            Controls.Add(picDonaciones);
            Controls.Add(picAdopcion);
            Controls.Add(picAlmacen);
            Controls.Add(lblInicio);
            Controls.Add(pnlEncabezado);
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GATITO-inicio";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)picAlmacen).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAdopcion).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDonaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblInicio;
        private PictureBox picDonaciones;
        private PictureBox picAlmacen;
        private PictureBox picAdopcion;
        private Button btnAlmacen;
        private Button btnAdopcion;
        private Button btnDonaciones;
    }
}
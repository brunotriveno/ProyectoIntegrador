using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;

namespace ProyectoIntegrador.Formularios
{
    public class almacen : Form
    {
        private Label lbl1Kg;
        private Label lblDias;
        public almacen()
        {
            CrearVentana();
        }
        private void CrearVentana(){
            //ventana
            this.Text = "Almacen";
            this.StartPosition= FormStartPosition.CenterScreen;
            this.ClientSize = new Size(800, 450);
            this.BackColor = Color.FromArgb(7, 38, 88);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //barra
            Panel barra= new Panel();
            barra.BackColor = Color.FromArgb(5, 30, 70);
            barra.Location = new Point(0, 0);
            barra.Size = new Size(800, 50);
            this.Controls.Add(barra);
            //menu
            Button btnMenu= new Button();
            btnMenu.Text = "☰";
            btnMenu.Font = new Font("Segoe UI", 14);
            btnMenu.ForeColor = Color.White;
            btnMenu.BackColor=Color.Transparent;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.Location = new Point(25, 7);
            btnMenu.Size = new Size(45, 35);
            barra.Controls.Add(btnMenu);
            //inicio
            Button btnInicio= new Button();
            btnInicio.Text = "⌂";
            btnInicio.Font = new Font("Segoe UI", 20);
            btnInicio.ForeColor = Color.White;
            btnInicio.BackColor = Color.Transparent;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.Location = new Point(735, 4);
            btnInicio.Size = new Size(45, 40);
            barra.Controls.Add(btnInicio);
            //titulo
            Label titu= new Label();
            titu.Text = "ALMACEN";
            titu.ForeColor = Color.White;   
            titu.Font=new Font("Segoe UI", 20, FontStyle.Bold);
            titu.TextAlign=ContentAlignment.MiddleCenter;
            titu.Location = new Point(250, 55);
            titu.Size = new Size(300, 45);
            this.Controls.Add(titu);
            //cantidad
            Label cant = new Label();
            cant.Text = "CANTIDAD";
            cant.ForeColor = Color.White;
            cant.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            cant.TextAlign = ContentAlignment.MiddleCenter;
            cant.Location = new Point(55, 100);
            cant.Size = new Size(140, 70);
            this.Controls.Add(cant);
            //izquierda
            Panel izquierda = 
                CrearCirculo(55, 168, 140, 140);
            this.Controls.Add(izquierda);
            //sis cant
            lbl1Kg = new Label();
            lbl1Kg.Text = "82 Kg";
            lbl1Kg.ForeColor = Color.White;
            lbl1Kg.Font = new Font("Segoe UI", 27);
            lbl1Kg.TextAlign = ContentAlignment.MiddleCenter;
            lbl1Kg.BackColor = Color.Transparent;
            lbl1Kg.Location = new Point(65, 210);
            lbl1Kg.Size = new Size(120, 55);
            this.Controls.Add(lbl1Kg);
            //centro
            Panel centro =
                CrearCirculo(240, 135, 140, 140);
            this.Controls.Add(centro);
            Label icono =new Label();
            icono.Text = "📄";
            icono.Font = new Font("Segoe UI Emoji", 27);
            icono.ForeColor = Color.White;
            icono.TextAlign = ContentAlignment.MiddleCenter;
            icono.BackColor = Color.Transparent;
            icono.Location = new Point(260, 150);
            icono.Size = new Size(100, 100);
            this.Controls.Add(icono);
            Label agregar = new Label();
            agregar.Text = "Agregar Cantidad de croquetas";
            agregar.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            agregar.ForeColor = Color.White;
            agregar.TextAlign = ContentAlignment.MiddleCenter;
            agregar.Location = new Point(220, 200);
            agregar.Size = new Size(100, 55);
            this.Controls.Add(agregar);
            //duracion
            Label durac = new Label();
            durac.Text = "Proyeccion";
            durac.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            durac.ForeColor = Color.White;
            durac.TextAlign = ContentAlignment.MiddleCenter;
            durac.Location = new Point(440, 100);
            durac.Size = new Size(180, 75);
            this.Controls.Add(durac);
            //derecha
            Panel derecha = 
                 CrearCirculo(440, 168, 140, 140);
             this.Controls.Add(derecha);
            //dias
            lblDias = new Label();
            lblDias.Text = "16 dias";
            lblDias.ForeColor = Color.White;
            lblDias.Font = new Font("Segoe UI", 27);
            lblDias.TextAlign = ContentAlignment.MiddleCenter;
            lblDias.BackColor = Color.Transparent;
            lblDias.Location = new Point(450, 210);
            lblDias.Size = new Size(120, 55);
            this.Controls.Add(lblDias);
        }
        private Panel CrearCirculo(int x,int y, int ancho, int alto)
        {
            Panel panel = new Panel();
            panel.Location = new Point(x, y);
            panel.Size = new Size(ancho, alto);
            panel.BackColor = Color.Transparent;
            panel.Paint += (sender, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen lapiz = new Pen(Color.White, 2))
                {
                    e.Graphics.DrawEllipse(lapiz, 1, 1, ancho - 3, alto - 3);
                }
            };
            return panel;
        }
    }
}

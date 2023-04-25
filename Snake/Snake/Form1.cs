﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private const int anchoEscenario = 735;
        private const int altoEscenario = 500;
        private Marcador marcador;
        private Serpiente serpiente;
        private Comidas comida;
        private const Keys arriba = Keys.Up;
        private const Keys abajo = Keys.Down;
        private const Keys izquierda = Keys.Left;
        private const Keys derecha = Keys.Right;
        private Stopwatch tiempo;
        private double ultimoTiempo;

        
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint
                   |ControlStyles.UserPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.SupportsTransparentBackColor, true);
            this.Text = "Serpiente VJ1208 ...";
            this.Width = anchoEscenario;
            this.Height = altoEscenario;
            this.BackColor = Color.DarkRed;
            serpiente = new Serpiente(new Point(this.Width/2, this.Height/2)); // Aquí se crea
            Controls.Add(serpiente.picBox); // Aquí se añade a Controls
            comida = new Comidas();
            //Controls.Add(comida.MiPictureBox);
            marcador = new Marcador();
            Controls.Add(marcador.Informacion);
            marcador.Informacion.SendToBack();
            tiempo = new Stopwatch();
            tiempo.Start();
            ultimoTiempo = 0.0;

    }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case arriba:
                    
                case abajo:
                    
                case izquierda:
                    
                case derecha:
                default:
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //double tiempoJuego = tiempo.ElapsedMilliseconds;
            //double tiempoTranscurrido = tiempoJuego-ultimoTiempo;
            //ultimoTiempo = tiempoJuego;
            this.BackColor = Color.Gray;
            this.Invalidate();
    }
    }
}

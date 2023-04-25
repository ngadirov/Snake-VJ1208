using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snake
{
    internal class Serpiente
    {
        public List<Segmento> cuerpo { get; set; }
        public Segmento cabeza;
        public PictureBox picBox;
        public Giro giro;
        public Serpiente(Point posInicial)
        {
            cuerpo = new List<Segmento>();
            cabeza = new Segmento(posInicial, 20, Color.Green, "");
            cuerpo.Add(new Segmento(new Point(posInicial.X,posInicial.Y-20), 20, Color.LightGreen, ""));
            cuerpo.Add(new Segmento(new Point(posInicial.X, posInicial.Y - 40), 20, Color.LightGreen, ""));
            picBox = cabeza.PicBox;
            
        }

    }
}

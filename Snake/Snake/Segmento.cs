using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snake
{
    internal class Segmento
    {
        private PictureBox picBox = new PictureBox();
        private int x;
        private int y;
        private int size;
        private Color color;
        private string direccion;
        public Segmento(int x, int y, int size, Color color, string direccion)
        {
            picBox.Location = new Point(x, y);
            this.x = x;
            this.y = y;
            this.size = size;
            this.color = color;
            this.direccion = direccion;
        }
    }
}

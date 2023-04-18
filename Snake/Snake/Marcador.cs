using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    internal class Marcador
    {
        public Label Informacion { get; }
        private Label informacion = new Label();
        public int Puntos  { get; set; }
        public double TiempoVida { get; set; }
        public Marcador()
        {
            informacion.Font = new Font("Courier", 18);
            informacion.AutoSize = true;
            Puntos = 0;
            TiempoVida = 10;
        }

        public void Actualizar()
        {

        }
    }
}

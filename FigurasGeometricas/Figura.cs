using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    using System.Drawing;

    public abstract class Figura
    {
        public Color Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        protected Figura(Color color, int x, int y)
        {
            Color = color;
            X = x;
            Y = y;
        }

        public abstract void Dibujar(Graphics g);
    }

}

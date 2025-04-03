using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    public class Rectangulo : Figura
    {
        public Rectangulo(Color color, int x, int y) : base(color, x, y) { }

        public override void Dibujar(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, X, Y, 50, 30);
            }
        }
    }

}

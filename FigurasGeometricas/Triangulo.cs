using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    using System.Drawing;
    using System.Drawing.Drawing2D;

    public class Triangulo : Figura
    {
        public Triangulo(Color color, int x, int y) : base(color, x, y) { }

        public override void Dibujar(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                Point[] puntos =
                {
                new Point(X, Y - 30),
                new Point(X - 25, Y + 30),
                new Point(X + 25, Y + 30)
            };

                g.FillPolygon(brush, puntos);
            }
        }
    }

}

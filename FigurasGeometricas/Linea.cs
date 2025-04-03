using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    public class Linea : Figura
    {
        public Linea(Color color, int x, int y) : base(color, x, y) { }

        public override void Dibujar(Graphics g)
        {
            using (Pen pen = new Pen(Color, 3))
            {
                g.DrawLine(pen, X, Y, X + 50, Y + 50);
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    public class Circulo : Figura
    {
        private const int Radio = 25;

        public Circulo(Color color, int x, int y) : base(color, x, y) { }

        public override void Dibujar(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillEllipse(brush, X - Radio, Y - Radio, Radio * 2, Radio * 2);
            }
        }
    }

}

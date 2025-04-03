using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    public static class FiguraFactory
    {
        public static Figura CrearFigura(string tipo, Color color, int x, int y)
        {
            if (tipo == "Rectangulo")
                return new Rectangulo(color, x, y);
            else if (tipo == "Circulo")
                return new Circulo(color, x, y);
            else if (tipo == "Linea")
                return new Linea(color, x, y);
            else if (tipo == "Triangulo")
                return new Triangulo(color, x, y);
            else
                throw new ArgumentException("Tipo de figura no válido.");
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16_Ejercicio.Moldes
{
    internal class Rectangulo : Cuadrilatero
    {
        public Rectangulo(double VerticeCCoordX, double VerticeACoordY) : base(0, VerticeACoordY, VerticeCCoordX, VerticeACoordY, VerticeCCoordX, 0, 0, 0)
        {

        }

        public override double CalculoArea()
        {
           return VerticeCCoordX * VerticeACoordY;
        }
    }
}

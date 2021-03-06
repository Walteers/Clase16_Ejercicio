using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase16_Ejercicio.Moldes
{
    public class Trapecio : Cuadrilatero
    {
        public Trapecio(double VerticeA_CoordX, double VerticeA_CoordY, double VerticeC_CoordX) : base(VerticeA_CoordX, VerticeA_CoordY, VerticeC_CoordX - VerticeA_CoordX, VerticeA_CoordY, VerticeC_CoordX, 0, 0, 0)
        {

        }

        public override double CalculoArea()
        {
            return ( (VerticeCCoordX + (VerticeCCoordX - VerticeACoordX) ) / 2) * VerticeACoordY;
        }
    }
}
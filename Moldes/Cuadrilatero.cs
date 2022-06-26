using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase16_Ejercicio.Moldes
{
    public abstract class Cuadrilatero
    {
        private double _verticeACoordX { get; set; }
        private double _verticeACoordY { get; set; }
        private double _verticeBCoordX { get; set; }
        private double _verticeBCoordY { get; set; }
        private double _verticeCCoordX { get; set; }
        private double _verticeCCoordY { get; set; }
        private double _verticeDCoordX { get; set; }
        private double _verticeDCoordY { get; set; }


        public Cuadrilatero(double VerticeACoordX, double VerticeACoordY, double VerticeBCoordX, double VerticeBCoordY, double VerticeCCoordX, double VerticeCCoordY, double VerticeDCoordX, double VerticeDCoordY)
        {
            _verticeACoordX = VerticeACoordX;
            _verticeACoordY = VerticeACoordY;
            _verticeBCoordX = VerticeBCoordX;
            _verticeBCoordY = VerticeBCoordY;
            _verticeCCoordX = VerticeCCoordX;
            _verticeCCoordY = VerticeCCoordY;
            _verticeDCoordX = VerticeDCoordX;            
            _verticeDCoordY = VerticeDCoordY;
        }

        public double CalculoArea()
        {
            if( (_verticeCCoordX == _verticeACoordY & _verticeCCoordX == _verticeBCoordX) | // Cuadrado
                (_verticeACoordX == _verticeBCoordX & _verticeACoordX != _verticeACoordY))  // Rectángulo
                return _verticeCCoordX * _verticeACoordY;

            else return ((_verticeCCoordX + (_verticeCCoordX - _verticeACoordX)) / 2) * _verticeACoordY; // Trapecio

        }
        

    }
}
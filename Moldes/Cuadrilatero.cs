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


        public Cuadrilatero(double DistanciaIngresada)// Constructor para Cuadrado
        {
            _verticeACoordX = 0;
            _verticeACoordY = DistanciaIngresada;

            _verticeBCoordX = DistanciaIngresada;
            _verticeBCoordY = DistanciaIngresada;

            _verticeCCoordX = DistanciaIngresada;
            _verticeCCoordY = 0;

            _verticeDCoordX = 0;
            _verticeDCoordY = 0;
        }

        public Cuadrilatero(double Base, double Altura) // Constructor para Rectangulo
        {
            _verticeACoordX = 0;
            _verticeACoordY = Altura;

            _verticeBCoordX = Base;
            _verticeBCoordY = Altura;

            _verticeCCoordX = Base;
            _verticeCCoordY = 0;

            _verticeDCoordX = 0;
            _verticeDCoordY = 0;
        }

        public Cuadrilatero(double VerticeA_CoordX, double VerticeA_CoordY, double VerticeC_CoordX) // Constructor Trapecio
        {
            _verticeACoordX = VerticeA_CoordX;
            _verticeACoordY = VerticeA_CoordY;

            _verticeBCoordX = VerticeC_CoordX - VerticeA_CoordX;
            _verticeBCoordY = VerticeA_CoordY;

            _verticeCCoordX = VerticeC_CoordX;
            _verticeCCoordY = 0;

            _verticeDCoordX = 0;
            _verticeDCoordY = 0;
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
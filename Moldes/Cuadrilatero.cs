using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase16_Ejercicio.Moldes
{
    public abstract class Cuadrilatero
    {
        private double _verticeACoordX;
        private double _verticeACoordY;
        private double _verticeBCoordX;
        private double _verticeBCoordY;
        private double _verticeCCoordX;
        private double _verticeCCoordY;
        private double _verticeDCoordX;
        private double _verticeDCoordY;

        public double VerticeACoordX
        {
            get { return _verticeACoordX; }
            set { _verticeACoordX = value; }
        }
        public double VerticeACoordY
        {
            get { return _verticeACoordY; }
            set { _verticeACoordY = value; }
        }
        public double VerticeBCoordX
        {
            get { return _verticeBCoordX; }
            set { _verticeBCoordX = value; }
        }
        public double VerticeBCoordY
        {
            get { return _verticeBCoordY; }
            set { _verticeBCoordY = value; }
        }
        public double VerticeCCoordX
        {
            get { return _verticeCCoordX; }
            set { _verticeCCoordX = value; }
        }
        public double VerticeCCoordY
        {
            get { return _verticeCCoordY; }
            set { _verticeCCoordY = value; }
        }
        public double VerticeDCoordX
        {
            get { return _verticeDCoordX; }
            set { _verticeDCoordX = value; }
        }
        public double VerticeDCoordY
        {
            get { return _verticeDCoordY; }
            set { _verticeDCoordY = value; }
        }



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

        public abstract double CalculoArea();
        //  {
        //    if ((_verticeCCoordX == _verticeACoordY & _verticeCCoordX == _verticeBCoordX) | // Cuadrado
        //        (_verticeACoordX == _verticeBCoordX & _verticeACoordX != _verticeACoordY))  // Rectángulo
        //        return _verticeCCoordX* _verticeACoordY;

        //    else return ((_verticeCCoordX + (_verticeCCoordX - _verticeACoordX)) / 2) * _verticeACoordY; // Trapecio

        //}


    }
}
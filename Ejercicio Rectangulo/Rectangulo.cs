using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Rectangulo
{
    internal class Rectangulo
    {
        private double _base;
        private double _altura;

        public Rectangulo(double baseRectangulo, double alturaRectangulo)
        {
            _base = baseRectangulo;
            _altura = alturaRectangulo;
        }

        public Rectangulo()
        {
            _base = 1;
            _altura = 1;
        }

       public double getbase()
        {
            return _base;
        }
        public double getaltura()
        {
            return _altura;
        }

        public void setbase(double baseRectangulo)
        {
            if (baseRectangulo > 0)
            {
                _base = baseRectangulo;
            }
            else
            {
                _base = 1;
            }
        }

        public void setaltura(double alturaRectangulo)
        {
            if (alturaRectangulo > 0)
            {
                _altura = alturaRectangulo;
            }
            else
            {
                _altura = 1;
            }
        }
        public double Area()
        {
            return (_base * _altura);
        }
        public double Perimetro()
        {
            return (_base * 2) + (_altura * 2);
        }
        public bool esCuadrado()
        {
            if (_base == _altura)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}


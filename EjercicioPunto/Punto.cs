using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPunto
{
    internal class Punto
    {
        #region Atributos
        private double _x;
        private double _y;
        #endregion

        #region Constructores
        public Punto(double x, double y)
          {
            _x = x;
            _y = y;
          }
        #endregion

        #region Comandos y Consultas

        public double getX()
        {
            return _x;
        }

        public void setX(double unNumero)
        {
            _x = unNumero;
        }

        public double getY()
        {
            return _y;
        }

        public void setY(double unNumero)
        {
            _y = unNumero;
        }

        #endregion

        #region Metodos
        public bool igualA(Punto otroPunto)
        {
            if (_x == otroPunto.getX() && _y == otroPunto.getY())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Punto mas(Punto otroPunto)
        {
            
            double nuevaX = _x + otroPunto.getX();
            double nuevaY = _y + otroPunto.getY();
   
            return new Punto(nuevaX, nuevaY);
        }

        public Punto menos(Punto otroPunto)
        {
            double nuevaX = _x - otroPunto.getX();
            double nuevaY = _y - otroPunto.getY();

            return new Punto(nuevaX, nuevaY);
        }

        public override string ToString()
        {
            return "Coordenada X: " + _x + " , Coordenada Y: " + _y;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Ejercicio_Herencia
{
    internal class Estudiante : Persona
    {
        private int _legajo;
        private string _carrera;
        private DateTime _fechaingreso;

        public Estudiante (int dni, int legajo) :base(dni)
        {
            _legajo = legajo;
        }
        public Estudiante(int legajo,string carrera,DateTime fechaingreso,int dni,string nombre,string apellido,DateTime fechanacimiento) :base(nombre,apellido,dni,fechanacimiento)
        {
            _legajo = legajo;
            _carrera = carrera;
            _fechaingreso = fechaingreso;
        }
        public int getlegajo()
        {
            return _legajo;
        }
        public string getcarrera()
        {
            return _carrera;
        }
        public DateTime getfechaingreso()
        {
            return _fechaingreso;
        }

        public void setlegajo(int legajo)
        {
            if (legajo > 0)
            {
                _legajo = legajo;
            }
            else
            {
                _legajo = 1;
            }

        }
        public void setcarrera(string carrera)
        {
            _carrera = carrera;
        }
       
        public void setfechaingreso(DateTime fechaingreso)
        {
            _fechaingreso = fechaingreso;
        }

        public override string Mostrar()
        {
            string datosPadre = base.Mostrar();
            string textoFinal = datosPadre + " | ";
            textoFinal += "Legajo: " + _legajo + " | ";
            textoFinal += "Carrera: " + _carrera;

            return textoFinal;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio_Herencia
{
    internal class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected int _dni;
        protected DateTime _fechaNacimiento;

        public Persona (int dni)
        {
            this._dni = dni;
        }
        public Persona (string nombre, string apellido, int dni, DateTime fechanacimiento)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._fechaNacimiento = fechanacimiento;
        }
        
        public int getDni()
        {
            return _dni;
        }

        public void setDni(int nuevoDocumento)
        {
            if (nuevoDocumento > 0)
            {
                _dni = nuevoDocumento;
            }
            else
            {
                _dni = 1;
            }
        }

        public string getNombre()
        {
            return _nombre;
        }

        public void setNombre(string nuevoNombre)
        {
            _nombre = nuevoNombre;
        }

        public string getApellido()
        {
            return _apellido;
        }

        public void setApellido(string nuevoApellido)
        {
            _apellido = nuevoApellido;
        }

        public DateTime getFechaNacimiento()
        {
            return _fechaNacimiento;
        }

        public void setFechaNacimiento(DateTime nuevaFecha)
        {
            _fechaNacimiento = nuevaFecha;
        }
        public virtual string Mostrar()
        {
            string texto = "DNI: " + _dni.ToString("#,##0").Replace(',', '.') + " | ";
            texto += "Nombre: " + _nombre + " " + _apellido + " | ";
            texto += "Nac: " + _fechaNacimiento.ToShortDateString();
            return texto;
        }
    }

    }


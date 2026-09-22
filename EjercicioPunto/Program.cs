using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPunto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creando el punto 1");
            Console.Write("Ingrese la coordenada x: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la coordenada y: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Punto punto1 = new Punto(x1, y1);

            Console.WriteLine("Creando el punto 2");
            Console.Write("Ingrese la coordenada x: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la coordenada y: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Punto punto2 = new Punto(x2, y2);

            Console.WriteLine("Resultados: ");
            Console.WriteLine("Punto 1: " + punto1.ToString());
            Console.WriteLine("Punto 2: " + punto2.ToString());

            if  (punto1.igualA(punto2))
            {
                Console.WriteLine("Los puntos son iguales.");
            }
            else
            {
                Console.WriteLine("Los puntos son diferentes.");
            }

            Punto Sumapuntos = punto1.mas(punto2);
            Console.WriteLine("La suma de los puntos es: " + Sumapuntos.ToString());

            Punto Restapuntos = punto1.menos(punto2);
            Console.WriteLine("La resta de los puntos es: " + Restapuntos.ToString());

            Console.ReadLine();
        }
    }
}

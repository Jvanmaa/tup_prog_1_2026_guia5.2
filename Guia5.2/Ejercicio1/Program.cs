using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int condicion;
            double n1, n2, n3, promedio;

            Console.WriteLine("Ingrese condición de promoción");
            condicion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese nota 1");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese nota 2");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese nota 3");
            n3 = Convert.ToDouble(Console.ReadLine());

            promedio = (n1 + n2 + n3) / 3;

            if (promedio > condicion)
            {
                Console.WriteLine($"Promedio: {promedio:f2}. El alumno promociona");
            }
            else
            {
                Console.WriteLine($"Promedio: {promedio:f2}. El alumno rinde examen final");
            }
            Console.ReadKey();
        }
    }
}

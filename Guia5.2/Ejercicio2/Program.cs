using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.WriteLine("Ingrese el número a evaluar");
            num = Convert.ToDouble(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("El número es negativo");
            }
            else
            {
                if (num == 0)
                {
                    Console.WriteLine("El número es cero");
                }
                else
                {
                    Console.WriteLine("El número es positivo");
                }

            }
        }
    }
}

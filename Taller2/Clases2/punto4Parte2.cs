using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases2
{
    class punto4Parte2
    {
        /*4.	Hacer un algoritmo que lea dos números y los imprima en orden ascendente.*/
        public void ordenAscendente()
        {
            double num1, num2;

            Console.WriteLine("Ingrese un número");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"En orden ascendente queda asi:");

            if (num1 < num2)
            {
                Console.WriteLine($"{num1}");
                Console.WriteLine($"{num2}");
            }
            else
            {
                Console.WriteLine($"{num2}");
                Console.WriteLine($"{num1}");
            }
            Console.ReadKey();
        }

    }
}

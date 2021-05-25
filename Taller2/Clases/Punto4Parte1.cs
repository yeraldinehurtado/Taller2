using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class Punto4Parte1
    {
        /*4.	Realizar un algoritmo que lea dos números e imprima la suma de los 2, 
         * en caso que el primero sea mayor al segundo*/
        public void suma()
        {
            double num1, num2, suma;

            Console.WriteLine("Ingrese un número");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                suma = num1 + num2;

                Console.WriteLine($"La suma de los dos números es: {suma}");
            }
            else
            {
                Console.WriteLine("El segundo número es mayor");
            }
            Console.ReadKey();
        }

    }
}

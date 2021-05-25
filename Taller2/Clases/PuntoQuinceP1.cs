using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class PuntoQuinceP1
    {
        /*15.	Realizar un algoritmo que lea un número y si éste es superior o igual a 10, 
         * permita imprimir su cubo.
         */
        public void numCubo()
        {
            string resp;
            Console.WriteLine("¿Desea iniciar el programa?");
            resp = Console.ReadLine();

            while (resp.Equals("si"))
            {
                double n;
                Console.WriteLine("Ingrese un número");
                n = double.Parse(Console.ReadLine());

                if (n >= 10)
                {
                    double resultado = Math.Pow(n, 3);
                    Console.WriteLine("El resultado es: " + resultado);
                }
                else
                {
                    Console.WriteLine("El número es menor que 10");
                }

                Console.WriteLine("¿Desea seguir en el programa?");
                resp = Console.ReadLine();
            }
            Console.WriteLine("Has salido del punto 15 del taller");
            Console.ReadKey();
        }
    }
}

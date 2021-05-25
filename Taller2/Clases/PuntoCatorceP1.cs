using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class PuntoCatorceP1
    {
        /*14.	Realizar un algoritmo que lea dos números e imprima la suma de los 2, 
         * en caso que el primero sea mayor al segundo.
         */
        public void sumaDosNumeros()
        {
            string resp;
            Console.WriteLine("¿Desea iniciar el programa?");
            resp = Console.ReadLine();

            while (resp.Equals("si"))
            {
                double n1, n2;

                Console.WriteLine("Ingrese el número 1");
                n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el número 2");
                n2 = double.Parse(Console.ReadLine());

                if (n1 > n2)
                {
                    double suma = n1 + n2;
                    Console.WriteLine("El resultado de la suma es: " + suma);
                }
                else
                {
                    Console.WriteLine("El primer número es menor.");
                }
                Console.WriteLine("¿Desea seguir en el programa?");
                resp = Console.ReadLine();
            }
            

            Console.WriteLine("Has salido del punto 14 del taller");
            Console.ReadKey();

        }
    }
}

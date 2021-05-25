using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class PuntoCatorceP2
    {
        /*14.	Elaborar un algoritmo que lea un número, si es par, que imprima el cubo y si es impar, 
         * que imprima el triple.
         */
        public void cuboTriple()
        {
            double cubo, triple;
            double num;
            
            Console.WriteLine("Ingrese un número");
            num = double.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                cubo = Math.Pow(num, 3);
                Console.WriteLine("El cubo de " + num + " es: " + cubo);
            }
            else if(num % 2 == 1)
            {
                triple = num * 3;
                Console.WriteLine("El triple de " + num + " es: " + triple);
            }
            Console.ReadKey();

        }
    
    }
}

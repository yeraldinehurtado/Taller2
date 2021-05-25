using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class Punto2Parte1
    {
        /*2.	Elabore un algoritmo que lea un número y si este es 
         * mayor o igual a 10 devuelva el triple de este.*/

        public void tripleNumero()
        {
            int num, triple;
            Console.WriteLine("Ingrese un número");
            num = int.Parse(Console.ReadLine());

            if (num >= 10)
            {
                triple = num * 3;
                Console.WriteLine($"El triple de {num} es {triple}");
            }
            else
            {
                Console.WriteLine("El número que ingresó es menor de 10");
            }
                
                

        }

    }
}

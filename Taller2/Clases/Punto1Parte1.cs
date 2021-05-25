using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class Punto1Parte1
    {
        /*1.	Leer un número e imprimir un mensaje en caso que sea par.*/
        public void numeroPar()
        {
            int num;
            Console.WriteLine("Ingrese un número");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("El número es par");
            else
                Console.WriteLine("El número es impar");
        }
    }
}

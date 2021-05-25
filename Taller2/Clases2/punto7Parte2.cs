using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto7Parte2
    {
        /*7.	Leer un número e imprimir un mensaje si es par o impar.
         */
        public void numeroParImpar()
        {
            double numero;

            Console.WriteLine("Ingrese un número");
            numero = double.Parse(Console.ReadLine());

            if ((numero % 2) == 0)
                Console.WriteLine("El número ingresado es par");
            else
                Console.WriteLine("El número ingresado es impar");

            Console.ReadKey();
        }

    }
}

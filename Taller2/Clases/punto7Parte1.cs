using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto7Parte1
    {
        /*7.	Leer un número e imprimir un mensaje en caso que sea negativo.*/

        public void numero()
        {
            double numero;

            Console.WriteLine("Ingrese un número");
            numero = double.Parse(Console.ReadLine());

            if (numero < 0)
                Console.WriteLine("El número ingresado es negativo");
            else
                Console.WriteLine("El número ingresado es positivo");

            Console.ReadKey();
        }

    }
}

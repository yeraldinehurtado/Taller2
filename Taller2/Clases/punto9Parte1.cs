using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto9Parte1
    {
        /*9.	Leer un número e imprimir un mensaje en caso que sea múltiplo de 5.*/

        public void numeroMensaje()
        {
            double numero;

            Console.WriteLine("Ingrese un número");
            numero = double.Parse(Console.ReadLine());

            if (numero % 5 == 0)
                Console.WriteLine("El número ingresado es multiplo de 5");

            Console.ReadKey();

        }

    }
}

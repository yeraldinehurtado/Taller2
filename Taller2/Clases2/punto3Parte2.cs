using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases2
{
    class punto3Parte2
    {
        /*3. Elabore un algoritmo que lea un número y si este es mayor o igual a 10 devuelva
         * el triple de este de lo contrario la cuarta parte de este.*/

        public void numero()
        {
            double numero, numeroFinal;
            Console.WriteLine("Ingrese un número");
            numero = double.Parse(Console.ReadLine());

            if (numero >= 10)
                numeroFinal = numero * 3;
            else
                numeroFinal = numero / 4;

            Console.WriteLine($"Número: {numeroFinal}");

            Console.ReadKey();
        }

    }
}

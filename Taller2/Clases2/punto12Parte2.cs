using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto12Parte2
    {
        /*12.	Elaborar un algoritmo que permita calcular el valor total a pagar en una papelería teniendo en cuenta que,
         * si lleva 5 cuadernos o más, se le cobrarán $2.000 por cada uno, mientras que, si lleva menos,
         * se le cobrarán $2.500 por cada uno.*/


        public void papeleria()
        {
            int cuadernos;
            double total;

            Console.WriteLine("Ingrese cuantos cuadernos se quiere llevar");
            cuadernos = int.Parse(Console.ReadLine());

            if (cuadernos >= 5)
            {
                total = cuadernos * 2000;

                Console.WriteLine($"el valor total a pagar es: {+total}");
            }
            else if (cuadernos < 5)
            {
                total = cuadernos * 2500;

                Console.WriteLine($"el valor total a pagar es: {+total}");
            }
            Console.ReadKey();
        }

    }
}

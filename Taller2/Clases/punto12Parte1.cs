using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto12Parte1
    {
        /*12.	Hacer un algoritmo que lea la estatura de una persona y si es mayor de 1.70, imprima que es alta*/

        public void estaturaImprimir()
        {
            double estatura;

            Console.WriteLine("Ingrese su altura en metros");
            estatura = double.Parse(Console.ReadLine());


            if (estatura > 1.70)
                Console.WriteLine("Usted es una persona alta");
            else
                Console.WriteLine("Usted es una persona baja");

            Console.ReadKey();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto8Parte2
    {
        /*8. Elaborar un algoritmo que permita calcular el número de pulsaciones que debe tener una persona 
         * por cada 10 segundos de ejercicio aeróbico; la fórmula que se aplica cuando el sexo es femenino, es: 
         * numpulsaciones = (220-edad)/10 y si el sexo es masculino: numpulsaciones = (210-edad)/10 */

        public void pulsaciones()
        {
            int sexo;

            double numPulsaciones, edad;

            Console.WriteLine("Ingrese su sexo, marque (1) si es Masculino, Marque (2) si es Femenino");
            sexo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());

            if (sexo == 1)
            {
                numPulsaciones = (210 - edad) / 10;
                Console.WriteLine("Sexo masculino");
                Console.WriteLine($"El número de pulsaciones que usted tiene cada 10 segundo es: {numPulsaciones}");
            }
            if (sexo == 2)
            {
                numPulsaciones = (220 - edad) / 10;
                Console.WriteLine("Sexo Femenino");
                Console.WriteLine($"El número de pulsaciones que usted tiene cada 10 segundo es: {numPulsaciones}");
            }
            Console.ReadKey();
        }

    }
}

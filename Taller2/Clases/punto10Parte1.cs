using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto10Parte1
    {
        /*10.	Leer la edad de una persona e imprimir un mensaje en caso que sea mayor de edad.*/

        public void edadMensaje()
        {
            double edad;

            Console.WriteLine("Ingrese la edad de una persona");
            edad = double.Parse(Console.ReadLine());

            if (edad >= 18)
                Console.WriteLine("la persona es mayor de edad");
            else
                Console.WriteLine("La persona es menor de edad");

            Console.ReadKey();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class PuntoDosP3
    {
        /*2.	Pedir un número N, introducir N sueldos, y mostrar el sueldo máximo.
         */
        public void sueldoMax()
        {
            int numero=0;
            int sueldo=0;
            int sueldoMaximo=0; //variable de tipo acumulador

            do
            {
                Console.WriteLine("Ingrese su sueldo");
                sueldo = int.Parse(Console.ReadLine());

                if (sueldo > sueldoMaximo)
                {
                    sueldoMaximo = sueldo;
                }

                Console.WriteLine("¿Desea salir del programa? Ingrese 0 para permanecer y 1 para salir");
                numero = int.Parse(Console.ReadLine());

            } while (numero == 0);

            Console.WriteLine("El sueldo mayor es: " + sueldoMaximo);
            Console.ReadKey();
        }


    }
}

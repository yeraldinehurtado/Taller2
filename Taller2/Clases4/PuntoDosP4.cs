using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class PuntoDosP4
    {
        /*2.	Pedir un número N, introducir N sueldos, y mostrar el sueldo máximo.
         */
        public void sueldoMaximo()
        {
            int sueldo, sueldoMaximo=0;
            int num;
            Console.WriteLine("¿Cuántos sueldos desea ingresar?");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Ingrese su sueldo");
                sueldo = int.Parse(Console.ReadLine());

                if (sueldo > sueldoMaximo)
                {
                    sueldoMaximo = sueldo;
                }
            }
            Console.WriteLine("El sueldo mayor es: " + sueldoMaximo);
            Console.ReadKey();
        }

    }
}

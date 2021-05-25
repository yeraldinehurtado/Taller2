using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto11Parte1
    {
        /*11.	Leer 4 notas, calcular el promedio e imprimir un mensaje indicando que reprobó en caso
         * que la nota sea menor a 3.5*/


        public void promedioMensaje()
        {
            double nota1, nota2, nota3, nota4, prom;

            Console.WriteLine("Ingrese la nota 1");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 2");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3");
            nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 4");
            nota4 = double.Parse(Console.ReadLine());

            prom = (nota1 + nota2 + nota3 + nota4) / 4;

            if (prom < 3.5)
                Console.WriteLine("Usted reprobó");
            else
                Console.WriteLine("Usted aprobó");

            Console.ReadKey();
        }

    }
}

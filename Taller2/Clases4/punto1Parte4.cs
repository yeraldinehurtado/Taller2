using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto1Parte4
    {
        /*1.	Realizar un programa que nos pida un número n, y nos diga cuantos números hay entre 1 y n que son primos.*/

        public void numerosPrimos4()
        {
            int n;

            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());
            bool primo;
            int cont = 0;
            for (int i = 2; i <= n; i++)
            {
                primo = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        primo = false;
                    }
                }
                if (primo)
                {
                    Console.WriteLine("# " + i);
                    cont++; ;
                }
            }
            Console.WriteLine("El total de primos es: " + cont);
            Console.ReadLine();
        }

    }
}

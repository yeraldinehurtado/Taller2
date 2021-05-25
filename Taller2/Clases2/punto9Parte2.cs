using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto9Parte2
    {
        /*9.	Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera: 
         * Si trabaja 40 horas o menos, se le paga a $10.000 la hora
         * Si trabaja más de 40 horas, se le paga $10.000 por cada una de las primeras 40 horas y $15.000 por cada una de las horas extras.*/


        public void salarioSemanal()
        {
            double horas, salario, vHora = 10000, extra, horaExtra = 15000, vhtemp;

            Console.WriteLine("ingrese las horas trabajadas por semana");
            horas = double.Parse(Console.ReadLine());

            if (horas <= 40)
            {
                salario = horas * vHora;

                Console.WriteLine($"su salario semanal es: {salario}");
            }
            else if (horas > 40)
            {
                extra = horas - 40;
                vhtemp = 40 * vHora;

                salario = (extra * horaExtra) + vhtemp;

                Console.WriteLine($"su salario semanal es: {salario}");
            }
            Console.ReadKey();
        }

    }
}

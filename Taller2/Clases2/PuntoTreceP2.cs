using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class PuntoTreceP2
    {
        /*13.	Una constructora ofrece vivienda de interés social, bajo las siguientes condiciones: 
         * Si los ingresos del comprador son iguales o superiores a $1.200.000, la cuota inicial será 
         * del 15% del valor de la vivienda y el resto, se distribuirá en 120 cuotas mensuales con un 
         * interés del 2% mensual. Si los ingresos del comprador son inferiores a $1.200.000, la cuota 
         * inicial será del 30% del valor de la vivienda y el resto, lo distribuirá en 84 cuotas mensuales 
         * con un interés del 1% mensual. La constructora desea saber cuánto debe pagar un comprador por 
         * concepto de cuota inicial y cuánto por cada cuota mensual.
         */
        public void vivienda()
        {
            double valorVivienda;
            double cuotaInicial;
            double valorMes;
            double intereses;

            Console.WriteLine("Ingrese el valor de la vivienda");
            valorVivienda = double.Parse(Console.ReadLine());

            double ingresos;
            Console.WriteLine("¿Cuántos son los ingresos del comprador?");
            ingresos = double.Parse(Console.ReadLine());

            if(ingresos>=1200000){
                cuotaInicial = valorVivienda * 0.15;
                valorMes = (valorVivienda * 0.85) / 120;
                intereses = valorMes * 0.02;
                Console.WriteLine("La cuota inicial es de: " + cuotaInicial);
                Console.WriteLine("El valor mensual a pagar es de: " + valorMes);
                Console.WriteLine("Los valor de los intereses mensuales es de: " + intereses);
                
            }
            else if (ingresos < 1200000)
            {
                cuotaInicial = valorVivienda * 0.30;
                valorMes = (valorVivienda * 0.70) / 84;
                intereses = valorMes * 0.01;
                Console.WriteLine("La cuota inicial es de: " + cuotaInicial);
                Console.WriteLine("El valor mensual a pagar es de: " + valorMes);
                Console.WriteLine("Los valor de los intereses mensuales es de: " + intereses);
            }
            Console.ReadKey();
        }
    }
}

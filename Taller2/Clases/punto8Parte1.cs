using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto8Parte1
    {
        /*8. Un hombre desea saber cuánto dinero se genera por concepto de intereses sobre 
         * la cantidad que tiene en inversión en el banco. El decidirá reinvertir los intereses 
         * siempre y cuando no excedan a $7000, y en ese caso desea saber cuánto dinero tendrá 
         * finalmente en su cuenta.*/


        public void inversionBanco()
        {
            double inversion, intereses, cantidadTot, tasaInteres;

            Console.WriteLine("Ingrese la cantidad invertida");
            inversion = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje de tasa de interes");
            tasaInteres = double.Parse(Console.ReadLine());

            intereses = inversion * (tasaInteres / 100);

            cantidadTot = inversion + intereses;

            if (intereses > 7000)
                Console.WriteLine("La cantidad generada por concepto de intereses es mayor a $7000");
            else
                Console.WriteLine("La cantidad generada por concepto de intereses es menor a $7000");

            Console.WriteLine($"Cantidad invertida: {inversion}");
            Console.WriteLine($"Intereses: {intereses}");
            Console.WriteLine($"La cantidad total que tiene en su cuenta es: {cantidadTot}");
            Console.ReadKey();
        }

    }
}

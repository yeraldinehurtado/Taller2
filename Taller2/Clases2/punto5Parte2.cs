using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto5Parte2
    {
        /*5. Determinar el precio de un pasaje de ida y vuelta por avión, 
         * conociendo la distancia a recorrer y sabiendo que esta es superior 
         * a 1.000 km, la línea aérea le hace un descuento del 30%. El precio 
         * por kilómetro es de $150. */

        public void pasajeAvion()
        {
            double distancia, descuento, precioKM = 150, precioPasaje, precioConDesc;

            Console.WriteLine("Ingrese los kilometros a recorrer");
            distancia = double.Parse(Console.ReadLine());

            precioPasaje = distancia * precioKM;

            descuento = precioPasaje * 0.30;

            precioConDesc = precioPasaje - descuento;

            if (distancia > 1000)
            {
                Console.WriteLine($"Precio del pasaje sin descuento: {precioPasaje}");
                Console.WriteLine($"Valor descuento: {descuento}");
                Console.WriteLine($"El precio del pasaje es: {precioConDesc}");
            }
            else
                Console.WriteLine($"El precio del pasaje es: {precioPasaje}");

            Console.ReadKey();
        }

    }
}

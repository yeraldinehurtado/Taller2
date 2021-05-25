using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto3Parte1
    {
        /*3. Un proveedor de computadores ofrece descuento del 10%, si cuesta $1.000.000 o más. 
         * Determinar cuánto pagará, con IVA incluido (19%),un cliente si la compra cumple con esta condición. */

        public void PrecioPc()
        {
            double precio, iva, dcto, valorTotal;
            String nombre;

            Console.WriteLine("Ingrese el nombre de la computadora");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio de la computadora");
            precio = double.Parse(Console.ReadLine());

            iva = precio * 0.19;

            dcto = 0;

            if (precio >= 1000000)
            {
                dcto = precio * 0.1;
                valorTotal = precio + iva - dcto;
            }
            else
                valorTotal = precio + iva;

            Console.WriteLine($"Modelo: {nombre}");
            Console.WriteLine($"Iva:: {iva}");
            Console.WriteLine($"Descuento: {dcto}");
            Console.WriteLine($"Valor total de la compra: {valorTotal}");

            Console.ReadKey();
        }

    }
}

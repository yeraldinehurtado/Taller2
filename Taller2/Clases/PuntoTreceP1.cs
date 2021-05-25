using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class PuntoTreceP1
    {
        /*13.	Un proveedor de computadores ofrece descuento del 10%, si cuesta $1.000.000 o más. 
         * Determinar cuánto pagará, con IVA incluido (19%), un cliente cualquiera por la compra de una computadora.
         */

        public void ValorTotal()
        {
            string resp;
            Console.WriteLine("¿Desea ingresar un nuevo valor?");
            resp = Console.ReadLine();

            while (resp.Equals("si"))
            {
                int valor;
                Console.WriteLine("Ingrese el valor de la computadora.");
                valor = int.Parse(Console.ReadLine());

                double iva = valor * 0.19;
                double precio = valor + iva;

                if (valor >= 1000000)
                {
                    double descuento = precio * 0.1;
                    double precioTotal = precio - descuento;
                    Console.WriteLine("El valor a pagar por la computadora es: " + precioTotal);
                }
                else
                {
                    Console.WriteLine("No hay descuento, el valor a pagar por la computadora es: " + precio);
                }

                Console.WriteLine("¿Desea ingresar un nuevo valor?");
                resp = Console.ReadLine();

            }

            Console.WriteLine("Has salido del punto 13 del taller");
            Console.ReadKey();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto5Parte1
    {
        /*5.	En un almacén se hace un 20% de descuento a los clientes cuya compra sea superior a 
         * $100.000. ¿Cuánto deberá pagar cada cliente?
         */

        public void pagoCompra()
        {
            double descuento, valorCondicion = 100000, pago, valorCompra;

            Console.WriteLine("El valor a ingresar debe ser diferente de 0");
            Console.WriteLine("Ingrese el valor de su compra");
            valorCompra = double.Parse(Console.ReadLine());

            while (valorCompra != 0)
            {
                if (valorCompra > valorCondicion)
                {

                    descuento = valorCompra * 0.20;
                    pago = valorCompra - descuento;
                    Console.WriteLine($"El descuento es de: {descuento} pesos");
                    Console.WriteLine($"El total a pagar es: {pago} pesos");
                }
                else
                {
                    Console.WriteLine($"El total a pagar es: {valorCompra} pesos");

                }
                Console.WriteLine("Ingrese el valor de su compra");
                valorCompra = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("El programa a terminado");

            Console.ReadKey();

        }
    }
}
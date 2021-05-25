using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class PuntoQuinceP2
    {
        /*15.	En un almacén se hace un 17% de descuento a los clientes cuya compra sea superior 
         * a $200.000, para las compras inferiores, el descuento será del 5%. ¿Cuánto deberá pagar cada cliente?
         */
        public void almacenDescuento()
        {
            double descuento, valorPagar;
            double valorCompra;
            Console.WriteLine("Ingrese el valor de la compra");
            valorCompra = double.Parse(Console.ReadLine());

            if (valorCompra >= 200000)
            {
                descuento = valorCompra * 0.17;
                valorPagar = valorCompra - descuento;
                Console.WriteLine("El cliente debe pagar: "+valorPagar);
            }
            else if (valorCompra < 200000)
            {
                descuento = valorCompra * 0.05;
                valorPagar = valorCompra - descuento;
                Console.WriteLine("El cliente debe pagar: " + valorPagar);
            }
            Console.ReadKey();
        }
    }
}

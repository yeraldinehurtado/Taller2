using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto11Parte2
    {
        /*11.	Una empresa desea hacer una compra de varias piezas de la misma clase a una fábrica.
         * La empresa, dependiendo del valor de la compra, decidirá la forma en que le pagará al fabricante.
         * Si el valor de la compra excede o es igual a $5.000.000, la empresa tendrá la capacidad de pagar con recursos
         * propios el 55% del valor de la compra, pedirá prestado a un banco el 30% y el resto lo pagará solicitando
         * un crédito al fabricante. Si el monto total de la compra no excede de $5.000.000, la empresa tendrá la capacidad
         * de pagar con recursos propios un 70% y el 30% restante, lo pagará solicitando un crédito al fabricante.
         * El fabricante cobra un 15% de interés sobre la cantidad que le pague a crédito.*/

        public void empresaCompra()
        {
            int nPiezas;
            double costo, total, inversion, banco, credito, interes;

            Console.WriteLine("Ingresa el número de piezas");
            nPiezas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el costo de la pieza");
            costo = int.Parse(Console.ReadLine());

            total = nPiezas * costo;

            if (total >= 5000000)
            {
                inversion = total * 0.55;

                banco = total * 0.30;

                credito = total * 0.15;

                interes = credito * 0.15;

                Console.WriteLine($"la inversión de la empresa es de: {+inversion}");
                Console.WriteLine($"El préstamo del banco es de: {+banco}");
                Console.WriteLine($"El crédito a pagar es por: {+credito}");
                Console.WriteLine($"El interés por el crédito es: {+interes}");

            }
            else if (total < 5000000)
            {
                inversion = total * 0.70;

                credito = total * 0.30;

                interes = credito * 0.15;

                Console.WriteLine($"la inversión de la empresa es de: {+inversion}");
                Console.WriteLine($"El crédito a pagar es por: {+credito}");
                Console.WriteLine($"El interés por el crédito es: {+interes}");
            }
            Console.ReadKey();
        }

    }
}

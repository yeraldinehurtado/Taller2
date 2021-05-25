using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases2
{
    class Punto2Parte2
    {
        /*2.	Hacer un algoritmo que calcule el total a pagar por la compra de camisas. 
         * Si se compran tres camisas o más se aplica un descuento del 20% sobre el total 
         * de la compra y si son menos de tres camisas un descuento del 10%*/

        public void camisas()
        {
            int valorCamisa, cantidadCamisas, valor;
            double descuento, valorTotal;
            Console.WriteLine("Ingrese el valor de la camisa");
            valorCamisa = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de camisas que va a comprar.");
            cantidadCamisas = int.Parse(Console.ReadLine());

            if(cantidadCamisas >= 3)
            {
                valor = valorCamisa * cantidadCamisas;
                descuento = valor * 0.20;
                valorTotal = valor - descuento;

                Console.WriteLine($"El valor a pagar con descuento de 20% es {valorTotal}");
            }
            else if(cantidadCamisas < 3)
            {
                valor = valorCamisa * cantidadCamisas;
                descuento = valor * 0.10;
                valorTotal = valor - descuento;

                Console.WriteLine($"El valor a pagar con descuento de 10% es {valorTotal}");
            }
            else
            {
                Console.WriteLine("Ingresó un número no válido");
            }
        }
    }
}

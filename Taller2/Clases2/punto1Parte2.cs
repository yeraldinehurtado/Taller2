using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases2
{
    class punto1Parte2
    {
        /*1. Hacer un algoritmo que imprima el nombre de un artículo, clave, precio original y su precio con descuento. 
         * El descuento lo hace en base a la clave, si la clave es 01 el descuento es del 10% y si la clave es 02 el 
         * descuento es del 20% (solo existen dos claves).*/
        public void articulo()
        {
            int clave, clave1 = 01, clave2 = 02;

            var respuesta = "si";

            Console.WriteLine("Ingrese la clave correspondiente al articulo: (01) o (02)");
            clave = int.Parse(Console.ReadLine());

            while (!(clave == clave1 || clave == clave2))
            {
                Console.WriteLine("La clave ingresada no existe" +
                    "Ingrese de nuevo la clave correspondiente al articulo: (01) o (02)");
                clave = int.Parse(Console.ReadLine());
            }
            while (respuesta.Equals("si"))
            {
                string nombre;
                double precio, dcto, precioTotal;

                Console.WriteLine("Ingrese el nombre del articulo");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el precio del articulo");
                precio = double.Parse(Console.ReadLine());
                precioTotal = 0;
                if (clave == clave1)
                {
                    dcto = precio * 0.1;
                    precioTotal = precio - dcto;
                }
                else if (clave == clave2)
                {
                    dcto = precio * 0.2;
                    precioTotal = precio - dcto;
                }
                Console.WriteLine($"Nombre articulo: {nombre}");
                Console.WriteLine($"Clave: {clave}");
                Console.WriteLine($"Precio: {precio}");
                Console.WriteLine($"Precio con descuento: {precioTotal}");

                Console.WriteLine("desea continuar ingresando articulos (si)");
                respuesta = Console.ReadLine();
                if (respuesta == "si")
                {
                    Console.WriteLine("Ingrese la clave correspondiente al articulo: (01) o (02)");
                    clave = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("Programa terminado");
            Console.ReadKey();
        }

    }
}

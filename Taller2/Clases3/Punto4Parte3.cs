using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases3
{
    class Punto4Parte3
    {
        /*4.	Pedir al usuario que ingrese una letra cualquiera del abecedario 
         * y mostrar por consola si se trata de un vocal o una consonante.*/

        public void vocalConsonante()
        {
            var resp = "si";
            while (resp == "si")
            {
                var letra="";
                Console.WriteLine("Ingrese una letra cualquiera del abecedario");
                letra = Console.ReadLine();

                if (letra.Equals("a") || letra.Equals("e") || letra.Equals("i") || letra.Equals("o") || letra.Equals("u"))
                    Console.WriteLine("La letra es una vocal");
                else
                    Console.WriteLine("La letra es una consonante");

                Console.WriteLine("¿Desea seguir ingresando letras?(si o no)");
                resp = Console.ReadLine();
            }


        }

    }
}

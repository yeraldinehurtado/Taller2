using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases4
{
    class punto4Parte4
    {
        /*4.	Pedir al usuario que ingrese una letra cualquiera del abecedario y mostrar por consola
         * si se trata de un vocal o una consonante.*/

        public void abecedario()
        {
            int i;
            for (i = 1; i <= 3; i++)
            {
                var letra = "";
                Console.WriteLine("Ingrese una letra cualquiera del abecedario");
                letra = Console.ReadLine();

                if (letra.Equals("a") || letra.Equals("e") || letra.Equals("i") || letra.Equals("o") ||
                    letra.Equals("u"))
                    Console.WriteLine("La letra es una vocal");
                else
                    Console.WriteLine("La letra es una consonante");

                Console.ReadKey();
            }
        }

    }
}

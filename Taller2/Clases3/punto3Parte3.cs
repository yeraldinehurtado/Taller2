using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Clases
{
    class punto3Parte3
    {
        /*3. Pedir un número de 0 a 99 y mostrarlo escrito. Por ejemplo, para 56 mostrar: cincuenta y seis. 
         * Pista: separar las unidades y las decenas. (unidades = num % 10; decenas = num / 10).*/

        public void numerosEscritos()
        {
            int numero, dec, uni;
            String decena = "", unidad = "";
            var respuesta = "si";
            Console.WriteLine("Ingrese un número de una o dos cifras");
            numero = int.Parse(Console.ReadLine());

            while (respuesta.Equals("si"))
            {
                if (numero > 1 && numero < 100)
                {
                    if (numero > 10 && numero < 16)
                    {
                        switch (numero)
                        {
                            case 11:
                                Console.WriteLine("ONCE");
                                break;
                            case 12:
                                Console.WriteLine("DOCE");
                                break;
                            case 13:
                                Console.WriteLine("TRECE");
                                break;
                            case 14:
                                Console.WriteLine("CATORCE");
                                break;
                            case 15:
                                Console.WriteLine(" QUINCE");
                                break;
                        }
                    }
                    else
                    {
                        dec = (numero - (numero % 10)) / 10;
                        uni = numero % 10;
                        switch (dec)
                        {
                            case 1:
                                decena = "DIEZ";
                                break;
                            case 2:
                                decena = "VEINTE";
                                break;
                            case 3:
                                decena = "TREINTA";
                                break;
                            case 4:
                                decena = "CUARENTA";
                                break;
                            case 5:
                                decena = "CINCUENTA";
                                break;
                            case 6:
                                decena = "SESENTA";
                                break;
                            case 7:
                                decena = "SETENTA";
                                break;
                            case 8:
                                decena = "OCHENTA";
                                break;
                            case 9:
                                decena = "NOVENTA";
                                break;
                        }
                        if (uni != 0)
                        {
                            switch (uni)
                            {
                                case 1:
                                    unidad = "UNO";
                                    break;
                                case 2:
                                    unidad = "DOS";
                                    break;
                                case 3:
                                    unidad = "TRES";
                                    break;
                                case 4:
                                    unidad = "CUATRO";
                                    break;
                                case 5:
                                    unidad = "CINCO";
                                    break;
                                case 6:
                                    unidad = "SEIS";
                                    break;
                                case 7:
                                    unidad = "SIETE";
                                    break;
                                case 8:
                                    unidad = "OCHO";
                                    break;
                                case 9:
                                    unidad = "NUEVE";
                                    break;
                            }
                            if (dec == 1)
                            {
                                decena = "DIECI";
                            }
                            if (dec == 2)
                            {
                                decena = "VENTI";
                            }
                            if (dec > 2 && dec < 10)
                            {
                                Console.WriteLine($"{decena} Y {unidad}");
                            }
                            else
                            {
                                Console.WriteLine($"{decena}  {unidad}");
                            }
                        }
                        else
                            Console.WriteLine("DECENA");
                    }
                }
                else
                    Console.WriteLine("NÚMERO INCORRECTO");
                Console.WriteLine("¿Desea seguir ingresando números? Ingrese (si) para continuar");
                respuesta = Console.ReadLine();
                if (respuesta.Equals("si"))
                {
                    Console.WriteLine("Ingrese un número de una o dos cifras");
                    numero = int.Parse(Console.ReadLine());
                }
                else
                    Console.WriteLine("Programa terminado");
            }
            Console.ReadKey();
        }

    }
}
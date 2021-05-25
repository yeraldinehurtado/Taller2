using System;
using Taller2.Clases;
using Taller2.Clases2;
using Taller2.Clases3;
using Taller2.Clases4;

namespace Taller2
{
    class Program
    {
        static void Main(string[] args)
        {
            var resp = "si";

            while (resp.Equals("si"))
            {
                int punto, parte;
                Console.WriteLine("Ingrese que punto desea ejecutar");
                punto = int.Parse(Console.ReadLine());
                Console.WriteLine("\nIngrese la parte del punto que desea ejecutar");
                parte = int.Parse(Console.ReadLine());

                if (punto == 1 && parte == 1)
                {
                    Console.WriteLine("Punto 1 parte 1");
                    var punto1Parte1 = new Punto1Parte1();
                    punto1Parte1.numeroPar();

                }
                else if(punto == 2 && parte == 1)
                {
                    Console.WriteLine("Punto 2 parte 1");
                    var punto2Parte1 = new Punto2Parte1();
                    punto2Parte1.tripleNumero();
                }
                else if (punto == 3 && parte == 1)
                {
                    Console.WriteLine("Punto 3 parte 1");
                    var punto3parte1 = new punto3Parte1();
                    punto3parte1.PrecioPc();
                }
                else if (punto == 4 && parte == 1)
                {
                    Console.WriteLine("Punto 4 parte 1");
                    var punto4Parte1 = new Punto4Parte1();
                    punto4Parte1.suma();
                }
                else if (punto == 5 && parte == 1)
                {
                    Console.WriteLine("Punto 5 parte 1");
                    var punto5Parte1 = new punto5Parte1();
                    punto5Parte1.pagoCompra();
                }
                else if(punto == 6 && parte == 1)
                {
                    Console.WriteLine("Punto 6 parte 1");
                    var punto6Parte1 = new punto6Parte1();
                    punto6Parte1.salarioEmp();
                }
                else if (punto == 7 && parte == 1)
                {
                    Console.WriteLine("Punto 7 parte 1");
                    var punto7Parte1 = new punto7Parte1();
                    punto7Parte1.numero();
                }
                else if (punto == 8 && parte == 1)
                {
                    Console.WriteLine("Punto 8 parte 1");
                    var punto8Parte1 = new punto8Parte1();
                    punto8Parte1.inversionBanco();
                }
                else if (punto == 9 && parte == 1)
                {
                    Console.WriteLine("Punto 9 parte 1");
                    var punto9Parte1 = new punto9Parte1();
                    punto9Parte1.numeroMensaje();
                }
                else if (punto == 10 && parte == 1)
                {
                    Console.WriteLine("Punto 10 parte 1");
                    var punto10Parte1 = new punto10Parte1();
                    punto10Parte1.edadMensaje();
                }
                else if (punto == 11 && parte == 1)
                {
                    Console.WriteLine("Punto 11 parte 1");
                    var punto11Parte1 = new punto11Parte1();
                    punto11Parte1.promedioMensaje();
                }
                else if (punto == 12 && parte == 1)
                {
                    Console.WriteLine("Punto 12 parte 1");
                    var punto12Parte1 = new punto12Parte1();
                    punto12Parte1.estaturaImprimir();
                }
                else if (punto == 13 && parte == 1)
                {
                    Console.WriteLine("Punto 13 parte 1");
                    var PuntoTreceP1 = new PuntoTreceP1();
                    PuntoTreceP1.ValorTotal();
                }
                else if (punto == 14 && parte == 1)
                {
                    Console.WriteLine("Punto 14 parte 1");
                    var PuntoCatorceP1 = new PuntoCatorceP1();
                    PuntoCatorceP1.sumaDosNumeros();
                }
                else if (punto == 15 && parte == 1)
                {
                    Console.WriteLine("Punto 15 parte 1");
                    var PuntoQuinceP1 = new PuntoQuinceP1();
                    PuntoQuinceP1.numCubo();
                }
                else if (punto == 1 && parte == 2) 
                {
                    Console.WriteLine("Punto 1 parte 2");
                    var punto1parte2 = new punto1Parte2();
                    punto1parte2.articulo();
                }
                else if (punto == 2 && parte == 2)
                {
                    Console.WriteLine("Punto 2 parte 2");
                    var punto2Parte2 = new Punto2Parte2();
                    punto2Parte2.camisas();
                }
                else if(punto == 3 && parte == 2)
                {
                    Console.WriteLine("Punto 3 parte 2");
                    var punto3parte2 = new punto3Parte2();
                    punto3parte2.numero();
                }
                else if (punto == 4 && parte == 2)
                {
                    Console.WriteLine("Punto 4 parte 2");
                    var punto4parte2 = new punto4Parte2();
                    punto4parte2.ordenAscendente();
                }
                else if (punto == 5 && parte == 2)
                {
                    Console.WriteLine("Punto 5 parte 2");
                    var punto5Parte2 = new punto5Parte2();
                    punto5Parte2.pasajeAvion();
                }
                else if (punto == 6 && parte == 2)
                {
                    Console.WriteLine("Punto 6 parte 2");
                    var punto6Parte2 = new punto6Parte2();
                    punto6Parte2.salarioEmpleado2();
                }
                else if (punto == 7 && parte == 2)
                {
                    Console.WriteLine("Punto 7 parte 2");
                    var punto7Parte2 = new punto7Parte2();
                    punto7Parte2.numeroParImpar();
                }
                else if (punto == 8 && parte == 2)
                {
                    Console.WriteLine("Punto 8 parte 2");
                    var punto8Parte2 = new punto8Parte2();
                    punto8Parte2.pulsaciones();
                }
                else if (punto == 9 && parte == 2)
                {
                    Console.WriteLine("Punto 9 parte 2");
                    var punto9Parte2 = new punto9Parte2();
                    punto9Parte2.salarioSemanal();
                }
                else if (punto == 10 && parte == 2)
                {
                    Console.WriteLine("Punto 10 parte 2");
                    var punto10Parte2 = new punto10Parte2();
                    punto10Parte2.calorias();
                }
                else if (punto == 11 && parte == 2)
                {
                    Console.WriteLine("Punto 11 parte 2");
                    var punto11Parte2 = new punto11Parte2();
                    punto11Parte2.empresaCompra();
                }
                else if (punto == 12 && parte == 2)
                {
                    Console.WriteLine("Punto 12 parte 2");
                    var punto12Parte2 = new punto12Parte2();
                    punto12Parte2.papeleria();
                }
                else if (punto == 13 && parte == 2)
                {
                    Console.WriteLine("Punto 13 parte 2");
                    var PuntoTreceP2 = new PuntoTreceP2();
                    PuntoTreceP2.vivienda();
                }
                else if (punto == 14 && parte == 2)
                {
                    Console.WriteLine("Punto 14 parte 2");
                    var PuntoCatorceP2 = new PuntoCatorceP2();
                    PuntoCatorceP2.cuboTriple();
                }
                else if (punto == 15 && parte == 2)
                {
                    Console.WriteLine("Punto 15 parte 2");
                    var PuntoQuinceP2 = new PuntoQuinceP2();
                    PuntoQuinceP2.almacenDescuento();
                }
                else if (punto == 1 && parte == 3)
                {
                    Console.WriteLine("Punto 1 parte 3");
                    var punto1Parte3 = new punto1Parte3();
                    punto1Parte3.numerosPrimos();
                }
                else if (punto == 2 && parte == 3)
                {
                    Console.WriteLine("Punto 2 parte 3");
                    var PuntoDosP3 = new PuntoDosP3();
                    PuntoDosP3.sueldoMax();
                }
                else if (punto == 3 && parte == 3)
                {
                    Console.WriteLine("Punto 3 parte 3");
                    var punto3Parte3 = new punto3Parte3();
                    punto3Parte3.numerosEscritos();
                }
                else if (punto == 4 && parte == 3)
                {
                    Console.WriteLine("Punto 4 parte 3");
                    var punto4Parte3 = new Punto4Parte3();
                    punto4Parte3.vocalConsonante();
                }
                else if (punto == 1 && parte == 4)
                {
                    Console.WriteLine("Punto 1 parte 4");
                    var punto1Parte4 = new punto1Parte4();
                    punto1Parte4.numerosPrimos4();
                }
                else if (punto == 2 && parte == 4)
                {
                    Console.WriteLine("Punto 2 parte 4");
                    var PuntoDosP4 = new PuntoDosP4();
                    PuntoDosP4.sueldoMaximo();
                }
                else if (punto == 3 && parte == 4)
                {
                    Console.WriteLine("Punto 3 parte 4");
                    var punto3parte4 = new punto3Parte4();
                    punto3parte4.numerosEscritos();
                }
                else if (punto == 4 && parte == 4)
                {
                    Console.WriteLine("Punto 4 parte 4");
                    var punto4parte4 = new punto4Parte4();
                    punto4parte4.abecedario();
                }
                else
                {
                    Console.WriteLine("No se encontró el punto:(");
                }

                Console.WriteLine("¿Desea continuar? (si o no)");
                resp = Console.ReadLine();


            }
            

        }
    }
}

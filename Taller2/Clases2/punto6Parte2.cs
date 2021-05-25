using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto6Parte2
    {
        /*6. Calcular e imprimir el salario de un empleado, teniendo en cuenta 
         * que si el salario bruto es igual o superior a $2.000.000, debe hacerse 
         * una retención del 10%, si el salario es inferior, la retención será del 3%. */


        public void salarioEmpleado2()
        {
            double condicion = 2000000, valorHora, salarioBruto, retencion, salarioNeto;
            int horasTrabajadas;

            Console.WriteLine("Ingrese las horas trabajadas durante el mes");
            horasTrabajadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor hora");
            valorHora = double.Parse(Console.ReadLine());

            salarioBruto = horasTrabajadas * valorHora;

            if (salarioBruto >= condicion)
            {
                retencion = salarioBruto * 0.1;

                salarioNeto = salarioBruto - retencion;

                Console.WriteLine($"Salario Bruto: {salarioBruto}");
                Console.WriteLine($"Rentención: {retencion}");
                Console.WriteLine($"Salario Neto: {salarioNeto}");
            }
            else
            {
                retencion = salarioBruto * 0.03;

                salarioNeto = salarioBruto - retencion;

                Console.WriteLine($"Salario Bruto: {salarioBruto}");
                Console.WriteLine($"Rentención: {retencion}");
                Console.WriteLine($"Salario Neto: {salarioNeto}");
            }
            Console.ReadKey();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto6Parte1
    {
        /*6.	Calcular el salario de un empleado, teniendo en cuenta que si el 
          salario bruto es superior a $2.000.000, debe hacerse una retención del 10%.
         */

        public void salarioEmp()
        {
            double condicion = 2000000, valorHora, salarioBruto, retencion, salarioNeto;
            int horasTrabajadas;

            Console.WriteLine("Ingrese las horas trabajadas durante el mes");
            horasTrabajadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor hora");
            valorHora = double.Parse(Console.ReadLine());

            salarioBruto = horasTrabajadas * valorHora;

            retencion = salarioBruto * 0.1;

            salarioNeto = salarioBruto - retencion;

            if (salarioBruto > condicion)
            {
                Console.WriteLine($"Salario bruto: {salarioBruto}");
                Console.WriteLine($"Retención: {retencion}");
                Console.WriteLine($"Salario Neto: {salarioNeto}");
            }
            else
            {
                Console.WriteLine($"Salario Neto: {salarioBruto}");
            }
            Console.ReadKey();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Clases
{
    class punto10Parte2
    {
        /*10.	Una persona enferma y cuyo peso es 70 kg, se encuentra en reposo y desea saber cuántas calorías consume su cuerpo
         * durante el tiempo que realice una misma actividad.Las actividades que puede realizar son únicamente dormir o estar sentado.
         * Los datos que tiene son que estando dormido consume 1.08 calorías por minuto y estando sentado en reposo
         * consume 1.66 calorías por minuto.*/


        public void calorias()
        {
            int opcion, tiempo;
            double calorias;

            Console.WriteLine("ingrese (1) si esta durmiendo, ingrese (2) si esta sentado");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("ingrese el tiempo en minutos que estuvo durmiendo");
                tiempo = int.Parse(Console.ReadLine());

                calorias = tiempo * 1.08;

                Console.WriteLine($"las calorias consumidas mientras dormia fueron: {+calorias}");
            }
            else if (opcion == 2)
            {
                Console.WriteLine("ingrese el tiempo en minutos que estuvo sentado");
                tiempo = int.Parse(Console.ReadLine());

                calorias = tiempo * 1.66;

                Console.WriteLine($"las calorias consumidas mientras estaba sentado fueron: {+calorias}");
            }
            Console.ReadKey();
        }

    }
}

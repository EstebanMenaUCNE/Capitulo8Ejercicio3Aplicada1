using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo8Ejercicio3
{
    class Program
    {
        //Hacer un programa que muestre la hora del día en formato AM/FM seguida del año, el día y el mes actual.
        static void Main(string[] args)
        {
            DateTime horaFecha = DateTime.Now;
            Console.WriteLine("La hora y fecha actuales son: {0: h:mm tt yyyy/m/d}", horaFecha);
            Console.ReadKey();
        }
    }
}

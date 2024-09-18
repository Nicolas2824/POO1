using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_04
{
    internal class Program
    {
       static void Main(string[] args)
        {
            Obrero obrero = new Obrero(101, "Nicolas", 160, 50.00);

            Console.WriteLine("Datos actuales:");
            Obrero.Listado(obrero);
            obrero.Horas_trabajadas += 8;
            obrero.Tarifa_hora -= obrero.Horas_trabajadas * 0.015;
            Console.WriteLine("Datos actualizados:");
            Obrero.Listado(obrero);
        }


    }
}

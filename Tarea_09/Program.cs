using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_09
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Pelota pelota = new Pelota("Puma", 450, 10, 22, 120.0);
            Console.WriteLine("Datos iniciales de la pelota:");
            Pelota.Listado(pelota);
            pelota.Precio *= 0.75;
            pelota.DiametroCentimetros += 1;
            Console.WriteLine("Datos después de modificar precio y diámetro:");
            Pelota.Listado(pelota);

            Console.ReadKey();
        }

    }
}

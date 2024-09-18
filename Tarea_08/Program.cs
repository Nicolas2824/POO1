using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_08
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Asesor ase = new Asesor(282828, "Nicolás", 30, 20);

            Console.WriteLine("Datos actuales: ");
            Asesor.Listado(ase);
            ase.Horas_trabajadas += 10;
            ase.Tarifa_hora -= ase.Tarifa_hora * 0.15;
            Asesor.Listado(ase);
        }
    }
}

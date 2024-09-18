using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_06
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Paciente paciente = new Paciente("Nicolás", "Pérez", 17, 1.81, 80.0);
            Console.WriteLine("Datos iniciales del paciente : ");
            Paciente.Listado(paciente);
            paciente.Edad = 20;
            Console.WriteLine("Datos después de modificar la edad : ");
            Paciente.Listado(paciente);

            Console.ReadKey();
        }

    }
}

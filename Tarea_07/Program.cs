using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_07
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Empleado empleado = new Empleado(2828, "Nicolás Pérez", 923495517, 3300);
            Console.WriteLine("Datos iniciales del empleado:");
            Empleado.Listado(empleado);
            empleado.Numero_celular = 999888777;
            empleado.Sueldo_soles += 200;
            Console.WriteLine("Datos después de modificar el número de celular y el sueldo:");
            Empleado.Listado(empleado);

            Console.ReadKey();
        }

    }
}

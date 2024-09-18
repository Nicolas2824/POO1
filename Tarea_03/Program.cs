using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_03
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Edificio edificio = new Edificio(101, 50, 7, 200);

            Console.WriteLine("Datos actuales:");
            Edificio.Listado(edificio);
            edificio.Precio_departamento += 0.2 * edificio.Precio_departamento;
            Console.WriteLine("Datos actualizados:");
            Edificio.Listado(edificio);

            Console.ReadKey();

        }

    }
}

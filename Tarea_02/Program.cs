using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_02
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Computadora computadora = new Computadora(101, "Lenovo", "Azul", 800.00);
            Console.WriteLine("Datos iniciales de la computadora:");
            Computadora.Listado(computadora);
            computadora.Precio_dolares *= 0.90;
            Console.WriteLine("Datos después de la reducción del precio:");
            Computadora.Listado(computadora);
            Console.ReadKey();


        }

    }
}

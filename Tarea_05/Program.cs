using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_05
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Video video = new Video(5461, "El arte de la guerra", 70, 30, 20);

            Console.WriteLine("Datos iniciales : ");
            Video.Listado(video);
            video.Precio_soles += 5.50;
            Console.WriteLine("Datos despues del aumento de precio : ");
            Video.Listado(video);

            Console.ReadKey();
        }

    }
}

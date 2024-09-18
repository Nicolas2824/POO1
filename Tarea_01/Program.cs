using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //creacion del objeto celular
            Celular celular = new Celular(923495517, 30, "Nicolás", 120);
            //mostrar los datos actuales
            Console.WriteLine("Datos actuales:");
            Celular.Listado(celular);
            //modificando los atributos del objeto celular
            celular.Segundos_consumidos += 20;
            celular.Precio_segundo -= celular.Precio_segundo * 0.05;
            //mostrando datos actualizados
            Console.WriteLine("Datos actualizados:");
            Celular.Listado(celular);

            Console.ReadKey();
        }

    }
}

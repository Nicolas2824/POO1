using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_05
{
    internal class Video
    {

        private int codigo;
        private string nombre;
        private double duracion;
        private double precio_soles;
        private double tipo_cambio;

        public Video(int codigo, string nombre, double duracion, double precio_soles, double tipo_cambio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.duracion = duracion;
            this.precio_soles = precio_soles;
            this.tipo_cambio = tipo_cambio;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public double Precio_soles
        {
            get { return precio_soles; }
            set { precio_soles = value; }
        }

        public double Tipo_cambio
        {
            get { return tipo_cambio; }
            set { tipo_cambio = value; }
        }

        public double PrecioDolares()
        {
            return precio_soles / tipo_cambio;
        }

        public static void Listado(Video video)
        {
            Console.WriteLine("\n--- Datos del Video ---");
            Console.WriteLine("Código: " + video.codigo);
            Console.WriteLine("Nombre: " + video.nombre);
            Console.WriteLine("Duración: " + video.duracion + " minutos");
            Console.WriteLine("Precio en soles: S/ " + video.precio_soles);
            Console.WriteLine("Precio en dólares: $ " + video.PrecioDolares());
            Console.WriteLine("----------------------------\n");
        }

    }
}

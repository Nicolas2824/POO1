using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_06
{
    internal class Paciente
    {

        private string nombre;
        private string apellido;
        private int edad;
        private double talla;
        private double peso;


        public Paciente(string nombre, string apellido, int edad, double talla, double peso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.talla = talla;
            this.peso = peso;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public double Talla
        {
            get { return talla; }
            set { talla = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public string VerificarEdad()
        {
            if (edad < 18)
            {
                return "Menor de edad";
            }
            else
                return "Mayor de edad";
        }

        public static void Listado(Paciente paciente)
        {
            Console.WriteLine("\n--- Datos del Paciente ---");
            Console.WriteLine("Nombre: " + paciente.nombre);
            Console.WriteLine("Apellido: " + paciente.apellido);
            Console.WriteLine("Edad: " + paciente.edad + " (" + paciente.VerificarEdad() + ")");
            Console.WriteLine("Talla: " + paciente.talla + " metros");
            Console.WriteLine("Peso: " + paciente.peso + " kg");
            Console.WriteLine("----------------------------\n");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_07
{
    internal class Empleado
    {

        private int codigo;
        private string nombre;
        private int numero_celular;
        private double sueldo_soles;
        public Empleado(int codigo, string nombre, int numero_celular, double sueldo_soles)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.numero_celular = numero_celular;
            this.sueldo_soles = sueldo_soles;
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

        public int Numero_celular
        {
            get { return numero_celular; }
            set { numero_celular = value; }
        }

        public double Sueldo_soles
        {
            get { return sueldo_soles; }
            set { sueldo_soles = value; }
        }

        public string EvaluarSueldo()
        {
            if (sueldo_soles > 3500)
            {
                return "mayor a 3500";
            }else if (sueldo_soles < 3500)
            {
                return "menor a 3500";
            }else{
                return "igual a 3500";
            }
        }
        public static void Listado(Empleado empleado)
        {
            Console.WriteLine("\n--- Datos del Empleado ---");
            Console.WriteLine("Código: " + empleado.codigo);
            Console.WriteLine("Nombre: " + empleado.nombre);
            Console.WriteLine("Número de Celular: " + empleado.numero_celular);
            Console.WriteLine("Sueldo en soles: S/ " + empleado.sueldo_soles + " (" + empleado.EvaluarSueldo() + ")");
            Console.WriteLine("----------------------------\n");
        }

    }
}

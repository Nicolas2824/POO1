using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_04
{
    internal class Obrero
    {

        private int codigo;
        private string nombre;
        private int horas_trabajadas;
        private double tarifa_hora;


        public Obrero(int codigo, string nombre, int horas_trabajadas, double tarifa_hora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horas_trabajadas = horas_trabajadas;
            this.tarifa_hora = tarifa_hora;
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

        public int Horas_trabajadas
        {
            get { return horas_trabajadas; }
            set { horas_trabajadas = value; }
        }

        public double Tarifa_hora
        {
            get { return tarifa_hora; }
            set { tarifa_hora = value; }
        }

        public double SueldoBruto()
        {
            return horas_trabajadas * tarifa_hora;
        }

        public double DescuentoAFP()
        {
            return SueldoBruto() * 0.10;
        }

        public double DescuentoEPS()
        {
            return SueldoBruto() * 0.05;
        }

        public double SueldoNeto()
        {
            return SueldoBruto() - DescuentoAFP() - DescuentoEPS();
        }

        public static void Listado(Obrero obrero)
        {
            Console.WriteLine("\n--- Datos del Obrero ---");
            Console.WriteLine("Código: " + obrero.codigo);
            Console.WriteLine("Nombre: " + obrero.nombre);
            Console.WriteLine("Horas trabajadas: " + obrero.horas_trabajadas);
            Console.WriteLine("Tarifa por hora: $" + obrero.tarifa_hora);
            Console.WriteLine("Sueldo bruto: $" + obrero.SueldoBruto());
            Console.WriteLine("Descuento AFP: $" + obrero.DescuentoAFP());
            Console.WriteLine("Descuento EPS: $" + obrero.DescuentoEPS());
            Console.WriteLine("Sueldo neto: $" + obrero.SueldoNeto());
            Console.WriteLine("----------------------------\n");
        }

    }
}

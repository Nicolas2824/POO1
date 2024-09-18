using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_08
{
    internal class Asesor
    {

        private int codigo;
        private string nombre;
        private int horas_trabajadas;
        private double tarifa_hora;
        public Asesor(int codigo, string nombre, int horas_trabajadas, double tarifa_hora)
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
        public double Descuento()
        {
            return SueldoBruto() * 0.15;
        }
        public double SueldoNeto()
        {
            return SueldoBruto() - Descuento();
        }
        public static void Listado(Asesor ase)
        {
            Console.WriteLine("\n--- Datos del Asesor ---");
            Console.WriteLine("Código: " + ase.codigo);
            Console.WriteLine("Nombre: " + ase.nombre);
            Console.WriteLine("Horas trabajadas: " + ase.horas_trabajadas);
            Console.WriteLine("Tarifa por hora: S/ " + ase.tarifa_hora);
            Console.WriteLine("Sueldo bruto: S/ " + ase.SueldoBruto());
            Console.WriteLine("Descuento (15%): S/ " + ase.Descuento());
            Console.WriteLine("Sueldo neto: S/ " + ase.SueldoNeto());
            Console.WriteLine("----------------------------\n");
        }

    }
}

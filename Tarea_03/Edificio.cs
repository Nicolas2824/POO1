using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_03
{
    internal class Edificio
    {

        private int codigo;
        private int numero_departamentos;
        private int cantidad_pisos;
        private double precio_departamento;


        public Edificio(int codigo, int numero_departamentos, int cantidad_pisos, double precio_departamento)
        {
            this.codigo = codigo;
            this.numero_departamentos = numero_departamentos;
            this.cantidad_pisos = cantidad_pisos;
            this.precio_departamento = precio_departamento;
        }


        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Numero_departamentos
        {
            get { return numero_departamentos; }
            set { numero_departamentos = value; }
        }

        public int Cantidad_pisos
        {
            get { return cantidad_pisos; }
            set { cantidad_pisos = value; }
        }

        public double Precio_departamento
        {
            get { return precio_departamento; }
            set { precio_departamento = value; }
        }


        public double PrecioEdificio()
        {
            return numero_departamentos * precio_departamento;
        }


        public static void Listado(Edificio edificio)
        {
            Console.WriteLine("\n--- Datos del Edificio ---");
            Console.WriteLine("Código : " + edificio.codigo);
            Console.WriteLine("Número de Departamentos : " + edificio.numero_departamentos);
            Console.WriteLine("Cantidad de Pisos : " + edificio.cantidad_pisos);
            Console.WriteLine("Precio por Departamento : $" + edificio.precio_departamento);
            Console.WriteLine("Precio total del Edificio : $" + edificio.PrecioEdificio());
            Console.WriteLine("----------------------------\n");
        }




    }
}

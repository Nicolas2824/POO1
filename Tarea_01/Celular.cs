using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarea_01
{
    internal class Celular
    {
        //atributos privados
        private int numero;
        private string usuario;
        private int segundos_consumidos;
        private double precio_segundo;

        //constructor
        public Celular(int numero, int segundos_consumidos, string usuario, double precio_segundo)
        {
            this.numero = numero;
            this.segundos_consumidos = segundos_consumidos;
            this.usuario = usuario;
            this.precio_segundo = precio_segundo;
        }

        //Get / Set
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public int Segundos_consumidos
        {
            get { return segundos_consumidos; }
            set { segundos_consumidos = value; }
        }
        public double Precio_segundo
        {
            get { return precio_segundo; }
            set { precio_segundo = value; }
        }

        //Métodos
        public double Costo_consumo()
        {
            return segundos_consumidos * precio_segundo;
        }

        public double Impuesto_IGV()
        {
            return Costo_consumo() * 0.18;
        }

        public double Total_pagar()
        {
            return Costo_consumo() + Impuesto_IGV();
        }

        // listado de datos
        public static void Listado(Celular celular)
        {
            Console.WriteLine("Usuario : " + celular.usuario);
            Console.WriteLine("Numero : " + celular.numero);
            Console.WriteLine("Segundos Consumidos : " + celular.segundos_consumidos);
            Console.WriteLine("Precio por segundos : " + celular.precio_segundo);
            Console.WriteLine("Costo por consumo : " + celular.Costo_consumo());
            Console.WriteLine("Impuesto por IGV : " + celular.Impuesto_IGV());
            Console.WriteLine("Total a Pagar : " + celular.Total_pagar());

        }

    }
}

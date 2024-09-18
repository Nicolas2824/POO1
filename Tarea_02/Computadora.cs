using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_02
{
    internal class Computadora
    {

        private int codigo;
        private string marca;
        private string color;
        private double precio_dolares;

        public Computadora(int codigo, string marca, string color, double precio_dolares)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.precio_dolares = precio_dolares;
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public double Precio_dolares
        {
            get { return precio_dolares; }
            set { precio_dolares = value; }
        }

        public double Precio_soles()
        {
            return precio_dolares * 3.35;
        }
        public double Precio_euros()
        {
            return precio_dolares / 1.20;
        }

        public static void Listado(Computadora computadora)
        {
            Console.WriteLine("Codigo: " + computadora.codigo);
            Console.WriteLine("Marca: " + computadora.marca);
            Console.WriteLine("Color: " + computadora.color);
            Console.WriteLine("Precio dolares: " + computadora.precio_dolares);
            Console.WriteLine("Precio en Soles: " + computadora.Precio_soles());
            Console.WriteLine("Precio en Euros: " + computadora.Precio_euros() + "\n");

        }

    }
}

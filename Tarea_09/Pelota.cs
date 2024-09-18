using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_09
{
    internal class Pelota
    {

        private string marca;
        private double peso_gramos;
        private double presion_libras;
        private double diametro_centimetros;
        private double precio;
        public Pelota(string marca, double peso_gramos, double presion_libras, double diametro_centimetros, double precio)
        {
            this.marca = marca;
            this.peso_gramos = peso_gramos;
            this.presion_libras = presion_libras;
            this.diametro_centimetros = diametro_centimetros;
            this.precio = precio;
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public double PesoGramos
        {
            get { return peso_gramos; }
            set { peso_gramos = value; }
        }

        public double PresionLibras
        {
            get { return presion_libras; }
            set { presion_libras = value; }
        }

        public double DiametroCentimetros
        {
            get { return diametro_centimetros; }
            set { diametro_centimetros = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public double Radio()
        {
            return diametro_centimetros / 2;
        }

        public double Volumen()
        {
            double radio = Radio();
            return (4 * 3.1416 * radio * radio * radio) / 3;
        }
        public double Descuento()
        {
            return precio * 0.10;
        }
        public double ImportePagar()
        {
            return precio - Descuento();
        }
        public static void Listado(Pelota pelota)
        {
            Console.WriteLine("\n--- Datos de la Pelota ---");
            Console.WriteLine("Marca: " + pelota.marca);
            Console.WriteLine("Peso (gramos): " + pelota.peso_gramos);
            Console.WriteLine("Presión (libras): " + pelota.presion_libras);
            Console.WriteLine("Diámetro (cm): " + pelota.diametro_centimetros);
            Console.WriteLine("Precio: S/ " + pelota.precio);
            Console.WriteLine("Radio (cm): " + pelota.Radio());
            Console.WriteLine("Volumen (cm³): " + pelota.Volumen());
            Console.WriteLine("Descuento (10%): S/ " + pelota.Descuento());
            Console.WriteLine("Importe a pagar: S/ " + pelota.ImportePagar());
            Console.WriteLine("----------------------------\n");
        }
    }
}

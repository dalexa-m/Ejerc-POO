using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.ejer1
{

    class Vehiculo
    {
        int id;
        string marca;
        string modelo;
        int km;
        decimal precio;
        int annio;

        //contructor con sus propiedades
        //
        public Vehiculo() { }
        public Vehiculo(int id, string marca, string modelo, int km, decimal precio, int annio)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Km = km;
            this.Precio = precio;
            this.Annio = annio;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Km { get => km; set => km = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Annio { get => annio; set => annio = value; }

        public override string ToString()
        {
            return "Modelo: " + modelo + "\n " + "Marca: " + marca + "\n" + "Kilometraje: " + km + "\n" + " Precio: " + precio + "Año: " + annio;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            //instanciando un nuevo objeton de la clase vehiculo
            Vehiculo vehiculo1 = new Vehiculo(1, "chebrolet", "Aveo", 5000, 15000, 2017);
            Console.WriteLine(vehiculo1.ToString());//tipo del objeto
            Console.ReadKey();
        }
    }
}

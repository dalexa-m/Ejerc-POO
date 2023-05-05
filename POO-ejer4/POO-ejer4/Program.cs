using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ejer4
{
    class Vehiculo
    {

        string marca;
        string modelo;
        int km;
        decimal precio;
        int annio;

        //contructor con sus propiedades
        //
        public Vehiculo() { }
        public Vehiculo(string marca, string modelo, int km, decimal precio, int annio)
        {

            this.Marca = marca;
            this.Modelo = modelo;
            this.Km = km;
            this.Precio = precio;
            this.Annio = annio;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Km { get => km; set => km = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Annio { get => annio; set => annio = value; }

        public virtual decimal Calprecio()
        {
            return precio;
        }

        public override string ToString()
        {
            return "Marca: " + marca + "Modelo: " + modelo + "Km: " + km + "Precio: " + Calprecio() + "Km: " + km + "Año: " + annio;

        }
    }

    class Auto : Vehiculo
    {
        bool airbag;

        public Auto(string modelo, string marca, int km, decimal precio, int anio, bool airbag)
        {

            this.airbag = airbag;
            base.Modelo = modelo;
            base.Marca = marca;
            base.Km = km;
            base.Precio = precio;
            base.Annio = anio;

        }

        public override decimal Calprecio()
        {
            if (airbag)
            {
                //Precio= Precio + 200;
                return base.Calprecio() + 200;
            }
            else
            {
                return base.Calprecio();
            }


        }
    }
    class Moto : Vehiculo
    {
        bool sidecar;
        public Moto(string modelo, string marca, int km, decimal precio, int anio, bool sidecar)
        {

            this.Sidecar = sidecar;
            base.Modelo = modelo;
            base.Marca = marca;
            base.Km = km;
            base.Precio = precio;
            base.Annio = anio;

        }

        public bool Sidecar { get => sidecar; set => sidecar = value; }

        public override decimal Calprecio()
        {
            if (sidecar)
            {
                return base.Calprecio() + 50;
            }
            else
            {
                return base.Calprecio();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Vehiculo veh = new Vehiculo("Totoya", "corola", 5000, 20000, 2018);
            Console.WriteLine("Vehiculo: " + veh);

            Auto auto = new Auto("Kia", "Rio", 2000, 25000, 2019, true);
            Console.WriteLine("Auto: " + auto);

            Moto moto = new Moto("Genesis", "Gen1500", 1000, 15000, 2022, false);
            Console.WriteLine("Moto: " + moto);
            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.ejer2
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

    class CasaComercial
    {
        //campo de la clase casa comercial
        string nombre;
        string correo;
        int totalv;

        //esto  es una composicion ya que la clase casa comercial posee una lista de objetos de tipo vehiculos
        List<Vehiculo> vehiculos;



        //contructor 
        public CasaComercial(string nombre, string correo, int totalv, List<Vehiculo> vehiculos)
        {
            this.Nombre = nombre;
            this.Correo = correo;
            this.Totalv = totalv;
            this.vehiculos = vehiculos;
        }

        //propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Totalv { get => totalv; set => totalv = value; }
        internal List<Vehiculo> Vehiculos { get => vehiculos; set => vehiculos = value; }


        //añadimos cada uno de los metodos 
        public void añadirVehiculo(Vehiculo V)
        {
            try
            {
                //parametro el objeto 
                this.Vehiculos.Add(V); //añadimos un nuevo objeto a la lista vehiculo
                this.totalv += 1; //actualizando el total de vehiculos
                Console.WriteLine("se ha añadido un nuevo vehiculo");
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede añadir debido a : \n" + ex.Message);
                Console.ReadLine();
            }


        }


        public void Mostrarvehiculo()
        {
            foreach (var item in this.vehiculos)
            {
                Console.WriteLine("---------");
                item.ToString();
            }
        }

        public void Vaciarvehiculos()
        {



            Console.WriteLine("Esta seguro que desea eliminar todos los elementos mostrados en la lista: s/n");
            string responce = Console.ReadLine();
            if (responce == "s" || responce == "S")
            {
                vehiculos = new List<Vehiculo>();
                this.totalv = 0;
                Console.WriteLine("Se han eliminado los objetos correctamente");
            }
            else
            {
                Console.WriteLine("No se elimino. hay " + totalv + "vehiculos rsgitrados");
            }
            Console.ReadLine();

        }

        public void eliminarvehiculo(Vehiculo V)
        {
            vehiculos.Remove(V);

            totalv -= 1;
            Console.WriteLine("Se ha eliminado un registro.");
        }





    }


    internal class Program
    {
        static void Main(string[] args)
        {
            CasaComercial cc2 = new CasaComercial("autolote el chele", "contacto@elchele.com", 0, null);
            cc2.añadirVehiculo(new Vehiculo(2, "hilux", "toyota", 4000, 6000, 2015));
            cc2.eliminarvehiculo(new Vehiculo());
            cc2.Mostrarvehiculo();
            cc2.Vaciarvehiculos();


            //Definimos un nuevo objeto de tipo casa comercial
            Console.WriteLine("De el nombre de la casa comercial");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el email");
            string email = Console.ReadLine();

            CasaComercial cc = new CasaComercial(nombre, email, 0, new List<Vehiculo>());

            //informacion del nuevo vehiculo a añadir
            Console.WriteLine("De la informacion del primer vehiculo a añadir");
            Console.WriteLine("Modelo: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();
            Console.WriteLine(" Kilometraje: ");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Año: ");
            int año = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            //procedemos a añadir la informacion del nuevo vehiculo haciendo uso del metodo Añadirvehiculo
            //definido en la clase casa comercial

            cc.añadirVehiculo(new Vehiculo(1, marca, modelo, km, precio, año));
        }
    }
}

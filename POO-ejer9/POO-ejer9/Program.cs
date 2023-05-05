using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ejer9
{
    class Camionero
    {
        int rfc;
        string poblacion;
        string nombre;
        string telefono;
        string direccion;
        double salario;
        Camion camionAsignado;
        List<Paquete> paquete;

        public Camionero(int rfc, string poblacion, string nombre, string telefono, string direccion, double salario, Camion camionAsignado, List<Paquete> paquete)
        {
            this.Rfc = rfc;
            this.Poblacion = poblacion;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Salario = salario;
            this.CamionAsignado = camionAsignado;
            this.Paquete = paquete;
        }

        public int Rfc { get => rfc; set => rfc = value; }
        public string Poblacion { get => poblacion; set => poblacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public double Salario { get => salario; set => salario = value; }
        public Camion CamionAsignado { get => camionAsignado; set => camionAsignado = value; }
        public List<Paquete> Paquete { get => paquete; set => paquete = value; }
        public void AgregarPack(Paquete p)
        {
            this.paquete.Add(p);
            Console.WriteLine("Se ha agregado un paquete");
        }
    }
    class Camion
    {
        int potencia;
        string matricula;
        string modelo;
        string tipo;

        public Camion(int potencia, string matricula, string modelo, string tipo)
        {
            this.Potencia = potencia;
            this.Matricula = matricula;
            this.Modelo = modelo;
            this.Tipo = tipo;
        }

        public int Potencia { get => potencia; set => potencia = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
    class Paquete
    {
        int codigo;
        string descricion;
        string destinatario;
        string direccion;
        Ciudad Ciudad;

        public Paquete(int codigo, string descricion, string destinatario, string direccion, Ciudad ciudad)
        {
            this.Codigo = codigo;
            this.Descricion = descricion;
            this.Destinatario = destinatario;
            this.Direccion = direccion;
            Ciudad1 = ciudad;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricion { get => descricion; set => descricion = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal Ciudad Ciudad1 { get => Ciudad; set => Ciudad = value; }
    }

    class Ciudad
    {
        int codigo;
        string nombre;

        public Ciudad(int codigo, string nombre)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Camionero camionero = new Camionero(12, "23,2333", "Juan", "56784565", "de la totonda 1 c abajo", 25000, new Camion(15, "M 123 456", "cisterna", "Tanque"), new List<Paquete>());
            Paquete paquete = new Paquete(45, "Paquete de ropa", "Casa 23", "Carretera norte 2 c arriba", new Ciudad(56, "Managua"));
            camionero.AgregarPack(paquete);
            Console.ReadKey();
        }
    }
}

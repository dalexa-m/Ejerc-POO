using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ejer10
{
    public class Persona
    {
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        string Nombre { get; set; }
        int Edad { get; set; }

        public void Mostrar()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }

    public class Cliente : Persona
    {
        public Cliente(string nombre, int edad, string numeroTelefono) : base(nombre, edad)
        {
            NumeroTelefono = numeroTelefono;
        }

        public string NumeroTelefono { get; set; }

        public new void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Número de Teléfono: {NumeroTelefono}");
        }
    }

    public class Empleado : Persona
    {
        public Empleado(string nombre, int edad, decimal sueldoBruto) : base(nombre, edad)
        {
            SueldoBruto = sueldoBruto;
        }

        public decimal SueldoBruto { get; set; }

        public new void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Sueldo Bruto: {SueldoBruto}");
        }

        public decimal CalcularSalarioNeto()
        {

            decimal seguro = SueldoBruto * 0.12m;
            decimal salarioneto = SueldoBruto - seguro;
            return salarioneto;
        }
    }

    public class Empresa
    {
        string Nombre;
        public Empresa(string nombre)
        {
            Nombre = nombre;
        }


    }

    public class Directivo : Persona
    {
        string Categoria { get; set; }
        public Directivo(string nombre, int edad, string categoria) : base(nombre, edad)
        {
            Categoria = categoria;
        }



        public new void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Categoría: {Categoria}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Persona per = new Persona("Ana", 24);
            per.Mostrar();

            Cliente cli = new Cliente("Pedro", 45, "78456737");
            cli.Mostrar();

            Empleado emp = new Empleado("Alicia", 56, 80000);
            emp.Mostrar();

            decimal salan = emp.CalcularSalarioNeto();
            Console.WriteLine("Salario neto: " + salan);

            Empresa empresa = new Empresa("Gallo Mas Gallo");

            Directivo direc = new Directivo("Marta", 45, "Gerente");
            direc.Mostrar();

            Console.ReadKey();
        }
    }
}

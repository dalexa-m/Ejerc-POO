using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ejer7
{
    class Persona
    {
        string nombre;

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return "Nombre: " + Nombre;
        }
    }
    class Estudiante : Persona
    {
        public Estudiante(string nombre) : base(nombre) { }

        public void Estudiar()
        {
            Console.WriteLine("{0} está estudiando", Nombre);
        }



    }
    class Profesor : Persona
    {
        public Profesor(string nombre) : base(nombre) { }

        public void Explicar()
        {
            Console.WriteLine("{0} está explicando", Nombre);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona[] person = new Persona[3];

            Profesor per1 = new Profesor("Pedro");
            person[0] = per1;

            Estudiante per2 = new Estudiante("Juan");
            person[1] = per2;

            Estudiante per3 = new Estudiante("Lisa");
            person[2] = per3;

            Console.WriteLine("impresion");
            Console.WriteLine(per1.ToString());
            per1.Explicar();  
            Console.WriteLine(per2.ToString());
            per2.Estudiar();   
            Console.WriteLine(per3.ToString());
            per3.Estudiar();

            Console.ReadKey();




        } 
    }
    
}

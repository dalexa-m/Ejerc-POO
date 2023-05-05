using POO_ejer8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ejer8
{
    class Pelicula
    {
        string nombre;
        int anio;
        private List<Actor> actores;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Anio { get => anio; set => anio = value; }
        internal List<Actor> Actores { get => actores; set => actores = value; }

        public Pelicula(string nombre, int anio, List<Actor> actores)
        {
            this.Nombre = nombre;
            this.Anio = anio;
            this.Actores = actores;
        }
        public void AgregarActor(Actor actor)
        {
            Actores.Add(actor);
        }
    }

    class Actor
    {
        string nombre;
        string Apellido;

        public Actor(string nombre, string apellido)
        {
            this.nombre = nombre;
            Apellido = apellido;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
    }

    class Estudio
    {
        string nombre;
        string direccion;
        List<Pelicula> peliculas;

        public Estudio(string nombre, string direccion, List<Pelicula> peliculas)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Peliculas = peliculas;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal List<Pelicula> Peliculas { get => peliculas; set => peliculas = value; }
        public void AgregarPelicula(Pelicula peli)
        {
            peliculas.Add(peli);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Estudio estudio = new Estudio("New yor","Wall street", new List<Pelicula>());
            Pelicula pelicula = new Pelicula("Pinocchio",2022, new List<Actor>());
            Actor actor = new Actor("Gregory","Man");
            Console.WriteLine("Nombre del estudio: {0}\nDireccion: {1}\nNombre de la pelicula: {2}\nAño de la pelicula: {3}\nNombre del actor: {4}\nApellido del actor: {5}.", estudio.Nombre, estudio.Direccion, pelicula.Nombre, pelicula.Anio, actor.Nombre, actor.Apellido1);
            Console.ReadKey();
        }
    }
}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ejer5
{
    class Foto
    {
        int id;
        double tamamg;
        DateTime fechacreacion;
        string comentarios;

        public Foto(int id, double tamamg, DateTime fechacreacion, string comentarios)
        {
            this.Id = id;
            this.Tamamg = tamamg;
            this.Fechacreacion = fechacreacion;
            this.Comentarios = comentarios;
        }

        public int Id { get => id; set => id = value; }
        public double Tamamg { get => tamamg; set => tamamg = value; }
        public DateTime Fechacreacion { get => fechacreacion; set => fechacreacion = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }

        public override string ToString()
        {
            return "Id: " + id + "\n" + "Tamaño MG: " + tamamg + "\n" + " fecha creacion: " + fechacreacion + "\n" + " Comentarios: " + comentarios;
        }

    }

    class Album
    {
        int id;
        string nombre;
        DateTime fechacreacion;
        List<Foto> Fotos;

        public Album(int id, string nombre, DateTime fechacreacion)
        {
            this.id = id;
            this.nombre = nombre;
            this.fechacreacion = fechacreacion;
            this.Fotos = new List<Foto>();
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fechacreacion { get => fechacreacion; set => fechacreacion = value; }
        internal List<Foto> Fotos1 { get => Fotos; set => Fotos = value; }

        public void AñadirFoto(Foto f)
        {
            Fotos1.Add(f);
        }

        public void MostrarFoto()
        {
            foreach (var x in Fotos)
            {
                Console.WriteLine(x.ToString());
            }
        }
        public void VaciarAlbum()
        {
            Fotos.Clear();
        }

        public void EliminarFoto(Foto f)
        {
            Fotos.Remove(f);
        }

        public double TamanoAlbum()
        {
            double tamanoTotal = 0;
            foreach (var foto in Fotos)
            {
                tamanoTotal += foto.Tamamg;
            }
            return tamanoTotal / 1024; // Convertir a GB
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Foto fot1 = new Foto(1, 2.5, new DateTime(2022, 4, 15), "Una foto de la playa");
            Foto fot2 = new Foto(2, 1.8, new DateTime(2022, 4, 16), "Una foto del campo");
            Album a1 = new Album(1, "Vacaciones", new DateTime(2023, 5, 1));

            Console.WriteLine("Añadir fotos:");
            a1.AñadirFoto(fot1);
            a1.AñadirFoto(fot2);
            a1.MostrarFoto();
            Console.WriteLine("-----");
            Console.WriteLine("Eliminar foto: ");
            a1.EliminarFoto(fot1);
            a1.MostrarFoto();
            Console.WriteLine("-----");
            Console.WriteLine("Eliminar todas las fotos:");
            a1.VaciarAlbum();

            Console.ReadKey();

        }
    }
}

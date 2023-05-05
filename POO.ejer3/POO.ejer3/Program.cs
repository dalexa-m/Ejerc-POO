using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.ejer3
{
    class Computadora
    {

        int capadisco;
        int espadisponible;
        bool encendido;



        public Computadora(int capadisco, int espadisponible, bool encendido)
        {
            this.Capadisco = capadisco;
            this.Espadisponible = espadisponible;
            this.Encendido = encendido;
        }

        public int Capadisco { get => capadisco; set => capadisco = value; }
        public int Espadisponible { get => espadisponible; set => espadisponible = value; }
        public bool Encendido { get => encendido; set => encendido = value; }
        public void Añadirdatos(int datos)
        {
            if (encendido)
            {
                if (datos <= espadisponible)
                {
                    espadisponible -= datos;
                    Console.WriteLine("Se añadio " + datos + " GB de datos al disco duro.\nEspacio disponible " + espadisponible + " GB");
                }
                else
                {
                    espadisponible = 0;
                    Console.WriteLine("No hay espacio disponible");
                }
            }
            else
            {
                Console.WriteLine("La computadora esta apagada");
            }
        }

        public void Eliminardatos(int datos)
        {
            if (encendido)
            {
                if (datos <= (capadisco - espadisponible))
                {
                    espadisponible += datos;

                    Console.WriteLine("Se elimino " + datos + " GB de datos del disco duro");
                }
                else
                {
                    espadisponible = capadisco;
                    Console.WriteLine("No hay datos suficiente almacenados en el dico duro para eliminar. \n Espacio disponible " + espadisponible);
                }
            }
            else
            {
                Console.WriteLine("La computadora esta apagada");
            }
        }

        public void Apagar()
        {
            encendido = false;
            Console.WriteLine("La computadora esta apagada");
        }
        public void Encendida()
        {
            encendido = true;
            Console.WriteLine("La computadora esta encendida");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De la capacidad de disco de su computadora");
            int cp = int.Parse(Console.ReadLine());

            Console.WriteLine("De el espacio disponible de su computadora");
            int ed = int.Parse(Console.ReadLine());
            Console.WriteLine("De el dato en GB a añadir");
            int dato1 = int.Parse(Console.ReadLine());

            Console.WriteLine("De el dato en GB a eliminar");
            int dato2 = int.Parse(Console.ReadLine());



            Computadora comp = new Computadora(cp, ed, false);
            comp.Encendida();
            comp.Añadirdatos(dato1);
            comp.Eliminardatos(dato2);
            comp.Apagar();

            Console.ReadKey();


        }
    }
}

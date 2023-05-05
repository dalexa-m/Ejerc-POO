using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ejer4
{
    
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

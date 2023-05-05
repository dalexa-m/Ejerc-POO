using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ejer6
{
   
    public class Forma
    {
        
        protected Ubicacion c;

        
        public Forma(double x, double y)
        {
            c = new Ubicacion(x, y);
        }

        // Métodos públicos
        public override string ToString()
        {
            return $"Posición: ({c.x}, {c.y})";
        }

        public virtual double Area()
        {
            return 0;
        }

        public virtual double Perimetro()
        {
            return 0;
        }
    }

    
    public class Rectangulo : Forma
    {
        
        private double lado1;
        private double lado2;

        
        public Rectangulo(double x, double y, double lado1, double lado2) : base(x, y)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        
        public override string ToString()
        {
            return $"Rectangulo [{base.ToString()}] Lado1: {lado1}, Lado2: {lado2}";
        }

        public override double Area()
        {
            return lado1 * lado2;
        }

        public override double Perimetro()
        {
            return 2 * (lado1 + lado2);
        }
    }

    
    public class Circulo : Forma
    {
        
        private double radio;

        
        public Circulo(double x, double y, double radio) : base(x, y)
        {
            this.radio = radio;
        }

        
        public override string ToString()
        {
            return $"Circulo [{base.ToString()}] Radio: {radio}";
        }

        public override double Area()
        {
            return Math.PI * radio * radio;
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    
    public class Ubicacion
    {
        // Atributos públicos
        public double x;
        public double y;

        // Constructor
        public Ubicacion(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

   
    public class Program
    {
        public static void Main()
        {
            
            Rectangulo rect = new Rectangulo(3, 5, 2, 8);
            Console.WriteLine(rect);
            Console.WriteLine($"Área: {rect.Area()}");
            Console.WriteLine($"Perímetro: {rect.Perimetro()}");

            // Crear un objeto Circulo y mostrar su área y perímetro
            Circulo circ = new Circulo(6, 8, 9);
            Console.WriteLine(circ);
            Console.WriteLine($"Área: {circ.Area()}");
            Console.WriteLine($"Perímetro: {circ.Perimetro()}");
        }
    }
}

using System;
using Trinagulo;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());
            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            Console.WriteLine($"Área do triângulo X: {areaX:F3}");
            Console.WriteLine($"Área do triângulo Y: {areaY:F3}");

            if (areaX > areaY)
            {
                Console.WriteLine("Área do triângulo X é maior");
            }
            else
            {
                Console.WriteLine("Área do triângulo Y é maior");
            }
        }
    }
}
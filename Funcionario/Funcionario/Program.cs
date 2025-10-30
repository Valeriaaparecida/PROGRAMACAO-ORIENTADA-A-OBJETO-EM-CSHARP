using System;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func1.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func2.SalarioBruto = double.Parse(Console.ReadLine());
            double salarioMedio = (func1.SalarioBruto + func2.SalarioBruto) / 2.0;
            Console.WriteLine($"Salário médio: {salarioMedio:F2}");
        }
    }
}
using Exercicio5;
using System.Globalization;

Conta c1;

Console.Write("Entre o número da conta:");
int numero = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta:");
string titular = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)?");
char resp = char.Parse(Console.ReadLine()!);
if (resp == 's' || resp == 'S')
{
    Console.Write("Entre o valor de depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    c1 = new Conta(numero, titular, depositoInicial);
   

}
else
{
    c1 = new Conta(numero, titular);
    
}

Console.WriteLine();
Console.WriteLine("Dados da conta: ");
Console.WriteLine(c1);

Console.WriteLine("Entre um valor para depósito: ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
c1.Deposito(quantia);
Console.WriteLine("Dados da conta atualizados: " );
Console.WriteLine(c1);




Console.WriteLine("Entre um valor para saque: ");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
c1.Saque(quantia);
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(c1);
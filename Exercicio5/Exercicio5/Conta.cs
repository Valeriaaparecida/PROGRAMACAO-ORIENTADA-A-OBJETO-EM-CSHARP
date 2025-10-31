using System.Globalization;

namespace Exercicio5
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
       


        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0.0;
        }
        public Conta(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
         
            Deposito(depositoInicial);
        }

      

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.0;
            
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }


}

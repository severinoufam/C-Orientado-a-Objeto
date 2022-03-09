using System;

namespace _01_BityBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.DefinirSaldo(100);

            Console.WriteLine(conta.ObterSaldo());

            Console.ReadLine();

        }
    }
}

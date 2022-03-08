using System;

namespace _01_BityBank
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposito1 = 400;
            double saque1 = 0;

            double deposito2 = 500;
            double saque2 = 0;

            double transferencia = 1000;

            ContaCorrente contaSeverino = new ContaCorrente();
            contaSeverino.titular = "severino";
            Console.WriteLine("Titular: " + contaSeverino.titular);


            contaSeverino.Depositar(deposito1);
            Console.WriteLine("Valor depositado: " + deposito1);
            Console.WriteLine("Saldo atual: " + contaSeverino.saldo);


            Console.WriteLine("------------------------------");

            ContaCorrente contaAldenise = new ContaCorrente();
            contaAldenise.titular = "aldenise";
            Console.WriteLine("Titular: " + contaAldenise.titular);

            contaAldenise.Depositar(deposito2);
            Console.WriteLine("Valor depositado: " + deposito2);
            Console.WriteLine("Saldo atual: " + contaAldenise.saldo);

            bool resuldado = contaAldenise.Transferencia(transferencia, contaSeverino);
            Console.WriteLine("Saldo atual severino: " + contaSeverino.saldo);
            Console.WriteLine("Saldo atual aldenise: " + contaAldenise.saldo);
            Console.WriteLine("resultado: " + resuldado);

            Console.ReadLine();

        }
    }
}

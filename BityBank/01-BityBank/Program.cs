using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BityBank
{
    class Program
    {
        static void Main(string[] args)
        {
            int somaSaldo = 150;

            ContaCorrente conta = new ContaCorrente();

            conta.titular = "severino";
            conta.agencia = 123;
            conta.numero = 321;
            conta.saldo = 100;

            conta.saldo += somaSaldo;

            Console.WriteLine("Titular: " + conta.titular);
            Console.WriteLine("Agencia: " + conta.agencia);
            Console.WriteLine("Numero: " + conta.numero);
            Console.WriteLine("Saldo: " + conta.saldo);

            //valor padrao

            //tipo de referencia e tipo de valor

            Console.ReadLine();

        }
    }
}

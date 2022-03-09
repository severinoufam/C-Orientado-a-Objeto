using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BityBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 100;

    public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {

            }
            this.saldo = saldo;
        }

    public double ObterSaldo()
        {
            return saldo;
        }

    public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (this.saldo < 0)
            {
                return false;
            }
            this.saldo -= valor;
            return true;
        }

        public bool Transferencia(double valor, ContaCorrente Destino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            Destino.Depositar(valor);
            return true;
        }
    }
}
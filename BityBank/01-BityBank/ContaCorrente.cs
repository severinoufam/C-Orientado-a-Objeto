public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo;

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Sacar(double valor)
    {
        if(this.saldo < 0)
        {
            return false;
        }
        this.saldo -= valor;
        return true;
    }

    public bool Transferencia(double valor, ContaCorrente Destino)
    {
        if(this.saldo < valor)
        {
            return false;
        }
        this.saldo -= valor;
        Destino.Depositar(valor);
        return true;
    }
}
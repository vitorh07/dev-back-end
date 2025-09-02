public class Conta
{
    // Atributos
    public int Numero { get; private set; }
    public double Saldo { get; private set; }
    public string Titular;

    // Construtor
    public Conta(int numero, string titular)
    {
        Numero = numero;
        Titular = titular;
        Saldo = 0.0;
    }

    // Métodos
    public bool Depositar(double valor, int numero)
    {
        if (Numero != numero || valor <= 0)
            return false;
        Saldo += valor;
        return true;
    }

    public bool Sacar(double valor, int numero)
    {
        if (Numero != numero || Saldo < valor || valor <= 0)
            return false;
        Saldo -= valor;
        return true;
    }

    // Getters and Setters

    /*
    public int GetNumero()
    {
        return Numero;
    }
    public string GetTitular()
    {
        return Titular;
    }
    public double GetSaldo()
    {
        return Saldo;
    }

    public void SetTitular(string titular)
    {
        Titular = titular;
    }

    public void SetSaldo(double saldo)
    {
        if (saldo >= 0)
            Saldo = saldo;
    }
    */

    //ToString
    public override string ToString()
    {
        return $"\nNumero: {Numero}\nTitular: {Titular}\nSaldo: {Saldo}\n";
    }
}
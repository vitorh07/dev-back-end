public class ContaBancaria
{
    // Propriedades públicas com get e set
    public int Number { get; private set; }
    public double Value { get; private set; }
    public string Name { get; private set; }

    // Construtor
    public ContaBancaria(int number, string name, double value = 0)
    {
        Number = number;
        Name = name;
        Value = value;
    }

    // Método para depósito
    public bool Deposit(double value, int number)
    {
        if (number == Number && value > 0)
        {
            Value += value;
            return true;
        }
        return false;
    }

    // Método para saque
    public bool CashOut(double value)
    {
        if (value > 0 && value <= Value)
        {
            Value -= value;
            return true;
        }
        return false;
    }

    // Método para verificar saldo
    public void CheckBalance()
    {
        Console.WriteLine($"Conta: {Number} | Titular: {Name} | Saldo: R$ {Value:F2}");
    }
}
Conta c1 = new Conta(1, "Vitor");

if(c1.Saldo == 0)
    c1.Depositar(100, 1);

c1.Titular = "Vitor Fogaça";
Console.WriteLine(c1);
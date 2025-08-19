// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Conta c1 = new Conta(1, "Vitor");
Conta c2 = new Conta(2, "Cainã");

c1.Depositar(1000, 1);
c2.Depositar(500, 2);
Console.WriteLine($"Conta 1 - Titular: {c1.Titular}, Saldo: {c1.Saldo}");
Console.WriteLine($"Conta 2 - Titular: {c2.Titular}, Saldo: {c2.Saldo}");
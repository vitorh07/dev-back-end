ContaBancaria conta = new ContaBancaria(1234, "Vitor Fogaca");

conta.CheckBalance();

if (conta.Deposit(500, 1234))
    Console.WriteLine("Depósito realizado com sucesso!");
else
    Console.WriteLine("Falha no depósito.");

conta.CheckBalance();

if (conta.CashOut(200))
    Console.WriteLine("Saque realizado com sucesso!");
else
    Console.WriteLine("Falha no saque.");

conta.CheckBalance();
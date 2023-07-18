using ExercicioHerancas;

Console.WriteLine("## Exercício  - Herenças ##");

ContaCorrente conta = new() { Titular = "Maria", Numero = 111};

Console.WriteLine("\nConta investimento: Número 111 | Titular: Maria");
Console.WriteLine("Depositando R$ 1.000,00");
conta.Depositar(1000);
Console.WriteLine("Sacando  R$ 100,00");
conta.Sacar(100);
Console.WriteLine($"Saldo da conta corrente: {conta.Saldo:C2}");

Console.WriteLine("Sacando  R$ 2.000,00");
conta.Sacar(2000);
Console.WriteLine($"Saldo da conta corrente: {conta.Saldo:C2}");

Console.WriteLine("\nConta poupança: Número 222 | Titular: José");
ContaPoupanca contaPoupanca = new() { Titular = "José", Numero = 222};
Console.WriteLine("Depositando R$ 1.000,00");
contaPoupanca.Depositar(1000);
Console.WriteLine("Sacando  R$ 100,00");
contaPoupanca.Sacar(100);
Console.WriteLine($"Saldo da conta poupança: {contaPoupanca.Saldo:C2}");

Console.WriteLine("Sacando  R$ 2.000,00");
contaPoupanca.Sacar(2000);
Console.WriteLine($"Saldo da conta poupança: {contaPoupanca.Saldo:C2}");


Console.WriteLine("\nConta investimento: Número 333 | Titular: Mario");
ContaInvestimento contaInvestimento = new() { Titular = "Mario", Numero = 333 };
Console.WriteLine("Depositando R$ 1.000,00");
contaInvestimento.Depositar(1000);
Console.WriteLine("Sacando  R$ 100,00");
contaInvestimento.Sacar(100);
Console.WriteLine($"Saldo da conta investimento: {contaInvestimento.Saldo:C2}");

Console.WriteLine("Sacando  R$ 2.000,00");
contaPoupanca.Sacar(2000);
Console.WriteLine($"Saldo da conta investimento: {contaInvestimento.Saldo:C2}");
using CamposEstaticos;

Console.WriteLine("## Campos Estáticos - Exercícios ##");

ContaCorrente conta1 = new();
conta1.Conta = 101;
conta1.Nome = "Maria";
//conta1.Juros = 3.99f;

ContaCorrente conta2 = new();
conta2.Conta = 102;
conta2.Nome = "Marta";
//conta2.Juros = 4.99f;

ContaCorrente.Juros = 4.25f;

Console.WriteLine($"Cliente: {conta1.Nome} - Juros Anual: {conta1.JurosAnual():c}");

Console.WriteLine($"Cliente: {conta2.Nome} - Juros Anual: {conta2.JurosAnual():c}");

Console.ReadKey();

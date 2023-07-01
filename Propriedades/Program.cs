using Propriedades;

Console.WriteLine("## Propriedades ## \n");

Produto caderno = new();
caderno.Nome = "Caderno";
caderno.Preco = 3;
caderno.EstoqueMinimo = 10;

caderno.Exibir();
Console.ReadKey();
using ConstrutorEstatico;

Console.WriteLine("## Construtor estático ##\n");

// Invoca o construtor parametrizado e o estático
Pessoa maria = new(20, "Maria");
Console.WriteLine($"{maria.Nome} - {maria.Idade}");
Console.WriteLine($"Idade mínima {Pessoa.IdadeMinima}");

// Invoca somente o construtor parametrizado, pois o estático foi invocado anteriormente
// O construtor estático só é invocado uma única vez
Pessoa joao = new(62, "João");
Console.WriteLine($"{joao.Nome} - {joao.Idade}");
Console.WriteLine($"Idade mínima {Pessoa.IdadeMinima}");


Console.ReadKey();

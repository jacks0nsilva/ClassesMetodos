using Struct;

Console.WriteLine("## Struct ##");

Cliente suzana = new("Suzana", "suzana04@gmail.com", 17);

Cliente jose = new();
jose.Nome = "José";
jose.Email = "jose094@outlook.com";
jose.Idade = 17;

jose.ExibirINfo(jose.Nome, jose.Email, jose.Idade);
suzana.ExibirINfo(suzana.Nome, suzana.Email, suzana.Idade);
suzana.ExibirINfo(suzana.Nome, suzana.Email);
Console.ReadKey();
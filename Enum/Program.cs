using Enum;

Console.WriteLine("## Enum ##");

Console.WriteLine($"{Cores.Branco} - {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - {(int)Cores.Azul}");

Console.WriteLine("\n Selecione a cor do seu Carro");
int cor = Convert.ToInt32(Console.ReadLine());

Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110, cor);
chevrolet.ExibirInfo();

Console.ReadKey();
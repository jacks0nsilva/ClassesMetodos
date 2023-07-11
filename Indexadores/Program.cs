using Indexadores;
using System.Reflection.Metadata;

Console.WriteLine("## Indexadores ##");

Time time = new Time();
// atribuindo valores = set
time[1] = "Palmeiras";
time[3] = "Santos";
time[5] = "São Paulo";
time[7] = "Vasco";
time[-1] = "Flamengo";
time[1000] = "Bahia";

// obtendo os valores = get
string valor1 = time[1];
string valor2 = time[3];
string valor3 = time[5];
string valor4 = time[7];
string valor5 = time[-1];
string valor6 = time[1000];

// exibir
Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);


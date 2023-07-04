Console.WriteLine("## Arrays ##");

string[] nomes = new string[5];
double[] notas = new double[5];

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine("Informe o nome do aluno: ");
    string? nome = Console.ReadLine();
    nomes[i] = nome;
}

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine("Informe a nota do aluno: ");
    double nota = Convert.ToDouble(Console.ReadLine());
    notas[i] = nota;
}

Console.WriteLine("Alunos: ");
foreach (string nome in nomes)
{
    Console.Write($"{nome} ");
}

double somarNotas = 0.0;
double totalNotas = notas.Count();

Console.WriteLine("\nNotas: ");
foreach (double nota in notas)
{
    somarNotas += nota;
    Console.Write($"{nota} ");
}

Console.WriteLine($"\nMédia Aritmética: {somarNotas/totalNotas}");
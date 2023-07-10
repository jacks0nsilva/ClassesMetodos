using ExercicioListT;

Console.WriteLine("## List<T> ##");

List<Aluno> alunos = new()
{
    new Aluno{Nome = "João", Nota = 8.75},
    new Aluno{Nome = "Manoel", Nota= 6.95},
    new Aluno{Nome = "Amanda", Nota = 7.25},
    new Aluno{Nome = "Carlos", Nota = 6.55},
    new Aluno{Nome = "Jaime", Nota = 8.50},
    new Aluno{Nome = "Debora", Nota = 5.95},
    new Aluno{Nome = "Alicia", Nota = 9.25},
    new Aluno{Nome = "Sandra", Nota = 5.55},
    new Aluno{Nome = "Marta", Nota = 7.85},
    new Aluno{Nome = "Sueli", Nota = 9.15},
};

ExibirAlunos(alunos); // Exibir todos os alunos

static void ExibirAlunos(List<Aluno> alunos)
{
    double notaTotal = 0.0;
    foreach (var aluno in alunos)
    {
        Console.WriteLine($"O {aluno.Nome} tem a nota {aluno.Nota}");
        notaTotal += aluno.Nota;
    }
    double mediaTotal = notaTotal / alunos.Count;
    Console.WriteLine($"\nMédia das notas: {mediaTotal:N2} | Quantidade de alunos na lista: {alunos.Count}\n");
}
Console.WriteLine();
Aluno bia = new() { Nome = "Bia", Nota = 7.75 };
Aluno mario = new() { Nome = "Mario", Nota = 8.95 };
alunos.Add(bia);
alunos.Add(mario); // Adicionar dois alunos

ExibirAlunos(alunos);

var aluno1 = alunos.Find(a=> a.Nome.Equals("Amanda"));
alunos.Remove(aluno1);
ExibirAlunos(alunos);

var listaOrdenada = alunos.OrderBy(n=> n.Nome).ToList();
ExibirAlunos(listaOrdenada);


var alunosNotaOito = alunos.FindAll(a=> a.Nota >= 8);
ExibirAlunos(alunosNotaOito);
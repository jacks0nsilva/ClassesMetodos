Console.WriteLine("## Array Bidimensional ##");

// Declaração e alocação de memória para o array
string[,] alunos = new string[2,5]; // [i,j]

for (int i = 0; i < alunos.GetLength(0); i++)
{
	for (int j = 0; j < alunos.GetLength(1); j++)
	{
        Console.Write($"Linha: {i} | Coluna: {j}\n");
        alunos[i, j] = Console.ReadLine();

    }
}

Console.WriteLine("Valores recebidos");

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.Write($"[{i},{j}] = {alunos[i, j]}\t ");
    }
    Console.WriteLine();
}

Console.ReadKey();
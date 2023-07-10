Console.WriteLine("## Classe Random ##");

int[] numerosSorteados = new int[6];
Random random = new Random();

for (int i = 0; i < numerosSorteados.Length; i++)
{
	int numeroAleatorio;

	do
	{
		numeroAleatorio = random.Next(1, 61); // Irá gerar um número de 1 a 60 e atribuir a variável numeroAleatorio
	} while (numerosSorteados.Contains(numeroAleatorio)); // Verifica se há um número igual no array numerosSorteados, se houver, repete o loop do while

	numerosSorteados[i] = numeroAleatorio;
}

Array.Sort(numerosSorteados); // Ordena o array de números sorteados

Console.WriteLine("\nNúmeros sorteados\n");

Console.Write(String.Join(" | ",numerosSorteados));
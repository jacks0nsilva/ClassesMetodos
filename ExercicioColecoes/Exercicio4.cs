using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioColecoes
{
    public class Exercicio4
    {
        public static void Exercicio()
        {
            List<Pessoa> pessoas = new();

            Console.WriteLine("Digite o nome de três pessoas: \n");
            string? nome;
            int idade;
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Nome: ");
                nome = Console.ReadLine();
                Console.Write("Idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                Pessoa pessoa = new() { Nome = nome, Idade = idade};
                pessoas.Add(pessoa);
                Console.Write("\n");
            }

            ListaPessoas(pessoas);

            Console.WriteLine("\nDigite o nome de duas pessoas: \n");
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Nome: ");
                nome = Console.ReadLine();
                Console.Write("Idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                Pessoa pessoa = new() { Nome = nome, Idade = idade };
                pessoas.Add(pessoa);
                Console.Write("\n");
            }

            ListaPessoas(pessoas);

            var ultimaPessoa = pessoas[pessoas.Count - 1];
            pessoas.Remove(ultimaPessoa);
            Console.WriteLine($"\nÚltima pessoa removida: {ultimaPessoa.Nome} \n");
            ListaPessoas(pessoas);

            
            Console.WriteLine($"Digite o nome de uma pessoa que você deseja remover: ");
            string? pessoaRemovida = Console.ReadLine();
            bool condicao = true;
            do
            {
                var remove = pessoas.Find(p => p.Nome.Equals(pessoaRemovida));
                if (remove == null)
                {
                    Console.WriteLine($"PESSOA NÃO ENCONTRADA, digite novamente o nome da pessoa que deseja remover: ");
                    pessoaRemovida = Console.ReadLine();
                    //remove = pessoas.Find(p => p.Nome.Equals(pessoaRemovida));
                }
                else
                {
                    Console.WriteLine($"\nPESSOA ENCONTRADA, {remove.Nome} será removido!");
                    pessoas.Remove(remove);
                    condicao = false;
                }
            } while (condicao);

            ListaPessoas(pessoas);
        }

        static void ListaPessoas(List<Pessoa> pessoas)
        {
            Console.WriteLine("\nLista de pessoas atual...\n");
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.Exibir());
            }
        }
        class Pessoa
        {
            public string? Nome { get; set; }
            public int Idade { get; set; }

            public string Exibir()
            {
                return Nome + " - " + Idade;
            }
        }
    }
}

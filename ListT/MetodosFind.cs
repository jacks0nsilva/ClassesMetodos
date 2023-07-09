using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListT
{
    internal class MetodosFind
    {
        public static void FindT()
        {
            // List<T> - Find(), FindLast(), FindIndex(), FindLastIndex(), FindAll()

            // O método Find() retorna o primeiro elemento que corresponde ao predicado fornecido

            // O método FindLast() retorna o último elemento que corresponde ao predicado fornecido.

            // O método FindIndex() retorna o índice do primeiro elemento que corresponde ao predicado fornecido.
            // Ele retorna -1 se não houver correspondência encontrada.

            // O método FindLastIndex() retorna o índice do último elemento que corresponde ao predicado fornecido.
            // Ele retorna -1 se não houve correspondência encontrada.

            // O método FindAll() recupera todos os elementos que correspondem às condições definidas pelo predicado especificado.

            // Um predicado é uma função/método de um argumento único que retorna um valor booleano

            List<string> frutas = new() { "Uva", "Banana", "Pera", "Maçã", "Abacate", "Laranja", "Morango" };
            var fruta1 = frutas.Find(Procurar);
            Console.WriteLine(fruta1);

            // usando o predicado como uma função
            static bool Procurar(string item)
            {
                return item.Contains('n');
            }

            // Expresão lambda (função anônima)
            var fruta2 = frutas.Find(f => f.StartsWith('L'));
            Console.WriteLine(fruta2); // Laranja

            var fruta3 = frutas.FindLast(f=> f.Contains('o'));
            Console.WriteLine(fruta3); // Morango

            var fruta4 = frutas.FindIndex(f => f == "Abacate");
            Console.WriteLine(fruta4); // 4

            var fruta5 = frutas.FindLastIndex(f=> f.Contains('n'));
            Console.WriteLine(fruta5); // 6

            var frutas6 = frutas.FindAll(f=> f.Contains('n'));
            Console.WriteLine(String.Join(", ", frutas6)); // Banana, Laranja, Morango
        }

    }
}

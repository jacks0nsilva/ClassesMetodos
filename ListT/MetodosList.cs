using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListT
{
    class MetodosList
    {
        public static void ListT()
        {
            List<string> lista = new();
            string[] array = { "Matheus", "Felipe" };
            string[] array2 = { "Fernanda", "Camila" };
            // List<T> - Adicionar elementos

            // O método Add permite incluir um único elemento ao final de uma List<T>
            // O método Insert(int index, Object value) permite incluir um elemento em uma posição qualquer usando um índicie específico
            lista.Add("Carlos");
            lista.Add("Paulo");
            lista.Insert(0, "Márcia");

            // AddRange(ICollection) - Adiciona a coleção de elementos ao final da lista
            // InsertRange(int index, ICollection) - Adiciona a coleção de elementos na Lista na posição do índice especificado
            lista.AddRange(array);
            lista.InsertRange(0, array2);

            // List<T> - Remover elementos

            // Remove(Object value) - Remove a primeira ocorrência de um objeto específico
            // RemoveAt(int index) - Remove o elemento no índice especificado
            // RemoveRange(int index, int count) - Remove um número definido de elementos a partir de um índice especificado
            lista.Remove("Felipe");

            // List<T> - Acesso aos elementos

            // Podemos acessar e atualizar os valores do elementos de uma List<T> usando o seu índice, da mesma forma que em um array.
            // O índice começa de zero e aumenta em um para cada elemento subsequente.
            Console.WriteLine(lista[0]);

            // List<T> - Iteração usando o laço for

            // Podemos iterar uma list<T> usando o laço for da mesma forma que nos arrays de uma dimensão. Usando a propriedade Count da List<T>
            // para obter o número total de elementos.

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"i: {i} listaCount: {lista.Count}");
                Console.WriteLine($"Count: {lista[i]}");
            }

            // List<T> - Iteração usando o laço foreach

            // Podemos iterar uma List<T> usando o laço foreach da mesma forma que em um array (não precisamos usar índices)

            foreach (var elemento in lista)
            {
                Console.WriteLine(elemento);
            }

            // List<T> - Verificar se um elemento está na coleção

            // O método Contains() pode ser usado para determinar se um elemento especificado exista na List<T> ou não.
            // O método retorna True se existir, caso contrário retorna False


            lista.Contains("Matheus"); // True
            lista.Contains("Ana"); // False

            // List<T> - Verificar se um elemento está na coleção

            // Para ordenar uma List<T> com elementos do mesmo tipo na ordem ascendente usamos o método Sort().
            lista.Sort();
            Console.WriteLine($"Lista ordenada: {String.Join(", ", lista)}");

            // Para remover todos os elementos de uma List<T> sem alterar sua capacidade usamos o método Clear()
            lista.Clear();
            Console.WriteLine($"Quantidade de elementos: {lista.Count}");
        }
    }
}

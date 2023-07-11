using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioColecoes
{
    public class Exercicio1
    {
        public static void Exercicio()
        {
            // a- Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
            string[] frutas = { "Maçã", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora" };
            for (int i = 0; i < frutas.Length; i++)
            {
                Console.Write($"Frutas: {frutas[i]} | ");
                Console.Write($"Quantidade de frutas: {frutas.Length} \n");
            }

            // b- Exiba os nomes da segunda e da penúltima fruta no console
            var segundaFruta = frutas[1];
            var penultimaFruta = frutas[8];
            Console.WriteLine($"Segunda fruta: {segundaFruta} | Penúltima fruta: {penultimaFruta}");

            // c- Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas
            frutas[2] = "Kiwi";
            frutas[frutas.Length - 1] = "Caqui";
            foreach (var fruta in frutas)
            {
                Console.WriteLine($"Frutas: {fruta}");
            }

            // d- Ordene a coleção de frutas na ordem ascendente
            Array.Sort(frutas);
            Console.WriteLine("\n\nOrdenando a coleção de frutas com Array.Sort()");
            foreach (var fruta in frutas)
            {
                Console.WriteLine($"Frutas: {fruta}");
            }


            //e - Exiba no console a coleção de nomes de frutas na ordem inversa
            Array.Reverse(frutas);
            Console.WriteLine("\n\nInvertendo a ordem da coleção");
            foreach (var fruta in frutas)
            {
                Console.WriteLine($"Frutas: {fruta}");
            }
        }
    }
}

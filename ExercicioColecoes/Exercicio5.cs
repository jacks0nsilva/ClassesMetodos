using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioColecoes
{
    public class Exercicio5
    {
        //1- Crie um método para exibir a relação de produtos , a soma total dos preços dos produtos, a média do
        //preço dos produtos e a quantidade de produtos na lista
        //2- Inclua na lista o seguinte produto : Mochila, R$ 22,44 e exiba novamente a lista de produtos
        //3- Ordene a lista pelo nome do produto e exiba a lista ordenada
        //4- Obtenha e exiba no console os produtos com preço inferior a R$ 5,00
        //5- Localize na lista o produto com nome Estojo

        public static void Exercicio()
        {
            List<Produto> lista = new() 
            { 
                new Produto { Nome = "Clips", Preco = 3.95},
                new Produto {Nome = "Caneta", Preco = 5.99},
                new Produto {Nome = "Lápis", Preco = 4.15},
                new Produto {Nome = "Estojo", Preco = 6.99},
                new Produto {Nome = "Caderno", Preco = 7.75}
            };
            ExibirProdutos(lista);

            Produto mochila = new() { Nome = "Mochila", Preco = 22.44 };
            lista.Add(mochila);

            ExibirProdutos(lista);

            var listaOrdenada = lista.OrderBy(n=> n.Nome).ToList();
            ExibirProdutos(listaOrdenada);

            var produtosBaratos = lista.FindAll(p=> p.Preco < 5);
            ExibirProdutos(produtosBaratos);

            var estojo = lista.Find(p=> p.Nome.Equals("Estojo"));
            Console.WriteLine($"\n{estojo?.Nome} | {estojo?.Preco:C2}");

            void ExibirProdutos(List<Produto> list)
            {
                double somaPrecos = 0.0;
                int quantidadeProdutos = list.Count;
                Console.WriteLine("\n-- Produtos --\n");
                foreach (var item in list)
                {
                    Console.WriteLine($"{item.Nome} | {item.Preco:C2}");
                    somaPrecos += item.Preco;
                }
                double mediaPrecos = somaPrecos / quantidadeProdutos;
                Console.WriteLine($"\n Quantidade de produtos: {quantidadeProdutos} | Preço total: {somaPrecos:C2} Média de preço: {mediaPrecos:C2}");
            }

        }

        class Produto
        {
            public string? Nome { get; set; }
            public double Preco { get; set; }
        }
    }
}

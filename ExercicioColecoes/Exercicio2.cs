using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioColecoes
{
    public class Exercicio2
    {
        public static void Exercicio()
        {
            Console.WriteLine("Insira o tamanho do array: ");
            int tamanhoArray = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[tamanhoArray];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Insira um valor para o array");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nQual número você deseja procurar no Array?");
            string numero;

            Console.WriteLine("\nInforme o número a localizar no array (Tecle fim para encerrar) : \n");
            do
            {
                numero = Console.ReadLine();

                if(numero != "fim") { 
                    int valor = Convert.ToInt32(numero);
                    Console.WriteLine(Array.BinarySearch(array, valor));
                    if (Array.BinarySearch(array, valor) >= 0)
                    {
                        Console.WriteLine($"\nO número {numero} Existe no array");
                    }
                    else
                    {
                        Console.WriteLine($"\nO número {numero} NÃO Existe no array");
                    }
                }

            } while (numero != "fim");
        }
    }
}

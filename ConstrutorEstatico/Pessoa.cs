using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorEstatico
{
    internal class Pessoa
    {
        public static int IdadeMinima;

        public int Idade { get; set; }
        public string? Nome { get; set; }

        public Pessoa(int idade, string nome) // ctor
        {
            Console.WriteLine("\n Executando o construtor parametrizado!");
            Idade = idade;
            Nome = nome;
        }
        public Pessoa()
        { }

        static Pessoa()
        {
            Console.WriteLine("\n Executando o construtor estático"); // Primeiro a ser executado
            Console.WriteLine("\n Inicializando o campo IdadeMinima");
            IdadeMinima = 18;
        }
    }
}

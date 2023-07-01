using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Carro
    {
        public string? Modelo { get; set; }
        public string? Montadora { get; set; }
        public string? Marca { get; set; }
        public int Ano { get; set; }
        public int Potencia { get; set; }
        public int Cor;
        public Carro(string modelo, string montadora, string marca, int ano, int potencia, int cor)
        {
            Modelo = modelo;
            Montadora = montadora;
            Marca = marca;
            Ano = ano;
            Potencia = potencia;
            Cor = cor;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Montadora: {Montadora}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Potência: {Potencia}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Cor: {(Cores)Cor}");
        }
    }



    enum Cores
    {
        Branco = 1,
        Vermelho,
        Preto,
        Cinza,
        Prata,
        Azul
    }
}

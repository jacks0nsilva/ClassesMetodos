using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseDosCarros
{
    internal class Carro
    {
        public string? Modelo;
        public string? Montadora;
        public string? Marca;
        public int Ano;
        public int Potencia;

        public Carro(string modelo, string montadora, string marca, int ano, int potencia)
        {
            Modelo = modelo;
            Montadora = montadora;
            Marca = marca;
            Ano = ano;
            Potencia = potencia;
        }

        public Carro(string modelo, string montadora)
        {
            Modelo = modelo;
            Montadora = montadora;
        }

 
        public void Acelerar(string? marca)
        {
            Console.WriteLine($"Acelerando o meu {marca}");
        }

        public int VelocidadeMaxima(int potencia)
        {
            int velocidade = (int)(potencia * 1.75);
            Console.WriteLine($"A velocidade máxima do {Marca} é de {velocidade} km/h");
            return velocidade;
        }

        public int AumentarPotencia(int potencia)
        {
            potencia += 3;
            return potencia;
        }

        public int AumentarPotencia(ref int potencia)
        {
            potencia += 3;
            return potencia;
        }

        public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
        {
            potencia += 7;
            velocidade = potencia * 1.75;
            return potencia;
        }

        public void ExibirInfo(string? modelo, string? montadora, string? marca, int potencia, int ano = 2000) // Parâmetro ano definido como padrão
        {
            Console.WriteLine($"Modelo: {modelo} | Montadora: {montadora} | Marca: {marca} | Potencia: {potencia}Cv | Ano: {ano}");
        }
    }
}

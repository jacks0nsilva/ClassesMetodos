using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Produto
    {
        // Ao usar as propriedades, podemos utilizar os métodos get e set para restringir o acesso e efetuar validações
        private string? nome; // O campo de apoio deve ser do mesmo tipo da propriedade 
        public string? Nome 
        { 
            get { return nome?.ToUpper(); } 
            set { nome = value; }
        }

        private double preco;
        public double Preco 
        { 
            get { return preco; } 
            set // Se o preço do produto for menor que 5, será atribuido o valor 5
            {
                if(value < 5)
                {
                    preco = 5;
                }
                else
                {
                    preco = value;
                }
            }
        }
        private double desconto = 0.05;
        public double Desconto 
        {
            get { return desconto; } // Somente leitura
        }


        public double PrecoFinal 
        {
            get { return Preco - (Preco * Desconto); }
        }
        public int EstoqueMinimo { get; set; }

        public void Exibir()
        {
            Console.WriteLine($"{Nome} \n{Preco:C} \n{Desconto} \n{PrecoFinal:C} \n{EstoqueMinimo}");

        }
    }
}

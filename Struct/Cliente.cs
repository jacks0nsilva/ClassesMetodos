using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal struct Cliente
    {
        public string? Nome;
        public string? Email;

        private int idade;
        public int Idade 
        {
            get { return idade; }
            set
            {
                if(value < 18)
                {
                    idade = 18;
                    Console.WriteLine($"Cliente: {Nome} menor de 18 anos");
                }
                else
                {
                    idade = value;
                    Console.WriteLine($"Cliente: {Nome} maior que 18 anos");
                }
            } 
        }

        public Cliente(string nome, string email, int idade)
        {
            this.idade = 0; // É necessário atribuir um valor ao campo idade, antes de inicializar o construtor
            Nome = nome;
            Email = email;
            Idade = idade;
        }

        public void ExibirINfo(string? nome, string? email, int idade = 0)
        {
            Console.WriteLine($"Nome: {nome} | Email: {email} | Idade:{idade}");

        }
    }
}

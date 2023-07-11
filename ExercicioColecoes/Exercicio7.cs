using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioColecoes
{
    public class Exercicio7
    {
        public static void Exercicio()
        {
            Aluno alunos = new();

            // atribuindo valores = set
            alunos[0] = "João";
            alunos[1] = "Marcos";
            alunos[2] = "José";
            alunos[3] = "Marta";
            alunos[4] = "Valentina";

            // obtendo os valores = get
            string nome1 = alunos[0];
            string nome2 = alunos[1];
            string nome3 = alunos[2];
            string nome4 = alunos[3];
            string nome5 = alunos[4];

            // exibir
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);
            Console.WriteLine(nome5);

        }
        class Aluno
        {
            // Limite do array definido
            string[] nomes = new string[10];

            public string this[int i]
            {
                get
                {
                    if(i>= 0 && i < nomes.Length)
                    {
                        return nomes[i]; // ex: alunos[1], alunos[2], alunos[3]...
                    }
                    else
                    {
                        return "Erro"; // ex: alunos[-1], alunos[100], alunos[-100]...
                    }
                }
                set 
                {
                    if(i>=0 && i < nomes.Length)
                    {
                        nomes[i] = value; // ex: alunos[1] = "Marcos";
                    }
                }
            }
        }
    }
}

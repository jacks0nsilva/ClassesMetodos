using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ExercicioColecoes
{
    public class Exercicio6
    {
        static public void Exercicio()
        {
            //Método estático : permite ser invocao sem criar instância da classe
            // Usa o array de parâmetros definido pela palavra-chave params
            // Define um variável chamada vetor do tipo object
            // Assim pode receber tipos por valor e tipos por referência

            void ProcessaObjetos(params object[] vetor)
            {
                Console.WriteLine("\nExibindo o conteúdo do array de objetos...\n");

                if (vetor != null)
                {
                    foreach (var objeto in vetor)
                    {
                        //Estamos usando GetType() herdado de Object
                        // E usamos o operador ? conhecido como “null-conditional operator”
                        // ou elvis operator, que determina se valor é null; se assim for,
                        // o método GetType() não será invocado e não teremos exceção
                        // NullReferenceException.
                        Console.WriteLine($"objeto: {objeto} \t tipo: {objeto?.GetType()}");
                    }
                }
            }

            //invoca o método estático e passa os argumentos
            ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null);
        }

        class Teste {}
    }
}

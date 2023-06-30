using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamposEstaticos
{
    internal class ContaCorrente
    {
        public int Conta;
        public string? Nome;
        public static float Juros; // O Campo Juros é igual para todos os objetos da classe ContaCorrente

        public float JurosAnual()
        {
            return Juros * 12;
        }
    }
}

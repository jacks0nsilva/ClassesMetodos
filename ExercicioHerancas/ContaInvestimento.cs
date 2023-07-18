using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerancas
{
    public class ContaInvestimento : ContaCorrente
    {
        public override decimal Juros { get; set; } = 0.009m;
        public decimal Imposto { get; set; } = 0.001m;


        public override decimal Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo = Saldo - valor - (Saldo * Imposto);
                return Saldo;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente...");
                return Saldo;
            }
        }
    }
}

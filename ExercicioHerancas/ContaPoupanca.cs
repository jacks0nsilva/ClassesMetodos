using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerancas
{
    public class ContaPoupanca : ContaCorrente
    {
        public override decimal Juros { get; set; } = 0.005m;

        public override decimal Sacar(decimal valor)
        {
            if(Saldo >= valor)
            {
                Saldo -= valor;
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

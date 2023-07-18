using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerancas
{
    public class ContaCorrente
    {
        public int Numero { get; set; }
        public string? Titular { get; set; }
        public decimal Saldo { get; set; } = 0.00m;
        public virtual decimal Juros { get; set; } = 0.000m;

        public virtual decimal Sacar(decimal valor)
        {
            Saldo -= valor;
            return Saldo;
        }

        public  decimal Depositar(decimal valor)
        {
            Saldo += valor;
            Saldo += (Saldo * Juros);
            return Saldo;
        } 
    }
}

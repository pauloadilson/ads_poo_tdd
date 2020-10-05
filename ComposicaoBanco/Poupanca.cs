using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        public double Saldo { get; private set; }
        public Poupanca()
        {
        }

        public Poupanca(double saldo)
        {
            this.Saldo = saldo;
        }
        public void Depositar(double deposito)
        {
            Saldo = Saldo + deposito;
        }

        public void Sacar(double saque)
        {
            Saldo -= saque;
        }
        ~Poupanca()
        {
            Console.WriteLine("Devido a falência, essa conta poupança foi encerrada!");
        }

    }
}

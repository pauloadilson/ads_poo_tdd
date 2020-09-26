using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    class Conta
    {
        private int numero;
        private Cliente titular;
        private double saldo;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public Cliente Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public void Mostrar()
        {
            Console.WriteLine($"Numero: {Numero}\tSaldo: {Saldo}");
            this.Titular.Mostrar();
        }
    }
}

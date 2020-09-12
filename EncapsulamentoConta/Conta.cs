using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        private int numero;
        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        private string titular;
        public string Titular
        {
            get { return this.titular; }
            set { this.titular = value; }
        }

        private double saldo;
        public double Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }


        public Conta(int numero = 0, string titular = "", double saldo = 0.0)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }
    }
}

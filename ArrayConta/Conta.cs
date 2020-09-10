using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConta
{
    public class Conta
    {
        public int numero;
        public string titular;
        public double saldo;

        public Conta(int numero = 0, string titular = "", double saldo = 0.0)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }
    }
}

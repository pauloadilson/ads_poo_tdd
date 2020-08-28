using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ADS_N
{
    public class Conta
    {
        private int numero;
        private string titular;
        private double saldo;

        public Conta(int numero = 0, string titular = "", double saldo = 0.0)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public void Depositar(double deposito)
        {
            saldo += deposito;
        }

        public void Sacar(double saque)
        {
            saldo -= saque;
        }

        public string Mostrar()
        {
            string result = $"{titular}. Conta {numero}. Saldo: {saldo.ToString("C")}";
            Console.WriteLine(result);
            return result;
        }
    }
}

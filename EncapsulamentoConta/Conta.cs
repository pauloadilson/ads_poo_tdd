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
        private string titular;
        private double saldo;

        public Conta() // UTILIZADO PARA CADASTRO -- INSERT
            {
            }
        public Conta(int numero = 0, string titular = null, double saldo = 0) // UTILIZADO NA BUSCA query em BD
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }
        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public string Titular
        {
            get { return this.titular; }
            set { this.titular = value; }
        }

        public double Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }

        public void Depositar(double deposito)
        {
            saldo += deposito;
        }

        public void Sacar(double saque)
        {
            saldo -= saque;
        }

        public void Mostrar()
        {
            string result = $"{titular}. Conta {numero}. Saldo: {saldo:C}";
            Console.WriteLine(result);
        }

        public void Transferencia(float valorTranferido, Conta destino)
        {
            saldo -= valorTranferido;
            destino.saldo += valorTranferido;
        }
    }
}

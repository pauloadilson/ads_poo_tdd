using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        public double Saldo { get; private set; }
        public double ChequeEspecial { get; set; }
        public double SaldoChequeEspecial { get; private set; }

        public ContaCorrente()
        {
        }

        public ContaCorrente(double saldo)
        {
            Saldo = saldo;
        }
        public ContaCorrente(double saldo, double chequeEspecial)
        {
            Saldo = saldo;
            ChequeEspecial = chequeEspecial;
            SaldoChequeEspecial = chequeEspecial;
        }
        public void Depositar(double deposito)
        {
            if (ChequeEspecialFoiUsado())
            {
                double valorUsado = ValorChequeEspecialUsado();
                if (valorUsado > deposito)
                    SaldoChequeEspecial += deposito;
                else
                {
                    Saldo = deposito - valorUsado;
                    SaldoChequeEspecial += valorUsado;
                }
            }
            else
              Saldo += deposito;
        }

        private double ValorChequeEspecialUsado()
        {
            return ChequeEspecial - SaldoChequeEspecial;
        }

        private bool ChequeEspecialFoiUsado()
        {
            return ChequeEspecial > SaldoChequeEspecial;
        }

        private bool ExisteSaldoSuficienteEmContaCorrente(double saque)
        {
            return saque <= Saldo;
        }
        private bool ExisteSaldoChequeEspecial(double saque)
        {
            double _ = saque - Saldo;
            return _ < SaldoChequeEspecial;
        }
        public void Sacar(double saque)
        {
            if (ExisteSaldoSuficienteEmContaCorrente(saque))
                Saldo -= saque;
            else
                SacarChequeEspecial(saque);
        }

        private void SacarChequeEspecial(double saque)
        {
            if (ExisteSaldoChequeEspecial(saque))
            {
                SaldoChequeEspecial -= (saque - Saldo);
                Saldo = 0;
            }
        }
        ~ContaCorrente()
        {
            Console.WriteLine("Desestruturando Conta Corrente!");
        }
    }
}

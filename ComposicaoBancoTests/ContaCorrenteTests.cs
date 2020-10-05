using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComposicaoBanco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoBanco.Tests
{
    [TestClass()]
    public class ContaCorrenteTests
    {
        private ContaCorrente _,_2;
        [TestInitialize]
        public void CriarContaCorrente()
        {
            _ = new ContaCorrente();
        }
        [TestMethod()]
        public void ObterSaldo()
        {
            Assert.AreEqual(0, _.Saldo);
        }
        [TestMethod()]
        public void Depositar()
        {
            _.Depositar(200.0);
            Assert.AreEqual(200.0, _.Saldo);
        }
        [TestMethod()]
        public void SacarComSaldoContaCorrente()
        {
            _.Depositar(200.0);
            _.Sacar(100);
            Assert.AreEqual(100, _.Saldo);
        }
        [TestMethod()]
        public void SaqueIgualSaldoContaCorrente()
        {
            _.Depositar(200.0);
            _.Sacar(200);
            Assert.AreEqual(0, _.Saldo);
        }
        [TestMethod()]
        public void SaqueSemSaldoContaCorrenteUsandoChequeEspecial()
        {
            _2 = new ContaCorrente(0,300);
            _2.Sacar(200);
            Assert.AreEqual(0, _2.Saldo);
            Assert.AreEqual(300, _2.ChequeEspecial);
            Assert.AreEqual(100, _2.SaldoChequeEspecial);
        }
        [TestMethod()]
        public void DepositoMenorQueChequeEspecialUsado()
        {
            _2 = new ContaCorrente(0, 300);
            _2.Sacar(200);
            Assert.AreEqual(100, _2.SaldoChequeEspecial);
            _2.Depositar(70.0);
            Assert.AreEqual(0, _2.Saldo);
            Assert.AreEqual(300, _2.ChequeEspecial);
            Assert.AreEqual(170, _2.SaldoChequeEspecial);
        }
        [TestMethod()]
        public void DepositoMaiorQueChequeEspecialUsado()
        {
            _2 = new ContaCorrente(0, 300);
            _2.Sacar(200);
            Assert.AreEqual(100, _2.SaldoChequeEspecial);
            _2.Depositar(400.0);
            Assert.AreEqual(200, _2.Saldo);
            Assert.AreEqual(300, _2.ChequeEspecial);
            Assert.AreEqual(300, _2.SaldoChequeEspecial);
        }

    }
}
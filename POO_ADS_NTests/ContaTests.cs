using Microsoft.VisualStudio.TestTools.UnitTesting;
using POO_ADS_N;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ADS_N.Tests
{
    [TestClass()]
    public class ContaTests
    {
        [TestMethod()]
        public void InstanciarObterSaldoTest()
        {
            Conta _ = new Conta(1, "Paulo", 2000.0);
            Assert.AreEqual(2000.0, _.GetSaldo());
        }
        [TestMethod()]
        public void InstanciarValoresPadraoObterSaldoTest()
        {
            Conta _ = new Conta();
            Assert.AreEqual(0.0, _.GetSaldo());
        }
        [TestMethod()]
        public void InstanciarDepositarTest()
        {
            Conta _ = new Conta(1, "Paulo", 2000.0);
            _.Depositar(200);
            Assert.AreEqual(2200.0, _.GetSaldo());
        }
        [TestMethod()]
        public void InstanciarContaAtribuirSaldoSacarTest()
        {
            Conta _ = new Conta(1, "Paulo", 2000.0);
            _.Sacar(100);
            Assert.AreEqual(1900.0, _.GetSaldo());
        }
        [TestMethod()]
        public void InstanciarDuasContasTransferirValorTest()
        {
            Conta _1 = new Conta(1, "Paulo", 2000.0);
            Conta _2 = new Conta(2, "José", 4000.0);
            _1.Transferencia(200, _2);
            Assert.AreEqual(1800.0, _1.GetSaldo());
            Assert.AreEqual(4200.0, _2.GetSaldo());
        }
        [TestMethod]
        public void InstanciarContaExibirDadosTest()
        {
            Conta _ = new Conta(1, "Paulo", 2000.0);
            var currentConsoleOut = Console.Out;
            // currentConsoleOut registra o console out no início
            string expected = "Paulo. Conta 1. Saldo: R$ 2.000,00";

            using (ConsoleOutput consoleOutput = new ConsoleOutput())
            {
                _.Mostrar();
                Assert.AreEqual(expected, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
            // Essa comparação serve para verificar se ConsoleOutput Disposed/limpou o output depois do teste
        }
    }
}

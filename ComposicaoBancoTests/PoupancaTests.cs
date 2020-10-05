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
    public class PoupancaTests
    {
        private Poupanca _;
        [TestInitialize]
        public void CriarContaCorrente()
        {
            _ = new Poupanca();
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
        public void Sacar()
        {
            _.Depositar(200.0);
            _.Sacar(100);
            Assert.AreEqual(100, _.Saldo);
        }
    }
}
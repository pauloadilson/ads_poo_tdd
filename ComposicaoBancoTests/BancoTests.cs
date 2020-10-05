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
    public class BancoTests
    {
        private Banco _;
        [TestInitialize]
        public void CriarBanco()
        {
            _ = new Banco();
        }
        [TestMethod()]
        public void BancoSemContas()
        {
            Assert.IsTrue(_.isEmpty());
        }
        [TestMethod()]
        public void AbrirContaCorrente()
        {
            ContaCorrente cc = new ContaCorrente(200);
            _.abrirContaCorrente(cc);
            Assert.IsFalse(_.isEmpty());
            Assert.AreEqual(1, _.ContasCorrente.Count);
        }
        [TestMethod()]
        public void AbrirPoupanca()
        {
            Poupanca pp = new Poupanca(2000);
            _.abrirPoupanca(pp);
            Assert.IsFalse(_.isEmpty());
            Assert.AreEqual(1, _.Poupancas.Count);
        }
        [TestMethod()]
        public void FalenciaBanco()
        {
            Poupanca pp = new Poupanca(2000);
            _.abrirPoupanca(pp);
            ContaCorrente cc = new ContaCorrente(200);
            _.abrirContaCorrente(cc);
            Assert.AreEqual(1, _.ContasCorrente.Count);
            Assert.AreEqual(1, _.Poupancas.Count);
            _.falencia();
            Assert.IsNull(_.ContasCorrente);
            Assert.IsNull(_.Poupancas);
        }
    }
}
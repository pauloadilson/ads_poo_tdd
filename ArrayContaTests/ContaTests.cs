using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayConta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConta.Tests
{
    [TestClass()]
    public class ContaTests
    {
        [TestMethod()]
        public void CriaInstanciaTest()
        {
            Conta _ = new Conta(1234, "Paulo", 2999.9);
            Assert.IsNotNull(_);
        }

    }
}
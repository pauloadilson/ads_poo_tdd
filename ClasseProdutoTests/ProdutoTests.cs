using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasseProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseProduto.Tests
{
    [TestClass()]
    public class ProdutoTests
    {
        [TestMethod()]
        public void CriaInstanciaTest()
        {
            Produto _ = new Produto(110, "Mouse", 9.9);
            Assert.IsNotNull(_);
        }
        [TestMethod()]
        public void InstanciarMostrarTest()
        {
            
            Produto _ = new Produto(110, "Mouse", 9.9);
            var currentConsoleOut = Console.Out;
            string expected = "Produto: Mouse. Código 110. Preço: R$ 9,90";

            using (ConsoleOutput consoleOutput = new ConsoleOutput())
            {
                _.Mostrar();
                Assert.AreEqual(expected, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);

        }
    }
}
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
        public void CriaProdutoGetTest()
        {
            Produto _ = new Produto(110, "Mouse", 9.9);
            Assert.AreEqual(9.9, _.Preco);
        }
        [TestMethod()]
        public void CriaProdutoSetTest()
        {
            Produto _ = new Produto(110, "Mouse", 9.9);
            _.Preco = 12.9;
            Assert.AreEqual(12.9, _.Preco);
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
        [TestMethod()]
        public void CriaTresProdutosSomaTotalTest()
        {
            Produto _ = new Produto(110, "Mouse", 9.9);
            Produto _2 = new Produto(111, "Teclado", 19.9);
            Produto _3 = new Produto(112, "Mousepad", 5.9);
            Assert.AreEqual(35,7, _.somaProdutos(_,_2,_3));
        }
    }
}
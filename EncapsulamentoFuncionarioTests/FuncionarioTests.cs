using Microsoft.VisualStudio.TestTools.UnitTesting;
using EncapsulamentoFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario.Tests
{
    [TestClass()]
    public class FuncionarioTests
    {
        [TestMethod()]
        public void CriaInstanciaTest()
        {
            Funcionario _ = new Funcionario(0, "Paulo", 5000.0);
            Assert.IsNotNull(_);
        }
        [TestMethod()]
        public void CriaInstanciaGetAtributosTest()
        {
            Funcionario _ = new Funcionario(0, "Paulo", 5000.0);
            Assert.AreEqual(0, _.Codigo);
            Assert.AreEqual("Paulo", _.Nome);
            Assert.AreEqual(5000.0, _.Salario);

        }
        [TestMethod()]
        public void CriaInstanciaSetAtributosTest()
        {
            Funcionario _ = new Funcionario(0, "Paulo", 5000.0);
            _.Codigo = 123;
            _.Nome = "João";
            _.Salario = 7500;
            Assert.AreEqual(123, _.Codigo);
            Assert.AreEqual("João", _.Nome);
            Assert.AreEqual(7500, _.Salario);

        }
        [TestMethod()]
        public void InstanciarMostrarTest()
        {
            Funcionario _ = new Funcionario(0, "Paulo", 5000.0);
            var currentConsoleOut = Console.Out;
            string expected = "Funcionário: Paulo. Código 0. Salário: R$ 5.000,00";

            using (ConsoleOutput consoleOutput = new ConsoleOutput())
            {
                _.Mostrar();
                Assert.AreEqual(expected, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
            // Essa comparação serve para verificar se ConsoleOutput Disposed/limpou o output depois do teste
        }
        [TestMethod()]
        public void InstanciarMostrarDescritoTest()
        {
            Funcionario _ = new Funcionario(0, "Paulo", 5000.50);
            _.Salario = Convert.ToDouble("5000,50");
            var currentConsoleOut = Console.Out;
            string expected = "Funcionário: Paulo. Código 0. Salário: R$ 5.000,50";

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
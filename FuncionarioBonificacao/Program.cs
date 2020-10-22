using FuncionarioBonificacaoHeranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioBonificacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Secretario sec = new Secretario(1234, "Paulo", 1000.0);
            sec.AplicarBonificacaoNoSalario();
            Console.WriteLine($"No fim do ano o salário do Secretario {sec.Nome} é {sec.Salario:C}.");
            Gerente ger = new Gerente(1234, "Paulo", 1000.0);
            ger.AplicarBonificacaoNoSalario();
            Console.WriteLine($"No fim do ano o salário do Gerente {ger.Nome} é {ger.Salario:C}.");
            Diretor dir = new Diretor(1234, "Paulo", 1000.0);
            dir.AplicarBonificacaoNoSalario();
            Console.WriteLine($"No fim do ano o salário do Diretor {dir.Nome} é {dir.Salario:C}.");

            Console.ReadKey();
        }
    }
}

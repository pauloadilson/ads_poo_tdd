using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();

            ContaCorrente cc1 = new ContaCorrente(200);
            ContaCorrente cc2 = new ContaCorrente(300);
            banco.abrirContaCorrente(cc1);
            banco.abrirContaCorrente(cc2);
            Console.WriteLine($"Há {banco.ContasCorrente.Count} contas correntes.");
            banco.ContasCorrente[0].Sacar(200);
            banco.ContasCorrente[1].Depositar(200);
            Console.Write($"Os saldos das Contas corrente são ");
            foreach (ContaCorrente c in banco.ContasCorrente)
                Console.Write($"{c.Saldo:C} ");

            Poupanca pp1 = new Poupanca(1000);
            banco.abrirPoupanca(pp1);
            Console.WriteLine($"Há {banco.Poupancas.Count} poupanças.");
            banco.Poupancas[0].Depositar(200);
            Console.WriteLine($"Saldo da poupança {banco.Poupancas[0].Saldo:C}.");

            banco = null;
            GC.Collect();
            Console.ReadKey();
        }
    }
}

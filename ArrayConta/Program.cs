using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta[] contas = new Conta[3];
            // Gere o total desses produtos
            Console.WriteLine("Vamos realizar o cadastro de dois produtos!");
            for (int i = 0; i < 3; i++)
            {
                contas[i] = new Conta(); //deve-se instanciar cada posicao
                Console.Write($"\nInforme o número da {i + 1}ª conta: ");
                contas[i].numero = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Informe o nome do titular: ");
                contas[i].titular = Console.ReadLine();
                Console.Write($"Informe o saldo da conta: R$ ");
                contas[i].saldo = Convert.ToDouble(Console.ReadLine());

            }

            Console.Write("\nDeseja mostrar todos os dados em sequência? (S ou N) ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "s")
            {
                foreach (Conta c in contas)
                    Console.WriteLine($"Titular: {c.titular}. Conta {c.numero}. Saldo: {c.saldo.ToString("C")}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Fim");
                Console.ReadKey();
            }
        }
    }
}

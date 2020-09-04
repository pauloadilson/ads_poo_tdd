using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario[] funcionarios = new Funcionario[2];
            Console.WriteLine("Vamos realizar o cadastro de dois funcionários!");
            for (int i = 0; i < 2; i++)
            {
                funcionarios[i] = new Funcionario();
                Console.Write($"Informe o código do {i + 1}º funcionário: ");
                funcionarios[i].codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Informe o nome: ");
                funcionarios[i].nome = Console.ReadLine();
                Console.Write($"Informe o salário: R$ ");
                funcionarios[i].salario = Convert.ToDouble(Console.ReadLine());
                funcionarios[i].Mostrar();
            }
            Console.Write("\nDeseja mostrar todos os dados em sequência? (S ou N) ");
            string resposta = Console.ReadLine().ToLower();
            if (resposta == "s")
            {
                foreach (Funcionario f in funcionarios)
                {
                    f.Mostrar();
                }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto[] produtos = new Produto[2];
            Console.WriteLine("Vamos realizar o cadastro de dois produtos!");
            for (int i = 0; i < 2; i++)
            {
                produtos[i] = new Produto();
                Console.Write($"Informe o código do {i + 1}º produto: ");
                produtos[i].codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Informe a descrição do produto: ");
                produtos[i].descricao = Console.ReadLine();
                Console.Write($"Informe o preço: R$ ");
                produtos[i].preco = Convert.ToDouble(Console.ReadLine());
                produtos[i].Mostrar();
            }
            Console.Write("\nDeseja mostrar todos os dados em sequência? (S ou N) ");
            string resposta = Console.ReadLine().ToLower();
            if (resposta == "s")
            {
                foreach (Produto f in produtos)
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

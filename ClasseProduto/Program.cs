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
            Console.WriteLine("Quantos produtos deseja cadastrar?");
            int nCadastros = Convert.ToInt32(Console.ReadLine());
            Produto[] produtos = new Produto[nCadastros];
            for (int i = 0; i < nCadastros; i++)
            {
                produtos[i] = new Produto(); //deve-se instanciar cada posicao
                Console.Write($"Informe o código do {i + 1}º produto: ");
                produtos[i].codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Informe a descrição do produto: ");
                produtos[i].descricao = Console.ReadLine();
                Console.Write($"Informe o preço: R$ ");
                produtos[i].preco = Convert.ToDouble(Console.ReadLine());
                produtos[i].Mostrar();
            }
            /* O que está abaixo não é possível: 
             * foreach precisa de um vetor preenchido
            foreach (Produto p in produtos)
            {
                p.codigo = Convert.ToInt32(Console.ReadLine());
                p.descricao = Console.ReadLine();
                p.preco = Convert.ToDouble(Console.ReadLine());
                p.Mostrar();
            }*/
            Console.Write("\nDeseja mostrar todos os dados em sequência? (S ou N) ");
            string resposta = Console.ReadLine().ToLower();
            if (resposta == "s")
            {
                foreach (Produto p in produtos)
                    p.Mostrar();
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

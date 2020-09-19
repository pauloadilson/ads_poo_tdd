using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
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
                Console.Write($"\nInforme o código do {i + 1}º produto: ");
                produtos[i].Codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Informe a descrição do produto: ");
                produtos[i].Descricao = Console.ReadLine();
                Console.Write($"Informe o preço: R$ ");
                produtos[i].Preco = Convert.ToDouble(Console.ReadLine());
            }
            double somaProdutos = 0;
            foreach (Produto p in produtos)
            {
                somaProdutos += p.Preco;
                p.Mostrar();
            }
            Console.WriteLine($"\nA soma dos produtos registrados é R$ {somaProdutos:C}.");
            Console.ReadKey();

        }
    }
}

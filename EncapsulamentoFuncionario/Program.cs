using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            f1.Codigo = 1; //set
            f1.Nome = "Ana";
            f1.Salario = 100;

            Funcionario f2 = new Funcionario();
            Console.Write("Digite o código: ");
            f2.Codigo = Convert.ToInt32(Console.ReadLine()); //set
            Console.Write("Digite o nome: ");
            f2.Nome = Console.ReadLine(); //set
            Console.Write("Digite o salário: ");
            f2.Salario = Convert.ToDouble(Console.ReadLine()); //set
            Console.WriteLine("Nome do f1: " + f1.Nome);//get
            Console.ReadKey();
        }
    }
}

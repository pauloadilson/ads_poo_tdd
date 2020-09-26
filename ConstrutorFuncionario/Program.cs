using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario c1 = new Funcionario();//utilização para cadastro
            c1.Mostrar();

            Funcionario c2 = new Funcionario(123,2000.0);
            c2.Mostrar();

            Funcionario c3 = new Funcionario(199, "Ana", 1005.0);//pesquisa de um banco
            c3.Mostrar();

            Console.WriteLine($"A quantidade de instâncias é {Funcionario.Contador}");

            Console.ReadKey();
        }
    }
}

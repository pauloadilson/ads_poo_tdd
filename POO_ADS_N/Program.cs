using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ADS_N
{
    class Program
    {
        static void Main(string[] args)
        {
            //criar um variável da classe: conta1
            Conta conta1;
            conta1 = new Conta();//instânciando o objeto conta1
            conta1.numero = 89;
            conta1.titular = "Ana";
            conta1.saldo = 1000;
            Console.Write("Informe o valor do saque: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            conta1.Sacar(valor);
            conta1.Mostrar();
            Console.WriteLine("Saldo: " + conta1.saldo);
            //outra forma de instanciar objeto e que será utilizada nas aulas
            Conta conta2 = new Conta();
            conta2.numero = 23;
            conta2.titular = "Bia";
            conta2.saldo = 500;
            conta2.Mostrar();
            Console.Write("Informe o valor do depósito: ");
            valor = Convert.ToDouble(Console.ReadLine());
            conta2.Depositar(valor);
            Console.WriteLine("Saldo: " + conta2.saldo);
            // Instanciando mais um objeto
            Conta conta3 = new Conta();
            Console.Write("Digite o número: ");
            conta3.numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o nome: ");
            conta3.titular = Console.ReadLine();
            Console.Write("Digite o saldo: ");
            conta3.saldo = Convert.ToDouble(Console.ReadLine());
            conta3.Mostrar();
            conta3.Transferencia(10, conta2);
            conta2.Mostrar();
            conta3.Mostrar();

            Console.ReadKey();
        }
    }
}

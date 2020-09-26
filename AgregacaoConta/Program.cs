using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta();
            Cliente cliente = new Cliente();
            conta1.Numero = 1;
            conta1.Titular = cliente;
            conta1.Titular.Nome = "Ana";
            conta1.Titular.Rg = "1111";
            conta1.Titular.Cpf = "1121111-90";
            conta1.Saldo = 100;
            conta1.Mostrar();

            Conta conta2 = new Conta();
            conta2.Numero = 2;
            conta2.Titular = new Cliente();
            conta2.Titular.Nome = "Bia";
            conta2.Titular.Rg = "2222";
            conta2.Titular.Cpf = "22222-97";
            conta2.Saldo = 200;
            conta2.Mostrar();
            Console.ReadKey();
        }
    }
}

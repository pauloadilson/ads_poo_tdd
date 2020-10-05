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
            conta1.Numero = 1;
            conta1.Saldo = 100;
            Cliente cliente1 = new Cliente("Ana","111","1118-60");
            Cliente cliente2 = new Cliente("Paulo", "222", "1236-00");
            conta1.Titular = new List<Cliente>(); // precisa instanciar o list 
            conta1.Titular.Add(cliente1);
            conta1.Titular.Add(cliente2);
            conta1.Mostrar();

            Console.ReadKey();
        }
    }
}

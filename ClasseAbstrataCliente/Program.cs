using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrataCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteFisico cf = new ClienteFisico(123, "Paulo", 34, "35307319860");
            cf.Mostrar();
            Console.WriteLine(cf.VerificaIdade(cf));

            Teste t = new Teste();
            Console.WriteLine(t.AnalisaIdade(cf));

            ClienteJuridico cj = new ClienteJuridico(456, "Adilson", 40, "35123789000110");
            cj.Mostrar();
            Console.WriteLine(cj.VerificaIdade(cj));
            Console.WriteLine(t.AnalisaIdade(cj));

            ClienteJuridico cj2 = new ClienteJuridico(456, "Adilson", 65, "35123789000110");
            cj2.Mostrar();
            Console.WriteLine(cj.VerificaIdade(cj2));

            Console.WriteLine(t.AnalisaIdade(cj2));

            Console.ReadKey();

        }
    }
}

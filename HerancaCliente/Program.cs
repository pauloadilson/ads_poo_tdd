using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            c.Codigo = 1;
            c.Nome = "Mariana";
            c.Endereco = "Rua Terezina";
            c.Mostrar();
            ClienteFisico cf = new ClienteFisico();
            cf.Codigo = 2;
            cf.Nome = "Ana";
            cf.Endereco = "Rua Terezina";
            cf.Rg = "2222";
            cf.Mostrar();
            ClienteJuridico cj = new ClienteJuridico();
            cj.Codigo = 3;
            cj.Nome = "Empresa SA Limitada";
            cj.Endereco = "Rua Terezina";
            cj.Cnpj = "3333-1000";
            cj.Mostrar();
            Console.ReadKey();
        }
    }
}

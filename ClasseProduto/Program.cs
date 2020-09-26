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
            Produto produto1 = new Produto();
            produto1.Mostrar();
            Produto produto2 = new Produto(1234,258.58);
            produto2.Mostrar();
            Produto produto3 = new Produto(1234, "Impressora Jato de Tinta", 258.58);
            produto3.Mostrar();
            Console.WriteLine($"Número de objetos instanciados: {Produto.QtdeInstancias}.");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{    // subclasse         superclasse
    class ClienteFisico : Cliente  
    {
        private string rg;

        public string Rg { get; set; }

        public ClienteFisico(int codigo, string nome, string endereco, string rg) : base(codigo, nome, endereco) // precisa criar o construtor na classe base
        {
            Rg = rg;
        }

        public override void Mostrar() // palavras reservadas
        {
            base.Mostrar();
            Console.WriteLine("\tRG: " + Rg);
        }
    }
}

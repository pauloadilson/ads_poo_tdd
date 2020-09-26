using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    class Cliente
    {
        private string nome;
        private string rg;
        private string cpf;

        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public void Mostrar()
        {
            Console.WriteLine($"Nome: {Nome}\tRg: {Rg}\tCpf: {Cpf}");
        }
    }
}

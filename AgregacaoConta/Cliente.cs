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

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public void Mostrar()
        {
            Console.WriteLine($"Nome: {Nome}\tRg: {Rg}\tCpf: {Cpf}");
        }
    }
}

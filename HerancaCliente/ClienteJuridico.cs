using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{
    class ClienteJuridico : Cliente
    {
        private string cnpj;
        public string Cnpj { get; set; }

        public ClienteJuridico(int codigo, string nome, string endereco, string cnpj) : base(codigo, nome, endereco) //
        {
            Cnpj = cnpj;
        }

    }
}

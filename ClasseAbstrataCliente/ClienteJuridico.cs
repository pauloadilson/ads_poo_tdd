using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrataCliente
{
    class ClienteJuridico : Cliente
    {
        public string Cnpj { get; set; }
        public ClienteJuridico(int codigo, string nome, int idade, string cnpj, Endereco endereco = null)
        {
            Codigo = codigo;
            Nome = nome;
            IniciarEnderecos();
            Enderecos.Add(endereco);
            Idade = idade;
            Cnpj = cnpj;
        }

        public override bool VerificaIdade(Cliente objetoCliente)
        {
            return objetoCliente.Idade > 50;
        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"\tCNPJ: {Cnpj}.");
        }
    }
}

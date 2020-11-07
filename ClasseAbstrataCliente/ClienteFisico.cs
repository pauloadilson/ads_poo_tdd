using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrataCliente
{
    class ClienteFisico : Cliente
    {
        public string Cpf { get; set; }
        
        public ClienteFisico(int codigo, string nome, int idade, string cpf, Endereco endereco = null) 
        {
            Codigo = codigo;
            Nome = nome;
            IniciarEnderecos();
            Enderecos.Add(endereco);
            Idade = idade;
            Cpf = cpf;
        }
        
        public override bool VerificaIdade(Cliente objetoCliente) {
            return objetoCliente.Idade >= 18
                && objetoCliente.Idade < 50;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"\tCPF: {Cpf}.");
        }


    }
}

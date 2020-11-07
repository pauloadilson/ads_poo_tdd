using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrataCliente
{
    abstract class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Endereco> Enderecos;
        public int Idade { get; set; }


        public abstract bool VerificaIdade(Cliente objetoCliente);
        //assinatura de métodos: saber o que ele faz e se tem parâmetro. Termina com ';'
        public virtual void Mostrar()
        {
            Console.Write($"Código: {Codigo}.\tNome: {Nome}.\tIdade: {Idade}. ");
        }
        public virtual void IniciarEnderecos()
        {
            Enderecos = new List<Endereco>();
        }
    }

    
}

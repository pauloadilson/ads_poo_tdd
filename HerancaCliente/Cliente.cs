using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{
    class Cliente //superclasse
    {
        protected int codigo;
        protected string nome;
        protected string endereco;

        public Cliente(int codigo, string nome, string endereco)
        {
            Codigo = codigo;
            Nome = nome;
            Endereco = endereco;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome + "\tEndereço: " + endereco);
        }
        public int Codigo
        {
            set
            {
                this.codigo = value;
            }
            get
            {
                return this.codigo;
            }
        }
        public string Nome
        {
            set
            {
                this.nome = value;
            }
            get
            {
                return this.nome;
            }
        }
        public string Endereco
        {
            set
            {
                this.endereco = value;
            }
            get
            {
                return this.endereco;
            }
        }

    }
}

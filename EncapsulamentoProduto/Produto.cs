using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    class Produto
    {
        private int codigo;
        private string descricao;
        private double preco;
        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }

        public double Preco
        {
            get { return this.preco; }
            set { this.preco = value; }
        }

        public Produto(int codigo = 0, string descricao = "", double preco = 0.0)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
        }

        public void Mostrar()
        {
            string result = $"\nProduto: {descricao}. Código {codigo}. Preço: {preco.ToString("C")}";
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        private int codigo;
        private string descricao;
        private double preco;
        private static int qtdeInstancias = 0;

        public int Codigo { get => this.codigo; set => this.codigo = value; } 
        public string Descricao { get => this.descricao; set => this.descricao = value;}
        public double Preco { get => this.preco; set => this.preco = value; }
        public static int QtdeInstancias { get => qtdeInstancias; }

        public Produto() 
        {
            qtdeInstancias++;
        }
        public Produto(int codigo, double preco)
        {
            qtdeInstancias++;
            this.codigo = codigo;
            this.preco = preco;
        }
        public Produto(int codigo, string descricao, double preco)
        {
            qtdeInstancias++;
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
        }

        public void Mostrar()
        {
            string result = $"Código {codigo}.\t Preço: {preco:C}.\t Produto: {descricao}.";
            Console.WriteLine(result);
        }
    }
}

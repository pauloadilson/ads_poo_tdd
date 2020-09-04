using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        public int codigo;
        public string descricao;
        public double preco;

        public Produto(int codigo = 0, string descricao = "", double preco = 0.0)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
        }

        public void Mostrar()
        {
            string result = $"Produto: {descricao}. Código {codigo}. Preço: {preco.ToString("C")}";
            Console.WriteLine(result);
        }
    }
}

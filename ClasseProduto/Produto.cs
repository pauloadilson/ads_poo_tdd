﻿using System;
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
            string result = $"Produto: {descricao}. Código {codigo}. Preço: {preco.ToString("C")}";
            Console.WriteLine(result);
        }

        public double somaProdutos(params Produto[] args)
        {
            double sum = 0.0;
            foreach (Produto produto in args)
                sum += produto.preco;
            return sum;
        }
    }
}

using System;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        private int codigo;
        private string nome;
        private double salario;
        public int Codigo { get => this.codigo; set => this.codigo = value; }
        public string Nome { get => this.nome; set => this.nome = value; }
        public double Salario { get => this.salario; set => this.salario = value; }
        public Funcionario(int codigo = 0, string nome = "", double salario = 0.0)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.salario = salario;
        }

        public void Mostrar()
        {
            string result = $"Funcionário: {nome}. Código {codigo}. Salário: {salario:C}";
            Console.WriteLine(result);
        }
    }
}

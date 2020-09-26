using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    class Funcionario
    {
        private int codigo;
        private string nome;
        private double salario;
        private static int contador;

        public static int Contador
        {
            get { return contador; }
        }

        static Funcionario()
        {
            contador = 99;
        }

        public Funcionario()
        {
            contador++;
        }

        public Funcionario(int codigo, double salario)
        {
            contador++;
            this.codigo = codigo;
            this.salario = salario;
        }

        public Funcionario(int codigo, string nome, double salario)
        {
            contador++;
            this.codigo = codigo;
            this.nome = nome;
            this.salario = salario;
        }

        public void Mostrar()
        {
            string result = $"Funcionário: {nome}. Código {codigo}. Salário: {salario.ToString("C")}";
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    public class Funcionario
    {
        public int codigo;
        public string nome;
        public double salario;

        public Funcionario(int codigo = 0, string nome = "", double salario = 0.0)
        {
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

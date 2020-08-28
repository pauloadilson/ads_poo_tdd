using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    public class Funcionario
    {
        private int codigo;
        private string nome;
        private double salario;

        public Funcionario(int codigo = 0, string nome = "", double salario = 0.0)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.salario = salario;
        }
    }
}

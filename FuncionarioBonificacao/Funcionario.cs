using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioBonificacaoHeranca
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        protected virtual double CalculaBonificacao => Salario * 0.1;

        public virtual void AplicarBonificacaoNoSalario()
        {
            Salario += CalculaBonificacao;
        }

    }
}

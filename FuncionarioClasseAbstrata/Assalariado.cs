using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioClasseAbstrata
{
    class Assalariado : Funcionario
    {

        public override double CalcularSalario(int diasUteis)
        {
            return (Salario / 30) * diasUteis;
        }
        public Assalariado(int codigo, string nome, double salario, Endereco endereco)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            Endereco = endereco;
            Dependentes = new List<Dependente>();
        }
        public Assalariado()
        {
            Dependentes = new List<Dependente>();
        }

    }
}

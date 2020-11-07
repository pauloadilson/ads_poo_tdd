using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioClasseAbstrata
{
    class Comissionado : Funcionario
    {
        public double Comissao { get; set; }

        public Comissionado(int codigo, string nome, double salario, Endereco endereco, double comissao = 0.2)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            Comissao = comissao;
            Endereco = endereco;
            Dependentes = new List<Dependente>();
        }
        public Comissionado()
        {
            Dependentes = new List<Dependente>();
        }

        public override double CalcularSalario(int diasUteis) 
        {
            return (Salario/30) * diasUteis * Comissao + Salario;
        }


    }
}

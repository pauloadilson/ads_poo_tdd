using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioBonificacaoHeranca
{
    public class Gerente : Funcionario
    {
        public Gerente(int codigo, string nome, double salario) : base(codigo, nome, salario) { }

        protected override double CalculaBonificacao => (Salario * 0.15);
    }
}

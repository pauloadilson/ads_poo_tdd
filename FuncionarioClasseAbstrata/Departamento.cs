using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioClasseAbstrata
{
    class Departamento
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public List<Funcionario> Funcionarios { get; set; }

        public Departamento(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
            Funcionarios = new List<Funcionario>();
        }
        public double CalcularFolhaPagamento1(int diasUteis)
        {
            return Funcionarios.Aggregate(0.0, (acc, f) => acc + f.CalcularSalario(diasUteis));
        }
        public void AdmitirFuncionario(Funcionario novoFuncionario)
        {
            Funcionarios.Add(novoFuncionario);
        }
        public void DemitirFuncionario(int codigoDoFuncionario)
        {
            Funcionario funcionario = Funcionarios.SingleOrDefault(f => f.Codigo == codigoDoFuncionario);
            Funcionarios.Remove(funcionario);
        }
        public void ListarNomeFuncionarioESalarioFixo()
        {
            foreach (Funcionario funcionario in Funcionarios)
                funcionario.Mostrar(); // generalização
        }
        public void ListarNomeFuncionarioESalario(int diasUteis)
        {
            foreach (Funcionario funcionario in Funcionarios)
            {
                funcionario.Mostrar(diasUteis); 
            }
        }
        public void MostrarQtdeDependentesFuncionario()
        {
            foreach (Funcionario funcionario in Funcionarios)
                Console.WriteLine($"O funcionário {funcionario.Nome} possui {funcionario.CalcularTotalDependentes()} dependente(s).");
        }


    }
}

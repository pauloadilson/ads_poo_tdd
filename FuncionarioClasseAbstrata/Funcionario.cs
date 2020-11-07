using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioClasseAbstrata
{
    abstract class Funcionario
    {
        protected int codigo;
        protected string nome;
        protected Endereco endereco;
        protected int salario;
        protected List<Dependente> dependentes;

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public double Salario { get; set; }
        protected List<Dependente> Dependentes { get ; set ; }

        public abstract double CalcularSalario(int diasUteis);

        public void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo}.\tNome: {Nome}.\tSalário: {Salario:C}.") ;
            Console.WriteLine(Endereco.EnderecoCompleto());
        }
        public void Mostrar(int diasUteis)
        {
            double salarioVariavel = CalcularSalario(diasUteis);
            Console.WriteLine($"Código: {Codigo}.\tNome: {Nome}.\tSalário: {salarioVariavel:C}.");
            Console.WriteLine(Endereco.EnderecoCompleto());
        }
        public int CalcularTotalDependentes()
        {
            return Dependentes.Count();
        }
        public void AdicionarDependente(Dependente novoDep)
        {
            Dependentes.Add(novoDep);
        }

        public void RemoverDependentesMaioridade()
        {
            Dependentes.RemoveAll(dependentes => dependentes.VerificaMaiorIdade());
        }
        public void RemoverDependente(int codigo)
        {
            Dependente d = Dependentes.SingleOrDefault(dependente => dependente.Codigo == codigo);
            Dependentes.Remove(d);
        }
        public void ListarDependentes()
        {
            foreach (Dependente d in Dependentes)
                d.Mostrar();
        }

        public void ListarDependentesMaiorIdade()
        {
            foreach (Dependente d in Dependentes)
                if (d.VerificaMaiorIdade())
                    d.Mostrar();
        }

    }
}

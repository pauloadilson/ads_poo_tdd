using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco end1 = new Endereco("Rua das Paixões", 333,"Jd. Amores","Cidade do Amor-S2");
            Assalariado a1 = new Assalariado(1, "Ana", 8000, end1);
            Comissionado c1 = new Comissionado(2, "Augusto", 16000, end1);
            Comissionado c2 = new Comissionado(3, "Silva", 32000, end1);
            


            Departamento d1 = new Departamento(1, "TI");
            d1.AdmitirFuncionario(a1);
            d1.AdmitirFuncionario(c1);
            d1.AdmitirFuncionario(c2);
            d1.DemitirFuncionario(1);
            d1.ListarNomeFuncionarioESalarioFixo();


            Endereco end2 = new Endereco("Rua das Araras", 111, "Jd. dos Passaros", "Zootopia-MU");
            Assalariado a2 = new Assalariado(4, "Paulo", 1000, end2);
            Comissionado c3 = new Comissionado(5, "Pereira", 2000, end2);
            Comissionado c4 = new Comissionado(6, "Nadir", 4000, end2);


            Departamento d2 = new Departamento(2, "RH");
            d2.AdmitirFuncionario(a2);
            d2.AdmitirFuncionario(c3);
            d2.AdmitirFuncionario(c4);
            d2.ListarNomeFuncionarioESalarioFixo();
            d2.DemitirFuncionario(4);
            d2.ListarNomeFuncionarioESalarioFixo();

            Dependente dep1 = new Dependente(1, "Paulinho", 6);
            Dependente dep2 = new Dependente(2, "Joãozinho", 16);
            Dependente dep3 = new Dependente(3, "Zézinho", 21);
            Dependente dep4 = new Dependente(4, "Maria", 20);
            Dependente dep5 = new Dependente(5, "Luana", 22);
            d1.Funcionarios[0].AdicionarDependente(dep1);
            d1.Funcionarios[0].AdicionarDependente(dep2);
            d1.Funcionarios[0].AdicionarDependente(dep3);
            d1.Funcionarios[1].AdicionarDependente(dep4);
            d1.Funcionarios[1].AdicionarDependente(dep5);
            Console.WriteLine("\nDependentes por funcionário");
            d1.MostrarQtdeDependentesFuncionario();

            d1.Funcionarios[0].RemoverDependentesMaioridade();
            d1.Funcionarios[0].RemoverDependente(2);


            Console.WriteLine("\nDependentes por funcionário");
            d1.MostrarQtdeDependentesFuncionario();
            Console.WriteLine($"\nTotal da folha de pagamento 1: {d1.CalcularFolhaPagamento(22)}");
            Console.WriteLine($"\nTotal da folha de pagamento 2: {d1.CalcularFolhaPagamento2(22)}");

            Console.ReadKey();

        }
    }
}

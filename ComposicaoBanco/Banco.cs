using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        public List<ContaCorrente> ContasCorrente { get; private set; }
        public List<Poupanca> Poupancas { get; private set; }

        public Banco() {
            this.iniciarBanco();
        }

        private void iniciarBanco()
        {
            ContasCorrente = new List<ContaCorrente>();
            Poupancas = new List<Poupanca>();
        }

        public bool isEmpty()
        {
            return ContasCorrente.Count == 0 && Poupancas.Count == 0;
        }

        public void abrirContaCorrente(ContaCorrente conta)
        {
            ContasCorrente.Add(conta);
            Console.WriteLine("Conta corrente adicionada");
        }

        public void abrirPoupanca(Poupanca conta)
        {
            Poupancas.Add(conta);
            Console.WriteLine("Conta poupança adicionada");
        }

        public void falencia()
        {
            ContasCorrente = null;
            Poupancas = null;
            Console.WriteLine("O banco faliu, suas contas foram encerradas!");
        }
        ~Banco()
        {
            ContasCorrente = null;
            Poupancas = null;
            Console.WriteLine("Desestruturando a instância do objeto banco!");
        }
    }
}

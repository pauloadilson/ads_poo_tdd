using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    class Conta
    {
        ///private int numero;
        //private Cliente titular;
        //private double saldo;
        public int Numero { get; set; }
        public List<Cliente> Titular;
        public double Saldo { get; set; }

        public void Mostrar()
        {
            Console.WriteLine($"Numero: {Numero}\tSaldo: {Saldo}");
            foreach (Cliente titular in Titular)
                titular.Mostrar();
        }
    }
}

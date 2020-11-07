using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioClasseAbstrata
{
    class Endereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

        public string EnderecoCompleto()
        {
            return $"Endereço: {Rua},{Numero}. {Bairro} - {Cidade}.";
        }

        public Endereco(string rua, int numero, string bairro, string cidade)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
        }
    }
}

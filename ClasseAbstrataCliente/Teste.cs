using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrataCliente
{
    class Teste
    {

        public bool AnalisaIdade(Cliente cliente)
        {
            return cliente.VerificaIdade(cliente);
        }

    }
}

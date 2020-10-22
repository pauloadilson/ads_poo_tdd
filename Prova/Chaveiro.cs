using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Chaveiro
    {
        public int id_chaveiro;
        public string local;

    }

    public class Colecao
    {
        public int id_colecao;
        public string nome_colecao;
        public List<Chaveiro> chaveiros; 
    }
}

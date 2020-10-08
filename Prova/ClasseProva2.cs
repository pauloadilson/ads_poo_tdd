using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class ClasseProva2
    {
        private int myVar;

        public int MyVar
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private string myVar2;

        public string MyVar2
        {
            get { return myVar2; }
            set { myVar2 = value; }
        }
        public ClasseProva2()
        {
        }

        public ClasseProva2(int myVar, string myVar2)
        {
            MyVar = myVar;
            MyVar2 = myVar2;
        }



        public void metodo()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class ClasseProva
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
        private List<ClasseProva2> myVar3;

        public List<ClasseProva2> MyVar3
        {
            get { return myVar3; }
            set { myVar3 = value; }
        }


        public ClasseProva()
        {
            myVar3 = new List<ClasseProva2>();
        }

        public ClasseProva(int myVar, string myVar2)
        {
            MyVar = myVar;
            MyVar2 = myVar2;
            myVar3 = new List<ClasseProva2>();

        }
        public ClasseProva(int myVar, string myVar2, List<ClasseProva2> myVar3)
        {
            MyVar = myVar;
            MyVar2 = myVar2;
            MyVar3 = myVar3;

        }


        public void metodo()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2
{
    public class ClasseModelo
    {
        private string Atributo1;
        private string Atributo2;

        public void Metodo1(string parametro1, string parametro2)
        {
            this.Atributo1 = parametro1;
            this.Atributo2 = parametro2;
        }

        public bool TestaAtributo()
        {
            if(this.Atributo1 == "a")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

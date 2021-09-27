using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_3
{
    class DiccionarioIterador : Iterador
    {
        private Diccionario elementos;
        int index;

        public DiccionarioIterador(Diccionario dic)
        {
            this.elementos = dic;
        }

        public object actual()
        {
            return elementos.getDiccionario()[index];
        }

        public bool fin()
        {
            if (index == elementos.getDiccionario().Count)
                return true;
            else
                return false;
        }

        public void inicial()
        {
            index = 0;
        }

        public void siguiente()
        {
            index++;
        }
    }
}

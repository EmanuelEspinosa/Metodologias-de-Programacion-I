using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class PilaIterador : Iterador
    {
        List<Comparable> datos;
        int index;

        public PilaIterador(List<Comparable> datos)
        {
            this.datos = datos;
            index = datos.Count - 1;
        }

        public object actual()
        {
            return datos[index];
        }

        public bool fin()
        {
            if (index < 0)
                return true;
            else
                return false;
        }

        public void inicial()
        {
            index = datos.Count;
        }

        public void siguiente()
        {
            index--;
        }
    }
}

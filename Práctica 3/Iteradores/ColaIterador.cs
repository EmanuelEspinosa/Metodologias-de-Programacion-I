using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_3
{
    class ColaIterador : Iterador
    {
        List<Comparable> datos;
        int index;

        public ColaIterador(List<Comparable> datos)
        {
            this.datos = datos;
            index = 0;
        }
        public object actual()
        {
            return datos[index];
        }

        public bool fin()
        {
            if (index == datos.Count)
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
